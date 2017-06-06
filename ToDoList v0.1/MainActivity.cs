using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Content;
using System;
using ToDoList_v0._1.Helper;
using System.Collections.Generic;

namespace ToDoList_v0._1
{
    [Activity(Label = "ToDoList_v0._1", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/ThemeOverlay.AppCompat.Light")]
    public class MainActivity : AppCompatActivity
    {
        EditText taskEditText;
        DbHelper dbHelper;
        CustomAdapter adapter;
        ListView lstTask;

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_item, menu);
            return base.OnCreateOptionsMenu(menu);
        }

      
        }
    }


