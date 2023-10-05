// Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками
// маленкие "к" заменить большими "К",
// а большие "С" заменить маленькими "с"


// string s = "qwety"
//             01234
// s[3] // r
string text = "- Ядумаю,- сказал князь, улыбнись, - что," + "ежели бы вас послали вместо нашего князя" + "князь был бы не князем, простым солдатом" + "и еще какая то чуш на С, например сметана + картошка";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Lenght;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '-');
Console.WriteLine(newText);