   M S B A M L   `   `   `  ����D  @TravelApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:TravelApp.PagesTravelApp.Pages  5          TravelApp.Pages.Hotels   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:TravelApp.Pages     5        N� Title$  Hotels��5	       N� 
Background �#bae3e8.��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   $	��250��6*   �� 5      $
��auto �6   �� 5      $	��250 �6   $	��250��6+    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   .+�5   
   ]� $	��Top=�6   $��3��6)   ���#fac716.+�5      �� -   5         ��Name$ CloseButton��5   Q   $��Закрыть��6   $��10(�6'   $��60��65   $��5 5 5 5q�6@   $��Right=�6f   6}   �� 5      $��
Отели��6   $��16(�6$   $
��Bold"�62   5      ]� 5   
   -   5         ]�Name$ PageDataGridDockPanel��5   5   $��1��6   $��3��6!   .+�5      ]� $	��Top=�6   .+�5      �� -   5        $ NewHotelButton��5   S   $��
Новый��6   $��10(�6)   $��60��67   $��5 5 5 5q�6B   6S   �� 5      -   5        $ CopyHotelButton��5   X   $��Копировать��6   $��10(�6.   $��60��6<   $��0 5 5 5q�6G   6X   �� 5       -   5        $ ChangeHotelButton��5    V   $��Изменить��6   $��10(�6,   $��60��6:   $��0 5 5 5q�6E   6V   �� 5!      -   5        $ DeleteHotelButton��5!   U   $��Удалить��6   $��10(�6+   $��60��69   $��0 5 5 5q�6D   6U   �� 5"      -   5        $ FilterHotelButton��5"   S   $��
Поиск��6   $��10(�6)   $��90��67   $��0 5 5 5q�6B   6S   �� 5#      5$      ]� 5&      -   5        $ FilterDockPanel��5&   -   $	��Top=�6   $y�	Collapsed=�6F   .+�5'      �� $��Быстрый поиск��6   �� 5(      -	   5         ��Name$ filterTextBox��5(      $��Center=�61   $��0 0 5 0q�6L   5)      ]� 5+      $��Bottom=�6   $��5q�60   5-      ]� 5.      $��Bottom=�6   $��5q�60   .+�5/      �� -
   5        $ startBlockButton��5/   ,   $��В начало��6   $��75��6F   �� 50      -   5        $ backBlockButton��50   )   $��
Назад��6   $��75��6B   $��5 0 0 0q�6M   �� 51      $��Страница:��6   $��15 0 0 0q�6,   �� 52      -   5         ��Name$ blockNumLabel��52      ��6/   ��  �� Path$ BlockNum��� 53      $
��из��6   �� 54      -   5        $ blockCountLabel��54      ��61   �� $ 
BlockCount��� 55      -   5        $ 
nextButton��55   *   $��Вперед��6   $��75��6>   $��15 0 0 0q�6J   �� 56      -   5        $ lastBlockButton��56   +   $��В конец��6   $��75��6D   $��5 0 0 0q�6O   �� 57      $@��:Количество записей на странице:��6   $��15 0 0 0q�6B   �� 58      -   5        $ countBlockRecordsTextBox��58      $��50��6<   ��6G   �� $ BlockCountRecords�	 �� UpdateSourceTrigger$	 PropertyChanged=�59      &   System.Windows.Controls.DataGrid  5:      -   5        
  Name$
 HotelsDataGrid��5:      $��0 5 0 0q�6/      Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$ Наименование��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 10* 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� $
 Name�6]     5=      $ Кол-во звезд��6)   $	 10* 6e    6?   �� $ CountOfStars�6e     5>      $ Код страны��6)   $	 10* 6b    6=   �� $ CountryCode�6b     5?      $ Описание��6)   $	 10* 6`    6;   �� $ Description�6`   5A      5C      �� 5E   
   -   5         ��Name$ DialogGridSplitter��5E      $��1��63   $��1��6C   $��Center=�6P   $��3��6m   $y�Hidden=�6w   �� 5F   
   -   5         ��Name$ DialogScrollViewer��5F      $��2��63   $��1��6C   $y�Hidden=�6P   $
��Auto=�6d   .��5G       � -   5          �Name$ DialogFrame��5G      5H      5I      5J      