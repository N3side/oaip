using System;
using System.Linq;

namespace HelloWorld
{
  class Program
  {
  	static Random random = new Random();
    static double[] generate_random_array(int min, int max) {
      int arr_length = random.Next(5, 16);
      double[] arr = new double[arr_length];

      for (int i = 0; i < arr.Length; i++) {
        int rand_n = random.Next(min, max);
        arr[i] = rand_n;
      }

      return arr;
    }
    
    static string string_array(double[] array) {
    	string s = "{";
        for (int i = 0; i < array.Length; i++) {
        	s += $"{array[i]}, ";
        }
        s += "}";
        
        return s;
    }
    
    static int z1(double[] arr) {
      double total = 1;

      for (int i = 0; i < arr.Length; i+= 2) {
        total *= arr[i];
      }
		
      Console.WriteLine($"arr = {string_array(arr)}");
      Console.WriteLine($"total = {total}");

      return 1;
    }
    
    static int z2() {
    
    	int[] arr = new int[] {-4, -8, 1, -6, -7, -2, 4, -6, -7, 8, -2, -1};
    	
        int positiveCount = 0;
        int total = 0;
        
        for (int i = 0; i < arr.Length; i++) {
        	if (arr[i] > 0) {
				if (positiveCount == 0) {
                	positiveCount++;
                } else {
                	break;
                }
                
			} else {
            	if (positiveCount == 1) {
                	total += arr[i];
                }
            }
        }
        
        Console.WriteLine(total); // -15
        
        return 1;
    }
    
    static int z3(double[] arr) {
    	Console.WriteLine($"inp = {string_array(arr)}");
        double buffed;
        
		//по возврастанию
        
        //for (int i = arr.Length; i >= 1; i--) {
        //	for (int j = 0; j < i - 1; j++) {
        //    	if (arr[j] > arr[j + 1]) {
        //        	buffed = arr[j];
        //            arr[j] = arr[j + 1];
        //            arr[j + 1] = buffed;
        //        }
        //    }
        //}
        
        //по убыванию
        
        for (int i = arr.Length; i >= 1; i--) {
        	for (int j = 0; j < i - 1; j++) {
            	if (arr[j] < arr[j + 1]) {
                	buffed = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = buffed;
                }
            }
        }
        
        
        Console.WriteLine($"result = {string_array(arr)}");
        
        return 1;
    }
    
    static int z4(double[] arr) {
    	Console.WriteLine($"inp = {string_array(arr)}");
    	for (int i = 0; i < arr.Length; i++) {
        	if (arr[i] < 0) {
            	arr[i] = Math.Pow(arr[i], 2);
            }
        }
        
        Array.Reverse(arr);
        
        Console.WriteLine($"result = {string_array(arr)}");
        
        return 1;
    }
    
    static int z5(double[] arr) {
    	Console.WriteLine($"inp = {string_array(arr)}");
        
        
    	
        double total = 0;
        int fives = 0;
        int deuces = 0;
        
        for (int i = 0; i < arr.Length; i++) {
        	if (arr[i] == 5) {
            	fives++;
            }
            if (arr[i] == 2) {
            	deuces++;
            }
            total += arr[i];
        }
        
        Console.Write($" типа json 'avg': '{total / arr.Length}', 'fives': '{fives}', 'deuces': '{deuces}', 'max': '{arr.Max()}'");
        
        return 1;
    }
    
    static int z6(double[] arr) {
    	Console.WriteLine($"inp = {string_array(arr)}");
        
        
    	
        double total = 0;
        int less200 = 0;
        int more500 = 0;
        
        for (int i = 0; i < arr.Length; i++) {
        	if (arr[i] < 200) {
            	less200++;
            }
            if (arr[i] > 500) {
            	more500++;
            }
            total += arr[i];
        }
        
        Console.Write($" типа json 'total': '{total}', 'less200': '{less200}', 'max': '{arr.Max()}', 'more500': '{Math.Round((double)more500 / arr.Length * 100, 2)}%'");
        
        return 1;
    }
  
    static void Main(string[] args)
    {
    	// z1(generate_random_array(0, 10));
        // z2();
        // z3(generate_random_array(-10, 100));
        // z4(generate_random_array(-10, 20));
        // z5(generate_random_array(2, 6));
        // z6(generate_random_array(150, 1000));
    }
  }
}