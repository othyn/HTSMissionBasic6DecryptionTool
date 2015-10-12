using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTSMissionBasic6DecryptionTool
{
    class Program
    {
        static void Main(string[] args)
        {
			// Encryption method is to add on the characters position in the string at a zero based starting point to the value of the character in said position.
			// E.g. 12345 becomes 13579, abcde becomes acegi resulting in [valueOfCurrentChar + charIndexInString = newValue]
			// Imagine the following iterating through each character in the given string:
			//	In the case of integers, it's straight forward:
			//	1 + 0 = 1
			//	2 + 1 = 3
			//	3 + 2 = 5
			//	etc...
			//	In the case of characters (including special chars), this can simply be mapped against the characters decimal ASCII value
			//	a (97) + 0 = a (97)
			//	b (98) + 1 = c (99)
			//	c (99) + 2 = e (101)
			//	etc...

			// So, to reverse that!

			// Bare in mind this application is not designed with boundard testing in mind, so things could go wrong, especially when passing long strings!

			Console.Write( "\nDecrypted string: " );

			if ( args.Length == 0 ){
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write( "Nothing to decrypt.\n" );
				Console.ResetColor();
				return;
			}
			// It's good to have user feedback and not just break in a horrible mess
			
			string stringToEncrypt = args[0];
			// Store the passed encryption string in something more readable/appropriate

			string decryptedString = "";
			// For storing our freshly decrypted string into during the loop below

			char newChar;
			// For storing the new calculated char value in during the loop below

			int currentCharIndex = 0;
			// For storing the current iteration index of the string in the loop below
			//	Used as the modifier for the currentChar value

			foreach ( char currentChar in stringToEncrypt ) {

				// Iterates through each character in the string
				
				newChar = (char)( currentChar - currentCharIndex );
				// Forcing the char type casts the calculated decimal output from adding the currentCharIndex to the currentChar back into a character value

				decryptedString += newChar;
				// Let's slowly build up the new string from the calculated result

				++currentCharIndex;
				// Iterate to match the next character in the string
			}

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write( decryptedString + "\n" );
			// Ouput the decrypted string

			Console.ResetColor();
        }
    }
}
