package com.example.finalpcmonitoring;

import android.app.Activity;
import android.os.Bundle;
import android.telephony.gsm.SmsManager;
import android.util.Log;
import android.view.View;
import android.widget.Spinner;
import android.widget.Toast;

public class DiskSpace extends Activity
{
	@Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.diskspace);
        
    }
	public void doDisplayDiskSpace(View v)
	{
		Spinner spinnermachinename,spinnerappname;
		spinnerappname=(Spinner)findViewById(R.id.spnDrive);
		spinnermachinename=(Spinner)findViewById(R.id.spnMachineList1);
		Log.e("123",spinnerappname.getSelectedItem().toString() );
		Log.e("123",Main_Menu.cmd );
		Log.e("123",spinnermachinename.getSelectedItem().toString() );
		
		Main_Menu.cmd = Main_Menu.cmd + " " + spinnerappname.getSelectedItem().toString() + " " + spinnermachinename.getSelectedItem().toString();
		Toast.makeText(getApplicationContext(), Main_Menu.cmd, 3000).show();
		SmsManager sms=SmsManager.getDefault();
		sms.sendTextMessage("9762758135", null, Main_Menu.cmd, null, null);
		
	}

}
