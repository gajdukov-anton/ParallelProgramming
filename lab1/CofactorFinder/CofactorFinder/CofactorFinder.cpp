// CofactorFinder.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"
#include "CMatrixReader.h"
#include "CCofactorFinder.h"

int main()
{
	CMatrixReader matrixReader;
	CCofactorFinder cofactorFinder;
	std::vector<std::vector<double>> matrix;
	matrixReader.ReadMatrixFromFile("test.txt");
	matrix = matrixReader.GetMatrix();
	std::cout << "size: " << matrix.size() << std::endl;
	/*for (size_t i = 0; i < matrix.size(); i++)
	{
		std::cout << "size[" << i << "] " << matrix[i].size() << ": " << ' ';
		for (size_t j = 0; j < matrix[i].size(); j++)
		{
			std::cout << matrix[i][j] << ' ';
		}
		std::cout << std::endl;
	}
	std::cout << "-------------------------" << matrix.size() << std::endl;*/
	int t = clock();
	cofactorFinder.GetMatrixOfAlgebraicComplements(matrix);
	//cofactorFinder.ShowMatrixOfAlgebraicComplements();
	std::cout << clock() - t << " ms" << std::endl;
}

// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
