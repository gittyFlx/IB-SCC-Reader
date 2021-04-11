# Interactive Brokers Security Code Card Reader

What does it do? <br/>
    During login to IB, it speeds up the tedious task of looking up the two numbers on the security code card and typing of the respective code combination. <br/>
How does it work? <br/>
  Before first use, create text file "codes.txt" and (only once) enter <br/>
  all 224 codes. One per line, 224 lines. Only the codes, without the <br/>
  line numbers. Like here:    ____________ <br/>
                             |T9G <br/>
                             |NL7 <br/>
                             |3QS <br/>
                             |... <br/>
  Put "codes.txt" in the same directory as this program's .exe file. <br/>
  When during the login process prompted for the codes of the two <br/>
  numbers displayed, start this little program and type in the 1st <br/>
  number <enter> and the 2nd number <enter>. The program closes but the <br/>
  resulting code is now in the clipboard. Paste it into the login field <br/>
  with the keyboard combination Ctrl-v (paste) and continue login to IB. <br/>
