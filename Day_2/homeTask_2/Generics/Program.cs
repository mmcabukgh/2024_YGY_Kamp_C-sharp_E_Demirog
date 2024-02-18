// See https://aka.ms/new-console-template for more information

List<string> sehirler = new List<string>();
sehirler.Add("Ankara");
sehirler.Add("Ankara");
sehirler.Add("Ankara");
sehirler.Add("Ankara");
sehirler.Add("Ankara");
sehirler.Add("Ankara");
Console.WriteLine("sehirler Sayısı : " + sehirler.Count);

MyList_N sehirler2 = new MyList_N();
sehirler2.Add("İstanbul");

// Artık bizim listemiz de Generic
MyList<string> sehirler3 = new MyList<string>();
sehirler3.Add("Ankara");
sehirler3.Add("Ankara");
sehirler3.Add("Ankara");
sehirler3.Add("Ankara");
sehirler3.Add("Ankara");
sehirler3.Add("Ankara");
sehirler3.Add("Ankara");
Console.WriteLine("sehirler3 Sayısı : " + sehirler3.Count);


class MyList_N //Normal klasik class tanımı
{
    public void Add(string item)
    {

    }
}

class MyList<T> //Generic class tanımı  -> T tip hatırlatması için seçilmiştir. Herşey seçilebilir.
{
    T[] _list = new T[0];
    T[] _tempList = new T[0];
    public void Add(T item)
    { 
        _tempList = _list;
        _list = new T[_list.Length + 1];
        for (int i = 0; i < _tempList.Length; i++)
        {
            _list[i] = _tempList[i];
        }
        _list[_list.Length - 1] = item;
    }

    public int Count
    {
        get { return _list.Length; }        
    }

}
