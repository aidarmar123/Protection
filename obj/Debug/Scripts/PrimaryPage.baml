   M S B A M L   `   `   `  ����H  DProtectionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ProtectionApp.ScriptsProtectionApp.Scripts  5      '    !ProtectionApp.Scripts.PrimaryPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:ProtectionApp.Scripts     5      -   5          N� Title$  PrimaryPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ BWatchApplication��5      $��Watch Application��5      �� 5      -   5        $ BEdit��5      $
��Edit��5      �� 5      -   5        $ BEAdd��5      $	��Add��5      �� 5      $&�� Input Name, Sename or Surname : ��6   �� 5      -   5         ��Name$ TBSearch��5      $	��250��5      5      (  "System.Windows.Controls.DatePicker  5      -   5          Name$ DPSourseDate��5      �� 5      -   5        $ BSearch��5      $��Search��5       �� 5"      -   5        $ BGoBack��5"      $��Go Back��5$      $y�Hidden=�5%      5&      &   System.Windows.Controls.DataGrid  5'   
   -	   5          Name$ DGAllApplication��5'         AutoGenerateColumns .     
IsReadOnly . $��1��5*      	   Columns	 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5-   %   �� *Name+  5.      $
 Sername��6%    5/   %   �� *Sename+  50      $
 Surname��6%    51   %   �� *	Surname+  52      $
 Visit purpose��6%    53   %   �� *VisitPurpose+  54      $
 State��6%   -
   5        	State�� 56   %   �� *
State.Name+  57      $

 Date��6%    58   %   �� *Date+5;      5<      5=      