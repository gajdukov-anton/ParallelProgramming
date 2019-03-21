#pragma once
#include "pch.h"

class CMatrixReader
{
public:
	CMatrixReader();
	void ReadMatrixFromFile(std::string  fileName);
	std::vector<std::vector<double>> GetMatrix() const;
	~CMatrixReader();
private:
	std::vector<std::vector<double>> m_matrix;

	std::vector<double> ConvertStrToMatrixLine(std::string const& str);
};

