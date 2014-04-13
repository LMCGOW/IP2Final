using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{
	//Lee's Timer
	/* GameObject colonImage;

    float animationHTimer = 60f;
    int currentHFrame = 4;
    bool destroyHPrevious = false;
    GameObject initialHImage;
    int minFrame = 0;

    float animationTTimer = 10f;
    int currentTFrame = 5;
    bool destroyTPrevious = false;
    GameObject initialTImage;

    float animationUTimer = 1f;
    int currentUFrame = 10;
    bool destroyUPrevious = false;
    GameObject initialUImage;

    public GameObject[] timerGraphics = new GameObject[11];

    float overallTimer = 300f;

    // Use this for initialization
    void Start()
    {
        initialHImage = (GameObject)Instantiate(timerGraphics[4], new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0), new Quaternion(0, 0, 0, 0));
        colonImage = (GameObject)Instantiate(timerGraphics[10], new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0), new Quaternion(0, 0, 0, 0));
        initialTImage = (GameObject)Instantiate(timerGraphics[5], new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0), new Quaternion(0, 0, 0, 0));
        initialUImage = (GameObject)Instantiate(timerGraphics[9], new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0), new Quaternion(0, 0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        DrawTimer();
        initialHImage.transform.position = new Vector3(Camera.main.transform.position.x + 8, Camera.main.transform.position.y + 4.5f, -2);
        colonImage.transform.position = new Vector3(Camera.main.transform.position.x + 9, Camera.main.transform.position.y + 4.5f, -2);
        initialTImage.transform.position = new Vector3(Camera.main.transform.position.x + 10, Camera.main.transform.position.y + 4.5f, -2);
        initialUImage.transform.position = new Vector3(Camera.main.transform.position.x + 11, Camera.main.transform.position.y + 4.5f, -2);

        overallTimer -= Time.deltaTime;

        if (overallTimer <= 0)
            Application.LoadLevel(4);

      
    }

    /// <summary>
    /// Renders the timer to the screen
    /// </summary>
    void DrawTimer()
    {

        AnimateHundredths();
        AnimateTenths();
        AnimateUnits();


    }

    private void AnimateUnits()
    {
        animationUTimer -= Time.deltaTime;


        if (animationUTimer < 0)
        {
            currentUFrame--;
            destroyUPrevious = true;
            animationUTimer = 1f;

        }


        if (currentUFrame < minFrame)
            currentUFrame = 9;

        if (destroyUPrevious)
        {
            Destroy(initialUImage);
            initialUImage = (GameObject)Instantiate(timerGraphics[currentUFrame], new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0), new Quaternion(0, 0, 0, 0));
            destroyUPrevious = false;
        }
    }

    private void AnimateTenths()
    {
        animationTTimer -= Time.deltaTime;


        if (animationTTimer < 0)
        {
            currentTFrame--;
            destroyTPrevious = true;
            animationTTimer = 10f;

        }


        if (currentTFrame < minFrame)
            currentTFrame = 5;

        if (destroyTPrevious)
        {
            Destroy(initialTImage);
            initialTImage = (GameObject)Instantiate(timerGraphics[currentTFrame], new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0), new Quaternion(0, 0, 0, 0));
            destroyTPrevious = false;
        }
    }

    /// <summary>
    /// Will animate the first number
    /// </summary>
    void AnimateHundredths()
    {

        animationHTimer -= Time.deltaTime;


        if (animationHTimer < 0)
        {
            currentHFrame--;
            destroyHPrevious = true;
            animationHTimer = 60f;
        }

        if (currentHFrame < minFrame)
            currentHFrame = 4;


        if (destroyHPrevious)
        {
            Destroy(initialHImage);
            initialHImage = (GameObject)Instantiate(timerGraphics[currentHFrame], Camera.main.transform.position, new Quaternion(0, 0, 0, 0));
            destroyHPrevious = false;
        }

    } */
	//Tom's Timer

	public static float timerMinutes;
	public static float timerSeconds;

	public GUIStyle hudStyle;

	bool coolDown = false;
	float coolDownTimer = 0.0F;

	void Start()
	{

		if (!timerHandlerScript.timeSaved)
		{
			timerMinutes = 4.0F;
		}
		else {
			timerMinutes = timerHandlerScript.timerSaveMinutes;
		}

		if (!timerHandlerScript.timeSaved)
		{
			timerSeconds = 59.0F;
		}
		else {
			timerSeconds = timerHandlerScript.timerSaveSeconds;
		}
	}

	void Update() 
	{



		timerSeconds -= Time.deltaTime;

		if (timerSeconds <= 0 && !coolDown)
		{
			if (timerMinutes > 0)
			{
			timerMinutes --;
			timerSeconds = 59.0F;
			coolDown = true;
			coolDownTimer = 1;
			}
			else {
				Application.LoadLevel(4);
			}	
		}

		if (coolDown)
		{
			coolDownTimer--;

			if (coolDownTimer <= 0)
			{
				coolDown = false;
			}
		}
	}

	void OnGUI() 
	{
		GUI.Label(new Rect( Screen.width - 210, 10, 200, 25), "Time left:" + " " + timerMinutes.ToString("F0") + ":" + timerSeconds.ToString("F0"), hudStyle);
	}

}