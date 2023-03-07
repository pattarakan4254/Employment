using Employment.Interface;
using Employment.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace Employment.Views
{
    public class RoomPage : ContentPage
    {
        private Button _button;
        private Entry room_name;

        public RoomPage()
        {
            this.Title = "Room Page";

            StackLayout stackLayout = new StackLayout();

            room_name = new Entry();
            room_name.Keyboard = Keyboard.Text;
            stackLayout.Children.Add(room_name);

            _button = new Button();
            _button.Text = "Go";
            _button.Clicked += _button_Clicked;
            stackLayout.Children.Add(_button);

            Content = stackLayout;
        }

        private void _button_Clicked(object sender, EventArgs e)
        {
            getRoom();
        }

        private async void getRoom()
        {
            try
            {
                IGitHubApi gitHubApi;
                gitHubApi = RestService.For<IGitHubApi>("http://172.29.70.130:9800/v1/employment-testing");
                ApiResponse response = await gitHubApi.GetUser();
                var result = response.data[0].room_name;

                //ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, user_names);
                room_name = new Entry();
                room_name.Text = result.ToString();
            }
            catch (Exception ex)
            {
                //Toast.MakeText(this, ex.StackTrace, ToastLength.Long).Show();

            }
        }
    }
}