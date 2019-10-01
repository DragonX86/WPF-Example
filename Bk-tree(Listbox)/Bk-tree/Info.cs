﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bk_tree
{
    class Info
    {
        static Dictionary<string, string> wordkeys = new Dictionary<string, string>
        {
            ["abstract"]= "Модификатор abstract указывает, что изменяемый элемент имеет отсутствующую или неполную реализацию. Модификатор abstract можно использовать с классами, методами, свойствами, индексаторами и событиями. Модификатор abstract в определении класса позволяет указать, что класс может быть только базовым классом для других классов. Члены, помеченные как абстрактные или включенные в абстрактный класс, должны быть реализованы классами, производными от абстрактного класса.",
            ["as"]= "Оператор as можно использовать для выполнения определенных типов преобразований между совместимыми ссылочными типами или типами, допускающими значение NULL. ",
            ["base"]= "Ключевое слово base используется для доступа к членам базового из производного класса ",
            ["bool"]= "Ключевое слово bool является псевдонимом для System.Boolean. Оно используется для объявления переменных для хранения логических значений true и false.",
            ["break"] = "Ключевое слово bool является псевдонимом для System.Boolean. Оно используется для объявления переменных для хранения логических значений true и false.",
            ["byte"] = "Ключевое слово byte обозначает целочисленный тип данных, в котором хранятся значения, описанные в приведенной ниже таблице.",
            ["case"] = "это оператор выбора, который выбирает для выполнения один раздел switch из списка кандидатов, сравнивая их с выражением соответствия.",
            ["catch"] = "Оператор try-catch состоит из блока try, за которым следует одно или несколько предложений catch, задающих обработчики для различных исключений.",
            ["char"]= "Ключевое слово char используется для объявления экземпляра структуры System.Char, используемой .NET Framework для представления символа Юникода. Значение объекта Char представляет собой 16-разрядное числовое (порядковое) значение.",
            ["checked"]= "Ключевое слово checked используется для явного включения проверки переполнения при выполнении арифметических операций и преобразований с данными целого типа.",
            ["class"] = "Классы объявляются с помощью ключевого слова class",
            ["continue"] = "Оператор continue передает управление следующей итерации вложенного оператора while, do, for или foreach, в котором она встречается.",
            ["decimal"] = "Ключевое слово decimal обозначает 128-разрядный тип данных. По сравнению с другими типами данных с плавающей запятой, диапазон значений decimal меньше, а точность выше, благодаря чему этот тип подходит для финансовых расчетов. ",
            ["default"] = "Ключевое слово default можно использовать в качестве инструкции switch для указания метки по умолчанию",
            ["delegate"] = "Ключевое слово delegate имеет ссылочный тип, который можно использовать для инкапсуляции именованного или анонимного метода.",
            ["do"] = "Оператор do выполняет оператор или блок операторов, пока определенное логическое выражение равно значению true.",
            ["double"] = "Ключевое слово double обозначает простой тип, используемый для хранения 64-разрядных значений с плавающей запятой. ",
            ["else"] = "Если логическое выражение оценивается как true, выполняется блок if, если иначе выполняется блок кода.",
            ["enum"] = "Ключевое слово enum используется для объявления перечисления — отдельного типа, который состоит из набора именованных констант, называемого списком перечислителей.",
            ["event"] = "Ключевое слово event используется для объявления события в классе Publisher.",
            ["explicit"] = "Ключевое слово explicit объявляет оператор преобразования определяемого пользователем типа, который должен быть вызван с помощью приведения.",
            ["extern"] = "Модификатор extern используется для объявления метода с внешней реализацией. ",
            ["false"] = "Используется в качестве перегруженного оператора или литерала",
            ["finally"] = "С помощью блока finally можно выполнить очистку всех ресурсов, выделенных в блоке try, и запускать код даже при возникновении исключения в блоке try. ",
            ["fixed"] = "Оператор fixed не позволяет сборщику мусора переносить перемещаемую переменную. Оператор fixed допускается только в небезопасном контексте. ",
            ["float"] = "Ключевое слово float обозначает простой тип, в котором хранятся 32-разрядные значения с плавающей запятой. ",
            ["for"] = "Оператор for выполняет оператор или блок операторов, пока определенное логическое выражение равно значению true.",
            ["foreach"] = "Оператор foreach выполняет оператор или блок операторов для каждого элемента в экземпляре типа, который реализует интерфейс System.Collections.IEnumerable или System.Collections.Generic.IEnumerable<T>.",
            ["goto"] = "Оператор goto передает управление программой непосредственно оператору с меткой.",
            ["if"] = "Оператор if определяет, какой оператор будет выполняться при выполнения условия, заданного логическим выражением.",
            ["implicit"] = "Ключевое слово implicit служит для объявления неявного оператора преобразования пользовательского типа.",
            ["in"] = "Ключевое слово in используется в качестве оператора foreach.",
            ["int"] = "int обозначает целочисленный тип данных (32bit)",
            ["interface"] = "Интерфейс содержит только сигнатуры методов, свойств, событий или индексаторов. Класс или структура, реализующие интерфейс, должны реализовать члены интерфейса, заданные в определении интерфейса.",
            ["internal"] = "Ключевое слово internal является модификатором доступа для типов и членов типов.",
            ["is"] = "Проверяет совместимость объекта с заданным типом или (начиная с C# 7.0) проверяет выражение на соответствие шаблону.",
            ["lock"] = "Оператор lock получает взаимоисключающую блокировку заданного объекта перед выполнением определенных операторов, а затем снимает блокировку.",
            ["long"] = "long обозначает целочисленный тип данных(64 bit)",
            ["namespace"] = "Ключевое слово namespace используется для объявления области действия, которая содержит набор связанных объектов.",
            ["new"] = "В C# new ключевое слово можно использовать в качестве оператора, модификатора или ограничения.",
            ["null"] = "Ключевое слово null является литералом, представляющим пустую ссылку, которая не ссылается на объект. null является значением по умолчанию для переменных ссылочного типа.",
            ["object"] = "Тип object является псевдонимом Object в .NET. В унифицированной системе типов C# все типы, стандартные и определяемые пользователем, ссылочные типы и типы значений напрямую или косвенно наследуются из Object.",
            ["operator"] = "Ключевое слово operator используется для перегрузки встроенного оператора или выполнения пользовательского преобразования в объявлении класса или структуры.",
            ["out"] = "Используется в  качестве модификатора параметра, который позволяет передавать аргумент в метод по ссылке, а не по значению.",
            ["override"] = "Модификатор override требуется для расширения или изменения абстрактной или виртуальной реализации унаследованного метода, свойства, индексатора или события.",
            ["params"] = "С помощью ключевого слова params можно указать параметр метода, принимающий переменное число аргументов.",
            ["private"] = "Закрытый доступ является уровнем доступа с минимальными правами. Доступ к закрытым членам можно получить только внутри тела класса или структуры",
            ["protected"] = "Доступ к защищенному элементу может быть получен из соответствующего класса, а также экземплярами производных классов.",
            ["public"] = "Ключевое слово public является модификатором доступа для типов и членов типов. Общий доступ является уровнем доступа с максимальными правами. Ограничений доступа к общим членам не существует",
            ["readonly"] = "В объявлении поля readonly указывает на то, что присвоение значения полю может происходить только при объявлении или в конструкторе этого класса.",
            ["ref"] = "При использовании в списке параметров метода ключевое слово ref указывает на то, что аргумент передается по ссылке, а не по значению.",
            ["return"] = "Оператор return завершает выполнение метода, в котором он присутствует, и возвращает управление вызывавшему методу. Он также возвращает необязательное значение. Если метод имеет тип void, оператор return можно опустить.",
            ["sbyte"] = "sbyte обозначает целочисленный тип данных (8 bit)",
            ["sealed"] = "При применении к классу модификатор sealed запрещает другим классам наследовать от этого класса.",
            ["short"] = "Ключевое слово short обозначает целочисленный тип данных (16 bit)",
            ["sizeof"] = "Позволяет получить размер в байтах для неуправляемого типа.",
            ["stackalloc"] = "Ключевое слово stackalloc используется для выделения блока памяти стеку.",
            ["static"] = "Модификатор static используется для объявления статического члена, принадлежащего собственно типу, а не конкретному объекту. ",
            ["string"] = "Тип string представляет последовательность, состоящую из нуля или более символов в кодировке Юникод. string является псевдонимом для String в .NET.",
            ["struct"] = "Тип struct представляет собой тип значения, который обычно используется для инкапсуляции небольших групп связанных переменных",
            ["switch"] = "switch — это оператор выбора, который выбирает для выполнения один раздел switch из списка кандидатов, сравнивая их с выражением соответствия.",
            ["this"] = "Ключевое слово this ссылается на текущий экземпляр класса, а также используется в качестве модификатора первого параметра метода расширения.",
            ["throw"] = "Сообщает о возникновении исключения во время выполнения программы.",
            ["true"] = "Используется в качестве перегруженного оператора или литерала",
            ["try"] = "Оператор try-catch состоит из блока try, за которым следует одно или несколько предложений catch, задающих обработчики для различных исключений.",
            ["typeof"] = "Позволяет получить объект System.Type для типа. ",
            ["uint"] = "Ключевое слово uint обозначает целочисленный беззнаковый тип данных (32 бит)",
            ["ulong"] = "Ключевое слово uint обозначает целочисленный беззнаковый тип данных (64 бит)",
            ["unchecked"] = "Ключевое слово unchecked позволяет предотвратить проверку переполнения при выполнении арифметических операций и преобразований с данными целого типа.",
            ["unsafe"] = "Ключевое слово unsafe обозначает небезопасный контекст, необходимый для выполнения любых операций с применением указателей. ",
            ["ushort"] = "Ключевое слово uint обозначает целочисленный беззнаковый тип данных (16 бит)",
            ["using"] = "Инструкция using определяет область, по завершении которой объект удаляется.",            
            ["virtual"] = "Ключевое слово virtual используется для изменения объявлений методов, свойств, индексаторов и событий и разрешения их переопределения в производном классе.",
            ["void"] = "При использовании в качестве типа возвращаемого значения для метода ключевое слово void указывает, что метод не возвращает значение.",
            ["volatile"] = "Ключевое слово volatile означает, что поле может изменить несколько потоков, выполняемых одновременно.",
            ["while"] = "Оператор while выполняет оператор или блок операторов, пока определенное логическое выражение равно значению true. "
        };
        public static string GetINFO(string input)
        {
            string output="";
            foreach (var pair in wordkeys)
            {
                if (pair.Key == input)
                {
                    output = pair.Value;
                }
            }
            return output;
        }
    }
}
