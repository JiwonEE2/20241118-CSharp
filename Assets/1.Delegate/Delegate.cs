using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Delegate : MonoBehaviour
{
	public TMP_InputField input1;
	public TMP_InputField input2;

	private float num1;
	private float num2;

	private delegate void Method();
	private Method method;

	public void Calc()
	{
		num1 = float.Parse(input1.text);
		num2 = float.Parse(input2.text);
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
