using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPostOffice.Classes
{
    //public enum TypeSending { Самолет, Поезд, Авто};
    public enum Status { Зарегистрирована, Отправлена,
                         Принята, В_пути, Доставлена,
                         Отказ, Возращена, Потеряна  };

    public class Postage
    {
        //const decimal COSTGRAM = 0.34m;

        //Скрытые поля класса 
        private string track;
        private Adress sender;
        private Adress target;
        private DateTime dateStart;
        //private bool esc;
        private int weight;
        //private TypeSending typeSending;
        private Status statusPostage;

        //Внутренний метод расчета стоимости отправления
        private decimal calcCost(decimal costGram)
        {
            return (decimal)weight* costGram;
        }

        //Открытый метод отображения данные об отправлении
        public string OutPostage()
        {
            return $"Трек: {this.track} Адрес отправителя: {this.sender}" +
                $" Адрес получателя: {this.target} Цена: {this.calcCost(0.34m)}";
        }

        //Доступные свойства класса
        public string Track { get { return track; } }
        public Adress Sender { get { return sender; } set { sender = value; } }
        public Adress Target { get; set; }
        public DateTime DateStart;
        //public bool ESC { get; set; }
        public int Weight
        {
            get { return weight; }  //Блок получения значения поля
            set                                     //Блок записи значения в поле с проверкой
            {
                if (value > 0)
                    weight = value;
                else
                    weight = 0;
            }
        }
        //public TypeSending TypeSending { get; set; }
        public Status StatusPostage { get; set; }
    }
}
