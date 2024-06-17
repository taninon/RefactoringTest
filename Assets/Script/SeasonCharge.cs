using System;
using UnityEngine;

public class SeasonCharge : MonoBehaviour
{
	private int month;

	readonly int summerStartMonth = 6;
	readonly int summerEndMonth = 8;

	[SerializeField] int quantity;
	[SerializeField] float winterRate;
	[SerializeField] int winterServiceCharge;
	[SerializeField] float summerRate;

	// Start is called before the first frame update
	void Start()
	{
		DateTime currentDate = DateTime.Now;
		int month = currentDate.Month;
		Debug.Log("����" + month + "��");

		int charge = 0;
		if (month >= summerStartMonth && month <= summerEndMonth)
		{

			charge = Mathf.CeilToInt(quantity * summerRate);
		}
		else
		{
			charge = Mathf.CeilToInt(quantity * winterRate) + winterServiceCharge;
		}

		Debug.Log("�l�i��" + charge + "��");
	}
}