﻿using System;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace AndroidIntroduction
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        private Button _buttonChangeName;
        private TextView _labelChangedName;
        private EditText _editTextForName;
        private Button _navigateSecondActivity;
        private Button _buttonListSample;
        private Button _buttonUseCamera;
        private Button _buttonPermissions;
        private Button _buttonSettings;
        private Button _buttonFiles;
        private Button _buttonBBDD;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.content_main);

            AddBindForLayout();                        
        }

        private void AddBindForLayout()
        {
            _buttonChangeName = FindViewById<Button>(Resource.Id.buttonChangeName);
            _labelChangedName = FindViewById<TextView>(Resource.Id.labelForName);
            _editTextForName = FindViewById<EditText>(Resource.Id.editTextName);
            _navigateSecondActivity = FindViewById<Button>(Resource.Id.buttonNavigateSecondActivity);
            _buttonListSample = FindViewById<Button>(Resource.Id.buttonNavigateListSample);
            _buttonUseCamera = FindViewById<Button>(Resource.Id.buttonUseCamera);            
            _buttonSettings = FindViewById<Button>(Resource.Id.buttonSettings);
            _buttonFiles = FindViewById<Button>(Resource.Id.buttonFiles);
            _buttonBBDD = FindViewById<Button>(Resource.Id.buttonBBDD);

            _buttonChangeName.Click += ChangeNameClick;
            _navigateSecondActivity.Click += NavigateSecondActivityClick;
            _buttonListSample.Click += NavigateListSample;
            _buttonUseCamera.Click += UseCamera;
            _buttonSettings.Click += NavigateSettings;
            _buttonFiles.Click += NavigateFiles;
            _buttonBBDD.Click += NavigateBBDD;
        }
        
        private void NavigateSecondActivityClick(object sender, EventArgs e)
        {
            Intent navigateIntent = new Intent(this, typeof(SecondActivity));
            StartActivity(navigateIntent);
        }

        private void NavigateListSample(object sender, EventArgs e)
        {
            Intent navigateIntent = new Intent(this, typeof(ListSampleActivity));
            StartActivity(navigateIntent);
        }

        private void ChangeNameClick(object sender, EventArgs e)
            => _editTextForName.Text = _labelChangedName.Text;

        private void UseCamera(object sender, EventArgs e)
        {
            Intent navigateIntent = new Intent(this, typeof(CameraActivity));
            StartActivity(navigateIntent);
        }
        
        private void NavigateSettings(object sender, EventArgs e)
        {
            Intent navigateIntent = new Intent(this, typeof(SettingsActivity));
            StartActivity(navigateIntent);
        }

        private void NavigateFiles(object sender, EventArgs e)
        {
            Intent navigateIntent = new Intent(this, typeof(FilesActivity));
            StartActivity(navigateIntent);
        }

        private void NavigateBBDD(object sender, EventArgs e)
        {
            Intent navigateIntent = new Intent(this, typeof(BBDDActivity));
            StartActivity(navigateIntent);
        }

    }
}

