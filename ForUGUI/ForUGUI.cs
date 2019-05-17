namespace Coffee.Text
{
	public static class ForUGUI
	{
		public static int GetLength(this UnityEngine.UI.Text self)
		{
			return self.text.Length;
		}
	}
}