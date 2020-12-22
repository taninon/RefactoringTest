using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestReplaceTemp : MonoBehaviour
{
	[SerializeField] private int quantity = 10;
	[SerializeField] private int itemPrice = 200;

	private void Start()
	{
		var price = GetPrice();
		Debug.Log("価格:" + price);
	}

	private float GetPrice()
	{
		var basePrice = quantity * itemPrice;
		if (basePrice > 1000)
		{
			return basePrice * 0.95f;
		}
		else
		{
			return basePrice * 0.98f;
		}
	}
}
