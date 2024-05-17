using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class VidaScxrip : MonoBehaviour
{
    // Start is called before the first frame update
    public float points;
    public float pointsMax;
    public float dañoEnemigo;
    [SerializeField] TMP_Text pointstoText;
    [SerializeField] GameObject LossMenu;



    //codigo de los puntos de vida desciende desde xx0xxx a 0 muere haciendo collision con el enemy tag que resta mepuntos.
    //activo panel de Game losted


    // Start is called before the first frame update
    void Start()
    {
        points = 500;
        pointsMax = 10000;
    }

    // Update is called once per frame
    void Update()
    {
      /* pointstoText.text = "Points:" + points.ToString();*/
        Muerte();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            points = points - dañoEnemigo;
        }
    }


    void Muerte()
    {
        if (points <= 0)
        {
            Debug.Log("Loser");
            LossMenu.gameObject.SetActive(true);
        }

    }
    public void ResetGame(int sceneToLoad = 1)
    {

        SceneManager.LoadScene(sceneToLoad);//carga la escena del mismo valor que sceneToLoad
       // AudioManager.Instance.StopCurrentMusic();
    }
   
}
