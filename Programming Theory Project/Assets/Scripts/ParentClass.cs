using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ParentClass : MonoBehaviour
{
    protected string nameChild;
    protected Color color;

    public TextMeshProUGUI display;
    public Material material;

    public void NameChild(string name)
    {
        nameChild = name;
    }


    public void Start()
    {
        display.gameObject.SetActive(false);
        //NameChild();
        display.SetText("Hello i'm " + material.name + " " + nameChild + "!");
        display.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 0.8f, 0));
    }

    private void OnMouseEnter()
    {
        ShowMessage();
    }

    private void OnMouseOver()
    {
        Spin();
        ChangeColor();
    }

    private void OnMouseExit()
    {
        display.gameObject.SetActive(false);
        GetComponent<MeshRenderer>().material.SetColor("_Color", Color.white);
    }

    private void ShowMessage()
    {
        display.gameObject.SetActive(true);
    }

    private void Spin()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * 50);
    }

    private void ChangeColor()
    {
        GetComponent<MeshRenderer>().material.color = material.color;
    }
}

