   M S B A M L   `   `   `  ����B  >WpfExam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfExamWpfExam  5   	       WpfExam.FUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfExam     5   	     � Title$  FUser��5   	   $	��450��6   $	��800��6$    � 	Resources 5	       �� Color   rWhiteSmoke��%3   &	        �� 5
   
   $ 
WhiteSmoke��6   6-   5      .��5      �   rLightSteelBlue#��[ 6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      $��50 �6   6+   .+�5   
   �� $��
First Name��6   $��0��6%   $��0��65   $��Right=�6B   $��Center=�6^   6{   �� 5   
   -   5         ��Name$ tbFirstName��5      $��1��6'   $��0��67   $��40��6D   $��30 0 0 0q�6P   $	��300��6b   $
��Left=�6n   $��Center=�6�   #��[  6�   6�   �� 5   
   $��	Last Name��6   $��0��6$   $��1��64   $��Right=�6A   $��Center=�6]   6z   �� 5   
   -   5        $ 
tbLastName��5      $��1��6&   $��1��66   $��40��6C   $��30 0 0 0q�6O   $	��300��6a   $
��Left=�6m   $��Center=�6�   #��[  6�   6�   ]� 5   
   $��0��6   $��6��6$   $��2��61     ExternalLinearSalmonBlue#��[ 6E   .+�5      �� -   5         ��Name$ Ok��5        rButtonStyle#��[ 6"   $	��100��6H   $��30��6T   $��OK��6`    �� 	IsDefault . $��10 10q�6~   $
��Left=�6�   6�   �� 5      -   5        $ Cancel��5      #��[ 6&   $��Cancel��6L    �� IsCancel . $
��Left=�6m   6�   5       5!      5"      