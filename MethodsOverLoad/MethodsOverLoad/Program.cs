namespace OverLoad
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

{
    public class Program
    {
        static void Main(string[] args)
        {
            var snum_1 = 4;
            var snum_2 = 2;
            logic_Sonic.SonicLogic.AddMethod(snum_1, snum_2);
            var totalAdd = logic_Sonic.SonicLogic.AddMethod(snum_1, snum_2);
            Console.WriteLine(totalAdd);

            var snum_3 = 4.2m;
            var snum_4 = 2.6m;
            logic_Sonic.SonicLogic.AddMethod(snum_3, snum_4);
            var totalAddFloat = logic_Sonic.SonicLogic.AddMethod(snum_3, snum_4);
            Console.WriteLine(totalAddFloat);

            var snum_5 = 42;
            var snum_6 = 52;
            var IsPayCheck = true;
            logic_Sonic.SonicLogic.AddMethod(snum_5, snum_6, IsPayCheck);
            var total = logic_Sonic.SonicLogic.AddMethod(snum_5, snum_6, IsPayCheck);
            Console.WriteLine(total);
        }
    }
}