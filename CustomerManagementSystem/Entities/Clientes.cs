namespace CustomerManagementSystem
{
    class Clientes
    {
        public string nome { get; set; } = string.Empty;
        public string endereco { get; set; } = string.Empty;
        public float valor { get; protected set; }
        public float valor_imposto { get; protected set; }
        public float total { get; protected set; }

        public virtual void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 10 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}