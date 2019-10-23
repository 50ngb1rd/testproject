package com.example.march.intents;

import android.app.SearchManager;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class BrowseActivity extends AppCompatActivity {
    public static final int WEB_SEARCH_REQUEST =1 ;
    EditText editText;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_browse);
        Intent intent = getIntent();
        String message = intent.getStringExtra(MainActivity.EXTRA_MESSAGE);
        TextView textView = findViewById(R.id.textView2);
        textView.setText("Hi "+ message+ "! Let us start!");
        Button goButton = findViewById(R.id.goButton);
        goButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent3 = new Intent(Intent.ACTION_WEB_SEARCH);
                editText  = findViewById(R.id.editText2);
                String query = editText.getText().toString();
                intent3.putExtra(SearchManager.QUERY,query);
                if (intent3.resolveActivity(getPackageManager())!= null){
                    startActivityForResult(intent3, WEB_SEARCH_REQUEST);
                }
            }
        });

    }
    protected void onActivityResult(int requestCode, int resultCode, Intent intent){
    if(requestCode == WEB_SEARCH_REQUEST){
        editText.setText("Did you not find what you're looking for?");
    }
    }
}
