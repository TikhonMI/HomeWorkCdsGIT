    USING SYSTEM;
USING SYSTEM.IO;

    /// <SUMMARY>
    ///    CLASS TO CREATE AN UPPER CASE COPY OF A FILE
    /// </SUMMARY>
    PUBLIC CLASS COPYFILEUPPER
    {
		PUBLIC STATIC VOID MAIN()
		{
        STRING SFROM, STO;
        STREAMREADER SRFROM;
        STREAMWRITER SWTO;

        CONSOLE.WRITE("COPY FROM:");
        SFROM = CONSOLE.READLINE();

        CONSOLE.WRITE("COPY TO:");
        STO = CONSOLE.READLINE();

        CONSOLE.WRITELINE("COPY FROM {0} TO {1}", SFROM, STO);
        TRY
        {
            SRFROM = NEW STREAMREADER(SFROM);
            SWTO = NEW STREAMWRITER(STO);
            WHILE (SRFROM.PEEK() != -1)
            {
                STRING SBUFFER = SRFROM.READLINE();
                SBUFFER = SBUFFER.TOUPPER();
                SWTO.WRITELINE(SBUFFER);
            }
            SWTO.CLOSE();
            SRFROM.CLOSE();
        }
        CATCH (FILENOTFOUNDEXCEPTION)
        {
            CONSOLE.WRITELINE("INPUT FILE NOT FOUND");
        }
        CATCH (EXCEPTION E)
        {
            CONSOLE.WRITELINE("UNEXPECTED EXCEPTION");
            CONSOLE.WRITELINE(E.TOSTRING());
        }
    }       
    }
