   M S B A M L   `   `   `  ����E  ARec_Escola, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Rec_Escola.ViewsRec_Escola.Views  5   	        Rec_Escola.Views.CursoList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Rec_Escola.Views     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ 	CursoList��5   	   $	��450��6   $	��800��6(   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridCurso��5       $��1��6   $��5q�67      AutoGenerateColumns$ False��6B      CanUserAddRows$ False��6^      CanUserDeleteRows$ False��5         
IsReadOnly$
 True��6-      AlternatingRowBackground �	#FFE5E5E5	 �� AlternationCount$	 2��6d   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5      $ 
Nome Curso��6%    69   �� *	NomeCurso+  5      $ Carga Horária��6%    6<   �� *CargaH+  5      $ Turno��6%    64   �� *Turno+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Ações��6)      CellTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   5"      5#      5%      5)      �� 5*   
   -   5         ��Name$ btAtualizar��5*      $��	Atualizar��6&   $
��Left=�6:   $��
424,10,0,0q�6U   $	��Top=�6i   $	��123��6�   6�   �� 5+   
   -   5        $ 	btDeletar��5+      $��Deletar��6$   $
��Left=�66   $��
573,10,0,0q�6Q   $	��Top=�6e   $	��116��6}   6�   5-      5.      