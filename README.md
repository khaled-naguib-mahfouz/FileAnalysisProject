# FileAnalysisProject

## Overview

`FileAnalysisProject` is a console application designed to analyze files in a specified directory. It supports analyzing text files and CSV files to generate statistics such as word count, character count, and line count. The project demonstrates the use of file reading, string manipulation, and basic object-oriented design principles in C#.

## Features

- Analyze text files and CSV files
- Calculate word count, character count, and line count
- Supports UTF-8 encoding
- Extensible design for adding more file types in the future

## Project Structure

- **Program.cs**: Entry point of the application. Handles user input and orchestrates file analysis.
- **FileAnalyzer.cs**: Abstract base class for file analyzers. Defines the interface and common properties.
- **CSVFileAnalyzer.cs**: Concrete implementation for analyzing CSV files.
- **TextFileAnalyzer.cs**: Concrete implementation for analyzing text files.
- **AnalysisResult.cs**: Data class to hold the results of the file analysis.
- **FileExtensions.cs**: Extension methods for checking file types.

## Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/FileAnalysisProject.git
