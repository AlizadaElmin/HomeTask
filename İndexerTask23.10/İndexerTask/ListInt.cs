using System.Text;

namespace İndexerTask;

public class ListInt
{
    private int[] _array=new int[0];

    public int this[int index]
    {
        get
        {
            return _array[index];
        }
        set
        {
            if (index >= 0 && index < _array.Length)
                _array[index] = value;
            else
                Console.WriteLine("Index dəyəri doğru deyil.");
        }
    }

    public void Add(int num)
    {
        Array.Resize(ref _array, _array.Length+1);
        _array[_array.Length - 1] = num;
    }

    public void Add(params int[] nums)
    {
        int index = _array.Length;
        Array.Resize(ref _array,_array.Length+nums.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            _array[index + i] = nums[i];
        }
    }

    public bool Contains(int num)
    {
        foreach (int digit in _array)
        {
            if (digit == num)
            {
                return true;
            }
        }

        return false;
    }

    public int Pop()
    {
        if (_array.Length == 0)
        {
            Console.WriteLine("Element yoxdur.");
            return 0;
        }
        int last = _array[_array.Length - 1];
        Array.Resize(ref _array,_array.Length-1);
        return last;
    }

    public int Sum()
    {
        int sum = 0;
        foreach (int num in _array)
        {
            sum += num;
        }

        return sum;
    }

    public override string ToString()
    {
        StringBuilder text = new StringBuilder();
        foreach (int num in _array)
        {
            text.Append(num);
            text.Append(" ");
        }

        return text.ToString();
    }

    public int IndexOf(int num)
    {
        for (int i = 0; i < _array.Length; i++)
        {
            if (_array[i] == num)
            {
                return i;
            }
        }

        return -1;
    }

    public int LastIndexOf(int num)
    {
        for (int i = _array.Length-1; i >= 0; i--)
        {
            if (_array[i] == num)
            {
                return i;
            }
        }

        return -1;
    }

    public void Insert(int num, int index)
    {
        if (index > _array.Length || index < 0)
        {
            Console.WriteLine("Index doğru daxil edilməyib.");
        }
        else
        {
            int[] newArr = new int[_array.Length + 1];
            for (int i = 0; i < index; i++)
            {
                newArr[i] = _array[i];
            }
            newArr[index] = num;
            for (int i = index; i < _array.Length; i++)
            {
                newArr[i + 1] = _array[i];
            }
            _array = newArr;
        }
        
    }

    public float Average()
    {
        // float sum = Sum();
        
        float sum = 0;
        float result = 0;
        if (_array.Length == 0)
        {
            return 0;
        }
        foreach (int num in _array)
        {
            sum += num;
        }
        
        result = sum / _array.Length;
        return result;
    }
    
}