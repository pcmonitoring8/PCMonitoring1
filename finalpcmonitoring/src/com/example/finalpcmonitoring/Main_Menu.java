package com.example.finalpcmonitoring;

import android.annotation.SuppressLint;
import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.os.StrictMode;
import android.view.View;

public class Main_Menu extends Activity 
{
	public static String cmd="";
	

    @SuppressLint("NewApi")
	@Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main_menu);
        
        StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
	    StrictMode.setThreadPolicy(policy);
    }


   public void doDisplayMachineList(View v)
   {
	   
	  if(v.getId()==0x7f09000c)
		  cmd="Processlist";
	  
	   
	  if(v.getId()==0x7f090008)
		  cmd="Capturescreen";
	  
	  if(v.getId()==0x7f090003)
		  cmd="Shutdown";
	  
	  if(v.getId()==0x7f090001)
		  cmd="Restart";
	  
		   
	   Intent i =new Intent(getApplicationContext(),Machine.class);
	   startActivity(i);
   }
   public void doDisplayApplictionList(View v)
   {
	   if(v.getId()==0x7f090005)// from Gen-R.java
		   cmd="Start";
	   if(v.getId()==0x7f090004)// from Gen-R.java
		   cmd="Kill" ;
	   Intent i =new Intent(getApplicationContext(),Application.class);
	   startActivity(i);
   }
   
   public void doDisplayDiskSpace(View v)
   {
	   if(v.getId()==0x7f09000d)// from Gen-R.java
		   cmd="Diskspace";
	   Intent i =new Intent(getApplicationContext(),DiskSpace.class);
	   startActivity(i);
   }
   
   public void doDisplayFileShare(View v)
   {
	   if(v.getId()==0x7f090009)// from Gen-R.java
	   cmd="Fileshare";
	   Intent i =new Intent(getApplicationContext(),FileShare.class);
	   startActivity(i);
   }
   
   
}
