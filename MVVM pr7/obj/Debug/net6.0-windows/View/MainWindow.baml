   M S B A M L   `   `   `  ����C  ?MVVM pr7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MVVM_pr7MVVM_pr7  5   	   b ^Microsoft.VisualBasic.Core, Version=11.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aaGclr-namespace:Microsoft.VisualBasic;assembly=Microsoft.VisualBasic.CoreMicrosoft.VisualBasic 6.       MVVM_pr7.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MVVM_pr7     5   	   Vi1Gclr-namespace:Microsoft.VisualBasic;assembly=Microsoft.VisualBasic.Core     6.     � Title$  
MainWindow��5      $	��350��6   $	��525��6+    � 	Resources 5	       �� 
TargetType �� Property �� Value��%  '��       '�� H     '�� �     �� 5
   
   " ��6   .�5      ��  � ��$ 14(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 40��6&   �� 5       � ��$ 5q�6'   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��0.8* �6    � RowDefinitions 5   
   �� 5      $��25 �6   �� 5      $��* �6   �� 5      $
��0.2* �6   .+�5   
   o� $��2��6   .@�5       m� $��Файл��6   .@�5!      m� $��Открыть��6    m� Command 6,   �� *OpenFileCommand+m� 5"      $��Сохранить��6    6.   �� *SaveFileCommand+5#      5$      �� 5%   
   $��1��6   ��6   �� *Smokes+ �� SelectedItem 5&      �� *SelectedSmoke+��5'      �� 5(      .R�5)      �� $��5q�6!   .+�5*      �� $��18(�6$   ��62   �� 	 �� Path$	 Title��� 5+      ��6$   �� $	 Company��� 5,      ��6$   �� $	 Price�5-      5.      50      �� 51   
   $��2��6   
 �� Orientation$
 
Horizontal=�6"   .+�52      �� ��6   �� *AddSmokeCommand+.��69   +6<   �� 53      ��6   �� *RemoveSmokeCommand+��54      �� *SelectedSmoke+.��6@   -6C   55      �� 57   
   $��1��6   $��1��6"    � DataContext 62   �� *SelectedSmoke+.+�58      �� $'��!Выбранный элемент��6   �� 59      $��Модель��6   �� 5:      ��6   �� *Title+�� 5;      $ ��Производитель��6   �� 5<      ��6   �� *	Company+�� 5=      $��Цена��6   �� 5>      ��6   �� *Price+5?      5@      5A      