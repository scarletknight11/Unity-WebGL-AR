using UnityEngine;
using Vuforia;

public class SimpleBarcodeScanner : MonoBehaviour
{
    //public TMPro.TextMeshProUGUI barcodeAsText;
    public GameObject pages;
    BarcodeBehaviour mBarcodeBehaviour;

    void Start()
    {
        mBarcodeBehaviour = GetComponent<BarcodeBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mBarcodeBehaviour != null && mBarcodeBehaviour.InstanceData != null)
        {
            //barcodeAsText.text = mBarcodeBehaviour.InstanceData.Text;
            pages.SetActive(true);
        }
        else
        {
            //barcodeAsText.text = "";
            pages.SetActive(false);
        }
    }
}