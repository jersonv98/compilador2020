   M S B A M L   `   `   `  ����I  ECompilador2020, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Compilador2020Compilador2020  5   	       Compilador2020.Principal   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Compilador2020     5   	     � Title$  Compilador 2020��5   	   $	��450��6!   $	��800��6.    � WindowStartupLocation$ CenterScreen=�6f    � 
ResizeMode$ NoResize=�6�    � Icon$+ %/csharp_original_logo_icon_146578.png��6�    � WindowStyle$
 None=�6�    � AllowsTransparency$
 True��6�   ��6:   Z� ��6P   Z�  � 	Resources 5	         FocusVisual �� Property �� Value	 J� SnapsToDevicePixels
 �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 btnSPortada �� 
TargetType �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName��%.  &	        &	 �     &	 �     &	 �     &	     &	 A    &	 d    &	 �    &	 �    &		 �    &	
 �    7  7  7  7  7 	 �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $
	 true��6/   #��� ��6J   $��1��6�   $	
 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ Transparent��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6$   .�5      ��  �@�FocusVisualStyle 61   Z� �� 5       � ��8   6+   �� 5       � ��8  6,   �� 5        � ��# � ��6+   �� 5!       � ��$ 1q�60   �� 5"       � ��$ Center=�6;   �� 5#       � ��$ Center=�69   �� 5$       � ��$ 1q�6(   �� 5%       � �� 5&      �� 5'      " ��6&   .R�5(      �� $ border��6!   #��z��61   #��z��6]   #��z��6�   $
	 true��6�   ._�5)      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   #	 z	 6�   #��z��6  5*       5+      P� 5,       �@��IsDefaulted$
 true��6=   . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver$
 true��6=   . �50   "   �� $ border��6@    6T   Z�  � ���� 51   "   $ contentPresenter��6K    � �� �	#FF0124316i   52      P� 53       � ��$
 true��6;   . �54   "   �� $ border��6@   8   � ��6T   55      P� 56       � {�$ false��6;   . �57   "   �� $ border��6@   8   � ��6T   �� 58   "   $ contentPresenter��6K   8   � ��6i   59      5;      5=      5>      5?      .��5@      � -   5         �Name$ 
grdPortada��5@       � UseLayoutRounding$ False��6    J� OpacityMask
 �   � � ColumnDefinitions 5A   
   �� 5B      $
��177* �6   �� 5C      $
��423* �6   �� 5D      $
��200* �6   .+�5F   
   A� -   5         A�Name$ 
eliPortada��5F      $
��Left=�6&   $	��430��6A   $��0,10,0,0q�6N   $	��Top=�6`   $��439.466��6x   $��1��6�   $��2��6�   ��5G      �� 5H       �� ImageSource$ /Logo_principal.jpg��6    j� Stretch$ UniformToFill=�6?   5J      �� 5K   
   -   5         ��Name$ 	lnlTitulo��5K      $
��Left=�6'   $��
168,59,0,0q�6B   $
��Wrap=�6V   $	��Top=�6j   $��	Open Sans)�6�   $
��Bold"�6�   $��48(�6�   $��1��6�   $��77��6�   $	��104��6�   ��5L      �� 5M       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5N      �  � Color$ Black��6#   � 5O      $ 	#FFFF4242��6#    � Offset$ 0Q�65   5P      �� 5Q   %     � Language$  es-es�6)   $	�UTN��6:   6H   �� 5R   
   -   5        $ lblEst2��5R      $
��Left=�6%   $��148,377,0,0q�6@   $
��Wrap=�6U   $	��Top=�6i   $��	Open Sans)�6�   $��20(�6�   $��1��6�   4  .System.Windows.Automation.AutomationProperties!   HelpText$! Estudiante 7mo CISIC��6�   $��30��6�   $	��152��6�   $
��Bold"�6  $��Italic$�6  ��5S      �� 5T      $ 0.5,1&�6&   $ 0.5,0&�67   .��5U      � $ Black��6#   � 5V      $ 	#FFF0E5D0��6#   $ 0Q�65   5W      �� 5X   %   $  es-es�6)   $�Vásquez Jerson��6:   6S   �� 5Y   
   -   5        $ lblEst1��5Y      $
��Left=�6%   $��163,349,0,0q�6@   $
��Wrap=�6U   $	��Top=�6i   $��	Open Sans)�6�   $��20(�6�   $��1��6�   $! Estudiante 7mo CISIC��6�   $��28��6�   $	��122��6�   $
��Bold"�6  $��Italic$�6  ��5Z      �� 5[      $ 0.5,1&�6&   $ 0.5,0&�67   .��5\      � $ Black��6#   � 5]      $ 	#FFF0E5D0��6#   $ 0Q�65   5^      �� 5_   %   $  es-es�6)   $�Torres Irwin��6:   6Q   �� 5`   
   -   5        $��Inicio��5`      $��1��6"   $
��Left=�62   $��	181,0,0,0q�6M   $��Center=�6`   $��84��6{   $��84��6�   $��0,0,0,0q�6�   $|�False��6�   " J� RenderTransformOrigin$" 1,0.5&�6�   #��� 
 6  # � Cursor$
# Hand��6.  $��22(�6<  $��MV Boli)�6J  $
��Bold"�6_  
���������6�   Z� ��5a      �� 5b      $# /button_blank_green_14986.png��6   5d      �� 5e   
   -   5        $ lnlTitulo_Copy��5e      $
��Left=�6,   $��
56,114,0,0q�6G   $
��Wrap=�6[   $	��Top=�6o   $��	Open Sans)�6�   $
��Bold"�6�   $��36(�6�   $��1��6�   $��36��6�   $��78��6�   ��5f      �� 5g      $ 0.5,1&�6&   $ 0.5,0&�67   .��5h      � $ Black��6#   � 5i      $ 	#FF858585��6#   $ 0Q�65   5j      �� 5k   %   $  es-es�6)   $
�FICA��6:   6I   �� 5l   
   -   5        $ lnlTitulo_Copy1��5l      $
��Left=�6-   $��305,114,0,0q�6H   $
��Wrap=�6]   $	��Top=�6q   $��	Open Sans)�6�   $
��Bold"�6�   $��36(�6�   $��1��6�   $��36��6�   $	��108��6�   ��5m      �� 5n      $ 0.5,1&�6&   $ 0.5,0&�67   .��5o      � $ Black��6#   � 5p      $ 	#FF858585��6#   $ 0Q�65   5q      �� 5r   %   $  es-es�6)   $�CISIC��6:   �� 6I   �� 6U   $  es-es�6Y   6m   5s      5t      