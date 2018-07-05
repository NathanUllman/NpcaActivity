/*********************************************************************************/
/**************************** Tools Reference ************************************/
/*********************************************************************************/
/*
    wordToEncrypt = wordToEncrypt.Replace("oldCharacters", "newCharacters"); 
        -  Replaces all occurances of 'oldCharacters' with 'newCharacters' in wordToEncrypt.

    wordToEncrypt = wordToEncrypt.Insert(locationNumber, "newCharacters" );
        -  Inserts newCharacters into the slot specifed by locationNumber in wordToEncrypt.

    wordToEncrypt = wordToEncrypt.ToLower();
        - Changes all characters to lower case in wordToEncypt.

     wordToEncrypt = ReverseAllLetters(wordToEncrypt);
        - Reverses all characters in wordToEncypt.

    SwitchFirstAndLastLetter(wordToEncrypt);
        - switches the spot of the first and last characters in wordToEncypt.


*/
/*********************************************************************************/
/**************************** Examples *******************************************/
/*********************************************************************************/
/*
Example 1:
                 wordToEncrypt = "Nebraska"
                 wordToEncrypt = wordToEncrypt.Replace("a", "z");
                 ** wordToEncrypt is now "Nzbrzaskz" **


Example 2:
                wordToEncrypt = "Something Fancy";
                wordToEncrypt = wordToEncrypt.Replace("i", "wow");
                ** wordToEncrypt is now "Somethwowg Fancy" **

Example 3:
                wordToEncrypt = "Husker";
                wordToEncrypt = wordToEncrypt.Replace("us","a");
                ** wordToEncrypt is now "Hasker";

Example 4:
                wordToEncrypt = "Remove it";
                wordToEncrypt = wordToEncrypt.Replace("e", ""); 
                ** wordToEncrypt is now "Rmov it" **

Example 5: 
                wordToEncrypt = "Add Something";
                wordToEncrypt = wordToEncrypt.Insert(0, "y" );
                ** wordToEncrypt is now "yAdd Something" **
                
Example 6:                 
                wordToEncrypt = "Another";
                wordToEncrypt = wordToEncrypt.Insert(1, "@");
                ** wordToEncrypt is now "A@nother" **

Example 6:
                wordToEncrypt = "Add End";
                wordToEncrypt = wordToEncrypt.Insert(7, "$%");
                ** wordToEncrypt is now "Add End$%" **

Example 7:
                wordToEncrypt = "Make sure to count the spaces also";
                wordToEncypt = wordToEncrypt.Insert(5, "top");
                ** wordToEncrypt is now "Make topsure to count the spaces also"

Example 8: 
                wordToEncrypt = "SUper CoOOl StUUF wOW";
                wordToEncrypt = wordToEncrypt.ToLower();
                ** wordToEncrypt is now "super coool stuuf wow"

Example 9: 
                
                wordToEncrypt = "Reverse";
                wordToEncrypt = ReverseAllLetters(wordToEncrypt);
                ** wordToEncrypt is now "esreveR"

Example 10:
                wordToEncrypt = "a";
                wordToEncrypt = ReverseAllLetters(wordToEncrypt);
                ** wordToEncrypt is now "a"


Example 11:
                wordToEncrypt = "Fancy";
                wordToEncrypt = SwitchFirstAndLastLetter(wordToEncrypt);
                ** wordToEncrypt is now "yancF"

Example 12:
                wordToEncrypt = "multiSteps";
                wordToEncypt = wordToEncypt.Insert(0, "$");
                wordtoEncypt = switchFirstAndLastLetter(wordToEncypt);
                ** wordToEncrypt is now smultiStep$ **

Example 13:
                wordToEncrypt = "";
*/