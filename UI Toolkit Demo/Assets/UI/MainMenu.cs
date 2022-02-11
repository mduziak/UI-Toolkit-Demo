using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UIElements.Button;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private UIDocument document;

    private Button startButton;
    private TextField nameTextField;
    
    
    void Start()
    {
        startButton = document.rootVisualElement.Q<Button>("StartButton");
        nameTextField = document.rootVisualElement.Q<TextField>("NameTextField");

        nameTextField.RegisterValueChangedCallback(NameChanged);
        startButton.clicked += StartButtonOnClicked;
    }

    private void StartButtonOnClicked()
    {
        document.rootVisualElement.Q("MainMenu").AddToClassList("fadeOut");
    }

    private void NameChanged(ChangeEvent<string> evt)
    {
        startButton.text = "Start As: " + evt.newValue;
    }


    void Update()
    {
        
    }
}
