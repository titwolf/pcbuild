﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcBuild
{
    partial class GameMenu //класс logs, продолжает форму gamemenu
    {
        #region intro
        public static string intro1 = "Привет, Ilon! \n Это - твой друг Сэм. Дело в том, что я владею небольшой мастерской по ремонту компьютеров и относительно недавно," +
            "меня пригласили поработать в другой штат. \n Дела у меня четсно говоря с мастерской не очень были." +
            "\n То термопасту забуду нанести, то на комплектующие денег совсем уже не было, иногда даже забывал заказывать их." +
            "\n В общем, мастерскую передаю тебе на время, ты вроде как по больше моего разбираешься в этом." +
            "\n Если сможешь месяц продержаться и дела у тебя в гору пойдут, то мастерская останется тебе!" +
            "\n И не забывай что в конце месяца будут приходить комунальные счета. Не забывай их во время оплачивать." +
            "\n Удачи в работе, верю в тебя!";
        public static string intro2 = "Привет, Eva&Gretta! \n Это - ваш дядя Сэм. Дело в том, что я владею небольшой мастерской по ремонту компьютеров и относительно недавно," +
            "меня пригласили поработать в другой штат. \n Дела у меня четсно говоря с мастерской не очень были." +
            "\n То термопасту забуду нанести, то на комплектующие денег совсем уже не было, иногда даже забывал заказывать их." +
            "\n В общем, мастерскую оставляю пока что на вас, Eva вроде как интересовалась раньше этим. Ну и Gretta заодно подучится \n да и два мозга лучше чем одни." +
            "\n Если сможете месяц продержаться и дела у вас в гору пойдут, то мастерская останется вам!" +
            "\n И не забывайте что в конце месяца будут приходить комунальные счета. Не забывайте их во время оплачивать." +
            "\n Удачи в работе, верю в вас!";
        #endregion intro


        List<string[]> mes = new List<String[]>();
        List<string[]> ans0 = new List<String[]>();
        List<string[]> ans1 = new List<String[]>();
        List<string[]> ans2 = new List<String[]>();
        List<string[]> ans3 = new List<String[]>();

        private void fmes1()
        {
            //tasks
            mes.Add(new string[5] { "Проверка на вирусы", "Помоги, а? Компьютер тормозит, может я нажал что-то не то и там вирусы?", "Удалить вирусы", "100", "1" });
            mes.Add(new string[5] { "Чистка системного блока", "Слушай бро! Мой комп что-то стал тормозить и сильно греться в последнее время. Может его нужно почистить?", "Чистка от пыли", "150", "2" });
            //answer1
            ans0.Add(new string[2] { "Установить антивирус, ждать когда он сам найдет угрозы, удалить найденые вирусы, удалить антивирус.", "0" });
            ans0.Add(new string[2] { "Установить антивирус, обновить сигнатуры вирусов, запустить полную проверку, удалить найденые вирусы.", "1" });
            ans0.Add(new string[2] { "Скинуть с флешки DrWeb Curelt, скачанный в прошлом году, запустить полную проверку, удалить найденые вирусы.", "0" });
            //answer2
            ans1.Add(new string[2] { "Отключить полностью системный блок, снять боковую крышку, пройтись кисточкой, поставить крышку обратно.", "0" });
            ans1.Add(new string[2] { "Открыть боковую системник, продуть пыль ртом, закрыть системник обратно, провертить на работоспособность.", "0" });
            ans1.Add(new string[2] { "Отсоединить все провода от системника, открыть боковую крышку, тщательно пройтись балоном с воздухом, закрыть системник, проверить на работоспособность.", "1" });
        }
        private void fmes2()
        {
            mes.Clear();
            //tasks
            mes.Add(new string[5] { "Установка драйверов", "Здравствуйте, я недавно переустановил виндовс, и сейчас он требует какие-то компоненты, что это такое?", "Установить драйвер пак", "250", "2" });
            mes.Add(new string[5] { "Чистка системного блока", "Слушай бро! Мой комп что-то стал тормозить и сильно греться в последнее время. Может его нужно почистить?", "Чистка от пыли", "150", "3" });
            mes.Add(new string[5] { "Замена термопасты", "Привет, у меня что-то часто начал греться комп, я его чистил, но ничего не изменилось. Посмотришь?", "Заменить термопасту на процессоре", "500", "1" });
            //answer1
            ans0.Add(new string[2] { "Включить компьютер и вставить флешку с паком драйверов, запустить приложение, дождаться установки всех нужных компонентов, извлечь флешку.", "1" });
            ans0.Add(new string[2] { "Подключить компьютер, скачать сторонний драйвер установочник из интернета, дождаться установки.", "0" });
            //answer2
            ans1.Add(new string[2] { "Отключить полностью системный блок, снять боковую крышку, пройтись кисточкой, поставить крышку обратно.", "0" });
            ans1.Add(new string[2] { "Открыть боковую системник, продуть пыль ртом, закрыть системник обратно, провертить на работоспособность.", "0" });
            ans1.Add(new string[2] { "Отсоединить все провода от системника, открыть боковую крышку, тщательно пройтись балоном с воздухом, закрыть системник, проверить на работоспособность.", "1" });
            //answer3
            ans2.Add(new string[2] { "Открыть системник, извлечь процессор, капнуть термопасты, вставить процессор, закрыть системник", "0" });
            ans2.Add(new string[2] { "Открыть системник, отсоединить охлаждение, нанести новую термопасту по верх старой, закрыть системник.", "0" });
            ans2.Add(new string[2] { "Отсоединить все провода, открыть системник, отсоеденить охлаждение, стереть старую термопасту, нанести новую на место старой, поставить охлаждение, подключить все обратно, закрыть системник.", "1" });
        }
        
        private void fmes3()
        {
            mes.Clear();
            //tasks
            mes.Add(new string[5] { "Установка Windows", "Здравствуйте, я не давно купил ноутбук, но не поглядел что на нем не установлена ОС, помогите пожалуйста", "Установить ОС", "500", "3" });
            mes.Add(new string[5] { "Повышение частоты процессора", "Привет дружище, я тут купил новый процессор, и знаю что его можно разогнать, было бы не плохо, если бы ты сделал это.", "Разогнать процессор", "500", "1" });
            mes.Add(new string[5] { "Чистка подставки ноутбука.", "Здравствуйте, относительно недавно купила подставку для ноутбука, что бы он не грелся, но спустя время пользования, она насобирала много пыли. Честно говоря я не знаю как ее чистить, надеюсь вы поможете, плачу хорошо!", "Чистка подставки", "1000", "3" });
            mes.Add(new string[5] { "Чистка девайсов", "Привет, у меня механическая клавиатура, и она уже подзабилась всякой дрянью, не мог бы ты почистить, а то я просто не умею?", "Очистить клавиатуру", "500", "3" });
            //answer1
            ans0.Add(new string[2] { "Подключить компьютер, вставить флешку в компьютер с ОС windows, запустить компьютер и зайти в биос, там выбрать установку ОС и дождаться окончании загрузки.", "1" });
            ans0.Add(new string[2] { "Зайти в папку флешки, открыть установочник виндовс, дождаться конца установки", "0" });
            ans0.Add(new string[2] { "Открыть системник, вставить и вытащить плашки оперативной памяти, запустить компьютер", "0" });
            ans0.Add(new string[2] { "Велючить компьютер, зайти на сайт загрузки ОС виндовс, скачать установочник, запустить, пройти настройку установочника, запустить установку, дождаться установки", "0" });
            //answer2
            ans1.Add(new string[2] { "Запустить компьютер, зайти на сайт бенчмарк, запустить тест, дождаться окончания результатов.", "0" });
            ans1.Add(new string[2] { "Включить компьютер, запустить приложение, которое сильно нагрузит компьютер, подождать некоторое время.", "0" });
            ans1.Add(new string[2] { "Запустить компьютер, зайти в биос, зайти в настройки CPU, поставить максимальное значение гегагерц, после чего зайти в любое тяжелое приложение, и протестировать", "1" });
            //answer3
            ans2.Add(new string[2] { "Открыть аккуратно подставку, продуть балончиком с воздухом подставку от пыли, закрыть подставку обратно.", "1" });
            ans2.Add(new string[2] { "Открыть подставку, достать вентиляторы, промыть под водой, сполоснуть саму подставку, собрать все обратно.", "0" });
            //answer4
            ans3.Add(new string[2] { "Нужным приспособлениеями, аккуратно достать все клавиши, почистить клавиатуру, поставить все клавиши обратно как они были расположены.", "1" });
            ans3.Add(new string[2] { "Разобрать клавиатуру, промыть клавиатуру и клавиши водой, поставить буквы в алфавитном порядке", "0" });
            ans3.Add(new string[2] { "Нужным приспособлениеями, аккуратно достать все клавиши, почистить клавиатуру, поставить клавиши в хаотичном порядке.", "0" });
        }
        private void fmes4()
        {
            mes.Clear();
            mes.Add(new string[5] { "Замена видеокарты", "Привет, мне посоветавал тебя один знакомый, сказал не плохо выполняешь работу. Я решил видеокарту свою обновить, заказал новую, а вот заменить не особо понимаю как. Поможешь?", "Установить новую видеокарту.", "250", "1" });
            mes.Add(new string[5] { "Сборка компьютера", "Здравствуйте, пишу вам с просьбой о помощи. Хотел сыну подрать на день рождение компьютер, но не сильно в них разбераюсь. Я слышал что дешевле будет по частям его отдельно собрать, не мог бы ты, подобрать комплектующие, а я их закажу. Бюджет, до $1000 Деньгами не обижу!", "Подобрать комплектующие для сборки компьютера.", "800", "4" });
            mes.Add(new string[5] { "Уборка системного блока", "Привет, кажется мой системник умирает от пыли. Не мог бы ты его открыть и прочистить все там? Заодно, по возможности упорядочи там проводку, если будет не трудно. Спасибо за ранее!", "Привести в порядок системный блок.", "350", "5" });
            //answer1
            ans0.Add(new string[2] { "Аккуратно открыть крышку системного блока, отсоединить видеокарту, закрыть обратно системный блок.", "0" });
            ans0.Add(new string[2] { "Вскрыть системный блок, оторваать шлейфы видеокарты, изъять саму видеокарту, затем выкинуть старую видеокарту, и кинуть в системный блок новую. Закрыть системный блок и отправить его обратно заказчику.", "0" });
            ans0.Add(new string[2] { "Открыть системный блок, аккуратно изъять старю видеокарту, затем продуть от пыли материнскую плату. Достать из коробки новую видеокарту, и аккуратно вставить ее в материнскую плату. Проверить работоспособность.", "1" });
            ans0.Add(new string[2] { "Аккуратно открыв системный блок, изъять плашки оперативной памяти, и заменить старую карту на новую.", "0" });  //сделать подвох..
            //answer2
            ans1.Add(new string[2] { "Открыть поисковую систему, по результатам поиска перейти по первой попавшейся ссылки, и собрать комплектующие наобум.", "0" });
            ans1.Add(new string[2] { "Заайти на проверенный маркет. Найти нужные комплектующие не заходя за рамки бюджета, при этом, комплектующие не будут конфликтоваать друг с другом.", "1" });
            ans1.Add(new string[2] { "Зайти наа сайт маркета с готовыми сборками компьютеров, скопировать список комплектующих и отослать их заказчику.", "0" });
            //answer3
            ans2.Add(new string[2] { "Варварски вскрыть системный блок, оторвав при этом все крепежи. Продуть всю пыль ртом, попутно забрызгав все слюнями, заодно забрать плашки оперативной памяти себе.", "0" });
            ans2.Add(new string[2] { "Открыть системный блок аккуратно сняв боковую крышку. Взяв кисточку, почистить только видные места от пыли.", "0" });
            ans2.Add(new string[2] { "Открыть системный блок, все аккуратно прочистить, и поменять установленные комплектующие, на более старые и изъезженные.", "0" });
            ans2.Add(new string[2] { "Оставить системный блок, ничего в нем не чистив. Сообщить заказчику, что работа выполена.", "0" });
            ans2.Add(new string[2] { "Открыть системный блок аккуратно снаяв боковую крышку. Изъять все комплектующие. Индивидуально, аккуратно прочистить каждое комплектующее. Пропылесосить и протереть системный блок, после чего собрать все в единое целое, и проверить на работоспособность.", "1" });
        }

        private void fmes5()
        {
            mes.Clear();
            mes.Add(new string[5] { "Заменить плашки оперативной памяти.", "Здравствуйте, такая просьба. В компьютере моего сына, видимо сгорела плашка оперативной памяти. Я уже заказал новую, и она будет в комплекте. Не могли бы вы заменить ее? Просто я сам сейчас в отъезде, а сын, не думаю что справится. ", "Заменить оперативную плашку оперативной памяти.", "250", "1" });
            mes.Add(new string[5] { "Починка клавиатуры ноутбука.", "Привет, на ноутбуке что-то клавиатура стала плохо реагировать, может быть забилась, а может и вовсе нужно на новую менять. Даа и пара клавиш вылетает при нажатии. Можешь посмотреть?", "Чистка клвиатуры ноутбука.", "200", "4" });
            mes.Add(new string[5] { "Замена СО на процессоре.", "Здравствуйте, недавно сломался кулер в моем компьютере, заказал новый, а заменить сам не понимаю как. Не могли бы посмотреть?", "Заменить СО.", "200", "2" });
            mes.Add(new string[5] { "Провести диагностику.", "Добрый день! Такая ситуация, после грозы, при включении компьютера, работа длиться максимум 5 минут. После чего системный блок греется, и выключается. Я было думал, что погорела система охлождения, но нет, она работает, да и нагрузку ему маленькую даю, не должен нагреваться вовсе. В общем, посмотрите пожалуйста.", "Провести диагностику системного блока.", "50", "1" });
            //answer1
            ans0.Add(new string[2] { "Открыть системный блок, методом исключения обнаружить неисправную плашку, аккуратно изъять старую плашку оперативной памяти, после вставить на это место, новую.", "1" });
            ans0.Add(new string[2] { "Оторвать крышку системного блока. Вырвать все плашки оперативной памяти, после вставить одну новую, и замотать системный блок в пакет, так как крышка быва вырвана.", "0" });
            ans0.Add(new string[2] { "Аккуратно открыть системный блок, снять кулер с процессора, изъять сгоревшую плашку оперативной памяти, положить новую плашку оперативной памяти в системный блок, примотав ее изолентой, что бы не бултыхалась, закрыть системный блок.", "0" });
            ans0.Add(new string[2] { "Ничего не делать. Оствить новую плашку памяти себе, сообщить что работа выполнена.", "0" });

            ans1.Add(new string[2] { "Перевенуть ноутбук, аккуратно маленькой отверткой открутить болты, не сорвар резьбу. Аккуратно снять крышку ноутбука, изъяв клавиатур. Прочистить и продуть всю клавиатуру, после собрать всю конструкцию в единое целое. Проверить на работоспособность.", "1" });
            ans1.Add(new string[2] { "Открыть ноутбук, пропылесосить клавиатуру пылесосом, сообщить о готовности заказа.", "0" });
            ans1.Add(new string[2] { "Вскрыть крышку ноутбука, откручивая болтики большой отверткой. Изъять клавиатуру полность из ноутбука, промыть ее. Поставить клавиаутуру обратно, затем попытаться закрутить болтики обратно, после нескольких неудачных попыток, посадить крышку на термоклей, так резба была сорвана.", "0" });

            ans2.Add(new string[2] { "Открыть системный блок, аккуратно отсоединить рандомный шлейф. Вырвать старую СО и поставить новую систему охлаждения на процессор.", "0" });
            ans2.Add(new string[2] { "Открыть системный блок, аккуратно отсоединить шлейф системы охлаждения процессора. Изъять старую СО, и убрать старую термопасту, нанесенную на процессоре. Нанести мазок новой термопасты, и поставить новую систему охлаждения на процессор. Подключить шлейф, закрыть системный блок, сообщить о выполненой работе.", "1" });
            ans2.Add(new string[2] { "Открыв системный блок, аккуратно извлечь старую систему охлаждения, попутно убрав старую засохшую термопасту. Поставить новую систему охлаждения на процессор, затем проверить на работоспособность.", "0" });
            ans2.Add(new string[2] { "Вырвав крышку системного блока, варварски оторвать старую систему охлаждения процессора и попутно прихватив с собой систему охлаждения видеокарты. Нанести большой ляпок термопасты поверх старой, которая уже засохла. Поставить новую систему охлаждения на процессор, приклеив ее к материнской плате на термоклей, попутно обмазав все вокруг. Сообщить о выполненой работе.", "0" });

            ans3.Add(new string[2] { "Включить компьютер, посмотреть что вообще с ним происходить и попытаться понять внешне, что не так с компьютером. Ничего не поняв, открыть системный блок, и заново включить компьютер. Проделать данную операцию пару раз, посмотря что происходит, возникает предположение, что погорела видеокарта. Отписать заказчику о данной проблеме.", "1" });
            ans3.Add(new string[2] { "Отдать компьютер в другой тех.сервис, где за работу возьмут дороже чем беру я.", "0" });
            ans3.Add(new string[2] { "Включив компьютер, попытаться провести диагностику с другого устройства, предварительно подключив его к компьютеру.", "0" });
        }

        private void fmes6()
        {
            mes.Clear();
            mes.Add(new string[5] { "Прочистить USB порты на ноутбуке.", "Сап, у меня в последнее время плохо стали порты контачить. Не знаю что с ними, скорее всего заабились, но это всего лишь мое предположение. Сам не полезу, боюсь испорчу. Посмотришь может?", "Почистить порты", "130", "2" });
            mes.Add(new string[5] { "Установка звуковых драйверов.","Привет дружище! Купил вчера компьютер, установили на него Windows, кое-как. Сейчас заметил что звука совсем нет. Знакомому позвонил, он сказал что дело может быть в каких-то Драйверах. Понятия не имею что это такое. Может поможешь?", "Установить драйвера для звуковой карты.", "100", "2" });
            mes.Add(new string[5] { "Установка антивируса.", "Здравствуйте! Сидела в интернете, и решила скачать фильм на компьютер. Скачала видимо что-то не то, и везде одна реклама на компьютере появилась, даже на рабочем столе. Не знаю что уж и делать! Надеюсь на вашу помощь!", "Почистить компьютер от вредоностных программ и установить антивирус.", "150", "4" });

            ans0.Add(new string[2] { "Сначала аккуратно попытаться прочистить как можно больше пространства, маленькой палочкой. После продуть при помози сжатого воздуха, и повторить такую операцию несколько раз.", "1" });
            ans0.Add(new string[2] { "Смазать ватную палочку слюной, после начать чистить порты. Как только прочистив все возможное таким способом, набрать в шприц воды, и залить в разъемы, что бы грязь немного размякла и лучше выходила. После повторить процедуру с ватной палочкой.", "0" });
            ans0.Add(new string[2] { "Продуть порты сжатым воздухом, сообщить о выполненой работе.", "0" });

            ans1.Add(new string[2] { "Зайти в браузер, набрать в поиск - Скачать драйвера для компьютера. После скачать нужный файл на первом сайте, и установить.", "0" });
            ans1.Add(new string[2] { "Узнать марку звуковой карты, после чего зайти на сайт производителя, и скачать драйвера. После успешного скачивания, установить драйвера, проверить работоспособность.", "1" });
            ans1.Add(new string[2] { "Скачать программу для автоматической установки всех нужных и недостающих дравверов в компьютере. Провести сканирование с помощью программы, и начать установку предложенных драйверов.", "0" });
            ans1.Add(new string[2] { "Зайти в настройки звука в Операционной системе, произвести сканирование и устранение неполадок, сообщить о выполненой работе.", "0" });

            ans2.Add(new string[2] { "Найти бесплатный антивирус в интернете, скачать установчник и произвести установку. После проверить работоспособность антивируса.", "0" });
            ans2.Add(new string[2] { "Взять старый не обновленный с флешки, установить его на компьютер, сообщить о выполненой работе.", "0" });
            ans2.Add(new string[2] { "Зайти на проверенный временем сайт нужного продукта, установить бесплатную или пробную версию, за ранее узнав какаю нужна владельцу. Произвести установку, и проверить на работоспособность. Сообщить о выполненой работе.", "1" });
        }
        private void fmes7()
        {
            mes.Clear();
            mes.Add(new string[5] { "Сборка компьютера", "Привет, я тебя пару дней назад просил собрать комплектующие для компьютера. Я заказал, все как ты и советовал. Только вот не учел, то что сам навряд ли все это подключу, да еще же и ОС нужно будет поставить, сам я в общем не в состоянии это сделать, так что обращаюсь снова к тебе. Надеюсь на тебя снова!", "Установить комплектующие в системный блок и установить Windows.", "1000", "6" });
            mes.Add(new string[5] { "", "", "", "", "", });

            ans0.Add(new string[2] { "", "" });
            ans0.Add(new string[2] { "", "" });
            ans0.Add(new string[2] { "", "" });

            ans1.Add(new string[2] { "", "" });
            ans1.Add(new string[2] { "", "" });
            ans1.Add(new string[2] { "", "" });
        }
        private void fmes8()
        {
            mes.Clear();
            mes.Add(new string[5] { "", "", "", "", "", });
            mes.Add(new string[5] { "", "", "", "", "", });
            mes.Add(new string[5] { "", "", "", "", "", });

            ans0.Add(new string[2] { "", "" });
            ans0.Add(new string[2] { "", "" });
            ans0.Add(new string[2] { "", "" });

            ans1.Add(new string[2] { "", "" });
            ans1.Add(new string[2] { "", "" });
            ans1.Add(new string[2] { "", "" });

            ans2.Add(new string[2] { "", "" });
            ans2.Add(new string[2] { "", "" });
            ans2.Add(new string[2] { "", "" });
        }
        private void fmes9()
        {
            mes.Clear();
            mes.Add(new string[5] { "", "", "", "", "", });
            mes.Add(new string[5] { "", "", "", "", "", });
            mes.Add(new string[5] { "", "", "", "", "", });
            mes.Add(new string[5] { "", "", "", "", "", });

            ans0.Add(new string[2] { "", "" });
            ans0.Add(new string[2] { "", "" });
            ans0.Add(new string[2] { "", "" });

            ans1.Add(new string[2] { "", "" });
            ans1.Add(new string[2] { "", "" });
            ans1.Add(new string[2] { "", "" });

            ans2.Add(new string[2] { "", "" });
            ans2.Add(new string[2] { "", "" });
            ans2.Add(new string[2] { "", "" });

            ans3.Add(new string[2] { "", "" });
            ans3.Add(new string[2] { "", "" });
        }
        private void fmes10()
        {
            mes.Clear();
            mes.Add(new string[5] { "", "", "", "", "", });
            mes.Add(new string[5] { "", "", "", "", "", });
            mes.Add(new string[5] { "", "", "", "", "", });
            mes.Add(new string[5] { "", "", "", "", "", });

            ans0.Add(new string[2] { "", "" });
            ans0.Add(new string[2] { "", "" });
            ans0.Add(new string[2] { "", "" });

            ans1.Add(new string[2] { "", "" });
            ans1.Add(new string[2] { "", "" });
            ans1.Add(new string[2] { "", "" });

            ans2.Add(new string[2] { "", "" });
            ans2.Add(new string[2] { "", "" });
            ans2.Add(new string[2] { "", "" });

            ans3.Add(new string[2] { "", "" });
            ans3.Add(new string[2] { "", "" });
        }
    }
}
