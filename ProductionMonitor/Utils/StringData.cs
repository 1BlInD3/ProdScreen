namespace ProductionMonitor.Utils
{
    /// <summary>
    /// A class used to store strings.
    /// </summary>
    public static class StringData
    {
        public static readonly string ScalaReadConnStr = @"data source=Scala1;
                                                           initial catalog = Fusetech; 
                                                           user id = scala_read; 
                                                           password=scala_read;";

        public static readonly string ScalaWriteConnStr = @"data source=Scala1;
                                                            initial catalog = Fusetech; 
                                                            user id = TERMELESMONITOR; 
                                                            password=TERM123;";

        public static readonly string[] Group1 = new string[]
        {
            "ÁRAMVÁLTÓ",
            "GCDAN",
            "LMM4",
            "NH-SPEC"
        };

        public static readonly string[] Group2 = new string[]
        {
           
            "HH",
            "MV",
            "BRAZING",
            "LINOCURSZER"
        };

        public static readonly string[] Group3 = new string[]
        {
            "HAL2",
            "HAL3",
            "TSA",
            "NH-WEBER"
        };

        public static readonly string[] Group4 = new string[]
        {

            "LM1",
            "LM2",
            "LM3",
            "LM4",
            "LMM",
            "LMMHC",
            "NH000W",
            "LMA000"  
        };

        public static readonly string[] Group5 = new string[]
        {
            "MULTIVERT00",
            "MV_MB-SPECIAL",
            "MULTIBLOC00",
            "MULTIVERT1-3",
            "FSD-ACCESSORIES",
            "MULTIBLOC1-3",
            "MULTIVERT1-3-4P"
                    
        };

        public static readonly string[] Group6 = new string[]
        {
            "FSD-FUSEBASE",
            "FSD-HANDLE"
        };
  
        public static readonly string[] Munkahelyek = new string[]
        {
            "GCDAN",
            "LINOCURSZER",
            "LINOCURALK",
            "LM4",
            "SZINTER",
            "BRAZING",
            //"HAL1",
            "HAL2",
            "HAL3",
            //"HALM",
            "HH",
            "HH MV EXTRA",
            "LM1",
            "LM2",
            "LM3",
            "LMA000",
            "LMM",
            //"LMM000",
            "LMM4",
            "LMMHC",
            //"MSM3",
            "MV",
            "NH-MERSEN EXTRA",
            "NH-MSCH EXTRA",
            "NH-SPEC",
            "NH-WEBER",
            "NH-WEBER EXTRA",
            "OLVADÓSZÁL",
            "SAJTOLÓ",
            "SPEC EXTRA",
            "TSA",
            "ÁRAMVÁLTÓ",
            "ÁRAMVÁLTÓ EXTRA",
            "WASTE",
            //"REWORK",
            "TROGGER"
        };

    }
}