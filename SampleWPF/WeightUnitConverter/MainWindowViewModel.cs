﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WeightUnitConverter {
    class MainWindowViewModel : ViewModel{
        private double gramValue, pondValue;
        //▲ボタンで呼ばれるコマンド
        public ICommand PondUnitToGram { get; private set; }
        //▼ボタンで呼ばれるコマンド
        public ICommand GramToPondUnit { get; private set; }
        
        //上のcomboboxで選択されている値
        public GramUnit CurrentGramUnit { get; set; }
        //下のcomboboxで選択されている値
        public PondUnit CurrentPondUnit { get; set; }

        //プロパティ
        public double GramValue {
            get { return this.gramValue; }
            set {
                this.gramValue = value;
                this.OnPropertyChenged();
            }
        }
        public double PondValue {
            get { return this.pondValue; }
            set {
                this.pondValue = value;
                this.OnPropertyChenged();
            }
        }

        public MainWindowViewModel() {
            this.CurrentGramUnit = GramUnit.Units.First();
            this.CurrentPondUnit = PondUnit.Units.First();

            this.GramToPondUnit = new DelegateCommand (
                () => this.PondValue = this.CurrentPondUnit.FromGramUnit(
                    this.CurrentGramUnit,this.GramValue));

            this.PondUnitToGram = new DelegateCommand(
                () => this.GramValue = this.CurrentGramUnit.FromPondUnit(
                    this.CurrentPondUnit, this.PondValue));
        }
    }
}
