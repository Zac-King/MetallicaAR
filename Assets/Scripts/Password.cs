using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

[RequireComponent(typeof(InputField))]
public class Password : MonoBehaviour
{
    private InputField m_Input
    { get { return GetComponent<InputField>(); } }

    [SerializeField]
    private string m_Password;

    public UnityEngine.Events.UnityEvent OnCorrectPassword;
    
    public void CheckPassword()
    {
        if (m_Input.text == m_Password)
            OnCorrectPassword.Invoke();
    }


    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
