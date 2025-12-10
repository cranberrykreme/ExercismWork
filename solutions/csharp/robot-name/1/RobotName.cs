public class Robot
{
    private static HashSet<string> prevNames = new HashSet<string>();
    private string _name = "";
    public string Name
    {
        get 
        {
            
            if(String.IsNullOrEmpty(_name))
            {
                var isDuplicate = true;
                while(isDuplicate)
                {
                    _name = "";
                    Random rand = new Random();
                    _name += (char)rand.Next('A', 'Z'+1);
                    _name += (char)rand.Next('A', 'Z'+1);
                    _name += (char)rand.Next('1', '9'+1);
                    _name += (char)rand.Next('1', '9'+1);
                    _name += (char)rand.Next('1', '9'+1);
                    if(prevNames.Add(_name))
                    {
                        isDuplicate = false;
                    }
                }
                
            }
            return _name;
        }
    }

    public void Reset()
    {
        _name = String.Empty;
    }
}