   M S B A M L   `   `   `  ���� C  ?StopGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:StopGameStopGame      StopGame.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:StopGame       � Title$  StopGame��$	��170��$	��300��$��0,0,0,0q� � WindowStartupLocation$ CenterScreen=�$	��170��$	��300�� � Icon$m gC:\Users\Я\documents\visual studio 2017\Projects\StopGameV2.0\StopGameV2.0\other\250px-Super_mario.png��.��� $��0,0,0,0q�$��Stretch=�$��Stretch=�$
��Auto��$
��Auto�� � ShowGridLines .  $	��150��$	��300��$	��400��$	��500�� � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��2* � � ColumnDefinitions �� $
��1.5* ��� $��* �.+�	� -    	�Name$ 
caseBanner�� d� 	IsChecked$
 TrueY�$��Баннер��$
��Left=�$��10,2,0,0q�$	��Top=�$��0��$��0��	� -   $ caseSwitchOff��$/��)Выключение Компьютера��$
��Left=�$��10,2,0,0q�$	��Top=�$��0��$��1��G� -    G�Name$ PasBox1��$��Center=�$��10,2,0,0q�$	��Top=�$	��150��$��2��$��0��$��2��	 � ToolTip	 �� MKВведите пароль для отмены своего решения�� -   
 ��Name$
 TextBoxH��$��0��$
��Left=�$��17��$��10,2,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$��29��$��1��$��0��.��	 �� |zВведите сколько часов осталось для игр или просмотра мультфильмов.���� -   $
 TextBoxM��$��0��$
��Left=�$��17��$��10,2,0,0q�$
 Wrap=�$	��Top=�$��29��$��1��$��1��.��	 �� |zВведите сколько минут осталось для игр или просмотра мультфильмов.���� $��Часы��$��Right=�$��0,0,20,0q�$	��Top=�$��28��$��1��$��0���� $��Минуты��$��Right=�$��0,0,20,0q�$	��Top=�$��28��$��1��$��1���� -    ��Name$ BStart��$��
Старт��$
��Left=�$��
10,5,10,10q�$��Center=�$��83��$��29�����	#FF5F5F5F$��0��$��3��$��2��z���  �� ScaleX$ 1Q� �� ScaleY$ 1Q� �� CenterX$	 100Q� �� CenterY$	 100Q��� -   $ BCancel��$��Отмена��$��Center=�$��	0,5,10,10q�$��Center=�$��83��$��29�����	#FF5F5F5F$��0��$��3��$��2���� -   $ 
ButtonInfo��$��Справка��$��Right=�$��
10,5,20,10q�$��Center=�$��83��$��29�����	#FF5F5F5F$��0��$��3��$��2��