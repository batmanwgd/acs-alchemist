General notes:

Notes on command line args:
 
 -s	: State Code
	+ State FIPS code (PA is 42, WY is 56.  Can be found online)
	
 -v	: Filter data by variable name file
	+ CSV file with two columns: first is the TableID of the variable you want from Sequence_Number_and_Table_Number_Lookup.xls, the second is a name to use for it in the exported shapefile.  Keep in mind that shapefile column names are limited to 10 characters, so any name longer than that will be truncated.
	
 -e	: Filter Spatially by Census Summary Level
	+ What level of geographic aggregation do you want?
	
 -f	: Filter Spatially by optional filename of WKT geometries
	+ Geometric mask
	
 -jobName        : Specify a name for this job / shapefile
 -replaceJob     : Replace an existing job / shapefile
 -exportToShape  : Export results to shapefile
 -exportToGrid   : Export results to fishnetted shapefile where value = # feet
 -gridEnvelope   : Align the grid cells to an envelope in a file
 -outputProjection: Provide the WKT of a desired projection to operate in
 -includeEmptyGridCells: Keeps empty grid cells during export
	+ Without this, any grid cells without values are dropped
  
 -outputFolder   : Specify where you'd like the results saved
 -preserveJam    : Optional flag to preserve jam values
	+ ACS uses "Jam" values in their columns to denote special things (like "data not available", etc)
	
 -listStateCodes : Displays a list of available state codes
	+ Shows valid options for states for -s flag?
	
 -listSummaryLevels: Displays a list of available boundary levels
	+ Shows valid options for summary levels flag "-e"

	
Three goals for this project:
	- Download the necessary data files from the ACS website and parse them into a usable format
	- Extract desired information from them in the form of shapefiles
	- The AcsImporter does the first two
	

AcsImporter: 
Things you absolutely need:
	State Code
	-v Variable file
	-e Summary level (no output without it)
	-exportToShape/exportToGrid  Output type
	
	
	