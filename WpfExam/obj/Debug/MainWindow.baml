   M S B A M L   `   `   `  ����B  >WpfExam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfExamWpfExam  5   	       WpfExam.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfExam     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         rColumnStyle �� Property �� Value��%p   &	        �� 5
   
   .�5      ��  � ��
 �����63   �� 5       � ��
 �����63   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgQuestions��5   /      AutoGenerateColumns .  $��1��6D   $��0��6Q      SelectionMode$ Single=�6a   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6%      Header$ Question��6/      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ��  �� Path$ Question�6e     5      $
 Type��6%    .  63   �� $
 Type�6S   5      � 5   
   $��1��6   $��1��6   
������� 5       �� 5!      $��23 �6    �� 5"      $��20 �6    �� 5#      $��20 �6    �� 5$      $��20 �6    �� 5%      $��20 �6    �� 5&      $��20 �6    .+�5(      �� $��Answers:��6   #��[  6)   
����·� �� TextAlignment$ Center=�6i   6�   �� 5)      -   5        $	��tb1��5)   #   $��1��6   60   �� 5*      -   5        $	��tb2��5*   #   $��2��6   60   �� 5+      -   5        $	��tb3��5+   #   $��3��6   60   �� 5,      -   5        $	��tb4��5,   #   $��4��6   60   �� 5-      -   5        $	��tb5��5-   #   $��5��6   60   5.      ]� 50   
   $��2��6   $��0��6!   
����·�.+�51      �� -   5         ��Name$ btSubmit��51        rButtonStyle#��[ 6(   $��Submit��6N   $��Center=�6_   $
��Left=�6z   52      53      54      55      