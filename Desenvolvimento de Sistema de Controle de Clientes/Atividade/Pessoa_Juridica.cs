namespace Atividade
{
    class Pessoa_Juridica : Clientes
    {
        public string cnpj { get; set; }
        public string ie { get; set; }

        public override void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20 / 100; // Imposto para Pessoa Jurídica é 20%
            this.total = this.valor + this.valor_imposto;
        }
    }
}