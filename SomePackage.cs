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
		}
	}
}
