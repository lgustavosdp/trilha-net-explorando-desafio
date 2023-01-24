//Código Modificado por Luiz Gustavo
//Assista as gravações destas modificações no canal L GUSTAVO - PROGRAMADOR PROFISSIONAL
// LINK DO CANAL - https://www.youtube.com/@lgustavo-programador
// LINK da PLAYLIST BOOTCAMP POTTENCIAL - https://www.youtube.com/watch?v=GHP6S3zKy7Y&list=PLNvQEEUeLujsHq1qF7Ze3C7FsE0ll3XyD

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            int quantidade_hospedes = hospedes.Count;
            
            Console.WriteLine(quantidade_hospedes);
            //Console.WriteLine("Chegou aqui-1");
            //Suite.Capacidade>=Hospedes.Count
            
            if (Suite.Capacidade>=quantidade_hospedes)
            {
                Console.WriteLine("A Reserva pode ser feita nesta suíte!");
                Hospedes = hospedes;
            }
            else
            {   
                
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                 Console.WriteLine("A Reserva NÃO pode ser feita nesta suíte!");
                 //catch(Exception ex){
                //Console.WriteLine($"Ocorreu uma exceção genérica.{ex.Message}");    
                //}

            }
            
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados*Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados>=10)
            {
                valor = valor*90/100;
            }

            return valor;
        }
    }
}