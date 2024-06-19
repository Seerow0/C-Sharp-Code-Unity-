
using UnityEngine;
//using UnityEngine.SceneManagement;


public class delayloadscene : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 10f;
    [SerializeField]
    private string scenenametoload;

    private float timeElasped;

    private void Update()
    {

        {
            timeElasped += Time.deltaTime;
            if (timeElasped > delayBeforeLoading)
            {
                //SceneManager.LoadScene(scenenametoload);
                Application.Quit();
                print("quitbich");
            }
            
        }
    }

}