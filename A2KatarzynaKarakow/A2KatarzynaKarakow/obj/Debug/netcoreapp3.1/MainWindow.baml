   M S B A M L   `   `   `  ����M  IA2KatarzynaKarakow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:A2KatarzynaKarakowA2KatarzynaKarakow  5   	   #    A2KatarzynaKarakow.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:A2KatarzynaKarakow     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� .+�5
   
   �� -   5         ��Name$ cboxContinents��5
       �� Left$	 132��6+   
 �� Top$ 37��6=   $	��120��6M   �� 5   
   -   5         ��Name$ lblContinents��5      $��
Continents��6'   $ 35��6<   $ 33��6M   �� 5   
   -   5         ��Name$ lboxCountries��5      $	��124��6)   $	��116��66   $	 134��6B   $ 73��6T   6d   �� 5   
   -   5        $ lblCountries��5      $��	Countries��6&   $ 38��6:   $ 73��6K   �� 5   
   -   5        $ lblLanguages��5      $��	Languages��6&   $ 38��6:   $	 217��6K   �� 5   
   -   5        $ lblCurrency��5      $��Currency��6%   $ 43��68   $	 255��6I   �� 5   
   -   5        $ 	lblCities��5      $ ��Cities of selected country��6#   $	 500��6H   $ 33��6Z   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgCities��5      $	��285��6%   $	��407��62   $	 352��6>   $ 73��6P   �� 5   
   -	   5         ��Name$ btnAddContinent��5      $��Add Continent��6*   $	 132��6B   $	 309��6T   6e   �� 5   
   -
   5        $ btnAddCountries��5      $��Add Countries��6*   $	 134��6B   $	 343��6T   6e   �� 5   
   -   5        $ btnAddCities��5      $��
Add Cities��6'   $	 144��6<   $	 379��6N   6_   �� 5   
   -   5        $ lblDisplayLanguages��5      $�� ��6-   $	 134��68   $	 217��6J   $	��118��6[   5      5      