namespace Coffee.CoreB
{
	public class Util
	{
		public static int Sub (int a, int b)
		{
			return a - b;
		}

		[UnityEditor.InitializeOnLoadMethod]
		public static void InitializeOnLoadMethod ()
		{
			UnityEngine.Debug.Log ("Coffee.CoreB.Util: InitializeOnLoadMethod");

#if COM_UNITY_TEXTMESHPRO
			Debug.Log ("[Coffee.CoreB] <color=green>a symbol 'COM_UNITY_TEXTMESHPRO' is defined.</color>");
#else
			Debug.Log ("[Coffee.CoreB] <color=orange>a symbol 'COM_UNITY_TEXTMESHPRO' is not defined.</color>");
#endif
#if COM_UNITY_QUICKSEARCH
			Debug.Log ("[Coffee.CoreB] <color=green>a symbol 'COM_UNITY_QUICKSEARCH' is defined.</color>");
#else
			Debug.Log ("[Coffee.CoreB] <color=orange>a symbol 'COM_UNITY_QUICKSEARCH' is not defined.</color>");
#endif
		}
	}
}
