   M S B A M L   `   `   `  ����H  DDirectoryChar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DirectoryCharDirectoryChar  5      "    DirectoryChar.DeleteWordPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:DirectoryChar     5        N� Title$  DeleteWordPage��5	       N� 
Background �	#FFF6E8B1.��5      �  � ColumnDefinitions 5   
   �� 5      $	��156 �6   �� 5      $	��27* �6   .+�5   
   �� -   5         ��Name$ ListOfDirectories��5      $
��Left=�6-   $	��329��6H   $��
10,111,0,0q�6U   $	��Top=�6i   $	��260��6�   ���	#FFE5CBCB$��3��6�   $��Visible=�6�   ��6�   ��  �� Mode$ OneWay=�6�   �� 5   
   -   5         ��Name$
 Lab1��5      $.��(       Enter a word you'd like to delete��6   $
��Left=�6Q   $��136.8,46,-31,0q�6l   $	��Top=�6�   $��43��6�   $	��511��6�   $��22(�6�   ���	#FF7C7916$
��Bold"�6�   $��2��6�   �� 5   
   -   5         ��Name$ 
WordTxtBox��5      $��2��6&   $
��Left=�66   $��29��6Q   $��191.8,94,0,0q�6]    �� TextWrapping$
 Wrap=�6s   $	��Top=�6�   $	��315��6�   ���	#FFD6D6D66�   �� 5   
   -   5         ��Name$ DeleteCharactersButton��5      $��287.8,280,219,69.6q�61   $��2��6�   ��6M   Z� ��6c   Z� ��6z   Z� .��5      �� 	 �� Orientation$	 
Horizontal=�6   
 � Cursor$

 Hand��62   .+�5      �� $��
Delete.png��6   $��Uniform=�6,   5      5      �� 5   
   -   5        $ 
FolderTest��5      $��10,-17,85,373.6q�6%   ��6>   Z� ��6T   Z� ��6k   Z� .��5      �� $	 
Horizontal=�6   $��54��62   $

 Hand��6>   .+�5      �� -   5         ��Name$ Choose_DirectoryButt��5      $��0050-folder_search.png��66   $��Uniform=�6V   $��51��6i   $��	0,0,0,0.4q�6t   5      5      �� 5   
   -   5        $ DirectoryNameTxtBox��5      $
��Left=�6/   $��29��6J   $��	76,10,0,0q�6V   $
 Wrap=�6i   $	��Top=�6}   $	��605��6�   ���	#FFD6D6D6$��2��6�   �� 5   
   -   5        $ 	Lab1_Copy��5      $��SubDirectories��6#   $
��Left=�6<   $��	53,68,0,0q�6W   $	��Top=�6j   $��43��6�   $	��167��6�   $��22(�6�   ���	#FF7C7916$
��Bold"�6�   $��3��6�   �� 5   
   -	   5        $ CharactersToBeLabe_��5      $��Word to be deleted��6-   $
��Left=�6J   $��241,190,0,0q�6e   $	��Top=�6z   $��43��6�   $	��309��6�   $��22(�6�   ���	#FF7C7916$
��Bold"�6�   $��1��6�   �� 5    
   -
   5        $ CharactersToBeDeleted��5        �� 
IsReadOnly . $��2��6C   $
��Left=�6S   $��29��6n   $��191.8,238,0,0q�6z   $
 Wrap=�6�   $	��Top=�6�   $	��315��6�   ���	#FFD6D6D6��6�   �� $ OneWay=��� 5!   
   -   5        $ EntersCharacters��5!      $

 Hand��6+   $��Add To List��69   $
��Left=�6O   $��274.8,128,0,0q�6j   $	��Top=�6�   $	��137��6�   $��48��6�   ���	#FFDACF68���	#FF5D5D1B$��24(�6�   $
��Bold"�6�   $��2��6�   6  �� 5#   
   -   5        $ ClearCharactersButt��5#      $��LeftToRight=�6.   $
��Left=�6K   $��150.8,233,0,0q�6f   $	��Top=�6}   $��41��6�   $��38��6�   $��Center=�6�   $��Center=�6�   $��2��6�   ��6  Z� ��6  Z� .��5$      �� $��Stretch=�6   $

 Hand��68    J� RenderTransformOrigin$ 0.5,0.5&�6F   $��38��6f   .+�5%      �� $
��Left=�6   $��X.png��64   $��36��6C   $��38��6O   5&      5'      �� 5)   
   -   5        $ BackButt��5)      $

 Hand��6#   $
��Back��61   $
��Left=�6@   $��	537,7,0,0q�6[   $	��Top=�6n   $��97��6�   $��34��6�   ���	#FFDACF68���	#FF5D5D1B$��24(�6�   $
��Bold"�6�   $��1��6�   6�   5+      5,      