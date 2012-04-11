using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_af_color_2
{
    public class Color_list
    {
        
    }
    public class Box
    {
        public int point_x;
        public int point_y;
        public int point_z;

        public int X_length;
        public int Y_length;
        public int Z_length;
        public List<int> neighbor = new List<int>();
        public int color;


    }
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            
            int k, j, i, x, y, z, Number, Genstand=1, mængde;
            int count;
            int Boxcolor, neighborcolor;
            List<Box> BoxList = new List<Box>();
            List<int>[, ,] Kasse = new List<int>[200, 200, 200];
            Box temp = new Box();

            temp.point_x = 0;
            temp.point_y = 0;
            temp.point_z = 0;

            temp.X_length = 10;
            temp.Y_length = 10;
            temp.Z_length = 10;

            BoxList.Add(temp);

            temp.point_x = 10;
            temp.point_y = 0;
            temp.point_z = 0;

            temp.X_length = 10;
            temp.Y_length = 10;
            temp.Z_length = 10;
            BoxList.Add(temp);

            Number = BoxList.Count-1;

            for(i=0; i<= Number; i++)
            {
                for (x = (BoxList[i].point_x - 1 - Genstand); x <= (BoxList[i].point_x + BoxList[i].X_length + Genstand); x++)
                {
                    for (y = (BoxList[i].point_y - Genstand); y <= (BoxList[i].point_y + BoxList[i].Y_length + Genstand); y++)
                    {
                        for (z = (BoxList[i].point_z - Genstand); z <= (BoxList[i].point_z + BoxList[i].Z_length + Genstand); y++)
                        {
                            Kasse[x, y, z].Add(i);
                        }
                    }
                }
            }
            for (i = 0; i <= Number; i++)
            {
                for (x = (BoxList[i].point_x - 1 - Genstand); x <= (BoxList[i].point_x + BoxList[i].X_length + Genstand); x++)
                {
                    for (y = (BoxList[i].point_y - Genstand); y <= (BoxList[i].point_y + BoxList[i].Y_length + Genstand); y++)
                    {
                        for (z = (BoxList[i].point_z - Genstand); z <= (BoxList[i].point_z + BoxList[i].Z_length + Genstand); y++)
                        {
                            if(Kasse[x,y,z].Count < 1)
                            {
                                mængde = Kasse[x, y, z].Count;
                                for (j = 0; j <= mængde; j++ )
                                {
                                    BoxList[i].neighbor.AddRange(Kasse[x, y, z]);
                                }
                            }
                        }
                    }
                }
            }
            for(i = 0 ; i <= Number; i++)
            {
                k = 0;
                BoxList[i].neighbor.Sort();
                count = BoxList[i].neighbor.Count;
                while (k < count)
                {
                    
                    if(BoxList[i].neighbor[k] == i)
                    {
                        BoxList[i].neighbor.RemoveAt(k);
                    }
                    if(BoxList[i].neighbor[k] == BoxList[i].neighbor[k + 1])
                        BoxList[i].neighbor.RemoveAt(k);
                    else
                        k++;
                }
            }
            for(i = 0 ; i <= Number; i++)
            {
                Boxcolor = 1;
                j = 0;
                while (j <= (BoxList[i].neighbor.Count)-1)
                {
                    x = BoxList[i].neighbor[j];
                    neighborcolor = BoxList[x].color;
                    
                    if(Boxcolor == neighborcolor)
                    {
                        Boxcolor++;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
                BoxList[i].color = Boxcolor;
                  
                    // i = boksen
                    // j = neighbor nummer i listen
                    // k =
                    // temp = boksen color

                    // kigger på boksen color

                    // kigger på neighbor boksens color
                   
                }
            }
        }
}
