   M S B A M L   `   `   `  ����H  DProtectionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ProtectionApp.ScriptsProtectionApp.Scripts  5      /    )ProtectionApp.Scripts.ApprovedApplication   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:ProtectionApp.Scripts     5        N� Title$  ApprovedApplication��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ BGoBack��5      $��Go back��5      5      �� 5      -   5        $ BEntry��5      $	��400��5      $��2��5      $��Center=�5      $��
Entry/Exit��5      $y�Visible=�5      &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ DGApprovedApplication��5"         AutoGenerateColumns .     
IsReadOnly . $��1��5%         Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5(   %   �� *Name+  5)      $ Sername��6%   	 5*   %   �� *Sename+  5+      $ Surname��6%   	 5,   %   �� *	Surname+  5-      $ Visit purpose��6%   	 5.   %   �� *VisitPurpose+  5/      $ State��6%   -   5        	State��	 51   %   �� *
State.Name+  52      $
 Date��6%   	 53   %   �� *Date+  54      $ 
Time Entry��6%   	 55   %   �� *	TimeEntry+  56      $ 	Time Exit��6%   	 57   %   �� *
TimeExit+5:      5;      5<      