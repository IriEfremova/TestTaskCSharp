// See https://aka.ms/new-console-template for more information

using var input = new StreamReader(Console.OpenStandardInput());
//using var input = new StreamReader("2");//12.8752831
using var output = new StreamWriter(Console.OpenStandardOutput());
//StreamWriter output = new StreamWriter("./Test11.txt");
var fstVar = input.ReadLine();
try
{
    var strResult = new System.Text.StringBuilder();
    int count = int.Parse(fstVar);
    DateTime time = DateTime.Now;
    for (int c = 0; c < count; c++)
    {
        //Dictionary<char, int> trdMsg = new Dictionary<char, int>();
        var scnVar = input.ReadLine();
        int cntMsg = int.Parse(scnVar);
        string str = input.ReadLine();

        char[] trdMsg = new char[cntMsg];
        int[] usMsg = new int[cntMsg];

        bool ans = true;
        int cntX = 0, cntY = 0, cntZ = 0;
        int pos = cntMsg - 1;

        for (int i = 0; i < cntMsg; i++)
        {
            trdMsg[i] = str[i];
            usMsg[i] = 1;
            switch (str[i])
            {
                case 'X': cntX++; break;
                case 'Y': cntY++; break;
                case 'Z': cntZ++; break;
            }
        }

        if (trdMsg[0] == 'Z' || trdMsg[cntMsg - 1] == 'X' || cntX > cntMsg / 2 || cntY > cntMsg / 2 || || cntZ > cntMsg / 2)
        {
            strResult.AppendLine("No");
            break;
        }

        for(int i = 0; i < cntMsg; i++)
        {
            if (trdMsg[i] == 'Y' && usMsg[j] == '1')
            {
                int j = i + 1;
                while (trdMsg[j] != 'Z' && usMsg[j] == '1')
                {
                    j++;
                }
                usMsg[j] = '0';
                usMsg[j] = '0';
                cntY--;
                cntZ--;
            }

            if (trdMsg[i] == 'X' && usMsg[j] == '1')
            {
                if(cntY > cntZ )
                {
                    int j = i + 1;
                    while (trdMsg[j] != 'Z' && usMsg[j] == '1')
                    {
                        j++;
                    }
                    usMsg[j] = '0';
                    usMsg[j] = '0';
                    cntY--;
                    cntZ--;
                }
                else
                {

                }
            }
        }



   
            for (int i = 0; i < cntMsg; i++)
            {
                Console.Write(trdMsg[0, i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < cntMsg; i++)
            {
                Console.Write(trdMsg[1, i] + " ");
            }
            Console.WriteLine();

    output.Write(strResult);
    //output.Close();
    //Console.WriteLine(DateTime.Now - time);
}
catch (Exception e)
{
    output.Write("Exception Error: " + e.Message);
}


/*
//7 задача Codenames
using var input = new StreamReader(Console.OpenStandardInput());
//using var input = new StreamReader("59");//12.8752831
using var output = new StreamWriter(Console.OpenStandardOutput());
var fstVar = input.ReadLine();
try
{
    var strResult = new System.Text.StringBuilder();
    int count = int.Parse(fstVar);
    DateTime time = DateTime.Now;
    for (int c = 0; c < count; c++)
    {
        var scnVar = input.ReadLine().Split();
        int cntAll = int.Parse(scnVar[0]);
        int cntBlue = int.Parse(scnVar[1]);
        int cntRed = int.Parse(scnVar[2]);
        int numBlack = int.Parse(scnVar[3]);

        HashSet<string> setAllWords = new HashSet<string>();
        Dictionary<string, int> vW = new Dictionary<string, int>();

        string blackWord = "";

        for (int i = 0; i < cntAll; i++)
        {
            var s = input.ReadLine();
            if (i < cntBlue)
            {
                List<string> sub = new List<string>();
                for (int j = 0; j < s.Length; j++) //с какой позиции
                {
                    for (int k = 1; k < s.Length; k++) //сколько символов
                    {
                        if (j + k <= s.Length)
                        {
                            string substr = s.Substring(j, k);
                            if (!sub.Contains(substr))
                            {
                                sub.Add(substr);
                            }
                        }
                    }
                }
                foreach (var str in sub)
                {
                    if (vW.ContainsKey(str))
                        vW[str]++;
                    else
                        vW.Add(str, 1);
                }
            }

            if (i >= cntBlue && i < cntBlue + cntRed)
            {
                List<string> sub = new List<string>();
                for (int j = 0; j < s.Length; j++) //с какой позиции
                {
                    for (int k = 1; k < s.Length; k++) //сколько символов
                    {
                        if (j + k <= s.Length)
                        {
                            string substr = s.Substring(j, k);
                            if (!sub.Contains(substr))
                            {
                                sub.Add(substr);
                            }
                        }
                    }
                }

                foreach (var str in sub)
                {
                    if (vW.ContainsKey(str))
                    {
                        vW[str]--;
                        if (vW[str] < 0)
                            vW.Remove(str);
                    }
                }
            }
            if (i == numBlack - 1)
                blackWord = s;

            setAllWords.Add(s);
        }

        for (int j = 0; j < blackWord.Length; j++) //с какой позиции
        {
            for (int k = 1; k < blackWord.Length; k++) //сколько символов
            {
                if (j + k <= blackWord.Length)
                {
                    string substr = blackWord.Substring(j, k);
                    vW.Remove(substr);
                }
            }
        }

        foreach (var str in setAllWords)
        {
            vW.Remove(str);
        }

        if (vW.Count == 0)
            strResult.AppendLine("nichego 0");
        else
        {
            strResult.AppendLine(vW.MaxBy(entry => entry.Value).Key + " " + vW.Values.Max());
        }
    }
    output.Write(strResult);
    Console.WriteLine(DateTime.Now - time);
}
catch (Exception e)
{
    output.Write("Exception Error: " + e.Message);
}
*/

/*
//7 задача Карточки
using var input = new StreamReader(Console.OpenStandardInput());
//using var input = new StreamReader("99");//20.39
using var output = new StreamWriter(Console.OpenStandardOutput());
var fstVar = input.ReadLine();
try
{
    var strResult = new System.Text.StringBuilder();
    int count = int.Parse(fstVar);
    DateTime time = DateTime.Now;
    for (int c = 0; c < count; c++)
    {
        bool result = true;
        bool minus = false;
        var scnVar = input.ReadLine().Split();
        int cntWindows = int.Parse(scnVar[0]);
        int cntUsers = int.Parse(scnVar[1]);

        var lstVar = input.ReadLine().Split();
        int[] arrInput = new int[cntUsers];
        int[] receptions = new int[cntUsers];
        int[] arrPosition = new int[cntUsers];
        for (int i = 0; i < cntUsers; i++)
        {
            arrInput[i] = Int32.Parse(lstVar[i]);
            receptions[i] = Int32.Parse(lstVar[i]);
            arrPosition[i] = i;
        }
        Array.Sort(receptions, arrPosition);
        //output.WriteLine("receptions[i] = " + string.Join(" ", receptions));
        int[] arrResult = new int[cntUsers];
        if (receptions[0] > 1)
        {
            receptions[0] = (receptions[0] - 1);
            arrResult[0] = -1;
        }

        for (int i = 1; i < cntUsers; i++)
        {
            if (receptions[i] - receptions[i - 1] > 1)
            {
                receptions[i] = receptions[i] - 1;
                arrResult[i] = -1;
            }
            else if (receptions[i] - receptions[i - 1] == 0)
            {
                receptions[i] = receptions[i] + 1;
                arrResult[i] = 1;
            }
            else if (receptions[i - 1] - receptions[i] >= 1)
            {
                result = false; break;
            }
        }
        if (receptions[cntUsers - 1] > cntWindows)
            result = false;

        if (!result)
            strResult.Append("x");
        else
        {
            int[] res = new int[cntUsers];
            var str = new System.Text.StringBuilder();
            for (int i = 0; i < cntUsers; i++) 
            {
                res[arrPosition[i]] = receptions[i] ;
            }
            for (int i = 0; i < cntUsers; i++)
            {
                if (res[i] - arrInput[i] == 0)
                {
                    strResult.Append("0");
                }
                else if (res[i] - arrInput[i] < 0)
                {
                    strResult.Append("-");
                }
                else
                {
                    strResult .Append("+");
                }
            }
        }
        if (c < count - 1)
            strResult.Append("\n");
    }
    output.Write(strResult);
    //Console.WriteLine(DateTime.Now - time);
} 
catch (Exception e)
{
    output.Write("Exception Error: " + e.Message);
}
*/

/*
//6 задача Карточки
using var input = new StreamReader(Console.OpenStandardInput());
//using var input = new StreamReader("52"); //9сек
using var output = new StreamWriter(Console.OpenStandardOutput());

var s = input.ReadLine().Split();
try
{
    //DateTime time = DateTime.Now;
    int cntFriends = int.Parse(s[0]);
    int cntCards = int.Parse(s[1]);

    var s1 = input.ReadLine().Split();
    int[] arrCard = new int[cntFriends];
    int[] arrResult = new int[cntFriends];

    for (int i = 0; i < cntFriends; i++)
    {
        arrCard[i] = Int32.Parse(s1[i]);
        arrResult[i] = i;
    }

    Array.Sort(arrCard, arrResult);

    int[] list = new int[cntCards];
    for (int i = 0; i < cntCards; i++)
    {
        list[i] = i + 1;
    }
    int iCard = list.Length - 1;
    int numFr = cntFriends - 1;
    while (numFr >= 0)
    {
        iCard = GetCardFromList(list, arrCard[numFr], iCard);
        if (iCard == -1)
        {
            output.WriteLine("-1");
            //Console.WriteLine(DateTime.Now - time);
            return;
        }
        arrCard[numFr] = list[iCard];
        list[iCard] = -1;
        numFr--;
    }

    int[] res = new int[cntFriends];
    for (int i = 0; i < arrCard.Length; i++)
    {
        res[arrResult[i]] = arrCard[i];
    }
    output.WriteLine(string.Join(" ", res));
    //Console.WriteLine(DateTime.Now - time);
}
catch (Exception e)
{
    output.Write("Exception Error: " + e.Message);
}


int GetCardFromList(int[] cards, int friendCard, int index)
{
    for (int i = index; i >= 0; i--)
    {
        if (friendCard < cards[i])
        {
            return i;
        }
    }
    return -1;
}
*/


/*
//5 задача Ваня и вирусный файл
using System.Text.Json;
using VirusCleaner;

// 10 тест - 14 сек
using var input = new StreamReader(Console.OpenStandardInput());
//using var input = new StreamReader("12");
using var output = new StreamWriter(Console.OpenStandardOutput());

var fstVar = input.ReadLine();
if (fstVar == null)
    return;

try
{
    //DateTime time = DateTime.Now;

    JsonSerializerOptions option = new JsonSerializerOptions { MaxDepth = 1000 };
    int count = int.Parse(fstVar);
    string result = "";
  
    for (int i = 0; i < count; i++)
    {
        var sndVar = input.ReadLine();
        if (sndVar == null)
            return;
        int strCount = int.Parse(sndVar);
        var sb = new System.Text.StringBuilder();
        for (int j = 0; j < strCount; j++)
        {
            sb.AppendLine(input.ReadLine());
        }

        FolderStructure? folderStructure =
                JsonSerializer.Deserialize<FolderStructure>(sb.ToString(), option);
        result += folderStructure?.getCountVirusFiles() + "\n";             
    }
    Console.WriteLine(result);
    //Console.WriteLine(DateTime.Now-time);
}
catch (Exception e)
{
    output.Write("Exception Error: " + e.Message);
}

namespace VirusCleaner
{
    public class FolderStructure
    {
        public string? dir { get; set; }
        public string[]? files { get; set; }
        public List<FolderStructure>? folders { get; set; }

        public int getCountVirusFiles()
        {
            return getCountVirusFiles(this);
        }

        private int getCountVirusFiles(FolderStructure dir, bool DirHack = false)
        {
            int count = 0;
            bool hasHack = false;

            if (DirHack || (dir.files != null && dir.files.Any(s => s.Contains(".hack"))))
                hasHack = true;

            if (hasHack)
            {
                if (dir.files != null)
                    count += dir.files.Length;
            }

            if (dir.folders != null)
            {
                foreach (FolderStructure innerStruct in dir.folders)
                        count += getCountVirusFiles(innerStruct, hasHack);
            }
            return count;
        }
    }
}

*/


/*
//4 задача Результаты соревнования
using var input = new StreamReader(Console.OpenStandardInput());
using var output = new StreamWriter(Console.OpenStandardOutput());

var fstVar = input.ReadLine();
if (fstVar == null)
    return;

int athletsCount;
try
{
    int count = int.Parse(fstVar);
    for (int i = 0; i < count; i++)
    {
        var sndVar = input.ReadLine();
        if (sndVar == null)
            return;
        athletsCount = int.Parse(sndVar);

        int[] athleticsNum = new int[athletsCount];
        int[] athleticsRes = new int[athletsCount];

        int[] resultList = new int[athletsCount];

        var thdVar = input.ReadLine().Split();
        for (int j = 0; j < athletsCount; j++)
        {
            athleticsNum[j] = j;
            athleticsRes[j] = int.Parse(thdVar[j]);
        }

        Array.Sort(athleticsRes, athleticsNum);

        int num = 1;
        resultList[athleticsNum[0]] = num;
        for (int j = 1; j < athleticsRes.Length; j++)
        {
            num++;
            if (athleticsRes[j] - athleticsRes[j - 1] > 1)
                resultList[athleticsNum[j]] = num;
            else
                resultList[athleticsNum[j]] = resultList[athleticsNum[j - 1]];
        }
        //output.WriteLine(string.Join(" ", resultList));
        for (int j = 0; j < resultList.Length; j++)
        {
            Console.Write(resultList[j] + " ");
        }
        Console.WriteLine();
    }

}
catch (Exception e)
{
    output.Write("Exception Error: " + e.Message);
}
*/


/*
//3 задача Оповещения
using var input = new StreamReader(Console.OpenStandardInput());
using var output = new StreamWriter(Console.OpenStandardOutput());
var s = input.ReadLine().Split();

if (s != null)
{
    try
    {
        int cntUsers = int.Parse(s[0]);
        int cntQueries = int.Parse(s[1]);

        //userQueries: номер элемента - номер пользователя, значение элемента - номер последнего запроса
        Dictionary<int, int> userQueries = new Dictionary<int, int>();
        int numAllNotification = 0;
        List<int> resultList = new List<int>();

        int numQuery = 0;
        for (int i = 0; i < cntQueries; i++)
        {
            var query = input.ReadLine().Split();
            if (query != null)
            {
                int type = int.Parse(query[0]);
                int user = int.Parse(query[1]);
                if (type == 1)
                {
                    numQuery++;
                    if (user == 0)
                    {
                        numAllNotification = numQuery;
                    }
                    else
                    {
                        if (userQueries.ContainsKey(user))
                            userQueries[user] = numQuery;
                        else
                            userQueries.Add(user, numQuery);
                    }
                }
                if (type == 2)
                {
                    int num = numAllNotification;
                    if (userQueries.ContainsKey(user) && userQueries[user] > numAllNotification)
                    {
                        num = userQueries[user];
                    }

                    resultList.Add(num);
                }
            }
        }

        output.WriteLine(string.Join("\n", resultList));
    }
    catch (Exception e)
    {
        output.Write("Exception Error: " + e.Message);
    }
}

*/


/*
//2 задача Наклейки
using var input = new StreamReader(Console.OpenStandardInput());
using var output = new StreamWriter(Console.OpenStandardOutput());

var startSticker = input.ReadLine();
if (startSticker != null)
{
    var cntNewSticker = input.ReadLine();
    if (cntNewSticker != null)
    {
        try
        {
            string endSticker = startSticker;
            int n = int.Parse(cntNewSticker);
            for (int i = 0; i < n; i++)
            {
                var l = input.ReadLine().Split();
                if (l != null)
                {
                    int a = int.Parse(l[0]);
                    int b = int.Parse(l[1]);
                    string s = l[2];
                    endSticker = applySticker(endSticker, a, b, s);
                }               
            }
            output.WriteLine(endSticker);
        }
        catch (Exception e)
        {
            output.Write("Exception Error: " + e.Message);
        }
    }
}


string applySticker(string sticker, int startPos, int endPos, string str)
{
    return sticker.Substring(0, startPos - 1) + str + sticker.Substring(endPos);
}

*/

/*
//1 задача Сумматор
using var input = new StreamReader(Console.OpenStandardInput());
using var output = new StreamWriter(Console.OpenStandardOutput());

var s = input.ReadLine();
if(s != null && s.Length > 0)
{
    try
    {
        int n = int.Parse(s);
        int[] sum = new int[n];
        for (int i = 0; i < n; i++)
        {
            var l = input.ReadLine().Split();
            if (l != null)
            {
                int a = int.Parse(l[0]);
                int b = int.Parse(l[1]);
                sum[i] = a + b;
            }
        }
        for (int i = 0; i < n; i++)
        {
            output.WriteLine(sum[i]);
        }
    }
    catch(Exception e) {
        output.Write("Exception Error: " + e.Message);
    }
}
*/


