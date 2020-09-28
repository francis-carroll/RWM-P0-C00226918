public class Modulo3Filter
{
    public static int modulo3(int input, int devisor)
	{
		return input - ((input / devisor) * devisor);
	}

	public static int[] modulo3s(int[] input)
	{
		int[] result = new int[input.Length];
		for (int i = 0; i < input.Length; i++)
		{
			result[i] = modulo3(input[i], 3);
		}
		return result;
	}
}