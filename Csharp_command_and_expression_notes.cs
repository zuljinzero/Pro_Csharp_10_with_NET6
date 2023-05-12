//***************************//
// TERMINAL COMMANDS (VSCode//
//*************************//
//
//  // Create new solution (can leave out -o .\FolderName if in correct directory)
//  dotnet new sln -n NameOfSolution -o .\FolderName
//
//  // Create a new console application (can leave out -o .\FolderName if in correct directory)
//  dotnet new console -lang c# -n NameOfApp -o .\FolderName\SubFolderName
//
//  // Add project/app to a solution
//  dotnet sln .\FolderName\SolutionName.sln add .\FolderName\ProjectFolderName
//
//  // Restore all NuGet packages required for you solution and project/app
//  dotnet restore
//
//  // Restore and Build all of the projects in your solution
//  dotnet build
//
//  // Run project/app without debugging
//  dotnet run
//
//  // Change location the terminal is aimed at
//	cd FolderName
//	
//	// Change location back one folder
//	cd ..
//
//********************//
//*******************//


//*************************//
// System.Console MEMBERS //
//***********************//
//
//	Beep()			// Forces the console to emit a beep of a specified frequency and duration
//	
//	BackgroundColor	// Sets background/foreground colors for the current output
//	
//	ForegroundColor // May be assignedany member of the ConsoleColor enumeration
//	
//	BufferHeight	// These properties control the height/width of the console's buffer area
//	BufferWidth		// ^^
//	
//	Title			// gets or sets the title of the current console
//	
//	WindowHeight	// These properties control the dimensions of the console in relation to the established buffer
//	WindowWidth		// ^^
//	WindowTop		// ^^
//	windowLeft		// ^^
//	
//	Clear()			// Clears the established buffer and console display area
//	
//********************//
//*******************//


//***************************//
// STRING FORMAT CHARACTERS //
//*************************//
//	
//	C or c			// Currency format. Uses local symbol ($, US default)
//	
//	D or d			// Decimal format. May specify minimum number of digits
//	
//	E or e			// Exponential notation. E or e casing controls if exponential constant is uppercase(E) or lowercase(e)
//	
//	F or f			// Fixed-point formatting. May specify minimum number of digits
//	
//	G or g			// (stands for general) Used to format a number to fixed or exponential format
//	
//	N or n			// Basic numerical formatting (with commas)
//	
//	X or x			// Hexadecimal formatting. X or x casing affects format case
//	
//********************//
//*******************//


//**********************************//
// STRING MEMBERS OF System.String //
//********************************//
//	
//	Length			// Returns the length of string
//	
//	Compare()		// Compares two strings
//	
//	Contains()		// Determines whether a string contains a specifc substring
//
//	Equals()		// Tests whether two string objects contain identical character data
//	
//	Format()		// Formats a string using other primitives (e.g. numerical data, other strings) and the {0} notation
//	
//	Insert()		// Inserts a string within a given string
//	
//	PadLeft()		// Pads a string with some characters (eight on left or right of string)
//	PadRight()		// ^^
//	
//	Remove()		// Receive a copy of a string with modifications (characters removed or replaced)
//	Replace()		// ^^
//
//	Split()			// Returns a String array containing the substrings delimited by specified character or string
//	
//	Trim()			// Removes all occurrences of a set of specified characters from the beginning and end of the current string
//	
//	ToUpper()		// Returns a copy of the string in uppercase or lowercase
//	ToLower()		// ^^
//	
//********************//
//*******************//


//***********************************//
// STRING LITERAL ESCAPE CHARACTERS //
//*********************************//
//	
//	\'				// Inserts single quote
//	
//	\"				// Inserts double quote
//	
//	\\				// Inserts backlash. Good for defining file or network paths
//	
//	\a				// Triggers a system alert(beep). For console programs, this can be an audio clue to the user
//	
//	\n				// Inserts a line feed, or new line (Unix-based systems (Windows, MacOS, etc)
//
//	\r\n			// Inserts a line feed (non-Unix-based platforms)
//	
//	\r				// Inserts a carriage return
//	
//	\t				// Inserts a horizontal tab
//	
//*********************//
//********************//


//********************************//
// EQUALITY/RELATIONAL OPERATORS //
//******************************//
//	
//	CurrentCulture				// Compares strings using culture-sensitive sort rules and the current culture
//	CurrentCultureIgnoreCase	// ^^ ignores the case of the strings being compared
//	
//	InvariantCulture			// Compares strings using culture-sensitive sort rules and the invariant culture
//	InvariantCultureIgnoreCase	// ^^ ignores the case of the strings being compared
//	
//	Ordinal						// Compares strings using ordinal (binary) sort rules
//	OrdinalIgnoreCase			// ^^ ignores the case of the strings being compared
//	
//**********************//
//*********************//


//***************************************//
// PATTERN MATCHING (Improved with C# 9 //
//*************************************//
//	
//	** These can be used to match variables with a type, or the type of another variable (i.e. if (variable1 is Type) checks if the variable IS a type...)
//	
//	Type						// Checks if a variable is a type
//	
//	Parenthesized				// Enforces or emphasizes the precedence of pattern combinations
//	
//	Conjuctive (and)			// Requires both patterns to match
//	
//	Disjunctive (or)			// Requires either pattern to match
//	
//	Negated (not)				// Requires a pattern doesn't match
//	
//	Relational					// Requires input to be less than, less than or equal, greater than, or greater than or equal
//	
//	Pattern combinator			// Allows multiple patterns to be used together
//	
//**********************//
//*********************//


//***********************//
// 
//*********************//
//	
//	
//	
//**********************//
//*********************//













