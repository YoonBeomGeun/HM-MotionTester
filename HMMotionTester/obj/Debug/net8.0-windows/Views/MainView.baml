   M S B A M L   `   `   `  ����I  EHMMotionTester, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:HMMotionTester.ViewModelsHMMotionTester.ViewModels  5      #    HMMotionTester.Views.MainView   5      a ]DevExpress.Xpf.Core.v24.2, Version=24.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ] YDevExpress.Mvvm.v24.2, Version=24.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm   5      e	 aDevExpress.Xpf.Controls.v24.2, Version=24.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aCdxwui7http://schemas.devexpress.com/winfx/2008/xaml/windowsui 	 5      ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5      d
 `DevExpress.Xpf.Docking.v24.2, Version=24.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a@dxdo5http://schemas.devexpress.com/winfx/2008/xaml/docking 
 5	      f bDevExpress.Xpf.Accordion.v24.2, Version=24.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxa7http://schemas.devexpress.com/winfx/2008/xaml/accordion  5
      8
ViewModels'clr-namespace:HMMotionTester.ViewModels  5      <dxb2http://schemas.devexpress.com/winfx/2008/xaml/bars  5      OdxwuinBhttp://schemas.devexpress.com/winfx/2008/xaml/windowsui/navigation 	 5      Ddxnav8http://schemas.devexpress.com/winfx/2008/xaml/navigation 	 5        � 	Resources  5      0  *DevExpress.Mvvm.UI.ObjectToObjectConverter %  !NavigationPaneVisibilityConverter
   Map   DevExpress.Mvvm.UI.MapItem   Target   Source % !NavigationPaneIsExpandedConverter  isExpandedToWidthConverter   DefaultTarget��%�  &	        &	 �     &	 a      5   
   . 5        $ Visible��6   $ 	Minimized��6.     5      $ Visible��6   $ Normal��6.     5      $ 	Collapsed��6   $	 Off��60   5        5   
   . 5        $ False��6   $ 	Minimized��6,     5      $
 True��6   $ Normal��6+     5      $ False��6   $	 Off��6,   5        5   
   $
 Auto��6L   . 5         $
 True��6   $	 220��6+   5!      5"      .��5$      ]� -   5         ]�Name$ BaseDockPanel��5$      
�������.+�5/   
   ' 	 !DevExpress.Xpf.Navigation.TileBar  -   5        $��MenuBar��5/      $	��Top=�6'    �� SelectedItem$ 0��6<   $	��100��6M   $��Stretch=�6Z   ���#464646$��0q�6�   .@�50      + 	 %DevExpress.Xpf.Navigation.TileBarItem  $��Motor Control��6    $��70��68   $��30,0,0,0q�6D     51      $��Add Function��6    $��70��67   $��30,0,0,0q�6C     52      $��Add Function��6    $��70��67   $��30,0,0,0q�6C   53      � 56   
   $��Bottom=�6   .+�57      �  � RowDefinitions 58      �� 59      $��1* �6$   �� 5:      $��1* �6$   .+�5>      � $��0��6   $��55��6$   .+�5?      � ���#464646 5@      �� 5A      $��25 �6,   �� 5B      $��1* �6,   .+�5F      �� $��0��6$   $��Error Message��61   
�������$
��Bold"�6Y   $��Center=�6k   $��Center=�6�   �� 5G      $��1��6!   $��1q�6.   
���  ��
���   �$��Stretch=�6g   $��Stretch=�6�   ._�5H      �� -   5         ��Name$ 	ErrorText��5H   (   
��� ���$��Center=�6q   $��Center=�6�   ��6;   �� *ErrorTextMessage+6�   5I      5J      5K      % 	 DevExpress.Xpf.WindowsUI.AppBar  5N      -   5        	  Name$	 appBar��5N      $��1��6/   $��95��6<   
   HideMode$
 AlwaysVisible=�6H   ���#464646 J� RenderTransformOrigin$ 0.5,0.5&�6v   z�5O      V� 5P      .~�5Q      ��  �� ScaleX$ 1Q�6-   �� 5R      �� 5S      T� 5T      5U      .@�5X      �  � ColumnDefinitions 5Y      �� 5Z      $
��Auto �6/   �� 5[      $��* �6/   �� 5\      $
��Auto �6/   .+�5`      �� $��Resources//HanmiLogo.png��6    $��0��6B   $��80��6R   $��50��6]   $��Center=�6i   $��Center=�6�   $��20,0,0,0q�6�   �� 5b      $��1��6%    �� Orientation$ 
Horizontal=�65   $��Center=�6N   $��200,0,200,0q�6k   .+�5c      + 	 %DevExpress.Xpf.WindowsUI.AppBarButton  -   5           Label$ Start��5c   1   6?   . 	 (DevExpress.Xpf.WindowsUI.AppBarSeparator  5d        5e      -   5        $
 Stop��5e   1   6>     5f        5g      -   5        $ ReStart��5g   1   6A   5h      � 5j      -   5         �Name$ SeqPanel��5j      $��2��61   $��80��6A   $��30��6L   
���  ��$��0,0,20,0q�6i    5k      �� 5l   "   $
��Auto �63   �� 5m   "   $
��Auto �63   .+�5o      �� $	��SEQ��6(   $
��Bold"�63   $��13(�6E   $��Center=�6S   $��Center=�6n   
�������$��0��6�   $��20,0,0,0q�6�   A� 5p      $��10��6&   $��10��61   
�������$��5,0,0,0q�6J   $��Center=�6[   $��Center=�6v   $��1��6�   5q      5r      5s      5t      5u      . 
 (DevExpress.Xpf.Docking.DockLayoutManager  5w   
   -	   5          Name$ dockLayoutManager��5w   5   $��0q�6!      
LayoutRoot. 5x      (	 
 "DevExpress.Xpf.Docking.LayoutGroup	  2
  ,DevExpress.Mvvm.UI.Interactivity.Interaction 
  	Behaviors 5y      5 
 /DevExpress.Xpf.Docking.DockingDocumentUIService  5z      -
   5          Name$% WorkspaceDocumentManagerService��5z   4      LayoutPanelStyle 5{      �� 5|       �� 
TargetType( 
 "DevExpress.Xpf.Docking.LayoutPanel"  6$   .�5}   "   �� + 
 %DevExpress.Xpf.Docking.BaseLayoutItem �� Property �@ 
AllowFloat �� Value$ False��6?   �� 5~   "    �@ 	AllowMove$ False��6>   �� 5   "    �@ ShowPinButton$ False��6B   �� 5�   "    �@ 	ItemWidth$	 250 �6>   �� 5�   "    �@ Padding$
 10,0q�6<   5�      5�       	  Items. 5�           
AllowClose$ False��5�   #      
AllowFloat$ False��66      ShowPinButton$ False��6I      
ShowBorder$ False��6_      ShowCaption$ False��6r      AllowSizing$ False��6�   -  'DevExpress.Xpf.Core.ScrollBarExtensions    PreventParentScrolling$  False��6�   !   	ItemWidth! 5�   #   �� *
IsExpanded+" �� 	Converter#" [ # �� ElementName$# 	accordion��y�5�   #   �� *NavigationPaneVisibility+#" [  ( 
 "DevExpress.Xpf.Docking.ContentItem$   Content.$ 5�      /  )DevExpress.Xpf.Accordion.AccordionControl  -   5        %  Name$% 	accordion��5�   +   &   IsCollapseButtonVisible$
& True��6>   '   CollapsedItemDisplayMode$' Content=�6]   (   CompactNavigation$( False��6�   )   AutoExpandAllItems$
) True��5�   +   *   CollapsedItemClickAction$* Select=�6E   +   AllowMouseScrolling$+ False��6g   $  False��6�   ,   HeaderContent$, Select Motion��5�   +   -   
IsExpanded- 6I   �� *NavigationPaneVisibility+#" [ . �� Mode$. TwoWay=�/   Items./ 5�      �� 0 �� SelectedIndex$0 0��6#   $	��100��65   $��30��6A   $��0,5,0,0q�6M   $��Center=�6^   $��Center=�6{   $��Center=�6�   
������
�������$
��Bold"�6�   .@�5�      �� $��Master 0��6+   �� 5�      $��Master 1��6+   5�      �� 5�      $
��Auto=�6'   $	��350��6J   $��Center=�6W   $	��130��6t   $��0,10,0,0q�6�   .��5�      �� -   5        $��MotionPanel��5�   )   .+�5�   "   �� $��MovePosition��6)   $��25��6@   $��2q�6L   
�������$
��Bold"�6j   ���#001A666|   �� 5�   "   $��MoveVelocity��6)   $��25��6@   $��2q�6L   
�������$
��Bold"�6j   ���#001A666|   �� 5�   "   $	��DSM��6)   $��25��67   $��2q�6C   
�������$
��Bold"�6a   ���#001A666s   �� 5�   "   $	��SLM��6)   $��25��67   $��2q�6C   
�������$
��Bold"�6a   ���#001A666s   �� 5�   "   $��MoveVibration��6)   $��25��6A   $��2q�6M   
�������$
��Bold"�6k   ���#001A666}   �� 5�   "   $��MoveLinearInterp��6)   $��25��6D   $��2q�6P   
�������$
��Bold"�6n   ���#001A666�   �� 5�   "   $��MovePnP��6)   $��25��6;   $��2q�6G   
�������$
��Bold"�6e   ���#001A666w   �� 5�   "   $��	FlipperUp��6)   $��25��6=   $��2q�6I   
�������$
��Bold"�6g   ���#001A666y   �� 5�   "   $��FlipperDown��6)   $��25��6?   $��2q�6K   
�������$
��Bold"�6i   ���#001A666{   �� 5�   "   $��PathInterpDirectControl��6)   $��25��6K   $��2q�6W   
�������$
��Bold"�6u   ���#001A666�   �� 5�   "   $��PathInterpFileInterface��6)   $��25��6K   $��2q�6W   
�������$
��Bold"�6u   ���#001A666�   �� 5�   "   $��	Circular~��6)   $��25��6=   $��2q�6I   
�������$
��Bold"�6g   ���#001A666y   5�      5�      5�      5�        5�      $ False��6#   $ False��66   $ False��6I   $ False��6_   $ False��6r   +  %DevExpress.Xpf.Bars.MergingProperties1   ElementMergingBehaviorD  >DevExpress.Xpf.Bars.Native.ElementMergingBehaviorTypeConverter$1 InternalWithExternal 6�   .$ 5�        $, Set Motion Parameter��6+   ./ 5�      �� $ 
Horizontal=�6%   $��0,3,0,0q�6>   .+�5�      �� $��✔️ Moving Axis: ��6(   $��15(�6@   $	��125��6N   $
��Left=�6Z   $
��Bold"�6u   �� 5�      -   5        2 ��Name$2 Moving_Axis��5�   '   3 �� DisplayMemberPath$3 AxisName��6�   $	��100��6�   $
��Left=�6�   $��Center=�6�   $��Center=�6�   ��6<   �� *Motors+ 6[   �� *SelectedMovingAxis+$. TwoWay=�6�   5�      � 5�      -   5        $��CoordinatesGrid��5�      $y�Visible=�66    5�      �� 5�   "   $��1* �63   �� 5�   "   $��1* �63   �� 5�   "   $��1* �63    5�      �� 5�   "   $��1* �60   �� 5�   "   $��1* �60   �� 5�   "   $��1* �60   .+�5�      �� $��2��6(   $��0��6<   $!��✔️ Set Coordinates Axes��6I   $��15(�6h   $	��180��6v   $
��Left=�6�   $
��Bold"�6�   $��0,10,0,0q�6�   �� 5�      $��2��6(   $��0��6<   $��Select Using Axis Count:��6I   $	��180��6i   $
��Left=�6u   $
��Bold"�6�   $��
200,13,0,0q�6�   �� 5�      -   5        $��UsingAxisCount��5�   I   $��2��6(   $��0��6<   4 �� SelectedValuePath$4 Content��6�   $��50��6�   $��21��6�   $
��Left=�6�   $��Center=�6�   $��Center=�6  $��
345,11,0,0q�6)  5 �� SelectedValue5 6_   �� *UsingAxisCount+$. TwoWay=�.@�5�   "   �� $��1��6/   �� 5�   "   $��2��6/   �� 5�   "   $��3��6/   5�      �� 5�      $��3��6)   $��1��6=   $ 
Horizontal=�6J   $��0, 10, 0, 0q�6c   $��Stretch=�6x   .+�5�   "   �� -   5        $��CoordinateAxis1��5�   <   $��0��6,   $��Transfer Axis 1: ��6S   $��95��6l   $
��Left=�6w   6 �� TextAlignment$6 Right=�6�   $��20,0,0,0q�6�   �� 5�   "   -   5        $��TransferAixs1��5�   ;   $��0��6+   $3 AxisName��6�   $	��100��6�   $
��Left=�6�   $��Center=�6  $��Center=�68  $
4 Self��6Z  ��6P   �� *Motors+ 6o   �� *SelectedTransferAxis1+$. TwoWay=�{�6�   �� *IsAxis1Enabled+��5�   &   �� 5�   *   " ��60   .�5�   .   ��  � {� 6J   �� *IsSelectable+5�   +   5�   #   �� 5�   "   -   5        $��CoordinateAxis2��5�   <   $��1��6,   $��Transfer Axis 2: ��6S   $��95��6l   $
��Left=�6w   $6 Right=�6�   $��50,0,0,0q�6�   �� 5�   "   -   5        $��TransferAxis2��5�   ;   $��1��6+   $3 AxisName��6�   $	��100��6�   $
��Left=�6�   $��Center=�6  $��Center=�68  ��6P   �� *Motors+ 6o   �� *SelectedTransferAxis2+$. TwoWay=�{�6�   �� *IsAxis2Enabled+��5�   &   �� 5�   *   " ��60   .�5�   .   ��  � {� 6J   �� *IsSelectable+5�   +   5�   #   �� 5�   "   -   5        $��CoordinateAxis3��5�   <   $��2��6,   $��ZMove Axis: ��6S   $��95��6g   $
��Left=�6r   $6 Right=�6�   $��50,0,0,0q�6�   �� 5�   "   -   5        $��	ZMoveAxis��5�   ;   $��2��6+   $3 AxisName��6�   $	��100��6�   $
��Left=�6�   $��Center=�6  $��Center=�6,  ��6L   �� *Motors+ 6k   �� *SelectedZAxis+$. TwoWay=�{�6�   �� *IsAxis3Enabled+��5�   &   �� 5�   *   " ��60   .�5�   .   ��  � {� 6J   �� *IsSelectable+5�   +   5�   #   5�      �� 5�      $��3��6)   $��2��6=   $ 
Horizontal=�6J   $��0, 10, 0, 0q�6c   $��Stretch=�6x   .+�5�   "   �� $��0��6,   $��UseSyncMaster: ��6<   $��95��6S   $
��Left=�6^   $6 Right=�6y   $��20,0,0,0q�6�   �� 5�   "   -   5        $��SyncMaster1��5�   ;   $��0��6+   $	��100��6s   $
��Left=�6   $��Center=�6�   $��Center=�6�   $
4 Self��6�   {�6N   �� *IsAxis1Enabled+.@�5�   &   �� $��FALSE��63   7 �� 
IsSelected$
7 True��6C   �� 5�   &   $
��TRUE��63   5   #   �� 5  "   $��1��6,   $��UseSyncMaster: ��6<   $��95��6S   $
��Left=�6^   $6 Right=�6y   $��50,0,0,0q�6�   �� 5  "   -   5        $��SyncMaster2��5  ;   $��1��6+   $	��100��6s   $
��Left=�6   $��Center=�6�   $��Center=�6�   {�6N   �� *IsAxis2Enabled+.@�5  &   �� $��FALSE��63   $
7 True��6C   �� 5  &   $
��TRUE��63   5  #   �� 5  "   $��2��6,   $��UseSyncMaster: ��6<   $��95��6S   $
��Left=�6^   $6 Right=�6y   $��50,0,0,0q�6�   �� 5  "   -   5        $��SyncMaster3��5  ;   $��2��6+   $	��100��6s   $
��Left=�6   $��Center=�6�   $��Center=�6�   {�6N   �� *IsAxis3Enabled+.@�5  &   �� $��FALSE��63   $
7 True��6C   �� 5	  &   $
��TRUE��63   5
  #   5     5     �� 5     -   5        8 ��Name$8 MotionContentControl��5  )   $��0,5,0,0q�6G   5D     5E     5F     5G     5H     5J     