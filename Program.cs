class reginit


{
    public static void Writer(String s)
    {

        Console.WriteLine(s);


    }
    public static void lists(String[] ss)
    {
        foreach (String s in ss)
        {
            Writer(s);



        }



    }
    public static String[] sets(String[] ss, String s, String ss1)
    {
        String s1 = "";
        String[] h = { };
        int counts = 0;
        Array.Sort(ss);

        foreach (String s2 in ss)
        {
            s1 = s2.Trim();
            h = s1.Split('=');
            if (h.Length > 1)
            {

                if (h[0].Trim() == s.Trim())
                {
                    ss[counts] = h[0] + "=" + ss1;
                    return ss;
                }

            }
            counts++;
        }

        Array.Resize(ref ss, ss.Length + 1);
        ss[ss.Length - 1] = s + "=" + ss1;

        return ss;



    }
    public static String gets(String[] ss, String s)
    {
        String s1 = "";
        String[] h = { };
        Array.Sort(ss);

        foreach (String s2 in ss)
        {
            s1 = s2.Trim();
            h = s1.Split('=');
            if (h.Length > 1)
            {

                if (h[0].Trim() == s.Trim()) return h[1];

            }

        }
        return "";
    }

    public static void save(String[] ss, String files)

    {
        String Value = "";
        String v = "";
        foreach (String s in ss)
        {
            v = s.Replace("=", "\x02");
            Value = Value + v + "\x01";



        }
        File.WriteAllText(files, Value);


    }
    public static String[] Splint(String s)

    {
        String[] ss = s.Split("\n");
        return ss;

    }



}




class regchanges

{
    static String resource1 = "main/main=main\n" +
                       "main/system=system\n" +
                       "main/x=xxx\n" +
                       "system/main=mene\n" +
                       "system/system=main\n";


    public static void Main()

    {
        String[] ss = reginit.Splint(resource1);


        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine(reginit.gets(ss, "main/main"));
        ss=reginit.sets(ss,"main/char","#####");
        reginit.lists(ss);
        reginit.save(ss, "hello.dat");



    }






}

