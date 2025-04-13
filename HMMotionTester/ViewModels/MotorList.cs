using HMMotionTester.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace HMMotionTester.ViewModels
{
    public class MotorList : INotifyPropertyChanged
    {
        public int MAX_AXIS_NUM = 128;
        public int MASTER_MAX_AXIS_NUM = 64;

        private static MotorList _instance;
        public static MotorList Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MotorList();
                return _instance;
            }
        }

        private string _errorTextMessage;
        public string ErrorTextMessage
        {
            get => _errorTextMessage;
            set
            {
                _errorTextMessage = value;
                OnPropertyChanged(nameof(ErrorTextMessage));
            }
        }

        private int _usingAxisCount;
        public int UsingAxisCount
        {
            get => _usingAxisCount;
            set
            {
                _usingAxisCount = value;
                OnPropertyChanged(nameof(UsingAxisCount));
                UpdateAxisEnable();
            }
        }

        public ObservableCollection<Motor> Motors { get; set; }

        private Motor _selectedMovingAxis;
        public Motor SelectedMovingAxis
        {
            get => _selectedMovingAxis;
            set
            {
                _selectedMovingAxis = value;
                OnPropertyChanged(nameof(SelectedMovingAxis));
            }
        }

        private bool _isAxis1Enabled = true;
        public bool IsAxis1Enabled
        {
            get => _isAxis1Enabled;
            set { _isAxis1Enabled = value; OnPropertyChanged(nameof(IsAxis1Enabled)); }
        }

        private bool _isAxis2Enabled;
        public bool IsAxis2Enabled
        {
            get => _isAxis2Enabled;
            set { _isAxis2Enabled = value; OnPropertyChanged(nameof(IsAxis2Enabled)); }
        }

        private bool _isAxis3Enabled;
        public bool IsAxis3Enabled
        {
            get => _isAxis3Enabled;
            set { _isAxis3Enabled = value; OnPropertyChanged(nameof(IsAxis3Enabled)); }
        }

        private Motor _selectedTransferAxis1;
        public Motor SelectedTransferAxis1
        {
            get => _selectedTransferAxis1;
            set
            {
                if (value == null) return;

                if (value == SelectedTransferAxis2 || value == SelectedZAxis)
                {
                    ErrorTextMessage = $"{value.AxisName}은 이미 선택된 Axis 입니다.";
                    OnPropertyChanged(nameof(ErrorTextMessage));

                    //System.Windows.Application.Current.Dispatcher.BeginInvoke(new Action(() =>
                    //{
                    //    SelectedTransferAxis1 = null;
                    //    OnPropertyChanged(nameof(SelectedTransferAxis1));
                    //}));
                    SelectedTransferAxis1 = null;
                    OnPropertyChanged(nameof(SelectedTransferAxis1));
                }
                else
                {
                    _selectedTransferAxis1 = value;
                    ErrorTextMessage = "";
                    OnPropertyChanged(nameof(ErrorTextMessage));
                    OnPropertyChanged(nameof(SelectedTransferAxis1));
                    UpdateSelectableMotors();
                }
            }
        }

        private Motor _selectedTransferAxis2;
        public Motor SelectedTransferAxis2
        {
            get => _selectedTransferAxis2;
            set
            {
                if (value == null) return;

                if (value == SelectedTransferAxis1 || value == SelectedZAxis)
                {
                    ErrorTextMessage = $"{value.AxisName}은 이미 선택된 Axis 입니다.";
                    OnPropertyChanged(nameof(ErrorTextMessage));

                    //System.Windows.Application.Current.Dispatcher.BeginInvoke(new Action(() =>
                    //{
                    //    SelectedTransferAxis1 = null;
                    //    OnPropertyChanged(nameof(SelectedTransferAxis1));
                    //}));
                    SelectedTransferAxis2 = null;
                    OnPropertyChanged(nameof(SelectedTransferAxis2));
                }
                else
                {
                    _selectedTransferAxis2 = value;
                    ErrorTextMessage = "";
                    OnPropertyChanged(nameof(ErrorTextMessage));
                    OnPropertyChanged(nameof(SelectedTransferAxis2));
                    UpdateSelectableMotors();
                }
            }
        }

        private Motor _selectedZAxis;
        public Motor SelectedZAxis
        {
            get => _selectedZAxis;
            set
            {
                if (value == null) return;

                if (value == SelectedTransferAxis1 || value == SelectedTransferAxis2)
                {
                    ErrorTextMessage = $"{value.AxisName}은 이미 선택된 Axis 입니다.";
                    OnPropertyChanged(nameof(ErrorTextMessage));

                    //System.Windows.Application.Current.Dispatcher.BeginInvoke(new Action(() =>
                    //{
                    //    SelectedTransferAxis1 = null;
                    //    OnPropertyChanged(nameof(SelectedTransferAxis1));
                    //}));
                    SelectedZAxis = null;
                    OnPropertyChanged(nameof(SelectedZAxis));
                }
                else
                {
                    _selectedZAxis = value;
                    ErrorTextMessage = "";
                    OnPropertyChanged(nameof(ErrorTextMessage));
                    OnPropertyChanged(nameof(SelectedZAxis));
                    UpdateSelectableMotors();
                }
            }
        }
        //===============================================================================================
        public MotorList()
        {
            UsingAxisCount = 1;
            UpdateAxisEnable();
            // 비어있을 때만
            if (Motors == null || Motors.Count == 0)
            {
                Motors = new ObservableCollection<Motor>();
                for (int i = 0; i < MASTER_MAX_AXIS_NUM; i++)
                {
                    Motors.Add(new Motor
                    {
                        AxisName = "Axis " + i,
                        AxisNum = i,
                    });
                }
            }
            //Motors = new ObservableCollection<Motor>();  // ⭐ 조건 없이 먼저 초기화

            //for (int i = 0; i < MASTER_MAX_AXIS_NUM; i++)
            //{
            //    Motors.Add(new Motor
            //    {
            //        AxisName = "Axis " + i,
            //        AxisNum = i,
            //    });
            //}

            //UsingAxisCount = 1;
            //UpdateAxisEnable();
        }
        //===============================================================================================
        private void UpdateSelectableMotors()
        {
            if (Motors == null)
                return;

            var selectedAxisNums = new HashSet<int>();
            if (_selectedTransferAxis1 != null)
                selectedAxisNums.Add(_selectedTransferAxis1.AxisNum);
            if (_selectedTransferAxis2 != null)
                selectedAxisNums.Add(_selectedTransferAxis2.AxisNum);
            if (_selectedZAxis != null)
                selectedAxisNums.Add(_selectedZAxis.AxisNum);

            foreach (var motor in Motors)
            {
                motor.IsSelectable = !selectedAxisNums.Contains(motor.AxisNum);
            }
        }
        //===============================================================================================
        public void LoadAxisNames(string iniFilePath)
        {
            for (int i = 0; i < Motors.Count; i++)
            {
                Motors[i].AxisName = $"Axis {i}";
            }

            if (!File.Exists(iniFilePath))
                return;

            foreach (string line in File.ReadAllLines(iniFilePath))
            {
                var match = Regex.Match(line, @"AxisName\((\d+)\)=(.+)");
                if (match.Success)
                {
                    int axisIndex = int.Parse(match.Groups[1].Value);
                    string axisName = match.Groups[2].Value;
                    if (axisIndex >= 0 && axisIndex < Motors.Count)
                    {
                        Motors[axisIndex].AxisName = $"{axisIndex}: {axisName}";
                    }
                }
            }
        }
        //===============================================================================================
        private void UpdateAxisEnable()
        {
            IsAxis1Enabled = UsingAxisCount >= 1;
            if (!IsAxis1Enabled)
            {
                SelectedTransferAxis1 = null;
                OnPropertyChanged(nameof(SelectedTransferAxis1));
            }

            IsAxis2Enabled = UsingAxisCount >= 2;
            if (!IsAxis2Enabled)
            {
                SelectedTransferAxis2 = null;
                OnPropertyChanged(nameof(SelectedTransferAxis2));
            }

            IsAxis3Enabled = UsingAxisCount >= 3;
            if (!IsAxis3Enabled)
            {
                SelectedZAxis = null;
                OnPropertyChanged(nameof(SelectedZAxis));
            }

            UpdateSelectableMotors();
        }
        //===============================================================================================
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
