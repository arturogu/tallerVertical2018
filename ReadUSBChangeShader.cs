using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ReadUSBChangeShader : MonoBehaviour {
	[SerializeField]public Shader shader1;
	[SerializeField]public Shader shader2;

	private Renderer holoRenderer;

	SerialPort sp; //whatever COM arduino uses

	private void Awake()
	{
		try
		{
			sp = new SerialPort("COM1", 9600);
			Debug.Log("bad port");
		}
		catch(System.Exception )
		{
			Debug.Log ("puerto malo");
		}
	}

	void Start()
	{
		holoRenderer = GetComponent<Renderer>();
		//shader1 = Shader.Find("Shade");
		//shader2 = Shader.Find("Shade2");
		try
		{
			sp.Open();
			sp.ReadTimeout = 1;
			Debug.Log("port open");
		}
		catch(System.Exception e)
		{
			Debug.Log(e);
		}

	}

	// Update is called once per frame
	void Update () {
		Debug.Log("te la pelaste0");
		if (sp.IsOpen)
		{
			Debug.Log("te la pelaste1");
			try
			{
				string byteval = sp.ReadByte().ToString();

				if (byteval == "1"){
					if (holoRenderer.material.shader == shader2){
						holoRenderer.material.shader = shader1;
						Debug.Log("color 1a");
					}
					else {
						holoRenderer.material.shader = shader2;
						Debug.Log("color 2b");
					}
						
				} // DO WHATEVER THE *YOU WANT
				else {
					


				}



			}
			catch (System.Exception)
			{
				Debug.Log("te la pelaste2");
			}
		}
		else
		{
			Debug.Log("te la pelaste3");
			if(Input.GetKeyDown(KeyCode.R))
			{
				//Do something
				Debug.Log("lee alterno");
			}
		}
	}




}