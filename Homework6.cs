// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int[] NewArray (int size) {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++) {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PrintArray (int[] array) {
//     foreach (int i in array) {
//         System.Console.Write(i + " ");
//     }
//     System.Console.WriteLine();
// }

// int PosNum (int[] array) {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++) {
//         if (array[i] > 0) {
//             result += 1;
//         }
//     }
//     return result;
// }

// System.Console.WriteLine("Input size of the array");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input numbers in array:");
// int[] array = NewArray(size);
// PrintArray(array);
// System.Console.WriteLine($"There are {PosNum(array)} of positive numbers");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

const int b = 0;
const int k = 1;
const int x_coord = 0;
const int y_coord = 1;
const int line1 = 1;
const int line2 = 2;

double[] lineData1 = InputLineData(line1);
double[] lineData2 = InputLineData(line2);
 
if (ValidateLines(lineData1, lineData2)) {
    double[] coord = FindCoords (lineData1, lineData2);
    System.Console.Write($"Точка пересечения прямых из уравнений -> ({coord[x_coord]}), ({coord[y_coord]})");
}

double[] FindCoords (double[] lineData1, double[] lineData2) {
    double[] coord = new double[2];
    coord[x_coord] = (lineData2[b] - lineData1[b]) / (lineData1[k] - lineData2[k]);
    coord[y_coord] = lineData1[k] * ((lineData2[b] - lineData1[b]) / (lineData1[k] - lineData2[k])) + lineData1[b];
    return coord;
}

bool ValidateLines (double[] lineData1, double[] lineData2) {
    if (lineData1[b] == lineData2[b]) {
        if (lineData1[k] == lineData2[k]) {
            System.Console.WriteLine("Прямые совпадают");
            return false;
        }
        else {
            System.Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}

double[] InputLineData (int numberOfLine) {
    double[] lineData = new double[2];
    System.Console.WriteLine("Input coeff");
    lineData[b] = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("Input const");
    lineData[k] = Convert.ToDouble(Console.ReadLine());

    return lineData;
}