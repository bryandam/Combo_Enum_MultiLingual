   M S B A M L   `   `   `  ����G  CBindingEnums, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BindingEnumsBindingEnums  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       BindingEnums.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ,localclr-namespace:BindingEnums     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5         Checkbox �� 
TargetType �� Property �� Value � ColumnDefinitions �� Mode d� 	IsChecked  ComboBox �� Source-   'BindingEnums.EnumBindingSourceExtension  
DatePicker(  "System.Windows.Controls.DatePicker	   Text  TextBox  CollectionOutputTemplate1  +BindingEnums.InputParameterTemplateSelector  InputDataTemplateSelector
   Checkbox   ComboBox   
DatePicker   TextBox��%�  &	        &	 }    &	 u    &	 V    &	 7    &	 m    7   7  7  7  �� 5	   
   .R�5
      �  5      ���� 5      '��       " ��6   .�5      ��  �@��Padding$ 5,0,0,0q�64   5      5       5      �� 5      $��* �6'   �� 5      $
��Auto �6'   .+�5      �� $��0��6?   ��6   �� *Name+$ TwoWay=�6?   �� 5      $��1��6   ._�5      �� $
 TrueY�6    5      5      5      �� 5   
   .R�5      �  5      �� 5      $��* �6'   �� 5      $��* �6'   .+�5       �� ��6   �� *Name+$ TwoWay=��� 5!      $��1��6j   ��6   ��    *M� *local:Status++6j   5"      5#      �� 5$   
   .R�5%      �  5&      �� 5'      $��* �6'   �� 5(      $��* �6'   .+�5*      �� ��6   �� *Name+$ TwoWay=�  5+      $��1��64   	 6   �� *Value+64   5,      5-      �� 5.   
   .R�5/      �  50      �� 51      $��* �6'   �� 52      $��* �6'   .+�54      �� ��6   �� *Name+$ TwoWay=��� 55      $��1��61   ��6   �� *Value+61   56      57      �� 58   
   .R�59      �� ��6   �� 5:        5;   
   8
   8  8  8  6�   5<      .��5=      � .+�5>   
   �� -   5        $��InputParameters��5>      -  'System.Windows.Input.KeyboardNavigation   TabNavigation$ Continue=�6)   $��Stretch=�6U   $��Disabled=�6�   $
��Auto=�6�   
������ 
������ #��[ 6?  ��6z   �� *InputParameterList+��5?      �� 5@      " ��6   .�5A      ��  � �� .  62   �� 5B       � ��$ Stretch=�6C   5C      5E      5F      5G      