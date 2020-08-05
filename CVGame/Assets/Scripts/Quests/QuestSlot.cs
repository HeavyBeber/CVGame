/**
Author : Alexandre Bernard
**/

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Text))]
public class QuestSlot : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    #region Variables
    public Quest quest;
	public GameObject questListHolder;
    public GameObject textHolder;
	public UnityEvent onClick;


    public Color NormalColor = Color.black;
    public Color HoverColor = Color.gray;
    #endregion

    #region Unity Methods

    public bool isHover;

    private Text _textComponent;
    private Text TextComponent
    {
        get
        {
            if (!_textComponent) _textComponent = GetComponent<Text>() ?? gameObject.AddComponent<Text>();
            return _textComponent;

        }
    }

    private void Start()
    {
        this.gameObject.SetActive(false);
    }

    public void CompleteQuest()
    {
    }

    #endregion

    #region IPointerHandler    
    public void OnClick()
	{
		questListHolder.SetActive(false);
        TextComponent.color = NormalColor;
        textHolder.SetActive(true);
        textHolder.GetComponentInChildren<Text>().text = quest.text;
    }

    public void OnReturnClick()
    {
        questListHolder.SetActive(true);
        textHolder.SetActive(false);
    }


    private void Updatecolor()
    {
        if (isHover)
        {
            TextComponent.color = HoverColor;
            return;
        }

        TextComponent.color = NormalColor;
    }


    public void OnPointerClick(PointerEventData eventData)
	{
		onClick.Invoke();
	}

    public void OnPointerEnter(PointerEventData eventData)
    {
        isHover = true;
        Updatecolor();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isHover = false;
        Updatecolor();
    }

    #endregion
}
