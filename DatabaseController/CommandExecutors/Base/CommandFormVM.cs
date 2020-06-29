using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMBase;

namespace DatabaseController.CommandExecutor.ViewModel
{
    abstract class CommandFormVM : ViewModelBase, IExecuteCommand
    {
        protected abstract string _generateCommandString();
        public void ExecuteCommand()
        {
            // Tutaj trzeba zrobić coś, co Będzie kazało bazie danych wywołać daną funkcję
            // Coś w stylu BazaDanych.WywołajZapytanie(_generateCommandString());
            throw new NotImplementedException();
        }
        public virtual bool CanExecuteCommand() { return true; }
    }
}
