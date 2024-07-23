using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField]private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasgroup;

    private void Awake(){
        rectTransform = GetComponent<RectTransform>();
        canvasgroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData EventData){
        canvasgroup.alpha = .6f;
        canvasgroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData EventData){
        rectTransform.anchoredPosition += EventData.delta/canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData EventData){
        canvasgroup.alpha = 1f;
        canvasgroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData EventData){
        
    }

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
