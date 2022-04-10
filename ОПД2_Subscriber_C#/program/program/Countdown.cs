using System.Globalization;
using System.Text.RegularExpressions;

namespace program
{
    // �����, ����������� ��������
    public class CountDown
    {
        public delegate void Callback(string mess);

        Dictionary<string, Callback> events;

        public CountDown()
        {
            events = new Dictionary<string, Callback>();
        }

        // ��������� ���������� � �������
        public void AddEvent(string name, Callback mess)
        {
            events.Add(name, mess);
        }

        // ������� ����������
        public void DeleteEvent(string name)
        {
            events.Remove(name);
        }
        
        public void Timer(int delay, string mess)
        {
            if (delay < 0)
            {
                throw new ArgumentException("delay is negative");
            }
            Thread.Sleep(delay);
            foreach(var sub in events)
            {
                sub.Value(mess);
            }
        }

    }


    // ����� - ��������� 1
    public class Subscriber1
    {
        private string NameSub;
        public string message = "";

        public Subscriber1(CountDown cd, string name)
        {
            NameSub = name;
            cd.AddEvent(name, (mess) => Display(mess));
        }

        private void Display(string Textmess)
        {
            if(Textmess == null)
                throw new ArgumentNullException("message argument is null");
            message = NameSub + ", " + Textmess;
            Console.WriteLine(message);
        }
    }

    // ����� - ��������� 2
    public class Subscriber2
    {
        private string NameSub;
        public string message = "";

        public Subscriber2(CountDown cd, string name)
        {
            NameSub = name;
            cd.AddEvent(name, (mess) => Display(mess));
        }

        private void Display(string Textmess)
        {
            if (Textmess == null)
                throw new ArgumentNullException("message argument is null");
            message = NameSub + ", " + Textmess;
            Console.WriteLine(message);
        }
    }



}