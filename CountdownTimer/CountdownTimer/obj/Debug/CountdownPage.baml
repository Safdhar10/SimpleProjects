   M S B A M L   `   `   `  ����I  ECountdownTimer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CountdownTimerCountdownTimer  5      "    CountdownTimer.CountdownPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:CountdownTimer     5        N� Title$  CountdownPage��5	       � 	Resources 5
       �� 
TargetType �� Property �� Value��%[   '��       �� 5   
   " ��6   .�5      ��  � ��$ LeftToRight=�6.   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��70 �6   .+�5   
   �� $��0��6   .+�5      �� -   5         ��Name$
 Time��5      $	��100��6"   $	��500��6/   $��
150,60,0,0q�6;   $��00:00:00��5      $��Assets/#Seven Segment)�6'   $��75(�5      5      �� 5   
   -   5         ��Name$ 
startPanel��5   "   $��1��6   .+�5      �� -   5        ���#caf7e3$��65��5   *   $��65��65   $��Arial)�6A   $��25(�6T   $��0,0,0,0q�6b   .��5      �� .+�5      �� $��Assets/start.png��6   5      5      5       �� 5!   
   -   5        $ 
pausePanel��5!   "   $��1��6    �� Orientation$ 
Horizontal=�66   $��Center=�6O   $y�Hidden=�6l   .+�5"      �� -   5        ���#caf7e3$��65��5"   *   $��65��65   .��5#      �� $��Assets/pause1.png��6   5$      5%      �� 5&   
   -   5        $ 	stopPanel��5&      $��1��6(   $ 
Horizontal=�65   $��Center=�6N   $y�Hidden=�6k   .+�5'      �� -   5        	 ��Name$
	 stop��5'      ���#caf7e3$��65��6H   $��65��6S   .��5(      �� $��Assets/stop.jpg��6   5)      �� 5*      -   5        $	 resume��5*      ���#caf7e3$��65��6:   $��65��6E   $��20,0,0,0q�6Q   .��5+      �� $��Assets/resume.png��6   5,      5-      5.      5/      