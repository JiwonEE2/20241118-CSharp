using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Delegate : MonoBehaviour
{
	public TextMeshProUGUI text1;
	public TextMeshProUGUI text2;

	private float num1;
	private float num2;
	private float result;

	private delegate void Method();
	private Method method;

	public void Calc()
	{
		num1 = float.Parse(text1.text);
		num2 = float.Parse(text2.text);
		method.Invoke();
	}

	private void Add()
	{
		print(num1 + num2);
	}

	private void Sub()
	{
		print(num1 - num2);
	}

	private void Mul()
	{
		print(num1 * num2);
	}

	private void Div()
	{
		print(num1 / num2);
	}

	public void AddButton()
	{
		method = Add;
	}

	public void SubButton()
	{
		method = Sub;
	}

	public void MulButton()
	{
		method = Mul;
	}

	public void DivButton()
	{
		method = Div;
	}
}
