using System;
/*.=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= -.
   /------------------------------ \
  |     By                                     |
  |     Jacob Merlin                   |
   \------------------------------ /
                 !           ! 
                !           !
                !          !
               ! _       !
         /   !__)     !
 __/___/_____)
        (_______)
 ___(______)
      \_(____)
         !       !
         !      !
         \__/
'-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-='*/

namespace logic_Sonic
{
	public class SonicLogic
	{
		public static int AddMethod(int snum_1, int snum_2)
        {
			return snum_1 + snum_2;
        }

		public static decimal AddMethod(decimal snum_3, decimal snum_4)
        {
			return (snum_3 + snum_4);
        }
		
		public static string AddMethod(int snum_5, int snum_6, bool IsPayCheck)
		{
			int num_Total = snum_5 + snum_6;

			if (IsPayCheck == true && num_Total > 1 || num_Total == 0)
			{
				return $"{num_Total} dollars";
			}
			else if (IsPayCheck == true && num_Total == 1)
			{
				return $" {num_Total} dollar";
			}
			else
            {
				return num_Total.ToString();
            }
		}
	}
}
