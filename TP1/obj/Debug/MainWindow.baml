   M S B A M L   `   `   `  ����>  :TP1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TP1TP1  5   	       TP1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:TP1     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��392* �6   �� 5      $��5* �6   .+�5   
   o� $
��Left=�6   $��27��6*   $	��Top=�66   $	��793��6N   $��2��6Z   .@�5      m� -   5        $��	Démarrer��5      .@�5      m� -   5        $��Lancer Ballon��5      62   m� 5      -   5        $��Lancer Premier��5      63   5      m� 5      $��Suppression��6   .@�5      m� -   5        $��Supprimer dernier��5      66   m� 5      -   5        $��Supprimer dernier ballon��5      6=   m� 5      -   5        $��Supprimer dernier premier��5      6>   m� 5      -   5        $ ��Supprimer tous les ballons��5      6?   m� 5      -	   5        $!��Supprimer tous les premiers��5      6@   m� 5      -
   5        $��Supprimer tout��5      63   5      m� 5      -   5        $��Quitter��5      6(   5      �� 5   
   -   5        $��ProcessList��5      $
��Left=�6%   $	��394��6@   $��0,27,0,-0.333q�6M    �� TextWrapping$
 Wrap=�6d   $!��Aucun Thread pour l'instant��6x   $	��Top=�6�   $	��300��6�   �� 5   
   -   5        $��NbBaloonText��5      $
��Left=�6&   $��24��6A   $��580,175,0,0q�6M   $
 Wrap=�6b   $��Nombre de Ballons: ��6v   $	��Top=�6�   $	��139��6�   �� 5   
   -   5        $��NbPremierText��5      $
��Left=�6'   $��25��6B   $��
579,32,0,0q�6N   $
 Wrap=�6b   $��Nombre de Premier : ��6v   $	��Top=�6�   $	��126��6�   �� 5    
   -   5        $��NbProcessusText��5       $
��Left=�6)   $��28��6D   $��579,299,0,0q�6P   $
 Wrap=�6e   $"��Nombre de processus total : ��6y   $	��Top=�6�   $	��170��6�   �� 5!   
   -   5        $��BaloonCount��5!      $
��Left=�6%   $��48��6@   $��556,231,0,0q�6L   $
 Wrap=�6a   $��0��6u   $	��Top=�6~   $	��163��6�   �� 5"   
   -   5        $��PremierCount��5"      $
��Left=�6&   $��59��6A   $��
556,80,0,0q�6M   $
 Wrap=�6a   $��0��6u   $	��Top=�6~   $	��163��6�   �� 5#   
   -   5        $��ProcessCount��5#      $
��Left=�6&   $��52��6A   $��556,345,0,0q�6M   $
 Wrap=�6b   $��0��6v   $	��Top=�6   $	��163��6�   5$      5%      