using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManage : MonoBehaviour
{
    public Text levelCleared;
    public Text preg;
    public Text verd;
    public Text fals;
    System.Random rnd = new System.Random();
    public int numeroAleatorio = -1;
    public int numeal = -1;
    void Start()
    {
        // Random rnd = new Random();
        if (numeroAleatorio == -1 ){
            numeroAleatorio = rnd.Next(0, 10);
            numeal = numeroAleatorio;
        }
    }
    private void Update(){

        
        AllFruitCollected();
    }
    public void AllFruitCollected(){
        if(transform.childCount==0){
            Debug.Log("No quedan frutas");
            levelCleared.gameObject.SetActive(true);
           
            Invoke("ChangeScene",1);
            
        }
        
        
        List<string> listaDePreguntas = new List<string>()
        {
            "¿Cuál es uno de los aspectos que abarca la legislación informática?",
            "¿Qué ley protege los datos personales de los ciudadanos europeos?",
            "¿Qué es el derecho al olvido?",
            "¿Cuál de las siguientes es una de las principales preocupaciones de la legislación informática?",
            "¿Qué ley protege los derechos de autor y promueve la innovación en el entorno digital?",
            "¿Cuál es una de las responsabilidades de un DPO (Oficial de Protección de Datos)?",
            "¿Qué organismo es responsable de hacer cumplir el RGPD en Europa?",
            "¿Qué es el consentimiento explícito en el contexto de la legislación de privacidad de datos?",
            "¿Qué es una cláusula de exclusión de responsabilidad en el contexto de la legislación informática?",
            "¿Qué ley regula el comercio electrónico en los Estados Unidos?"
        };
        List<string> listaOpcionVerdadera = new List<string>()
        {
            "A) Privacidad de datos",
            "A) GDPR (Reglamento General de Protección de Datos)",
            "A) El derecho a que los datos personales sean eliminados o no sean procesados sin el consentimiento del titular.",
            "A) Protección de la propiedad intelectual.",
            "A) DMCA (Digital Millennium Copyright Act)",
            "A) Supervisar el cumplimiento de la normativa de protección de datos.",
            "A) Agencia de Protección de Datos de la Unión Europea.",
            "A) El consentimiento debe ser otorgado de manera inequívoca mediante una acción afirmativa.",
            "A) Una cláusula que exime a una parte de la responsabilidad por ciertas acciones.",
            "A) E-Sign Act"
        };
        List<string> listaOpcionFalsa = new List<string>()
        {
            "B) Seguridad cibertermica",
            "B) Ley de Seguridad Cibernética",
            "B) El derecho a compartir información personal en línea.",
            "B) Promoción del spam electrónico.",
            "B) Ley de Patentes de Software",
            "B) Supervisar la seguridad física de los servidores.",
            "B) Comisión Europea de Ciberseguridad.",
            "B) El consentimiento puede ser implícito y no requerir una acción afirmativa.",
            "B) Una cláusula que garantiza la total responsabilidad de todas las partes involucradas.",
            "B) Ley de Protección de la Privacidad en Línea (COPPA)"
        };
        string preguntaSeleccionada = listaDePreguntas[numeroAleatorio];
        string respuestaVerdadera = listaOpcionVerdadera[numeroAleatorio];
        string respuestaFalsa = listaOpcionFalsa[numeroAleatorio];

        preg.gameObject.SetActive(true);
        verd.gameObject.SetActive(true);
        fals.gameObject.SetActive(true);
        
        if (preg != null && verd != null && fals != null ) {
            preg.text = preguntaSeleccionada;
            verd.text = respuestaVerdadera;
            fals.text = respuestaFalsa;
        }
        
        
    }
    void ChangeScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}

