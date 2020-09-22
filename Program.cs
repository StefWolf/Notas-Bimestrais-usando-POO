using System;
using System.Collections.Generic;

namespace novoestudo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();
            Aluno alunois = new Aluno();
            string name;
            float not = 0;
            float som;
            float medi;
            int quantidade = 0;

            Console.WriteLine("--------CADASTRO DE NOTA ESCOLAR--------");
            Console.WriteLine("Digite a quantidade de alunos: ");
            quantidade = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantidade; i++){
                medi = 0;
                som = 0;
                Console.WriteLine("Digite o nome do aluno: ");
                name = Console.ReadLine();

                for(int j = 0; j < 4; j++){
                    Console.WriteLine("Digite a nota do "+j+" bimestre: ");
                    not = float.Parse(Console.ReadLine());
                    som = som+not;
                }
                medi = alunois.Mediu(som); 
                string cod = alunois.condicao(medi);
                
                alunos.Add(new Aluno{  
                    nome = name,
                    media = medi,
                    condic = cod
                  
                });
            }
            Console.WriteLine("---------RESULTADO---------");
            foreach(var Aluno in alunos){
                 Console.WriteLine("||"+Aluno.nome+"||"+Aluno.media+"||"+Aluno.condic+"||");
            }
        }
        class Aluno{
            public string nome {get; set;}
            public float nota1 {get; set;}
            public float media {get; set;}
            public string condic {get; set;}

            public float Mediu(float total){
                media = total/4;
                return media;
            }
            public string condicao(float mediacondi){
                mediacondi = media;
                if(media < 6){
                    condic = "Recuperação";
                }
                else{
                    condic = "Aprovado";
                }
                return condic;
            }


        }
    }
}
