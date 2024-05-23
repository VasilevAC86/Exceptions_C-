using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Money
    {
        public int Hryvnia { get; set; }
        public int Kopecks { get; set; }
        public Money(int hry, int kop)
        {
            this.Hryvnia = hry;
            this.Kopecks = kop;
            if (Hryvnia < 0 || Kopecks < 0) { throw new ArgumentException("Деньги не могут быть меньше нуля!!!"); }
        }
        public static Money operator +(Money m1, Money m2) // Перегрузка +
        { 
            int totalKopecks = m1.Kopecks + m1.Hryvnia * 100 + m2.Hryvnia * 100 + m2.Kopecks;
            return new Money(totalKopecks / 100, totalKopecks % 100);
        }
        public static Money operator -(Money m1, Money m2) // Перегрузка -
        {
            int totalKopecks = m1.Kopecks + m1.Hryvnia * 100 - m2.Hryvnia * 100 - m2.Kopecks;
            if (totalKopecks < 0) { throw new Bankrot("Вы банкрот! У вас деньги меньше 0!"); }
            return new Money(totalKopecks / 100, totalKopecks % 100);
        }
        public static Money operator *(Money m, int multiplier) // Перегрузка *
        {
            int totalKopeck = (m.Hryvnia * 100 + m.Kopecks) * multiplier;
            return new Money(totalKopeck / 100, totalKopeck % 100);
        }
        public static Money operator /(Money m, int divisor) // Перегрузка деления
        {
            if (divisor == 0) {  throw new DivideByZeroException("Делить на ноль нельзя!"); }
            int totalKopecks = m.Hryvnia * 100 + m.Kopecks;
            return new Money(totalKopecks / divisor / 100, totalKopecks % divisor % 100);
        }
        public static bool operator <(Money m1, Money m2)
        {
            return (m1.Hryvnia < m2.Hryvnia) || (m1.Hryvnia == m2.Hryvnia && m1.Kopecks < m2.Kopecks);
        }
        public static bool operator >(Money m1, Money m2)
        {
            return (m1.Hryvnia > m2.Hryvnia) || (m1.Hryvnia == m2.Hryvnia && m1.Kopecks > m2.Kopecks);
        }
        public static bool operator ==(Money m1, Money m2)
        {
            return m1.Hryvnia == m2.Hryvnia && m1.Kopecks == m2.Kopecks;
        }
        public static bool operator !=(Money m1, Money m2) { return !(m1 == m2); }
        public static Money operator ++(Money m) // Оператор инкремента
        {
            return m + new Money(0, 1); // Прибавляем одну копейку через создание нового объекта
        }
        public static Money operator --(Money m) // Оператор декремента
        {
            return m - new Money(0, 1); // Удаляем одну копейку через создание нового объекта, если деньги < 0,
                                         // то сработает исключение перегруженного оператора вычитания
        }
        public override string ToString()
        {
            return $"{Hryvnia} грн, {Kopecks} коп";
        }
    }
}
