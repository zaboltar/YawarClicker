using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public Button idolButton, sunButton, keroButton;
    public GameObject idolSoldTxt, sunSoldTxt, keroSoldTxt;
    public Text idolPriceTxt, sunPriceTxt, keroPriceTxt;

    public GameObject idol, sun, kero;
    public Text hitTxt;
    public int hitAmmount;

    private bool isIdolSold, isSunSold, isKeroSold;
    public int idolPrice = 10, sunPrice = 20, keroPrice = 30;

    // Start is called before the first frame update
    void Start()
    {
        idol.gameObject.SetActive(false);
        sun.gameObject.SetActive(false);
        kero.gameObject.SetActive(false);

        idolButton.interactable = false;
        sunButton.interactable = false;
        keroButton.interactable = false;

        idolSoldTxt.gameObject.SetActive(false);
        sunSoldTxt.gameObject.SetActive(false);
        keroSoldTxt.gameObject.SetActive(false);

        idolPriceTxt.text = idolPrice.ToString() + " hits";
        sunPriceTxt.text = sunPrice.ToString() + " hits";
        keroPriceTxt.text = keroPrice.ToString() + " hits";
    }

    // Update is called once per frame
    void Update()
    {
        hitTxt.text = hitAmmount.ToString() + " Hits";

        BuyFiscalization();
        
    }

    public void IncreaseHitAmmount()
    {
        hitAmmount += 1;
    }

    public void SellIdol()
    {
        idol.gameObject.SetActive(true);
        hitAmmount -= idolPrice;
        isIdolSold = true;
        idolSoldTxt.gameObject.SetActive(true);
        idolPriceTxt.gameObject.SetActive(false);


    }

    public void SellSun()
    {
        sun.gameObject.SetActive(true);
        hitAmmount -= sunPrice;
        isSunSold = true;
        sunSoldTxt.gameObject.SetActive(true);
        sunPriceTxt.gameObject.SetActive(false);



    }

    public void SellKero()
    {
        kero.gameObject.SetActive(true);
        hitAmmount -= keroPrice;
        isKeroSold = true;
        keroSoldTxt.gameObject.SetActive(true);
        keroPriceTxt.gameObject.SetActive(false);
    }

    void BuyFiscalization()
    {
        if (hitAmmount < idolPrice)
            idolButton.interactable = false;

        if (hitAmmount < sunPrice)
            sunButton.interactable = false;

        if (hitAmmount < keroPrice)
            keroButton.interactable = false;



        if (!isIdolSold && hitAmmount >= idolPrice)
        {
            idolButton.interactable = true;
        }

        if (!isSunSold && hitAmmount >= sunPrice)
        {
            sunButton.interactable = true;
        }

        if (!isKeroSold && hitAmmount >= keroPrice)
        {
            keroButton.interactable = true;
        }
    }

}
