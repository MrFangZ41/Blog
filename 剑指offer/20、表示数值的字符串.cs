public class Solution
{
    public bool ValidNumber(string s)
    {
        int state=0;
        for(int i=0;i<s.Length;i++)
        {
            switch(s[i])
            {
                //输入正负号
                case '+':
                case '-':
                if(state==0)
                {
                    state=1;
                }
                else if(state==4)
                {
                    state=6;
                }
                else
                {
                    return false;
                }
                break;
                //输入数字
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                     switch(state)
                     {
                         case 0:
                         case 1:
                         case 2:
                             state=2;
                             break;
                         case 3:
                             state=3;
                             break;
                         case 4:
                         case 5:
                         case 6:
                             state=5;
                             break;
                         case 7:
                         case 8:
                             state=8;
                         default:
                             return false;
                     }
                     break;
                case '.':
                     switch(state)
                     {
                         case 0:
                         case 1:
                             state=7;
                             break;
                         case 2:
                             state=3;
                             break;
                         default:
                             return false;
                     }
                     break;
                case 'e':
                     switch(state)
                     {
                         case 2:
                         case 3:
                         case 8:
                             state=4;
                             break;
                         default:
                             return false;
                     }
                     break;
                default:
                     return false;
            }
        }

        return state==2||state==3||state==5||state==8;
    }
}