using System;

public class Modulo3Filter
{
    public static int modulo3(int t_input, int t_devisor)
	{
		return t_input - (t_devisor * (t_input / t_devisor));
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