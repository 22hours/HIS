   M S B A M L   `   `   `  ����   	HISServer    HISServer.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Server��$	��450��$	��800�� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � 	Resources    SwitchTypeToggleButton �� 
TargetType �� 	Resources  Key �� Property �� Value J� SnapsToDevicePixels	 �� StrokeDashArray
 �� 
TargetType � 	Resources �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value �� 
Background �� Bullet ��Name �� CornerRadius J� RenderTransformOrigin J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   	Direction �� Triggers P� Property P� Value  CheckRadioFocusVisual �� 
TargetName 
 Accent N� EnterActions ��Name  StoryboardIsChecked �� BeginStoryboardName  StoryboardIsCheckedOff  Color.Additional.LightGrey �� Color & "Color.MedtronicBranding.CobaltBlue  Color.Additional.MediumGrey )	 %Color.MedtronicBranding.MedtronicBlue 
 ToggleButtonContentTextbox  �Name! � ColumnDefinitions" �� ElementName# �� Path$ � RowDefinitions% ��Name& A�Name  ToggleButtonTrueBackground  ToggleButtonFalseBackground' ��Name  OnContentControl  OffContentControl( �� Orientation  ToggleButtonTrueForeground  ToggleButtonFalseForeground  TextBoxBaseControlTemplate) ��Name��%w  &	        7  7  7  7  7  7  7 	 7 
 7 
 7 
 7  7  7  7  7  7  7  7  &	     �� " d� ���� CheckRadioFocusVisual .���  � �� �� .R��� $��14,0,0,0q� . #��� ��$��1��$		 1 2R��� SliderCheckBox " ��.���  � ��# � ����  � ��$ 1q���  �@�Cursor$
 Hand����  � �� �� "
 �� ���� StoryboardIsChecked .��U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ 	CheckFlag��.\�  $ 0��$ 0Q�  $ 0:0:0.2��$ 14Q��� StoryboardIsCheckedOff .��U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ 	CheckFlag��.\�  $ 0��$ 14Q�  $ 0:0:0.2��$ 0Q�.R��� 
 ����  .  �� $ ForegroundPanel��$��1q�$��35��$��20��$ 10��._��� .+��� $ 	CheckFlag��
�������$ 10��$��Center=�$��1q�$��19��$��18��$ 0.5,0.5&�z�V� .~��� �� �� T�    $ 1Q�$	 180Q�._��� #��z��#��z����. # z $��Center=� P�  � �� . . ��� 8    �@�FocusVisualStyle��  � ��$ 4,0,0,0q�P�  � {� .  . ��� # � �� � ��P�  �@d�	IsChecked$
 TrueY�. ��� $ ForegroundPanel��# �   � �� �� $  BeginStoryboardCheckedTrue��8�� �� $! BeginStoryboardCheckedFalse��P�  �@d�	IsChecked$ FalseY�. ��� $ ForegroundPanel�� � ��
 ����� �� $! BeginStoryboardCheckedFalse��8�� �� $  BeginStoryboardCheckedTrue����Color.Additional.LightGrey #989EA8����Color.Additional.MediumGrey #61656B����)%Color.MedtronicBranding.MedtronicBlue #004B87����&"Color.MedtronicBranding.CobaltBlue #0085CA���� ToggleButtonContentTextbox " ��.���  � ��$ Stretch=���  � ��$ Stretch=��� ToggleButtonFalseBackground 8  �� ToggleButtonTrueBackground 8  �� ToggleButtonFalseForeground 8  �� ToggleButtonTrueForeground 8  �� 
OffContent 8�� $	��Off���� OnContentControl " ��.���  � ��$ Center=���  � ��$ Center=���  � �� �� .R��� $��Wingdings 2)�$��24(�$
��Bold"�
�������8�� $�� ����  � ��$ Center=���  � ��$ Center=��� OffContentControl " ��.���  � ��$ Center=���  � ��$ Center=���  � �� �� .R��� $��24(�
�������8��	 $�� ����  � ��$ Center=���  � ��$ Center=�.���  � �� �� "
 d�.R�� $  MainRow��.+�� ! �� ���� $" TopRow��$# ActualHeight��� �� ���� $" TopRow��$# ActualHeight�$ �� $% TopRow���� .+�A� $& BackgroundEllipse1��$��2��$��0��$��3��$
��Left=�8��
 ���� $" MainRow��$# ActualHeight����� $" MainRow��$# ActualHeight�A� $& BackgroundEllipse2��$��0��$��2��$��0��$��3��$��Right=�8�� ���� $" MainRow��$# ActualHeight����� $" MainRow��$# ActualHeight��� $ BackgroundBorder��$��0��$��2��$��1��8�� � $��Stretch=�! �� $' AnimationWidth���� ���� $" MainRow��$# ActualHeight�.+��� $ AnimationSizeBorder��$��0���� $��0��8�� � $��Stretch=�! �� ���� $" MainRow��$# ActualHeight��� .+��� $��1��8�� � 
������ .+��� $
��Left=�$( 
Horizontal=�.+��� ���� $" AnimationSizeBorder��$# ActualWidth�A� $& ForegroundEllipse��$��Right=�8�� ���� $" MainRow��$# ActualHeight����� $" MainRow��$# ActualHeight� P�  �@d�	IsChecked$ FalseY�. ��� $ BackgroundBorder��8   � ���� $ ForegroundEllipse��8   � ���� $ AnimationSizeBorder�� � ��$ 0���� "
 ��.R��� $ Bd��#��z��
���   �#��z��$ 10��._��� $) PART_ContentHost�� P�  � {� .  . ��� # � ��$ Bd�� � ���� # � �� � ��P�  � ��$
 Auto��. ���  � ��$	 100��P�  � ��$
 Auto��. ���  � ��$ 20��.��� .+��� ���	#FFE6712E$��	0,0,0,405q�.+��� $��8���� -   * ��Name$* 	textBlock��$
��Wrap=�$��38��$��	0,0,303,0q�
�������$��20(�$��Comic Sans MS)��� $�  22Hours 활자인쇄소���� $� [ SERVER ]���� $
��Left=�$	��397��$	��Top=�$	��184��$��0,45,0,0q�.+��� $��74��.+��� -   $* userName��$��Right=�$
��Wrap=�$	��Top=�$	��184��$��SERVER.��+ �� TextAlignment$+ Center=��� -   $* serverStatus��$
��Left=�$
��Wrap=�$��Bottom=�$��26��$	��184��$+ Center=����� *server+�� $��29��$( 
Horizontal=�.+��� -   $��
SERVER RUN�����	#FFBBBDBA��Z� �� -   $��SERVER STOP�����	#FFBBBDBA��Z� �� $	��322��.+��� $��24��.+��� -   $* 
textBlock1��$
��Wrap=�$��CONNECTION LIST��$��24��$+ Center=����	#FFE6712E
��������� $	��297��.+��� -   , ��Name$, CList��$	��212��$- �� IsSynchronizedWithCurrentItem$
- TrueY����� ���� .R�� .+��� $
��Bold"����� *id+�� $��: ��$
��Bold"��� $
��auto��$
��Wrap=�$��Stretch=����� *handle+�� . ��Name$. button1��-   $
��Kick��$��75���� $
��Left=�$	��397��$	��Top=�$	��608��$��
184,45,0,0q�.+��� -	   / ��Name$/ chatBox��$	��334��$( 
Horizontal=�.+��� $	��612��.+��� -
   $, 
RecieveBox��$	��330��$��
0,0,-304,0q���Z� ���� ���� .R�� .+��� $
��Bold"����� *user+�� $��: ��$
��Bold"��� $
��auto��$
��Wrap=�$��Stretch=����� *text+�� $	��304���� $��62��$( 
Horizontal=�.+��� $��61��$��0q�$	��532��$( 
Horizontal=�.+��� $��64��$��0,0,0,-3q�$��10���� $	��521��.+��� $��4���� $��50��.+��� -   0 ��Name$0 	inputText��#��[ $��50��1 �� TextWrapping$
1 Wrap=�$�� ��$
��Left=�$	��511��2 �� TextAlignment$2 Center=��� -   $. button_Copy2��$��>>��$
��Left=�$	��Top=�$��50��$��62�����	#FF3887C8$
��Bold"�$��24(�$��Impact)���Z� ��Z� �� -   $. button��$	��ㅡ��$
��Left=�$	��Top=�$��59��$��	606,4,0,0q�$��33��
���������Z� ��Z� �� -   $. button_Copy��$	��ㅁ��$
��Left=�$	��Top=�$��59��$��	665,4,0,0q�$��33��
���������Z� ��Z� �� -   $. closeButton��$��X��$
��Left=�$	��Top=�$��59��$��	724,4,0,0q�$��33��
���������Z� ��Z� 