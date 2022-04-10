using NUnit.Framework;
using program;
using System;


namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // проверка на сообщени€
        [Test]
        public void TestSub1()
        {
            var Timer = new CountDown();
            var firstSubscriber = new Subscriber1(Timer, "Ivan");
            Timer.Timer(2000, "Caboom");
            Assert.AreEqual("Ivan, Caboom", firstSubscriber.message);
        }

        [Test]
        public void TestSub2()
        {
            var Timer = new CountDown();
            var secondSubscriber = new Subscriber2(Timer, "Kate");
            Timer.Timer(5000, "Hello");
            Assert.AreEqual("Kate, Hello", secondSubscriber.message);
        }

        // проверка на удаление
        [Test]
        public void TestDel()
        {
            var Timer = new CountDown();
            var subscriber = new Subscriber1(Timer, "Ivan");
            Timer.DeleteEvent("Ivan");
            Timer.Timer(2000, "Caboom");
            Assert.AreEqual("", subscriber.message);
        }

        // проверка на добавление подписчика (на подписку)
        [Test]
        public void CatchNullMesExc()
        {
            var Timer = new CountDown();
            var firstSubscriber = new Subscriber1(Timer, "Tom");
            CountDown.Callback mess = null;
            Timer.AddEvent("Ivan", mess);
            Assert.Throws<ArgumentNullException>(() => Timer.Timer(2000, null));
        }

        [Test]
        public void CatchNegDelExc()
        {
            var Timer = new CountDown();
            var firstSubscriber = new Subscriber1(Timer, "Ira");
            Assert.Throws<ArgumentException>(() => Timer.Timer(-2000, "Caboom"));
        }


        [Test]
        public void TestSeveralSubs()
        {
            var Timer = new CountDown();
            var firstSubscriber = new Subscriber1(Timer, "Rita");
            var secondSubscriber = new Subscriber2(Timer, "Mira");
            Timer.Timer(3000, "Caboom");
            string[] m = new string[] { firstSubscriber.message, secondSubscriber.message };
            Assert.AreEqual(new string[] { "Rita, Caboom", "Mira, Caboom" }, m);
        }

        [Test]
        public void TestNolSubs()
        {
            var Timer = new CountDown();
            Timer.Timer(2000, "Caboom");
        }

    }
}