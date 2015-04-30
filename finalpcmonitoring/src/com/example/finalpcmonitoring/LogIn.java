package com.example.finalpcmonitoring;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.Toast;

public class LogIn extends Activity 
{
	EditText lun,lpwd;
	
	@Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.login_activity);
    	lun=(EditText)findViewById(R.id.txtusername);
		lpwd=(EditText)findViewById(R.id.txtpassword);
	
    }
	
	
	public void dodisplaylogin(View v)
	{
		if(lun.getText().toString().equals("Admin")&&lpwd.getText().toString().equals("Admin"))
		{
			Intent i = new Intent(getApplicationContext(), Main_Menu.class);
			startActivity(i);
			finish();
		}
		else
		{
			Toast.makeText(getApplicationContext(),"login unsuucessful" , 500).show();
		}
		
	}
	public void doexit(View v)
	{

	System.exit(0);
	}
}
