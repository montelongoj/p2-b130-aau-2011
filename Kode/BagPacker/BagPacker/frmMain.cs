﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BagPacker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        public List<luggage_item> luggage_items = new List<luggage_item>();
        public List<luggage> luggages = new List<luggage>();
        

        private void btnOpenLug_Click(object sender, EventArgs e)
        {
            frmLug f = new frmLug();
            f.Show();
                  
        }

        public int avg_weight_per_lug (int numb_items, int numb_lug)
        {

            int weight_counter = 0;
            int count = 0;
            for (count = 0; count < numb_items; count++)
            {
                weight_counter += luggage_items[count].weight;
            }

            return weight_counter / numb_lug;
        }

        public void sort_lugagge_and_items()
        {
            luggages.Sort(delegate(luggage lug1, luggage lug2)
            {
                int lug1_volume = lug1.width * lug1.height * lug1.depth;
                int lug2_volume = lug2.width * lug2.height * lug2.depth;
                int returnValue = 0;
                if (lug1_volume < lug2_volume)
                {
                    returnValue = 1;
                }
                else if (lug1_volume == lug2_volume)
                {
                    returnValue = 0;
                }
                else
                {
                    returnValue = -1;
                }
                return returnValue;
            });

            luggage_items.Sort(delegate(luggage_item lug_item1, luggage_item lug_item2)
            {
                int lug_item1_volume = lug_item1.width * lug_item1.height * lug_item1.depth;
                int lug_item2_volume = lug_item2.width * lug_item2.height * lug_item2.depth;
                int returnValue = 0;
                if (lug_item1_volume < lug_item2_volume)
                {
                    returnValue = 1;
                }
                else if (lug_item1_volume == lug_item2_volume)
                {
                    returnValue = 0;
                }
                else
                {
                    returnValue = -1;
                }
                return returnValue;
            });
        }

        public void make_lug_and_item()
        {
            luggage_item tmp_lug_item;

            tmp_lug_item = new luggage_item();
            tmp_lug_item.name = "Kasse 1";
            tmp_lug_item.height = 30;
            tmp_lug_item.width = 90;
            tmp_lug_item.depth = 40;
            tmp_lug_item.weight = 3;
            tmp_lug_item.rotation = 0;
            luggage_items.Add(tmp_lug_item);

            tmp_lug_item = new luggage_item();
            tmp_lug_item.name = "Kasse 2";
            tmp_lug_item.height = 50;
            tmp_lug_item.width = 20;
            tmp_lug_item.depth = 30;
            tmp_lug_item.weight = 8;
            tmp_lug_item.rotation = 0;
            luggage_items.Add(tmp_lug_item);

            tmp_lug_item = new luggage_item();
            tmp_lug_item.name = "Kasse 3";
            tmp_lug_item.height = 80;
            tmp_lug_item.width = 70;
            tmp_lug_item.depth = 10;
            tmp_lug_item.weight = 4;
            tmp_lug_item.rotation = 0;
            luggage_items.Add(tmp_lug_item);

            luggage tmp_lug = new luggage();

            tmp_lug = new luggage();
            tmp_lug.name = "Kuffert 1";
            tmp_lug.height = 100;
            tmp_lug.depth = 150;
            tmp_lug.width = 50;
            tmp_lug.max_weight = 23;
            luggages.Add(tmp_lug);

            tmp_lug = new luggage();
            tmp_lug = new luggage();
            tmp_lug.name = "Kuffert 2";
            tmp_lug.height = 80;
            tmp_lug.depth = 90;
            tmp_lug.width = 80;
            tmp_lug.max_weight = 23;
            luggages.Add(tmp_lug);
        }

        public class luggage_item
        {
            public string name;
            public int height;
            public int depth;
            public int width;
            public int weight;
            public int rotation;
        }

        public class luggage
        {
            public string name;
            public int height;
            public int depth;
            public int width;
            public int max_weight;
            public int weight = 0;
            public int[, ,] value = new int[99, 99, 99];
        }

        private void bntStartPacking_Click(object sender, EventArgs e)
        {

            make_lug_and_item();
            sort_lugagge_and_items();

            int numb_items = luggage_items.Count;
            int numb_lug = luggages.Count;
            int weight_per_luggage = 0;

            weight_per_luggage = avg_weight_per_lug(numb_items, numb_lug);

            List<luggage_item> luggage_items_not_packed = new List<luggage_item>(luggage_items);
            List<luggage_item> luggage_items_to_pack = new List<luggage_item>();
            luggage_items_not_packed.RemoveAt(0);
            while (luggage_items_not_packed.Count != 0)
            {
                
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        
    }
}
