   M S B A M L   `   `   `  ����I  EHMMotionTester, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:HMMotionTesterHMMotionTester  5   	       HMMotionTester.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:HMMotionTester     5   	     � Title$  
MainWindow��5   	   $	��700��6   $	��985��6)    � 
ResizeMode$ NoResize=�5	   	    � 	Resources 5         RoundedButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers	 P� Property
 P� Value��%Y  &	        �� 5   
   " ��6+   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ 15��6!   #��z��63   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5      	 �@J�IsMouseOver$

 True��6=   . �5   "   ��  � �� �#F0F0F06?   5      5      5      5      5      .��5      � .+�5    
   � 
�������$��45��6"   $	��Top=�6.   .+�5"      �� $��Resources/HanmiLogo.jpeg��6   $��45��66   $��70��6B   $��Center=�6M   $��Center=�6j   �� 5$      -   5        $��SeqPanel��5$       �� Orientation$ 
Horizontal=�6)   $
��Left=�6B   $
��15,0q�6]   .+�5%      �� $	��SEQ��6   $
��Bold"�6'   $��13(�69   $��Center=�6G   
���  ��6b   A� 5&      $��10��6   $��10��6%   
���  ��$��5,2,0,0q�6<   $��Center=�6M   5'      5(      ]� 5)   
   .+�5+      �� -   5        $��ControlPanel��5+      $	��Top=�6.   $��45��6C   $ 
Horizontal=�6O   $��Stretch=�6h   $��0,45,0,0q�6�   ���#00327A.+�5,      �� $��
AllServoOn��6   
��� � �$
��Bold"�6A   $��5q�6S   $	��100��6^   $��30��6j   #��[  6v   �� 5-      $��AllServoOff��6   
���  ��$
��Bold"�6@   $��5q�6R   $	��100��6]   $��30��6i   #��[  6u   �� 5.      $��AllAlarmClear��6   
��� ���$
��Bold"�6C   $��5q�6U   $	��100��6`   $��30��6l   #��[  6x   �� 5/      $��ServoOn/Off��6   ���#001A66$
��Bold"�6D   $��5q�6V   $	��100��6a   $��30��6m   #��[  6y   �� 50      $��
AlarmClear��6   ���#001A66$
��Bold"�6C   $��5q�6U   $	��100��6`   $��30��6l   #��[  6x   51      �� 54      $
��Left=�6   ���#00327A$	��130��6D   $��Stretch=�6P   .+�56      �� $��10q�6    �� SelectedIndex$ 0��6'   $��Center=�69   ���#001A66���#001A66$
��Bold"�6�   .@�6�   .@�57          �� $��Master 0��6#   �� 58      $��Master 1��6#   59      �� 5;      $��10q�6   $ 0��6'   
���   �.@�5<      �� $��Axis 0��6#   �� 5=      $��Axis 1��6#   �� 5>      $��Axis 2��6#   5@      �� 5A      $
��Auto=�6   $	��400��6B   .��5B      �� -   5        $��	AxisPanel��5B   !   .+�5D      �� $��Axis 0��6!   $��2,2,2,0q�62   
����������#001A666V   �� 5E      $��Axis 1��6!   $��2,2,2,0q�62   
����������#001A666V   �� 5F      $��Axis 2��6!   $��2,2,2,0q�62   
����������#001A666V   �� 5G      $��Axis 3��6!   $��2,2,2,0q�62   
����������#001A666V   5H      5I      �� 5J      -   5        $��	Reset_Btn��5J      $��Reset��6*   $	��100��6:   $��30��6F   
��� ���
�������$
��Bold"�6}   $��0, 0, 0, -120q�6�   5K      ]� 5N      $	��Top=�6   $��30��6-   .+�5O      �  � ColumnDefinitions 5P      �� 5Q      $��30 �6+   �� 5R      $��* �6+   �� 5S      $��30 �6+   .+�5V      �� -   5        $��LeftArrowButton��5V   -   $��0��6   $	��◀��6D   $��30��6P   $��30��6[   
�������
����������#001A666�   �� 5X      $��1��6#   $��Hidden=�63   $��Disabled=�6Z   $��Stretch=�6�   $��30��6�   .��5Y      �� -   5        $��
TabControl��5Y   %    J� RenderTransformOrigin$ 0.5,0.5&�67   $ 0��6W   $	��500��6i   z�5Z      T� 5[   "   -   5        TabTranslateTransform�� T� X$ 0Q�5[   T   .@�5]      �� $��MovePosition��6&   $	��130��6<   $��30��6H   .��5^   "   � .+�5_   &   �� $	��sda��60   6=   5`   #   5a      �� 5b      $��MoveVelocity��6&   $	��130��6<   $��30��6H   �� 5c      $	��DSM��6&   $	��130��63   $��30��6?   �� 5d      $	��SLM��6&   $	��130��63   $��30��6?   �� 5e      $��MoveVibration��6&   $	��130��6=   $��30��6I   �� 5f      $��
MoveInterp��6&   $	��130��6:   $��30��6F   �� 5g      $	��PnP��6&   $	��130��63   $��30��6?   �� 5h      $��FlipUp��6&   $	��130��66   $��30��6B   �� 5i      $��FlipDn��6&   $	��130��66   $��30��6B   5j      5k      �� 5m      -   5        $��RightArrowButton��5m   -   $��2��6   $	��▶��6E   $��30��6Q   $��30��6\   
�������
����������#001A666�   5n      5o      �� 5r      $ 
Horizontal=�6   $��Center=�62   $��Bottom=�6O   $��0,0,0,10q�6j   .+�5s      �� $	��▶��6   $��15(�6%   
�������$��35��6F   $��35��6Q   $��10q�6]   ��5t      �� 5u      " ��6*   .R�5v      �� #��z��6%   $ 25��6O   ._�5w   "   �� $��Center=�63   $��Center=�6P   5x       5y      P� 5z   "   	 �@J�IsMouseOver$
 False��6A   . �5{   &   ��  � �� �#00327A6C   5|   #   P� 5}   "   	 �@J�IsMouseOver$

 True��6A   . �5~   &   ��  � �� �#8E9DFF6C   5   #   P� 5�   "   	 � ��$

 True��6?   . �5�   &   ��  � �� �#0000666C   5�   #   5�      5�      �� 5�      $��15(�6   ���#F75E5E
�������$��33��6O   $��33��6Z   $��10q�6f   $��Center=�6r   5�      5�      5�      5�      