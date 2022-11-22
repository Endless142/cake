namespace Cake
{
    public  class tort
    {
        private DateTime data = new DateTime();
        
        private int zakazik;
        public List<string> zakaziks = new List<string>();
        public tort()
        {
           
        }
        public void Zakaz(int vvod )
        {
            data = DateTime.Now;
            switch(vvod)
            {
                case 0:
                    zakaziks.Add("Без глазури");
                    break;
                case 1:
                    zakazik += 500;
                    zakaziks.Add("круг - 500");
                    break;
                
                case 2:
                    zakazik += 500;
                    zakaziks.Add("Ваниль - 500");
                    break;
                case 3:
                    zakazik += 500;
                    zakaziks.Add("1 корж - 500");
                    break;
                case 4:
                    zakazik += 500;
                    zakaziks.Add("Белая глазурь - 500");
                    break;
                case 5:
                    zakazik += 500;
                    zakaziks.Add("Ваш декор(готовый проект) - 500");
                    break;
                case 6:
                    zakazik += 600;
                    zakaziks.Add("Квадрат - 600");
                    break;
                case 7:
                    zakazik += 600;
                    zakaziks.Add("Клубничный вкус - 600");

                    break;
                case 8:
                    zakazik += 600;
                    zakaziks.Add("2 коржа - 600");
                    break;
                case 9:
                    zakazik += 600;
                    zakaziks.Add("Розовая глазурь - 600");
                    break;
                case 10:
                    zakazik += 700;
                    zakaziks.Add("Прямоугольник - 700");
                    break;
                case 11:
                    zakazik += 700;
                    zakaziks.Add("3 коржа - 700");
                    break;
                case 12:
                    zakazik += 700;
                    zakaziks.Add("Наш готовый декор - 700");
                    break;
                case 13:
                    zakazik += 800;
                    zakaziks.Add("Сердечко - 800");
                    break;
                case 14:
                    zakazik += 1000;
                    zakaziks.Add("Маленький(8 порций) - 1000");
                    break;
                case 15:
                    zakazik += 1000;
                    zakaziks.Add("Малина - 1000");
                    break;
                case 16:
                    zakazik += 1000;
                    zakaziks.Add("Совсместное составление декора - 1000");
                    break;
                case 17:
                    zakazik += 1200;
                    zakaziks.Add("Средний(10 порций) - 1200");
                    break;
                case 18:
                    zakazik += 1500;
                    zakaziks.Add("Большой(12 порций) - 1500");
                    break;
                case 19:
                    zakazik += 1500;
                    zakaziks.Add("4 коржа и больше - 1500");
                    break;
                case 20:
                    File.AppendAllText("D:\\Totiks", "\n");
                    File.AppendAllText("D:\\Totiks", "Заказ от:" + data);
                    foreach(string  i in zakaziks)
                    {
                        File.AppendAllText("D:\\Totiks",i);
                    }
                    File.AppendAllText("D:\\Totiks", "Заказ на сумму:" + zakazik);
                    Console.WriteLine("Вы сделали заказ, закройте программу ");

                    break;




            }
            
            
        }

        public string name;
        

    }
}