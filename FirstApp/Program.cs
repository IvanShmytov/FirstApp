
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pult pult = new Pult();
            Gate gate = new Gate();

            pult.SetAction(new GateOpenAction(gate));
            pult.OpenButton();
            pult.CloseButton();

        }


    }

    class Pult
    {
        IAction _action;

        /// <summary>
        ///  Инициализация команды
        /// </summary>
        public void SetAction(IAction action)
        {
            _action = action;
        }

        public void OpenButton()
        {
            // запуск команды
            _action.Run();
        }

        public void CloseButton()
        {
            // отмена команды
            _action.Undo();
        }
    }

    class Gate
    {
        public void Open()
        {
            Console.WriteLine("Открываем ворота");
        }

        public void Close()
        {
            Console.WriteLine("Закрываем ворота");
        }
    }

    interface IAction
    {
        void Run();
        void Undo();
    }
    class GateOpenAction : IAction
    {
        Gate _gate;

        public GateOpenAction(Gate gateSet)
        {
            _gate = gateSet;
        }

        public void Run()
        {
            _gate.Open();
        }

        public void Undo()
        {
            _gate.Close();
        }
    }
}
