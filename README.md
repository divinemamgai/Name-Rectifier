# Name-Rectifier
Bulk file name rectification with ease!

You can very easily manipulate the names of multiple files at once.
The program uses File Name Format, according to which all the files will be renamed, it can include following Expressions/Functions : 
[List is also available in the program itself.]

Mathematical Expressions ::

          ?N? : Current file/folder count/number.
          ?f(N)? : Evaluation of function f(N) comprised of variable N and other constants.

String Expressions ::

          |F| : File/Folder Name
          |F/M| : File/Folder name with first M characters removed.
          |F\M| : File/Folder name with last M characters removed.
          |F>String| : File/Folder name with "String" appended to it.
          |F<String| : File/Folder name with "String" prepended to it.
          |F:StringOne>StringTwo| : File/Folder name with "StringOne" replaced (case-sensitive) by "StringTwo".
          |F*W| : File/Folder name with every word's first letter converted to uppercase.
          |F*w| : File/Folder name with every word's first letter converted to lowercase.
          |F*Regex>String| : File/Folder name with matched values replaced by the string, based on regex.
                                          Eg.: |F*\((.*)\)>_| with F as "Yo(Yo)" : Yo_
          |F*Regex<String| : File/Folder name with matched group values replaced by the string, based on regex.
                                          Eg.: |F*\((.*)\)>_| with F as "Yo(Yo)" : Yo(_)

Default Variables ::

          N : Current file/folder number.
          F : Current file/folder name.
