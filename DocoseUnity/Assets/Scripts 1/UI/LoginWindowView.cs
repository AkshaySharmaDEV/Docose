//--------------------------------------------------------------------------------------
// LoginWindowView.cs
//
// Advanced Technology Group (ATG)
// Copyright (C) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//--------------------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using TMPro;
using System.Collections;





public class LoginWindowView : MonoBehaviour
{
    [Header("UI")]
    public UserBox[] userBoxes;
    
    // Debug Flag to simulate a reset
    public bool ClearPlayerPrefs;

    // Meta fields for objects in the UI
    public InputField Username;
    public InputField Password;
    public InputField ConfirmPassword;
    public Toggle RememberMe;

    
    public Button PlayAsGuestButton;
    public Button RegisterButton;
    public Button CancelRegisterButton;
    // public Button ClearSigninButton;
    public Button ResetSampleButton;

    // Meta references to panels we need to show / hide
    public GameObject RegisterPanel;
    public GameObject SigninPanel;
    public GameObject LoginPanel;
    public GameObject LoggedinPanel;
    public Text StatusText;
    // public Text UserName;
    public InputField UserDisplayName;
    public TMP_Text DisplayName1;
    public TMP_Text DisplayName2;

    public TMP_Text WelcomeText;

    public TMP_Text GenderText;
    public TMP_Text AgeText;
    public TMP_Text WeightText;
    public TMP_Text HeightText;
    // public TMP_Text DisplayName2;
    // public TMP_Text DisplayName3;
    // public TMP_Text DisplayName4;

    public TMP_Text Langauge;



    // public GameObject WelecomeTab;

    // public GameObject FormTab;


    

    


    

    // public InputField UserDisplayName;

    // Settings for what data to get from playfab on login.
    public GetPlayerCombinedInfoRequestParams InfoRequestParams;

    // Reference to our Authentication service
    private PlayFabAuthService _AuthService = PlayFabAuthService.Instance;

    // int count = 0;

    
    // public void MakeUnvisible()
    // {
    //     count = 1;
    //     PlayerPrefs.SetInt("CurrentCount1", count);
        
    // }

    // public void Logout()
    // {
    //     count = 0;
    //     PlayerPrefs.SetInt("CurrentCount1", count);
    // }

    public void Awake()
    {
        if (ClearPlayerPrefs)
        {
            _AuthService.UnlinkSilentAuth();
            _AuthService.ClearRememberMe();
            _AuthService.AuthType = Authtypes.None;
        }

        //Set our remember me button to our remembered state.
        RememberMe.isOn = _AuthService.RememberMe;

        //Subscribe to our Remember Me toggle
        RememberMe.onValueChanged.AddListener(
            (toggle) =>
            {
                _AuthService.RememberMe = toggle;
            });

        
    }

    void Start()
    {
        
        // Hide all our panels until we know what UI to display
        LoginPanel.SetActive(false);
        LoggedinPanel.SetActive(false);
        RegisterPanel.SetActive(false);
        SigninPanel.SetActive(true);

        // Subscribe to events that happen after we authenticate
        PlayFabAuthService.OnDisplayAuthentication += OnDisplayAuthentication;
        PlayFabAuthService.OnLoginSuccess += OnLoginSuccess;
        PlayFabAuthService.OnPlayFabError += OnPlayFaberror;

        // Bind to UI buttons to perform actions when user interacts with the UI.
        // LoginButton.onClick.AddListener(OnLoginClicked);
        PlayAsGuestButton.onClick.AddListener(OnPlayAsGuestClicked);
        RegisterButton.onClick.AddListener(OnRegisterButtonClicked);
        CancelRegisterButton.onClick.AddListener(OnCancelRegisterButtonClicked);
        ResetSampleButton.onClick.AddListener(OnResetSampleButtonClicked);
        // ClearSigninButton.onClick.AddListener(OnClearSigninButtonClicked);

        // Set the data we want at login from what we chose in our meta data.
        _AuthService.InfoRequestParams = InfoRequestParams;

        

        // Start the authentication process.
        _AuthService.Authenticate();


        
        
        

        // if(PlayerPrefs.GetInt("CurrentCount1") == 0)
        // {
        //     WelecomeTab.SetActive(true);
        //     FormTab.SetActive(true);
        // }
        // if(PlayerPrefs.GetInt("CurrentCount1") == 1)
        // {
        //     WelecomeTab.SetActive(false);
        //     FormTab.SetActive(false);
        // }
    }

    


    /// <summary>
    /// Login Successfully - Goes to next screen.
    /// </summary>
    /// <param name="result"></param>
    private void OnLoginSuccess(PlayFab.ClientModels.LoginResult result)
    {
        if(string.IsNullOrEmpty(UserDisplayName.text))
        {
            UserDisplayName.text = result.InfoResultPayload.AccountInfo.TitleInfo.DisplayName ?? result.PlayFabId;
        }
        
        PlayFabClientAPI.UpdateUserTitleDisplayName(new UpdateUserTitleDisplayNameRequest
        {
            DisplayName = UserDisplayName.text
        }, result =>
        {
            
            Debug.Log("The player's display name is now: " + result.DisplayName);
        }, error => Debug.LogError(error.GenerateErrorReport()));
        
        // if(string.IsNullOrEmpty( name.text ))
        // {
        //     GetCharacters();
            
            
        // }

        // SaveUsers();

        // // GetCharacters();

        
        

        Debug.LogFormat("Logged In as: {0}", result.PlayFabId);
        StatusText.text = "";
        LoginPanel.SetActive(false);
        LoggedinPanel.SetActive(true);

        DisplayName1.text = UserDisplayName.text;
        DisplayName2.text = UserDisplayName.text;
        // DisplayName2.text = UserDisplayName.text;
        // DisplayName3.text = UserDisplayName.text;
        // DisplayName4.text = UserDisplayName.text;

        
        
        GetCharacters1();


        GetTitleData();
        

        
        

        

        
        
         

        
    }

    

    

    

    

    

    

    /// <summary>
    /// Error handling for when Login returns errors.
    /// </summary>
    /// <param name="error"></param>
    private void OnPlayFaberror(PlayFabError error)
    {
        //There are more cases which can be caught, below are some
        //of the basic ones.
        switch (error.Error)
        {
            case PlayFabErrorCode.InvalidEmailAddress:
            case PlayFabErrorCode.InvalidPassword:
            case PlayFabErrorCode.InvalidEmailOrPassword:
                StatusText.text = "Invalid Email or Password";
                break;

            case PlayFabErrorCode.AccountNotFound:
                RegisterPanel.SetActive(true);
                SigninPanel.SetActive(false);
                return;
            default:
                StatusText.text = error.GenerateErrorReport();
                break;
        }

        //Also report to debug console, this is optional.
        Debug.Log(error.Error);
        Debug.LogError(error.GenerateErrorReport());
    }

    /// <summary>
    /// Choose to display the Auth UI or any other action.
    /// </summary>
    private void OnDisplayAuthentication()
    {
        //Here we have choses what to do when AuthType is None.

        

        LoginPanel.SetActive(true);
        LoggedinPanel.SetActive(false);
        StatusText.text = "";

        
        
        
        
        

        /*
         * Optionally we could Not do the above and force login silently
         * 
         * _AuthService.Authenticate(Authtypes.Silent);
         * 
         * This example, would auto log them in by device ID and they would
         * never see any UI for Authentication.
         * 
         */
    }

    

    /// <summary>
    /// Play As a guest, which means they are going to silently authenticate
    /// by device ID or Custom ID
    /// </summary>
    private void OnPlayAsGuestClicked()
    {

        StatusText.text = "Logging In As Guest ...";

        _AuthService.Authenticate(Authtypes.Silent);
    }

    /// <summary>
    /// Login Button means they've selected to submit a username (email) / password combo
    /// Note: in this flow if no account is found, it will ask them to register.
    /// </summary>
    public void OnLoginClicked()
    {
        StatusText.text = string.Format("Logging In As {0} ...", Username.text);

        _AuthService.Email = Username.text;
        _AuthService.Password = Password.text;
        _AuthService.Authenticate(Authtypes.EmailAndPassword);

        PlayFabClientAPI.UpdateUserTitleDisplayName(new UpdateUserTitleDisplayNameRequest
        {
            DisplayName = UserDisplayName.text
        }, result =>
        {
            
            Debug.Log("The player's display name is now: " + result.DisplayName);
        }, error => Debug.LogError(error.GenerateErrorReport()));
        

        
    }

    /// <summary>
    /// No account was found, and they have selected to register a username (email) / password combo.
    /// </summary>
    private void OnRegisterButtonClicked()
    {
        if (Password.text != ConfirmPassword.text)
        {
            StatusText.text = "Passwords do not Match.";
            return;
        }

        StatusText.text = string.Format("Registering User {0} ...", Username.text);

        _AuthService.Email = Username.text;
        _AuthService.Password = Password.text;
        _AuthService.Authenticate(Authtypes.RegisterPlayFabAccount);

        PlayFabClientAPI.UpdateUserTitleDisplayName(new UpdateUserTitleDisplayNameRequest
        {
            DisplayName = UserDisplayName.text
        }, result =>
        {
            
            Debug.Log("The player's display name is now: " + result.DisplayName);
        }, error => Debug.LogError(error.GenerateErrorReport()));
    }

    /// <summary>
    /// They have opted to cancel the Registration process.
    /// Possibly they typed the email address incorrectly.
    /// </summary>
    private void OnCancelRegisterButtonClicked()
    {
        // Reset all forms
        Username.text = string.Empty;
        Password.text = string.Empty;
        ConfirmPassword.text = string.Empty;

        // Show panels
        RegisterPanel.SetActive(false);
        SigninPanel.SetActive(true);
    }

    private void OnClearSigninButtonClicked()
    {
        // _AuthService.ClearRememberMe();
        // StatusText.text = "Signin info cleared";
        
    }

    private void OnResetSampleButtonClicked()
    {
        _AuthService.ClearRememberMe();
        StatusText.text = "Signin info cleared";
        PlayFabClientAPI.ForgetAllCredentials();
        _AuthService.Email = string.Empty;
        _AuthService.Password = string.Empty;
        _AuthService.AuthTicket = string.Empty;
        _AuthService.Authenticate();
    }


    void GetTitleData()
    {
        PlayFabClientAPI.GetTitleData(new GetTitleDataRequest(),OnTitleDataRecieved,OnError);

    }

    void OnTitleDataRecieved(GetTitleDataResult result){
        if(result.Data == null || result.Data.ContainsKey("Welcome") == false || result.Data.ContainsKey("Gender") == false || result.Data.ContainsKey("Age") == false || result.Data.ContainsKey("Weight") == false || result.Data.ContainsKey("Height") == false || result.Data.ContainsKey("Language") == false) {
            Debug.Log("Server Error");
            return;
        }

        WelcomeText.text = result.Data["Welcome"];
        GenderText.text = result.Data["Gender"];
        AgeText.text = result.Data["Age"];
        WeightText.text = result.Data["Weight"];
        HeightText.text = result.Data["Height"];
        Langauge.text = result.Data["Language"];

        
    }

    


    

    // public void SaveUsers()
    // {
    //     List <UsersGender> usersgender = new List<UsersGender>();
    //     foreach (var item in userBoxes){
    //         usersgender.Add(item.ReturnClass1());
    //     }
    //     var request = new UpdateUserDataRequest{
    //         Data = new Dictionary<string, string>{
    //             {"Users",JsonConvert.SerializeObject(usersgender)}

    //         }
    //     };
    //     PlayFabClientAPI.UpdateUserData(request, OnDataSend, OnError);
    // }

    

    public void SaveUsers1()
    {
        List <UsersData> usersdata1 = new List<UsersData>();
        foreach (var item in userBoxes){
            usersdata1.Add(item.ReturnClass());
        }
        var request = new UpdateUserDataRequest{
            Data = new Dictionary<string, string>{
                {"Users",JsonConvert.SerializeObject(usersdata1)}

            }
        };
        PlayFabClientAPI.UpdateUserData(request, OnDataSend, OnError);
    }




    

   

    // public void GetCharacters(){
    //     PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnUsersDataRecieved,OnError);
    // }
    // void OnUsersDataRecieved(GetUserDataResult result){
    //     Debug.Log("Recieved User Data!");
    //     if(result.Data!= null && result.Data.ContainsKey("Gender")){
    //         List<UsersGender> usersgender = JsonConvert.DeserializeObject<List<UsersGender>>(result.Data["Gender"].Value);
    //         for(int i = 0; i < userBoxes.Length;i++){
    //             userBoxes[i].SetUi(usersgender[i]);
    //         }
    //     }
    // }

    public void GetForm()
    {
         Invoke("GetFormData", 1.0f);
    }

    void GetFormData()
    {
         GetCharacters1();
         
    }




    public void GetCharacters1(){
        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnUsersDataRecieved1,OnError);
    }
    void OnUsersDataRecieved1(GetUserDataResult result){
        Debug.Log("Recieved User Data!");
        if(result.Data!= null && result.Data.ContainsKey("Users")){
            List<UsersData> usersdata1 = JsonConvert.DeserializeObject<List<UsersData>>(result.Data["Users"].Value);
            for(int i = 0; i < userBoxes.Length;i++){
                userBoxes[i].SetUi1(usersdata1[i]);
            }
        }
    }

    void OnDataSend(UpdateUserDataResult result){}
    void OnError(PlayFabError error){}


    
    
}