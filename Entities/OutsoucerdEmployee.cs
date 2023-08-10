namespace Principal.Entities {
    class OutsourcedEmployee : Employee {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee (string name, int hours, double payment, double additionalCharge) : base(name, hours, payment) {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment() {
            
            return AdditionalCharge * 1.1 + base.Payment();
        }
    }
}