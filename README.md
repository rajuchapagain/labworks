Framework Requirement: .Net core 3.1
Language: C#

Development Tool: Visual Studio 2019

Test cases:
Assignment is the main project folder, Assignment.Test is the test project in which I have performed following testing as part of unit testing requirement. 
1.	AddCatalogAMustPass – To add item in the catalog A
2.	AddSupplierBarCodeB – Add supplierBar code for company B
3.	RemoveCatalogAMustPass – To remove item from catalog A 
Additional unit test functionalities: 
1.	DirectoryShouldExist – To make sure the input directory exists
2.	CatatalogNotEmpty – To make sure the catalog is not empty. No point of performing merge if the either one of the catalog is empty
3.	OutputFileRowsCheck – For the given input file, number of rows that need to be returned is checked with reference to the output file provided
4.	FileCountMustBeSixFiles – To make sure all the files exist in input folder
Following snapshot shows all the unit testing passed (3 main + 4 additional test cases)
 
Output: output file contains the merged list 
 
Assumptions:
1.	Input folder must exist in application root. 
2.	Output file will be printed in output folder in application root. 
3.	Input folders must exist in test project application root as well to perform the above tests. 


Refer to Project Outline document for details
