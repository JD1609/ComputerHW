   M S B A M L   `   `   `  ���� B  >HW_Info, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PC_InfoPC_Info      PC_Info.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:PC_Info     -     � WindowStartupLocation$  CenterScreen=� � Title$ HW_Info�� � Icon$ 
pc_ico.ico��$	��240��$	��425�� � 
ResizeMode$ CanMinimize=�
���������Z� .��� $��10q�����  � ColumnDefinitions �� $	��60* ��� $
��277* ��� $	��60* �.+��� -   $��	UserLabel��$��User:��$
��Left=�$��10,0,0,0q�$	��Top=�$��26��$
��Bold"�$��39���� -   $��OSLabel��$	��OS:��$
��Left=�$��	10,25,0,0q�$	��Top=�$��26��$
��Bold"�$��39���� -   $��CPULabel��$
��CPU:��$
��Left=�$��	10,50,0,0q�$	��Top=�$��26��$
��Bold"�$��37���� -   $��GPULabel��$
��GPU:��$
��Left=�$��	10,75,0,0q�$	��Top=�$��26��$
��Bold"�$��38���� -   $��RAMLabel��$
��RAM:��$
��Left=�$��
10,100,0,0q�$	��Top=�$��26��$
��Bold"�$��41���� -   $��MBLabel��$	��MB:��$
��Left=�$��
10,125,0,0q�$	��Top=�$��26��$
��Bold"�$��41���� -   $��
UserLabelC��$��Unknown��$
��Left=�$��0,0,0,0q�$	��Top=�$��1��$��2��$��26�� � Cursor$
 Hand���� -	   $��OSLabelC��$��Unknown��$
��Left=�$��0,25,0,0q�$	��Top=�$��1��$��2��$��26��$
 Hand���� -
   $��	CPULabelC��$��Unknown��$
��Left=�$��0,50,0,0q�$	��Top=�$��1��$��2��$��26��$
 Hand���� -   $��	GPULabelC��$��Unknown��$
��Left=�$��0,75,0,0q�$	��Top=�$��1��$��2��$��26��$
 Hand���� -   $��	RAMLabelC��$��Unknown��$
��Left=�$��	0,100,0,0q�$	��Top=�$��1��$��2��$��26��$
 Hand���� -   $��MBLabelC��$��Unknown��$
��Left=�$��	0,125,0,0q�$	��Top=�$��1��$��2��$��26��$
 Hand���� -   $��OK��$��93,161,94,0q�$	��Top=�$��1��$��20���� -   $��SaveDesktop��$��2��$
��Left=�$��20��$��20��$��40,0,0,0q�$	��Top=�$
 Hand�� � ToolTip$ Save to desktop������  �� ImageSource$ save.png���� -   $��SaveClipboard��$��2��$
��Left=�$��20��$��20��$��15,0,0,0q�$	��Top=�$
 Hand��$ Save to clipboard������ $ Clipboard.png���� -   $
��Help��$��2��$
��Left=�$��15��$��15��$��
44,163,0,0q�$	��Top=�$
 Hand������ $ help.png��