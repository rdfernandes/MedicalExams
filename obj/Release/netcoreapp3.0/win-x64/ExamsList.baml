   M S B A M L   `   `   `  ����   MedicalExams    MedicalExams.ExamsList   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/    � WindowStartupLocation$  CenterScreen=�
������    ExamsList.WindowTitle � Title# �   $	��450��$	��800��.����   GeneralBorder#��[ ._�� ����  �� ImageSource$% Resources/Images/background.jpg�� � RowDefinitions �� $
��Auto ��� �� $
��Auto �.+��� $��0��  ExamsList.Title#���    	TitleText#��[ �� -    ��Name$ ExamsListView��$��1��  ListView#��[ $	��600�� �� View �� .P���  �� Width$	 150�� ' #ExamsList.ColumnTitle.ProcessNumber#���   �� DisplayMemberBinding �� *Id+�� $	 150�� % !ExamsList.ColumnTitle.CreatedDate#���   �� *CreatedDate+ �� StringFormat$ dd/MM/yyyy HH:mm:ss���� $	 200�� , (ExamsList.ColumnTitle.TotalExamsSelected#���   �� *TotalSelectedExams+�� $ 90��$�� ��	 �� CellTemplate	 �� .R��� 
 ��Name$
 ExamRowButton��-     ExamRowButton#��[  	 ExamsList.ButtonMoreInfo#��� 	 
 � Tag �� *Id+�� -   $
 RefreshButton��$��2�� 
 CircleButton#��[
 $
{�True��$
��Left=�$��40��$��40��.��!  FontAwesome.WPF.FontAwesome     Icon$ Refresh=�$��17(�$��0 4 0 0q��� -   $
 NewExamButton��$��2��#��[
 $��40��$��	ExtraBold"�$��20(�$��40��$��+��$��Right=�