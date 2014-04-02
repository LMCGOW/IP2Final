using UnityEngine;
using System.Collections;

public class MG_ShowSprayRemaining : MonoBehaviour {

    public Texture[] sprayGauge = new Texture[16];
    public Texture sprayRemainingString;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

       

	}

    void OnGUI()
    {

        GUI.DrawTexture(new Rect(5, 20, 151, 25), sprayRemainingString);

        if (MG_ControlSpray.sprayRemaining <= 100 && MG_ControlSpray.sprayRemaining > 93.75f)
        {
            GUI.DrawTexture(new Rect(160, 15, 117, 30), sprayGauge[0]);
        }
        else if(MG_ControlSpray.sprayRemaining <= 93.75 && MG_ControlSpray.sprayRemaining > 87.5)
        {
            GUI.DrawTexture(new Rect(160, 12.5f, 117, 30), sprayGauge[1]);
        }
        else if (MG_ControlSpray.sprayRemaining <= 87.5 && MG_ControlSpray.sprayRemaining > 81.25)
        {
            GUI.DrawTexture(new Rect(160, 12.5f, 117, 30), sprayGauge[2]);
        }
        else if (MG_ControlSpray.sprayRemaining <= 81.25 && MG_ControlSpray.sprayRemaining > 75)
        {
            GUI.DrawTexture(new Rect(160, 12.5f, 117, 30), sprayGauge[3]);
        }
        else if (MG_ControlSpray.sprayRemaining <= 75 && MG_ControlSpray.sprayRemaining > 68.75)
        {
            GUI.DrawTexture(new Rect(160, 12.5f, 117, 30), sprayGauge[4]);
        }
        else if (MG_ControlSpray.sprayRemaining <= 68.75 && MG_ControlSpray.sprayRemaining > 62.5)
        {
            GUI.DrawTexture(new Rect(160, 12.5f, 117, 30), sprayGauge[5]);
        }
        else if (MG_ControlSpray.sprayRemaining <= 62.5 && MG_ControlSpray.sprayRemaining > 56.25)
        {
            GUI.DrawTexture(new Rect(160, 12.5f, 117, 30), sprayGauge[6]);
        }
        else if (MG_ControlSpray.sprayRemaining <= 56.25 && MG_ControlSpray.sprayRemaining > 50)
        {
            GUI.DrawTexture(new Rect(160, 12.5f, 117, 30), sprayGauge[7]);
        }
        else if (MG_ControlSpray.sprayRemaining <= 50 && MG_ControlSpray.sprayRemaining > 43.75)
        {
            GUI.DrawTexture(new Rect(160, 12.5f, 117, 30), sprayGauge[8]);
        }
        else if (MG_ControlSpray.sprayRemaining <= 43.75 && MG_ControlSpray.sprayRemaining > 37.5)
        {
            GUI.DrawTexture(new Rect(160, 12.5f, 117, 30), sprayGauge[9]);
        }
        else if (MG_ControlSpray.sprayRemaining <= 37.5 && MG_ControlSpray.sprayRemaining > 31.25)
        {
            GUI.DrawTexture(new Rect(160, 12.5f, 117, 30), sprayGauge[10]);
        }
        else if (MG_ControlSpray.sprayRemaining <= 31.25 && MG_ControlSpray.sprayRemaining > 25)
        {
            GUI.DrawTexture(new Rect(160, 12.5f, 117, 30), sprayGauge[11]);
        }
        else if (MG_ControlSpray.sprayRemaining <= 25 && MG_ControlSpray.sprayRemaining > 18.75)
        {
            GUI.DrawTexture(new Rect(160, 12.5f, 117, 30), sprayGauge[12]);
        }
        else if (MG_ControlSpray.sprayRemaining <= 18.75 && MG_ControlSpray.sprayRemaining > 12)
        {
            GUI.DrawTexture(new Rect(160, 12.5f, 117, 30), sprayGauge[13]);
        }
        else if (MG_ControlSpray.sprayRemaining <= 12 && MG_ControlSpray.sprayRemaining > 0)
        {
            GUI.DrawTexture(new Rect(160, 12.5f, 117, 30), sprayGauge[14]);
        }
        else if (MG_ControlSpray.sprayRemaining == 0)
        {
            GUI.DrawTexture(new Rect(160, 12.5f, 117, 30), sprayGauge[15]);
        }

    }
}
