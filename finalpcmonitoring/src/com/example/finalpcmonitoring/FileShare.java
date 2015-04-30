package com.example.finalpcmonitoring;

import android.app.Activity;
import android.os.Bundle;
import android.telephony.gsm.SmsManager;
import android.util.Log;
import android.view.View;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.Toast;

public class FileShare extends Activity
{
	@Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.fileshare);
    }
	public void doDisplayFileShare(View v)
	{
		EditText txtpathname,txtfilename,txtmailid;
		Spinner spinnermachinename;
		spinnermachinename=(Spinner)findViewById(R.id.spn1MachineList);
		txtpathname=(EditText)findViewById(R.id.txtfolder);
		txtfilename=(EditText)findViewById(R.id.txtfile);
		txtmailid=(EditText)findViewById(R.id.txtemail);

		Log.e("123",spinnermachinename.getSelectedItem().toString() );
		Log.e("123",Main_Menu.cmd );
		Log.e("123",txtpathname.getText().toString() );
		Log.e("123",txtfilename.getText().toString() );
		Log.e("123",txtmailid.getText().toString() );


		
		Main_Menu.cmd = Main_Menu.cmd+" "+txtmailid.getText() + " \\\\" +spinnermachinename.getSelectedItem().toString() + "\\" + txtpathname.getText().toString()+"\\"+txtfilename.getText();
		Toast.makeText(getApplicationContext(), Main_Menu.cmd, 3000).show();
		SmsManager sms=SmsManager.getDefault();
		sms.sendTextMessage("9762758135", null, Main_Menu.cmd, null, null);
		Log.e("123",Main_Menu.cmd);
		
	}
}


