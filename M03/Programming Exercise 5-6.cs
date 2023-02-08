using static System.Console;
class DisplayMultiplicationTable
{
   static void Main()
   {
     // Write your main here.
     for (int i = 0; i < 11; ++i)
      {
        for (int h = 0; h < 11; ++h)
          { 
            if (i == 0 && h == 0) 
              Write(" {0,3} "," ");
              else if (i == 0 && h != 0)
              Write(" {0,3} ", h);
              else
              {
                if (h == 0)
                Write(" {0,3} ", i);
                  else
                  Write(" {0,3} ", i * h);
              }}
              WriteLine("");
      }
   }
}
