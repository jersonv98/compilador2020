   M S B A M L   `   `   `  ����I  ECompilador2020, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Compilador2020.ParserCompilador2020.Parser  5   	   (    "Compilador2020.Parser.ParserWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Compilador2020.Parser     5   	     � Title$  Parser��5   	   $	��450��6   $	��800��6%    � Icon$2 ,/Parser/csharp_original_logo_icon_146578.png��61    � WindowStyle$ SingleBorderWindow=�6e    � 
ResizeMode$ NoResize=�6�    � WindowStartupLocation$ CenterScreen=�6�   ��5	      �� 5
   
    j� Stretch$ UniformToFill=�6    �� ImageSource$ /Parser/1516578954.jpg��6-   .��5      � .+�5   
   �� -   5         ��Name$ TabControlSintactico��5      $��10,87,173,10q�63   $	��617��6I   .@�5      �� -   5         ��Name$ TabItemTokensReconocidos��5      $��Tokens Reconocidos��68   .��5      � -   5        	 �Name$	 GridTokensReconocidos��5      ���	#FFE5E5E5.+�5      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 tbl_TokensReconocidos��5      $��10,10,10,10q�6>   $��1��6S   
���   �$��3,3,3,3q�6{      MinColumnWidth$	 142Q�6�      AutoGenerateColumns$ False��6�      CanUserAddRows$ False��6�      CanUserDeleteRows$ False��6�      CanUserResizeRows$ False��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Numero del Token��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6K   �� *NumeroToken+  5      $ Sinonimo del Token��61    6M   �� *SinonimoToken+  5      $ Nombre del Token��61    6K   �� *NombreToken+  5      $ Lexema del Token��61    6K   �� *LexemaToken+5      5      5      �� 5      -   5        $ TabItemGramaticaOriginal��5      $��Gramática Original��68   .��5      � -   5        $	 GridGramaticaOriginal��5      ���	#FFE5E5E5.+�5        -   5        $
 tbl_GramaticaOriginal��5      $��2��6>   $��10,10,10,10q�6R   $ False��6g   $ False��6~   $ False��6�   $��3,3,3,3q�6�   
���   �$	 142Q�6�   $ False��6�    5        5      $ Numero de regla��61    6J   �� *rnum+  5      $ Parte Izquierda��61    6J   �� *izq+  5       $ Parte Derecha��61    6H   �� *der+5"      5#      5$      �� 5%      -   5        $ TabItemGramaticaSinonimos��5%      $��Gramática en Sinónimos��69   .��5&      � ���	#FFE5E5E5.+�5'        -	   5        $
 tbl_GramaticaEnSinonimoss��5'      $��2��6B   $��10,10,10,10q�6V   $ False��6k   $ False��6�   $ False��6�   $��3,3,3,3q�6�   
���   �$	 142Q�6�   $ False��6�    5(        5)      $ Numero de regla��61    6J   �� *rnum+  5*      $ Parte Izquierda��61    6J   �� *izq+  5+      $ Parte Derecha��61    6H   �� *der+5-      5.      5/      �� 50      -
   5        $ TabItemFirstNext��50      $��
First/Next��60   .��51      � ���	#FFE5E5E5.+�52        -   5        $
 tbl_FirstNext��52      $��2��66   $��10,10,10,10q�6J   $ False��6_   $ False��6v   $ False��6�   $��3,3,3,3q�6�   
���   �$	 142Q�6�   $ False��6�    53        54      $ No Terminal��61    6F   �� *noTer+  55      $ First��61    6@   �� *first+  56      $
 Next��61    6?   �� *next+58      59      5:      �� 5;      -   5        $ TabItemMatrizTransicion��5;      $��Matriz de Transiciones��67   .��5<      � ���	#FFE5E5E56   5=      �� 5>      -   5        $! TabItemMatrizPilaSintactica��5>      $��Pila Sintáctica��6;   .��5?      � ���	#FFE5E5E56   5@      �� 5A      -   5        $ TabItemMovimientos��5A      $��Movimientos��62   .��5B      � ���	#FFE5E5E56   5C      �� 5D      -   5        $ TabItemReglasReconocidas��5D      $��Reglas Reconocidas��68   .��5E      � ���	#FFE5E5E56   5F      5G      A� 5H   
   $
��Left=�6   $��58��6-   $��	36,10,0,0q�69   
���   �$	��Top=�6[   $��59��6s    � Cursor$ ArrowCD��6~   ��5I      �� 5J      $ /Parser/unnamed.png��6   5L      �� 5M   
   $
��Left=�6   $��
106,10,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��46��6o   $	��509��6{    �� TextAlignment$ Center=�6�   $��36(�6�   $��Normal"�6�   $��Normal$�6�   $��COMPILADOR 2020��6�   $��MV Boli)�6�   ���	#FF4B48486�   �� 5N   
   $
��Left=�6   $��44��6+   $��
601,17,0,0q�67   $	��Top=�6K   $	��160��6c   $��/Parser/Vive.png��6o   �� 5O   
   -   5        $�� ��5O      $
��Left=�6   $��692,207,0,0q�67   $	��Top=�6L   $��36��6d   $��43��6p   ��6�   Z� ��5P      �� 5Q      $? 9/Parser/merkletreesdiagramchartflowchartprocess_95911.png��6   5S      �� 5T   
   $��Sintáctico��6   $
��Left=�6%   $��671,243,0,0q�6@   $	��Top=�6U   $��Segoe Script)�6m   $
��Bold"�6�   $��14(�6�   5V      5W      