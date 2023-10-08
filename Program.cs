namespace slavas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Автор: Player1, добро пожаловать в дом с загадками. Твоя главная задача выброться от сюда, собрав для этого три артефакта, но для начало давай введем твоя имя.");
            string name = Console.ReadLine();
            Console.WriteLine("Автор: " + name + "? неплохое имя, теперь я пожелаю тебе удачи, ну а мне нужно идти, у меня важные дела.");
            Console.WriteLine("игра: если ты готов, то напиши это слово (готов)");
            Console.ReadLine();
            Console.WriteLine("     ");
            Console.WriteLine("     ");
            Console.WriteLine("Игра: игрок " + name + " осматривается  и думает, что можно сделать");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("мысли: \n а) попробовать сразу открыть дверь. \n б) оглядеться");
            int art = 0;
            string choice = Console.ReadLine();
            bool isGotKey = false;
            string artefact = "артефакт";
            string key = "ключ";
            do
            {
                if (choice == "а")
                {
                    if (isGotKey == true)
                    {
                        Console.WriteLine("Дверь открыта!");
                        choice = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Дверь не открывается. Нужна отмычка!");
                        choice = Console.ReadLine();
                    }

                }
                else if (choice == "б")
                {

                    Console.WriteLine("Вы замечаете, что рядом с вами тумбочка ,и в нем два ящика.");
                    Console.WriteLine("Вы решаетесь  открыть 1 ящик и видите,что там пусто, но вы хотите посмотреть, что находится во втором ящике.");
                    Console.WriteLine("Подсказка: чтобы открыть 2 ящик нажмите(ф) ");
                    string choice1 = Console.ReadLine();
                    bool isGotKey1 = false;
                    do
                    {
                        if (choice1 == "ф")
                        {
                            if (isGotKey1 == false)
                            {
                                Console.WriteLine("Открыв ящик, вы находите " + key + " и первый  " + artefact);
                                art = art + 1;
                                Console.WriteLine("");
                                Console.WriteLine("Полученно новое достижение \n НАЧАЛО ПОЛОЖЕННО");
                                Console.WriteLine("Теперь, чтобы обернуться снова к двери нажмите снова  (ф)");
                                Console.ReadLine();

                                string choice2 = "ф";
                                bool isGotKey2 = false;
                                do
                                {
                                    if (choice2 == "ф")
                                    {

                                        Console.WriteLine("вы смотрите на дверь и понимаете, что этот ключ слишком мал для двери");
                                        Console.WriteLine("Но так же вы замечаете боковым зрением небольшую щель в стене. Вы подходите к ней и понимаете, что эта щель по форме ключа ,и вставляете его туда.");
                                        Console.WriteLine("Перед вами открылась тусклая тайная комната, где в середине находится стол, а на нем второй  артефакт");
                                        art = art + 1;
                                        Console.WriteLine("Вы забираете его и у вас теперь " + art + " артефакта");
                                        Console.WriteLine("После этого вы ничаете осматривать комнату и видите, что в темном углу кто-то есть, оно очень сильно было похоже на тело человека, которое  начинает позлти к вам, когда оно немного приблизилось силуэт стал четким и было понятно, что перед вами мертвец" +
                                            " от страха вы  начали бежать обратно в другую комнату, при этом случайно наступив на плитку. Комната начала сужаться, но вы благополучно успели выбраться от туда. Отдышавшись, взглянули на вверх с мольбой к богу о помощи, но заметили вентиляционную решетку, c третим артефактом и еще одним ключем." +
                                            " вы решили поставить тумбочку по ближе к этой решетке");
                                        Console.WriteLine("Подсказка: Чтобы двигать предметы нужно нажимать на цифры (сначало 1 потом 2 и т. д. пока не пододвините этот предмет");
                                        Console.ReadLine();
                                        int num = 0;
                                        do
                                        {
                                            if (num < 3)
                                            {
                                                num++;
                                                Console.WriteLine(name + " попробуй ещё раз!!");
                                                choice = Console.ReadLine();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Вы пододвинули тумбочку. Встали на нее и смогли открыть решетку там вы взяли новый ключ и третий " + artefact);
                                                art = art + 1;
                                                Console.WriteLine("Спустившись с тумбочки, вы подошли и открыли гланую дверь. перед вами появилась новая комната, где была панель с небольшими отверстиями. сразу было понятно, что надо вставить туда артефакты.");
                                                Console.WriteLine("Подсказка: чтобы вставить артефакты нажимайте от 1 до 3");
                                                Console.ReadLine();
                                                int num1 = 0;
                                                do
                                                {
                                                    if (num1 < 2)
                                                    {
                                                        num1++;
                                                        Console.WriteLine(name + " Вставьте все артефакты!!");
                                                        Console.ReadLine();
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Поставив все артефакты, перед вами появился портал, который введет домой. Вы вошли в него.....(Затемнение)Поздравляю вы прошли игру!!");
                                                        Console.ReadLine();
                                                    }

                                                } while (num1 > 0);
                                            }

                                        } while (num > 0);

                                    }
                                    else
                                    {
                                        Console.WriteLine("Начните игру заново)");
                                        Console.ReadLine();
                                    }

                                } while (isGotKey2 == false);


                            }
                            else
                            {
                                Console.WriteLine("вы облажались, начните заново");
                                Console.ReadLine();
                            }


                        }
                        else if (choice1 != "ф")
                        {
                            Console.WriteLine("Попробуйте заново");
                        }

                    } while (isGotKey == false);


                }
            } while (isGotKey == false);




        }
    }
}