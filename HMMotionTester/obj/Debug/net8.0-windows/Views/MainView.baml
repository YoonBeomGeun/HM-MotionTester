   M S B A M L   `   `   `  ����I  EHMMotionTester, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:HMMotionTester.ViewModelsHMMotionTester.ViewModels  5      #    HMMotionTester.Views.MainView   5      a ]DevExpress.Xpf.Core.v24.2, Version=24.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ] YDevExpress.Mvvm.v24.2, Version=24.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm   5      :
ViewModels'clr-namespace:HMMotionTester.ViewModels   5      e	 aDevExpress.Xpf.Controls.v24.2, Version=24.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aCdxwui7http://schemas.devexpress.com/winfx/2008/xaml/windowsui 	 5      ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5	      d
 `DevExpress.Xpf.Docking.v24.2, Version=24.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a@dxdo5http://schemas.devexpress.com/winfx/2008/xaml/docking 
 5
      f bDevExpress.Xpf.Accordion.v24.2, Version=24.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxa7http://schemas.devexpress.com/winfx/2008/xaml/accordion  5        � DataContext  5      -   'HMMotionTester.ViewModels.MainViewModel  5   
   .��5      ]� -   5         ]�Name$ BaseDockPanel��5      
�������.+�5   
   �� -   5         ��Name$ ControlPanel��5      $	��Top=�6+   $	��100��6@    �� Orientation$ 
Horizontal=�6M   $��Stretch=�6f   ���#4646466�   � 5   
   $��Bottom=�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      ( 
 "DevExpress.Xpf.Docking.LayoutPanel  $��0��6   ( 
 "DevExpress.Xpf.Docking.ContentItem   Content. 5      � 
������� � ColumnDefinitions 5       �� 5!      $��1* �6+   �� 5"      $��1* �6+   �� 5#      $��1* �6+   .+�5'      �� $��0��6!   $��10q�61   .+�5(      �� $��Cmd Position: 0.00��6$   
�������6>   �� 5)      $��Cmd Velocity: 0.00��6$   
�������6>   �� 5*      $��OpState: Offline��6$   
���  ��$
��Bold"�6M   5+      �� 5.      $��1��6!   $ 
Horizontal=�61   $��Center=�6J   .+�5/      �� $��
AllServoOn��6!   
������$��5q�6N   �� 50      $��AllServoOff��6!   
�������$��5q�6I   �� 51      $��
AlarmClear��6!   
��� ���$��5q�6J   52      �� 55      $��2��6!   $��10q�61   .+�56      �� $��Error Message��6$   
�������69   �� 57      
���   � �� Padding$ 5q�64   ._�58      �� $��Motor is not registered��6(   
��� ���6G   59      5:      5;      5<      % 	 DevExpress.Xpf.WindowsUI.AppBar  5?      -   5          Name$ appBar��5?      $��1��6+   $��95��68   	   HideMode$	 AlwaysVisible=�6D   ���#464646
 J� RenderTransformOrigin$
 0.5,0.5&�6r   z�5@      V� 5A      .~�5B      ��  �� ScaleX$ 1Q�6)   �� 5C      �� 5D      T� 5E      5F      .@�5I      �  5J      �� 5K      $
��Auto �6+   �� 5L      $��* �6+   �� 5M      $
��Auto �6+   .+�5Q      �� $��Resources//HanmiLogo.jpeg��6   $��0��6?   $��80��6O   $��50��6Z   $��Center=�6f   $��Center=�6�   $��20,0,0,0q�6�   �� 5S      $��1��6!   $ 
Horizontal=�61   $��Center=�6J   $��200,0,200,0q�6g   .+�5T      + 	 %DevExpress.Xpf.WindowsUI.AppBarButton     Label$ Start��6-   . 	 (DevExpress.Xpf.WindowsUI.AppBarSeparator  5U        5V      $
 Stop��6-     5W        5X      $ ReStart��6-   5Y      � 5[      -   5         �Name$ SeqPanel��5[      $��2��6-   $��80��6=   $��30��6H   
���  ��$��0,0,20,0q�6e    5\      �� 5]      $
��Auto �6/   �� 5^      $
��Auto �6/   .+�5`      �� $	��SEQ��6$   $
��Bold"�6/   $��13(�6A   $��Center=�6O   $��Center=�6j   
�������$��0��6�   $��20,0,0,0q�6�   A� 5a      $��10��6"   $��10��6-   
�������$��5,0,0,0q�6F   $��Center=�6W   $��Center=�6r   $��1��6�   5b      5c      5d      5e      . 
 (DevExpress.Xpf.Docking.DockLayoutManager  5�   
   -   5        $��dockLayoutManager��5�   5   $��0q�6!      
LayoutRoot. 5�      ( 
 "DevExpress.Xpf.Docking.LayoutGroup     Orientation$ Vertical=�6   +	 
 %DevExpress.Xpf.Docking.BaseLayoutItem 	  
ItemHeight$ * �66      Items. 5�        2
  ,DevExpress.Mvvm.UI.Interactivity.Interaction 
  	Behaviors 5�      5 
 /DevExpress.Xpf.Docking.DockingDocumentUIService  5�      -   5          Name$% WorkspaceDocumentManagerService��5�   8      LayoutPanelStyle 5�      �� 5�   "    �� 
TargetType"  6(   .�5�   &   ��  �� Property �@	 
AllowFloat �� Value$ False��6C   �� 5�   &    �@	 	AllowMove$
 True��6B   �� 5�   &    �@ ShowPinButton$ False��6F   �� 5�   &    �@	 	ItemWidth$	 250 �6B   �� 5�   &    �@	 Padding$
 10,0q�6@   5�   #   5�      5�      5�      5�      5�      5�      