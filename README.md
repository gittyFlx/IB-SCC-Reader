# Interactive Brokers Security Code Card Reader

What does it do? <br/>
&#160;&#160;During login to IB, it speeds up the tedious task of looking  <br/>
&#160;&#160;up the two numbers on the security code card and typing of  <br/>
&#160;&#160;the respective code combination. <br/>
How does it work? <br/>
&#160;&#160;Before first use, create text file "codes.txt" and (only once) enter all 224 codes. One per line, 224 lines. Only the codes, without the line numbers. <br/>
Like here: ____________ <br/>
&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;|T9G <br/>
&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;|NL7 <br/>
&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;|3QS <br/>
&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;|... <br/>
&#160;&#160;Put "codes.txt" in the same directory as this program's .exe file. <br/>
&#160;&#160;When during the login process prompted for the codes of the two <br/>
&#160;&#160;numbers displayed, start this little program and type in the 1st <br/>
&#160;&#160;number <enter> and the 2nd number <enter>. The program closes but the <br/>
&#160;&#160;resulting code is now in the clipboard. Paste it into the login field <br/>
&#160;&#160;with the keyboard combination Ctrl-v (paste) and continue login to IB. <br/>
