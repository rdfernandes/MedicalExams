   M S B A M L   `   `   `  ����  MedicalExams    MedicalExams.ExamsList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	     � WindowStartupLocation$  CenterScreen=�5   	   
������    ExamsList.WindowTitle � Title# �   5
   	   $	��450��69   $	��800��6F   .��5      ��   GeneralBorder#��[ 6   ._�5   
   � ��5      �� 5       �� ImageSource$% Resources/Images/background.jpg��6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      �� 5      $
��Auto �6    .+�5      �� $��0��6     ExamsList.Title#���  6%     	TitleText#��[ 6N   �� 5      -   5         ��Name$ ExamsListView��5      $��1��6.     ListView#��[ 6;   $	��600��6]    �� View 5      �� 5      .P�5      ��  �� Width$	 150��6)    ' #ExamsList.ColumnTitle.ProcessNumber#���  65    �� DisplayMemberBinding 6t   �� *Id+�� 5       $	 150��6)    % !ExamsList.ColumnTitle.CreatedDate#���  65    6r   �� *CreatedDate+ �� StringFormat$ dd/MM/yyyy HH:mm:ss���� 5!      $	 200��6)    , (ExamsList.ColumnTitle.TotalExamsSelected#���  65    6y   �� *TotalSelectedExams+�� 5"      $ 90��6)   $�� ��64   	 �� CellTemplate	 5#      �� 5$   "   .R�5%   &   �� 
 ��Name$
 ExamRowButton��6-   -   5          ExamRowButton#��[ 5%   D    	 ExamsList.ButtonMoreInfo#��� 	 6k   
 � Tag 6�   �� *Id+5&   #   5(      5)      5+      �� 5.      -   5        $
 RefreshButton��5.   H   $��2��6    
 CircleButton#��[
 6"   $
{�True��6{   $
��Left=�6�   $��40��6�   $��40��6�   .��5/      !  FontAwesome.WPF.FontAwesome     Icon$ Refresh=�6!   $��17(�60   $��0 4 0 0q�6>   50      �� 53      -   5        $
 NewExamButton��53   H   $��2��6   #��[
 6"   $��40��6{   $��	ExtraBold"�6�   $��20(�6�   $��40��6�   $��+��6�   $��Right=�6�   55      56      58      