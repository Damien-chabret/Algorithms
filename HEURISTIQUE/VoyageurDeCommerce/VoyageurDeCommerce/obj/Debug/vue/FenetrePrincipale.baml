   M S B A M L   `   `   `  ����M  IVoyageurDeCommerce, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:VoyageurDeCommerceVoyageurDeCommerce  5   	   .    (VoyageurDeCommerce.vue.FenetrePrincipale   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:VoyageurDeCommerce     5   	     � Title$'  !SAÉ S2.02 - Voyageur de commerce��5   	   $	��900��62   $
��1600��6?    � WindowStartupLocation$ CenterScreen=�5	   	   $��20(�5
   	   $
��1024��5   	   $	��576��5   	    � Icon$ /;component/icon.ico��6    � 	Resources 5       �� 
TargetType �� Property �� Value��%R   '�       �� 5   
   " �6   .�5      ��  � ��$ 20(�6)   5      5      .��5      � 
����ح� � ColumnDefinitions 5   
   �� 5      $��5* �6   �� 5      $��* �6   .+�5   
   ]� 
����ح�$��0��6+   .+�5      ��  �� Padding$ 10q�6   $	��Top=�6"   $��0q�67   ._�5      � 
�������$��Center=�6*   $	��Top=�6G   .+�5      �� -   5        	 ��Name$	 ComboBoxFichier��5      $	��300��6�   ��68   �� *ListeFichiers+
 �� SelectedItem
 6^   �� *FichierSelectionne+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   5      5      �� 5      -   5         ��Name$ TextTournee��5      
�������$��0,5,0,5q�6j   $��Bottom=�6{   $	��100��6�   $
��Wrap=�6�    �� Padding$ 5q�6�   ��6.   �� *TextTourneeSelectionnee+5      �� 5       -   5         ��Name$ ScrollViewerGraphe��5    (   $	��0,5q�6   
�������$��Visible=�6W   $��Visible=�6}   .��5!      � -   5         �Name$ ScrollContent��5!   1   
������ .+�5"      �� -   5         ��Name$ CanvasGraphe��5"      
������ $��50��6L   $��50��6W   6e   5#      5$      5%      ]� 5&   
   
����ح�$��1��6+   ��. .+�5'      �� $ 20,10,10,10q�6   $	��Top=�6+   $��0q�6@   ._�5(      ]� $	��Top=�6   .+�5)      �� -   5        $	 ComboBoxAlgorithme��5)       �� DisplayMemberPath$	 Nom��6�   $	��Top=�6�   $��0,0,0,10q�6�   ��6;   �� *ListeDesAlgorithmes+
 6g   �� *AlgorithmeSelectionne+6�   �� 5*      -   5         ��Name$ BoutonExecution��5*      .��6T   	Execution6_   5+      5,      �� 5-      -   5         ��Name$ TextBoxDistance��5-      $��Bottom=�6/   $��20,10,10,10q�6G   $��Center=�6\    �� 
IsReadOnly . .��6�   
Distance6�   �� 5.      -	   5        $ ScrollStory��5.      
�������$��20,10,10,10q�6C   .��5/      �� -
   5         ��Name$ 
StackStory��5/      
�������61   50      51      52      53      