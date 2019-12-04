using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Media;
using Java.Lang;
using Android.Views;

namespace XamarinDiceRoller
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class XamarinDiceRoller : AppCompatActivity
    {
        private ImageView imageViewDice;
        private Random rng = new Random();
        MediaPlayer blee = new MediaPlayer();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            imageViewDice = FindViewById<ImageView>(Resource.Id.image_view_dice);
            imageViewDice.Click += (sender, e) => {
                RollDice(blee, rng, imageViewDice);
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        void RollDice(MediaPlayer blee, Random rng, ImageView imageViewDice)
        {
            if (blee.IsPlaying)
            {
                blee.Stop();
                blee.Release();
            }
            blee = MediaPlayer.Create(this, Resource.Raw.shake);
            blee.Start();

            int randomNumber = rng.Next(1, 20);

            switch (randomNumber)
            {
                case 1:
                    imageViewDice.SetImageResource(Resource.Drawable.dice1);
                    blee = MediaPlayer.Create(this, Resource.Raw.fail);
                    blee.Start();
                    break;
                case 2:
                    imageViewDice.SetImageResource(Resource.Drawable.dice2);
                    break;
                case 3:
                    imageViewDice.SetImageResource(Resource.Drawable.d3);
                    break;
                case 4:
                    imageViewDice.SetImageResource(Resource.Drawable.d4);
                    break;
                case 5:
                    imageViewDice.SetImageResource(Resource.Drawable.d5);
                    break;
                case 6:
                    imageViewDice.SetImageResource(Resource.Drawable.d6);
                    break;
                case 7:
                    imageViewDice.SetImageResource(Resource.Drawable.d7);
                    break;
                case 8:
                    imageViewDice.SetImageResource(Resource.Drawable.d8);
                    break;
                case 9:
                    imageViewDice.SetImageResource(Resource.Drawable.d9);
                    break;
                case 10:
                    imageViewDice.SetImageResource(Resource.Drawable.d10);
                    break;
                case 11:
                    imageViewDice.SetImageResource(Resource.Drawable.d11);
                    break;
                case 12:
                    imageViewDice.SetImageResource(Resource.Drawable.d12);
                    break;
                case 13:
                    imageViewDice.SetImageResource(Resource.Drawable.d13);
                    break;
                case 14:
                    imageViewDice.SetImageResource(Resource.Drawable.d14);
                    break;
                case 15:
                    imageViewDice.SetImageResource(Resource.Drawable.d15);
                    break;
                case 16:
                    imageViewDice.SetImageResource(Resource.Drawable.d16);
                    break;
                case 17:
                    imageViewDice.SetImageResource(Resource.Drawable.d17);
                    break;
                case 18:
                    imageViewDice.SetImageResource(Resource.Drawable.d18);
                    break;
                case 19:
                    imageViewDice.SetImageResource(Resource.Drawable.d19);
                    break;
                case 20:
                    imageViewDice.SetImageResource(Resource.Drawable.d20);
                    blee = MediaPlayer.Create(this, Resource.Raw.crit);
                    blee.Start();
                    break;
            }
        }
    }
}