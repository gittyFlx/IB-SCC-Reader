# IB-SCC-Reader
Interactive Brokers Security Code Card Reader

What does it do?
  During login to IB, it speeds up the tedious task of looking up the
  two numbers on the security code card and typing of the respective
  code combination.
How does it work?
  Before first use, create text file "codes.txt" and (only once) enter
  all 224 codes. One per line, 224 lines. Only the codes, without the
  line numbers. Like here:    ____________
                             |T9G
                             |NL7
                             |3QS
                             |...
  Put "codes.txt" in the same directory as this program's .exe file.
  When during the login process prompted for the codes of the two
  numbers displayed, start this little program and type in the 1st
  number <enter> and the 2nd number <enter>. The program closes but the
  resulting code is now in the clipboard. Paste it into the login field
  with the keyboard combination Ctrl-v (paste) and continue login to IB.
