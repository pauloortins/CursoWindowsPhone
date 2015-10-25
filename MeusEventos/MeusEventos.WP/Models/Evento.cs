using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusEventos.WP.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }        
        public string Local { get; set; }
        public List<Trilha> Trilhas { get; set; }

        public string Periodo {
            get
            {
                return string.Format("{0} - {1}", DataInicial.ToString("dd/MM"), DataFinal.ToString("dd/MM"));
            }
        }

        public static List<Evento> Eventos
        {
            get
            {
                return new List<Evento>()
                {
                    new Evento()
                    {
                        Nome="The Developers Conference Porto Alegre",
                        Descricao="Um encontro de Comunidades de TI",
                        DataInicial=new DateTime(2015, 9, 24),
                        DataFinal=new DateTime(2015, 9, 26),
                        Local="Porto Alegre",                        
                        Trilhas= new List<Trilha>()
                        {
                            new Trilha()
                            {
                                Nome="Carreira",
                                Descricao="A formação de uma carreira é pautada de muita dedicação, grandes desafios e aprendizados. Por esse motivo, o TDC tem o prazer de lançar uma trilha com foco em ajudá-lo a vencer os seus desafios, através de conhecimentos, experiências e histórias vivenciadas por profissionais que criaram suas próprias empresas, trabalharam em grandes corporações, participaram de projetos open source usados em todo o mundo e ganharam prêmios nacionais e/ou internacionais! Profissionais que têm muito mais a nos ensinar, do que frameworks e novas linguagens de programação. Venha conhecer, participar e inspirar mais pessoas conosco!Esperamos por você!",
                                Palestras=new List<Palestra>()
                                {
                                    new Palestra()
                                    {
                                        Nome="De entregador de pizza a programador Java e empresário: a história de Vinicius Senger",
                                        Descricao="Nesta palestra Vinicius Senger, fundador da Globalcode e um dos criadores do TDC vai contar suas história de como começou a trabalhar como programador com apenas 13 anos de idade e passou por grandes empresas como Proceda, instrutor e consultor da Sun Microsystems, instrutor da Oracle e várias experiências além da tecnologia",
                                        DataHora="10:10",
                                        Palestrante= new Palestrante()
                                        {
                                            Nome="Vinicius Morandin Senger",
                                            MiniBio="Trabalha com desenvolvimento de software desde os 13 anos de idade foi instrutor e consultor da Sun Microsystems e fundou a Globalcode."
                                        }
                                    },
                                    new Palestra()
                                    {
                                        Nome="Making your way to the Valley: Um guia prático",
                                        Descricao="Muita gente me pergunta qual a melhor maneira, ou a maneira mais fácil (se é que ela existe) de se mudar e trabalhar no Silicon Valley. Essa é uma palestra realista com algumas dicas pra pessoas que como eu, tinham ou têm o sonho de trabalhar no exterior, especialmente no Vale do Silício e San Francisco. Vou contar um pouco da minha história e como cheguei a San Francisco quase 4 anos atrás para trabalhar como desenvolvedor de software.",
                                        DataHora="13:10",
                                        Palestrante= new Palestrante()
                                        {
                                            Nome="Netto Farah",
                                            MiniBio="Netto Farah se diverte construindo apps. Com experiência em Fabrica de Software de fundo de quintal, Consultoria, Web Apps com milhões de usuários, Full Stack e Mobile Development, Netto sempre tem uma história pra contar. Seu desafio mais recente é trabalhar como Senior Software Engineer no time de produtos do IFTTT."
                                        }
                                    },
                                }
                            },
                            new Trilha()
                            {
                                Nome=".NET",
                                Descricao=".NET é um Framework que proporciona um modelo de programação consistente e uma maneira compreensiva de se desenvolver aplicações visualmente fantásticas sem abrir mão da usabilidade, segurança e produtividade do desenvolvedor.Nesta trilha vamos falar sobre suas linguagens, recursos e ferramentas disponíveis trazendo todas as principais novidades do mundo.NET para que você volte para casa um profissional atualizado e pronto para fazer sua empresa crescer ainda mais.",
                                Palestras=new List<Palestra>()
                                {
                                    new Palestra()
                                    {
                                        Nome="Construindo aplicativos moveis conectados com Xamarin e Azure Mobile Services",
                                        Descricao="Utilizando Xamarin com Visual Studio e Azure Mobile Services iremos construir aplicativos multi-plataforma escritos em C#, que tiram vantagem da Nuvem para autenticação e armazenamento de dados sincronizados em múltiplos dispositivos, compartilhando código nas plataformas Android, iOS e Windows através de uma única Portable-Class-Libray.",
                                        DataHora="10:10",
                                        Palestrante= new Palestrante()
                                        {
                                            Nome="William S. Rodriguez",
                                            MiniBio="Atualmente sou fundador da 28 Bytes Digital, onde através da tecnologia ajudo pessoas desenvolverem suas ideias, construindo soluções resultem em valor para nossos clientes. Também viajo o Brasil palestrando em eventos e conferências de tecnologia, sou um profissional certificado e reconhecido como especialista em nuvem (Microsoft Azure), e desenvolvimento mobile cross plataforma (Xamarin), participando ativamente de comunidades técnicas e organizando eventos de tecnologia em Curitiba."
                                        }
                                    },
                                    new Palestra()
                                    {
                                        Nome="Microsoft Azure DevOps",
                                        Descricao="Palestra mostrando como o Microsoft Azure pode auxiliar nas demandas de DevOps e também como startups podem se beneficiar com o Azure.",
                                        DataHora="11:10",
                                        Palestrante= new Palestrante()
                                        {
                                            Nome="Lucas Chies",
                                            MiniBio="Possuo +9 anos de experiência em TI. Atualmente sou Parceiro Microsoft, no programa Microsoft Student Partner. Trabalho na Dell como Senior Support. Possuo certificações de Virtualização com Hyper-V & System Center, Infraestrutura no Microsoft Azure."
                                        }
                                    },
                                }
                            },
                        }
                    },
                    new Evento()
                    {
                        Nome="Linguagil 2015",
                        Descricao="Participe do melhor evento de 2015",
                        DataInicial=new DateTime(2015, 3, 11),
                        DataFinal=new DateTime(2015, 3, 14),
                        Local="Salvador",                        
                        Trilhas= new List<Trilha>()
                        {
                            new Trilha()
                            {
                                Nome="13/03",
                                Descricao="Palestras do primeiro dia do Linguagil 2015",
                                Palestras=new List<Palestra>()
                                {
                                    new Palestra()
                                    {
                                        Nome="Nos precisamos de um PO!",
                                        Descricao="Porque os projetos falham, mesmo sendo bem construídos, usando clean code e as melhores técnicas de desenvolvimento? Porque os produtos ficam lá, estacionados, sem vendas e com dezenas de features implementadas e não usadas? Vamos conversar sobre esses assuntos hoje.",
                                        DataHora="09:00",
                                        Palestrante= new Palestrante()
                                        {
                                            Nome="Juliano Ribeiro",
                                            MiniBio="Juliano Ribeiro atuou como team member, Scrum Master e Agile Coach. Desenvolve software a 20 anos, liderou a equipe Delphi na Produtec por 5 anos e implementou diversas práticas de XP e Scrum nessa e em outras empresas da região. É CSM, CSP (SA) e CDD (Embarcadero). Palestrou no Agile Tour em Maringá e Curitiba (2012) e no Scrum Bolívia Day. Ministrou cursos ágeis no Brasil e EUA e atua como Agile Coach e Trainer pela Massimus C&T."
                                        }
                                    },
                                    new Palestra()
                                    {
                                        Nome="Como um programador pode ser dono do seu tempo e fazer o que quiser.",
                                        Descricao="Tá no título! Bora conversar sobre as tecnologias que nenhum curso de programação menciona, mas que são essenciais para quem quer ter nas mãos as rédeas da própria carreira.",
                                        DataHora="13:10",
                                        Palestrante= new Palestrante()
                                        {
                                            Nome="Henrique Bastos",
                                            MiniBio="Henrique Bastos é um inquieto eupreendedor. Aplica tecnologia para iniciativas que promovem autonomia de pessoas comuns. É membro da Python Software Foundation, da Django Software Foundation e da Associação PythonBrasil, atuando constantemente nas comunidades de programadores ministrando palestras, cursos e evangelizando o empoderamento através do desenvolvimento software, no Brasil e no exterior."
                                        }
                                    },
                                }
                            },
                            new Trilha()
                            {
                                Nome="14/03",
                                Descricao="Palestras do segundo dia do Linguagil 2015",
                                Palestras=new List<Palestra>()
                                {
                                    new Palestra()
                                    {
                                        Nome="Docker - O fim do na minha maquina funciona.",
                                        Descricao="Docker é um plataforma aberta para desenvolvedores criarem, distribuírem e rodarem aplicações distribuídas em Containers. No Docker, esses containers são como máquinas virtuais, porém simplificadas e normalmente sem overhead da virtualização. Essa apresentação tem como objetivo explicar como utilizar essa nova solução, demonstrando que é possível replicar facilmente o ambiente de produção para desenvolvimento e vice-versa, assim como também as melhores práticas, tanto de segurança, como de produtividade do seu uso.",
                                        DataHora="10:30",
                                        Palestrante= new Palestrante()
                                        {
                                            Nome="Rafael Gomes",
                                            MiniBio="Soteropolitano, hacker urbano e consultor de infraestrutura, formado na Universidade de Salvador no curso de Gestão de Redes, pós-graduando pela Universidade Federal da Bahia em sistemas distribuídos. Trabalho atualmente como Arquiteto de Soluções na Superintendência de Tecnologia da Informação da Universidade Federal da Bahia, focado em aplicações, monitoramento e segurança. Certificado em LPIC-1, MCSO e Zabbix Certified Specialist."
                                        }
                                    },
                                    new Palestra()
                                    {
                                        Nome="DDD - Agil ou Fragil?",
                                        Descricao="Qual a relação entre DDD e Agilidade? Podemos ter um sem o outro? Entenda como podemos aplicá-los em conjunto e extrair o máximo de ambos.",
                                        DataHora="13:30",
                                        Palestrante= new Palestrante()
                                        {
                                            Nome="Osni Oliveira",
                                            MiniBio="Engenheiro de Software no Elo7 e instrutor na Caelum, com uma carreira de cerca de 20 anos. Estudou Processamento de Dados no Colégio Técnico da Unicamp e Análise de Sistemas na PUC Campinas. Já trabalhou com C/C++, Visual Basic e PHP, entre outras tecnologias. Hoje, trabalha com Java, estuda C#/.NET e Objective-C/iOS."
                                        }
                                    },
                                }
                            },
                        }
                    },
                    new Evento()
                    {
                        Nome="CONANEC",
                        Descricao="Congresso On-line Nacional de Negócios, Empreendedorismo e Coaching. 7 dias de palestras com diversos experts para a sua empresa se transformar, inovar e crescer!",
                        DataInicial=new DateTime(2015, 10, 19),
                        DataFinal=new DateTime(2015, 10, 25),
                        Local="Online",                                                
                        Trilhas= new List<Trilha>()
                        {
                            new Trilha()
                            {
                                Nome="19/10",
                                Descricao="Palestras do primeiro dia do CONANEC",
                                Palestras=new List<Palestra>()
                                {
                                    new Palestra()
                                    {
                                        Nome="Como fazer o seu lancamento digital em 30 dias sem criar o seu produto primeiro",
                                        Descricao="",
                                        DataHora="09:00",
                                        Palestrante= new Palestrante()
                                        {
                                            Nome="Serge Normando Rehem",
                                            MiniBio=""
                                        }
                                    },
                                    new Palestra()
                                    {
                                        Nome="Fidelizacao de Clientes: Menos e mais",
                                        Descricao="",
                                        DataHora="13:10",
                                        Palestrante= new Palestrante()
                                        {
                                            Nome="Leone Negri",
                                            MiniBio=""
                                        }
                                    },
                                }
                            },
                            new Trilha()
                            {
                                Nome="20/10",
                                Descricao="Palestras do segundo dia do CONANEC",
                                Palestras=new List<Palestra>()
                                {
                                    new Palestra()
                                    {
                                        Nome="Educacao financeira para todos",
                                        Descricao="",
                                        DataHora="10:30",
                                        Palestrante= new Palestrante()
                                        {
                                            Nome="Lelio Braga Calhau",
                                            MiniBio=""
                                        }
                                    },
                                    new Palestra()
                                    {
                                        Nome="Planejamento financeiro pessoal e familiar",
                                        Descricao="",
                                        DataHora="13:30",
                                        Palestrante= new Palestrante()
                                        {
                                            Nome="Abel Fiorot",
                                            MiniBio=""
                                        }
                                    },
                                }
                            },
                        }
                    }
                };
            }
        }
    }
}
