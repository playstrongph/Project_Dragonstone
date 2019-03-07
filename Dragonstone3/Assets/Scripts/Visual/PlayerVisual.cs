using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;

public class PlayerVisual : MonoBehaviour {

	public GameObject targetPointer;
	public GameObject targetPointerGO;

	DragSource dragSource;
	GameObject pointerObject;

	public bool dragging = false;

	
	
	// Update is called once per frame
	void Update () {
		
		pointerObject = UpdateMouseOver();

		if (pointerObject != null )
		{
				if(pointerObject.gameObject.GetComponent<DragSource>() != null && pointerObject.gameObject.GetComponent<DragSource>().canDrag)
				{				
					if (Input.GetMouseButtonDown(0))
					{
						dragSource = pointerObject.gameObject.GetComponent<DragSource>();							
						targetPointerGO = Instantiate(targetPointer, dragSource.gameObject.transform.position, dragSource.gameObject.transform.rotation, dragSource.GetComponentInParent<HeroManager>().gameObject.transform);			
						targetPointerGO.transform.SetParent(dragSource.gameObject.transform);




						dragging = true;						
					}
				}//pointerObject		

				if (dragging)
				{			
					//while dragging and mouse button is released
					if (Input.GetMouseButtonUp(0))
					{				
						//Debug.Log ("no target:");
						dragging = false;
						Destroy(targetPointerGO);				
					}
				}//dragging

				else
				{
					if (targetPointerGO != null)
					{
						Destroy(targetPointerGO);
					}
				}

		}//pointerObject

		else //if pointerObject != null
		{
			if (Input.GetMouseButtonUp(0))
			{
				dragging = false;
				if (targetPointerGO != null)
				{
					Destroy(targetPointerGO);
				}
			}
		}

		


		
	}//Update



	private GameObject UpdateMouseOver()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider != null)
        {
			
			return hit.transform.gameObject;
          //pointer over hero  
		}
		else return null;

    }

}
