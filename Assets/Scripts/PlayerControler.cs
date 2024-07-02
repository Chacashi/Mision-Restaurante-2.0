using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public GameObject Nube;
    public EfectoTexto Texto;
    public GameObject NubeCuy;
    Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void Dialogo(sbyte n)
    {
        Nube.SetActive(true);
        if (n == 0)
        {
            Texto.Inprimir("Otro d�a sin clientes�Supongo que se acab�");
        }
        if (n == 1)
        {
            Texto.Inprimir("�Y t� qui�n eres?");
        }
        if (n == 3)
        {
            Texto.Inprimir("Creo que me ha hecho mal no dormir bien. �Estoy so�ando?");
        }
        if (n==5)
        {
            Texto.Inprimir("�Okey? �Y qu� tengo que hacer?");
        }
        if (n==7)
        {
            animator.SetTrigger("Feliz");
            Texto.Inprimir("�Entonces me ense�ar�s a cocinar?");
        }
        NubeCuy.SetActive(false);
    }
}
