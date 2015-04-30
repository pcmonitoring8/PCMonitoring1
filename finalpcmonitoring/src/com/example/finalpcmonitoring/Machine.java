package com.example.finalpcmonitoring;

import android.annotation.SuppressLint;
import android.app.Activity;
import android.app.PendingIntent;
import android.content.Intent;
import android.os.Bundle;
import android.telephony.SmsManager;
import android.util.Log;
import android.view.View;
import android.widget.Spinner;
import android.widget.Toast;

@SuppressLint("UnlocalizedSms")
public class Machine extends Activity 
{

	@Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.machine);
    }
 	
	@SuppressLint("UnlocalizedSms")
	public void doDisplayMachineList(View v)
	{
		Spinner spinnermachinename,spinnerappame;
		String command = "";
		spinnerappame=(Spinner)findViewById(R.id.spnmachinelist2);
		
		command  = Main_Menu.cmd + " " +spinnerappame.getSelectedItem().toString() ;
		
		Log.e("123","ddddd===="+command);
		Toast.makeText(getApplicationContext(), command, 3000).show();
		
		
		String PhoneNo = "09762758135";
		try
		{
			SmsManager smsManager = SmsManager.getDefault();
			PendingIntent piSent=PendingIntent.getBroadcast(this, 0, new Intent("SMS_SENT"), 0);
	        PendingIntent piDelivered=PendingIntent.getBroadcast(this, 0, new Intent("SMS_DELIVERED"), 0);
	        Log.e("123", "SMS Manager  : " + smsManager.toString());
			smsManager.sendTextMessage(PhoneNo,null,command,piSent, piDelivered);
			Toast.makeText(getApplicationContext(), "Your sms has successfully sent!",Toast.LENGTH_LONG).show();
		}
		catch(Exception ex)
		{
			Toast.makeText(getApplicationContext(), "SMS sent faild !",Toast.LENGTH_LONG).show();
			Log.e("123", "Exception : " +ex.toString());
		}
		
		//sendSMS("8625916321",command);
		command="";
		
	}
 	
}

