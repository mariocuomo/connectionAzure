using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AzureConnection : MonoBehaviour
{

        MobileServiceClient Client;
        IMobileServiceTable<utenze> tbl;
    
        void Start()
        {
            Client = new MobileServiceClient("https://registrazioneunity.azurewebsites.net");
        }


        public async void Insert()
        {
            IMobileServiceTable<utenze> tbl = Client.GetTable<utenze>();

            try
            {
                utenze utente = new utenze();
                utente.Id = GameObject.Find("UsernameText").GetComponent<Text>().text;
                utente.password = GameObject.Find("PasswordText").GetComponent<Text>().text;

                await tbl.InsertAsync(utente);

            }
            catch (Exception e)
            {

            }
        }
}
