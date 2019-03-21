#include "pch.h"
#include "CMatrixReader.h"


CMatrixReader::CMatrixReader()
{
}

void CMatrixReader::ReadMatrixFromFile(std::string  fileName)
{
	std::string line;
	std::ifstream fileStream(fileName);
	if (fileStream.is_open())
	{
		while (getline(fileStream, line))
		{
			m_matrix.push_back(ConvertStrToMatrixLine(line));
		}
	}
}

std::vector<double> CMatrixReader::ConvertStrToMatrixLine(std::string const& str)
{
	std::vector<double> matrixLine;
	std::stringstream  stringStream;
	stringStream << str;
	std::string numberStr;
	double number;
	while (stringStream >> numberStr)
	{
		try
		{
			number = std::stod(numberStr);
			matrixLine.push_back(number);
		}
		catch (std::invalid_argument)
		{
			throw std::invalid_argument("Invalid value in matrix");
		}
	}
	return matrixLine;
}

std::vector<std::vector<double>> CMatrixReader::GetMatrix() const
{
	return m_matrix;
}

CMatrixReader::~CMatrixReader()
{
}
