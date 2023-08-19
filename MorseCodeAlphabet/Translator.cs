namespace MorseCodeAlphabet
{
    public static class Translator
    {
        public static bool TryTranslateToMorseCode(char @char, out byte @byte)
        {
             @byte = 0x00;

             switch (@char)
             {
                 case 'A':
                 case 'a':
                     @byte = 0x31;
                     break;
                 case 'B':
                 case 'b':
                     @byte = 0xFE;
                     break;
                 case 'C':
                 case 'c':
                     @byte = 0xFA;
                     break;
                 case 'D':
                 case 'd':
                     @byte = 0x76;
                     break;
                 case 'E':
                 case 'e':
                     @byte = 0x11;
                     break;
                 case 'F':
                 case 'f':
                     @byte = 0xFB;
                     break;
                 case 'G':
                 case 'g':
                     @byte = 0x74;
                     break;
                 case 'H':
                 case 'h':
                     @byte = 0xFF;
                     break;
                 case 'I':
                 case 'i':
                     @byte = 0x33;
                     break;
                 case 'J':
                 case 'j':
                     @byte = 0xF1;
                     break;
                 case 'K':
                 case 'k':
                     @byte = 0x72;
                     break;
                 case 'L':
                 case 'l':
                     @byte = 0xFD;
                     break;
                 case 'M':
                 case 'm':
                     @byte = 0x30;
                     break;
                 case 'N':
                 case 'n':
                     @byte = 0x32;
                     break;
                 case 'O':
                 case 'o':
                     @byte = 0x70;
                     break;
                 case 'P':
                 case 'p':
                     @byte = 0xF9;
                     break;
                 case 'Q':
                 case 'q':
                     @byte = 0xF4;
                     break;
                 case 'R':
                 case 'r':
                     @byte = 0x75;
                     break;
                 case 'S':
                 case 's':
                     @byte = 0x77;
                     break;
                 case 'T':
                 case 't':
                     @byte = 0x10;
                     break;
                 case 'U':
                 case 'u':
                     @byte = 0x73;
                     break;
                 case 'V':
                 case 'v':
                     @byte = 0xF7;
                     break;
                 case 'W':
                 case 'w':
                     @byte = 0x71;
                     break;
                 case 'X':
                 case 'x':
                     @byte = 0xF6;
                     break;
                 case 'Y':
                 case 'y':
                     @byte = 0xF2;
                     break;
                 case 'Z':
                 case 'z':
                     @byte = 0xFC;
                     break;
                 default:
                     return false;
             }

             return true;
        }

        public static bool TryTranslateFromMorse(byte @byte, out char @char)
        {
            @char = ' ';

            switch (@byte)
            {
                case 0x31:
                    @char = 'A';
                    break;
                case 0xFE:
                    @char = 'B';
                    break;
                case 0xFA:
                    @char = 'C';
                    break;
                case 0x76:
                    @char = 'D';
                    break;
                case 0x11:
                    @char = 'E';
                    break;
                case 0xFB:
                    @char = 'F';
                    break;
                case 0x74:
                    @char = 'G';
                    break;
                case 0xFF:
                    @char = 'H';
                    break;
                case 0x33:
                    @char = 'I';
                    break;
                case 0xF1:
                    @char = 'J';
                    break;
                case 0x72:
                    @char = 'K';
                    break;
                case 0xFD:
                    @char = 'L';
                    break;
                case 0x30:
                    @char = 'M';
                    break;
                case 0x32:
                    @char = 'N';
                    break;
                case 0x70:
                    @char = 'O';
                    break;
                case 0xF9:
                    @char = 'P';
                    break;
                case 0xF4:
                    @char = 'Q';
                    break;
                case 0x75:
                    @char = 'R';
                    break;
                case 0x77:
                    @char = 'S';
                    break;
                case 0x10:
                    @char = 'T';
                    break;
                case 0x73:
                    @char = 'U';
                    break;
                case 0xF7:
                    @char = 'V';
                    break;
                case 0x71:
                    @char = 'W';
                    break;
                case 0xF6:
                    @char = 'X';
                    break;
                case 0xF2:
                    @char = 'Y';
                    break;
                case 0xFC:
                    @char = 'Z';
                    break;
                default:
                    return false;
            }

            return true;
        }
    }
}
