   M S B A M L   `   `   `  ????A  =Labb-3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Labb_3Labb_3  5   	       Labb_3.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Labb_3     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ? ??5   
   ?? 5       ?? ImageSource$ /img/dining_mobile.jpg??6    j? Stretch$
 Fill=?6>    ? ColumnDefinitions 5   
   ?? 5      $??20 ?6   ?? 5      $??0 ?6   ?? 5      $
??auto ?6   ?? 5      $??20 ?6   ?? 5      $
??auto ?6   ?? 5      $??20 ?6   ?? 5      $
??auto ?6   ?? 5      $??20 ?6   ?? 5      $
??auto ?6   ?? 5      $??20 ?6   ?? 5      $
??auto ?6   ?? 5      $??* ?6   ?? 5      $??20 ?6    ? RowDefinitions 5   
   ?? 5      $??20 ?6   ?? 5       $??0 ?6   ?? 5!      $
??auto ?6   ?? 5"      $??5 ?6   ?? 5#      $
??auto ?6   ?? 5$      $??5 ?6   ?? 5%      $
??auto ?6   ?? 5&      $??5 ?6   ?? 5'      $
??auto ?6   ?? 5(      $??40 ?6   ?? 5)      $
??auto ?6   ?? 5*      $??15 ?6   ?? 5+      $
??auto ?6   ?? 5,      $??15 ?6   ?? 5-      $
??auto ?6   ?? 5.      $??* ?6   ?? 5/      $??20 ?6   .+?5:   
   ?? -   5         ??Name$ lstboxListBookings??5=      $??2??5<      $??2??6   $??10??6*   $	??200??5=   )   $
??auto??68   .@?5>      ?? 6   5@      ?? 5D   
   $??4??5E      $??2??6   $??0q?6*   $??Datum??5F      $
??Bold"?6   
???????5G      (  "System.Windows.Controls.DatePicker  5I   
   -   5          Name$ dtpSelecter??5K      $??4??5J      $??4??6   $??0q?6*   5M      ?? 5O   
   $??4??5P      $??6??6   $??0q?6*   $	??Tid??5Q      $
??Bold"?6   
???????5R      ?? 5T   
   -   5         ??Name$ ComboBoxTime??5U      $??4??5V      $??8??6   $??0q?6*   .@?5W      ?? .??6   17:006"   ?? 5X      .??6   17:156"   ?? 5Y      .??6   17:306"   ?? 5Z      .??6   17:456"   ?? 5[      .??6   18:006"   ?? 5\      .??6   18:156"   ?? 5]      .??6   18:306"   ?? 5^      .??6   18:456"   ?? 5_      .??6   19:006"   ?? 5`      .??6   19:156"   ?? 5a      .??6   19:306"   ?? 5b      .??6   19:456"   ?? 5c      .??6   20:006"   ?? 5d      .??6   20:156"   ?? 5e      .??6   20:306"   ?? 5f      .??6   20:456"   ?? 5g      .??6   21:006"   5h      ?? 5m      -   5         ??Name$ btnbook??5n      $
??Boka??6"   $??4??5o      $??10??6!   $??0q?6/   $??30??5p      5r      ?? 5u      -   5        $ btnShowBookings??5v      $??Visa Bokningar??6*   $??4??5w      $??12??6!   $??0q?6/   $??30??5x      5z      ?? 5}      -   5        $ btnCancelBooking??5~      $??Avboka??6+   $??4??5      $??14??6!   $??0q?6/   $??30??5?      5?      ?? 5?   
   $??6??5?      $??2??6   $??0q?6*   $
??Namn??5?      
???????$
??Bold"?6,   5?      ?? 5?   
   -   5        	 ??Name$	 txtCustommerName??5?      $??6??5?      $??4??6"   $??0q?6/   5?      ?? 5?   
   $??6??5?      $??6??6   $??0q?6*   $??Bordsnummer??5?      
???????$
??Bold"?63   5?      ?? 5?   
   -   5        $ ComboBoxTablenumber??5?      $??6??5?      $??8??6   $??0q?6*   .@?5?      ?? .??6   16   ?? 5?      .??6   26   ?? 5?      .??6   36   ?? 5?      .??6   46   ?? 5?      .??6   56   5?      5?      5?      