   M S B A M L   `   `   `  ����E  ARec_Escola, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Rec_Escola.ViewsRec_Escola.Views  5   	   !    Rec_Escola.Views.EscolaList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Rec_Escola.Views     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ 
EscolaList��5   	   $	��450��6   $
��1205��6)   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Listagem de Escolas��6!   $��24(�6<    �� Padding$ 10q�6J   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridEscola��5       $��1��6   $��5q�68      AutoGenerateColumns$ False��6C      CanUserAddRows$ False��6_      CanUserDeleteRows$ False��5      	   
IsReadOnly$
	 True��6-   
   AlternatingRowBackground
 �	#FFE5E5E5 �� AlternationCount$ 2��6d      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5      $ Nome Fantasia��6%    6<   �� *NomeFantasia+  5      $
 CNPJ��6%    63   �� *Cnpj+  5       $
 Tipo��6%    63   �� *Tipo+  5!      $ E-email��6%    66   �� *Email+  5"      $ Telefone��6%    67   �� *
Telefone+  5#      $ Responsável��6%    6:   �� *Responsavel+  5$      $ Telefone do Resp.��6%    6@   �� *ResponsavelTelefone+4  .System.Windows.Controls.DataGridTemplateColumn  5&      $ Ações��6)      CellTemplate 5'      �� 5(      .R�5)      ��  �� Orientation$ 
Horizontal=�6)   5,      5-      5/      53      �� 54   
   -   5        $��	Atualizar��54      $
��Left=�6%   $��	767,5,0,0q�6@   $��1��6S   $	��Top=�6`   $	��118��6x   6�   �� 55   
   -   5        $��Remover��55      $
��Left=�6#   $��	917,5,0,0q�6>   $��1��6Q   $	��Top=�6^   $	��121��6v   6�   57      58      