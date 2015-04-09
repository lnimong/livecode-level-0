using System;
using SharedCode;
using Android.App;
using Android.Content;

namespace Android
{
	public class AndroidPhoneDialer : IPhoneDialer
	{
		private Activity mainActivity;

		public AndroidPhoneDialer(Activity mainActivity)
		{
			this.mainActivity = mainActivity;
		}

		public void Call(string name, string number)
		{
			Intent callIntent = new Intent(Intent.ActionCall);
			callIntent.SetData(Net.Uri.Parse("tel:" + number));
			mainActivity.StartActivity(callIntent);
		}
	}
}

