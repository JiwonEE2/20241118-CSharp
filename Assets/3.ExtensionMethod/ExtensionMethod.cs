using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtensionMethod : MonoBehaviour
{
	private void Start()
	{
		string str = "Hi Hello hO goInG hoME";
		for (int i = 0; i < MySplit.Split(str, ' ').Length; i++)
		{
			print(MySplit.Split(str, ' ')[i]);
		}
		print(MySplit.ToLower(str));
		print(MySplit.ToUpper(str));
	}
}

public static class MySplit
{
	public static string[] Split(this string str, char cha)
	{
		return str.Split(cha);
	}

	public static string ToLower(this string str)
	{
		return str.ToLower();
	}

	public static string ToUpper(this string str)
	{
		return str.ToUpper();
	}
}