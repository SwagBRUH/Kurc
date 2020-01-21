using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurc
{
   
       class Program
        {
            static void Main(string[] args)
            {
                bool flag = false;
                Console.WriteLine("Выберите параметр записи (1-Добавление;2-Перезапись) :");
                for (; ; )
                {
                    try
                    {
                        int parametr = int.Parse(Console.ReadLine());
                        if (parametr == 2)
                        {
                            flag = true;
                            break;
                        }
                        else if (parametr == 1)
                        {
                            flag = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Неверный ввод .Пожалуйста повторите ");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Неверный ввод .Пожалуйста повторите ");
                    }

                }
                StreamWriter file = new StreamWriter(("Result.txt"), true);
                if (flag == true)
                {
                    file.Close();
                    file = new StreamWriter(File.Create("Result.txt"));
                    file.WriteLine("БАЗА ДАННХ");
                }


                while (true)
                {
                    Console.WriteLine("БАЗА ДАННЫХ ");
                    Console.WriteLine("*********************************");
                    Console.WriteLine("*****Меню*****");
                    Console.WriteLine("1-Ввод из файла");
                    Console.WriteLine("2-Ввод из консоли");
                    Console.WriteLine("3-Очистить базу данных");
                    Console.WriteLine("4-Завершить редактирование");
                    Console.WriteLine("5-Выход из программы");
                    int sp = int.Parse(Console.ReadLine());
                    switch (sp)
                    {
                        case 1:
                            try
                            {
                                int i = 0;
                                Sportsmancs[] sportsmancsf = new Sportsmancs[30];
                                Teems[] teemsf = new Teems[30];
                                typs[] typsf = new typs[30];
                                vids[] vidsf = new vids[30];

                                StreamReader sr = File.OpenText("Sportsmancs.txt");
                                StreamReader sr2 = File.OpenText("Teems.txt");
                                StreamReader sr3 = File.OpenText("vids.txt");

                                while (true)
                                {
                                    
                                    string str = sr.ReadLine();
                                    if (str == null)
                                        break;
                                    string[] elements = str.Split(';');


                                    //(считывание значений)
                                    sportsmancsf[i] = new Sportsmancs();

                                    sportsmancsf[i].setfio_s(elements[0]); 
                                    sportsmancsf[i].setgod_r(int.Parse(elements[1]));                               
                                    sportsmancsf[i].setteam(elements[2]); 
                                    sportsmancsf[i].setsport_raz((elements[3]));
                                sportsmancsf[i].setlich_record((elements[4]));
                                sportsmancsf[i].setvid_S((elements[5]));

                                teemsf[i] = new Teems();
                                    teemsf[i].setfio_t(elements[6]); 
                                    teemsf[i].setname_t((elements[7])); 
                                    teemsf[i].setsity((elements[8])); 
                                   

                                    

                                    string strn = sr2.ReadLine();
                                    if (strn == null)
                                        break;
                                    string[] elementsn = strn.Split(';');


                                    
                                    vidsf[i] = new vids();
                                    vidsf[i].setnaim_sar((elementsn[0]));
                                    vidsf[i].setmesto_prov(elementsn[1]);
                                    vidsf[i].setdata_prov(DateTime.Parse(elementsn[3]));
                                    

                                    string strs = sr3.ReadLine();
                                    if (strs == null)
                                        break;
                                    string[] elementss = strs.Split(';');

                                    
                                    typsf[i] = new typs();
                                    typsf[i].setnaz_vid((elementss[0]));
                                    typsf[i].setedin_iz(elementss[1]);
                                    typsf[i].setword_rec((elementss[2]));
                                    typsf[i].setdata_rec(DateTime.Parse(elementss[3]));
                                    


                                    i++;
                                }
                                sr.Close();
                                i = 0;
                                while (true)
                                {
                                    if (sportsmancsf[i] == null) break;
                                   
                                    Console.WriteLine("[" + (i + 1) + "]");
                                    file.WriteLine("[" + (i + 1) + "]");
                                    sportsmancsf[i].Print();
                                    sportsmancsf[i].Printf(file);
                                    
                                    Console.WriteLine("[" + (i + 1) + "]");
                                    file.WriteLine("[" + (i + 1) + "]");
                                    teemsf[i].Print();
                                    teemsf[i].Printf(file);
                                    file.WriteLine("***************");
                                    Console.WriteLine("===============");
                                    i++;
                                }
                                i = 0;
                                while (true)
                                {
                                    if (vidsf[i] == null) break;
                                    
                                    Console.WriteLine("[" + (i + 1) + "]");
                                    file.WriteLine("[" + (i + 1) + "]");
                                    vidsf[i].Print();
                                    vidsf[i].Printf(file);


                                    i++;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("---Ошибка при заполнении!Повторите ввод---");
                            }
                            break;


                        case 2:
                            int n;
                            for (; ; )
                            {
                                try
                                {
                                    Console.WriteLine("Введите кол.участ:");
                                    n = int.Parse(Console.ReadLine());
                                    if (n > 0)
                                    {
                                        break;
                                    }

                                    else
                                    {
                                        Console.WriteLine("---Значение введено неверно!Пожалуйста повторите ввод---");
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("---Значение введено неверно!Пожалуйста повторите ввод---");
                                }

                            }

                            Sportsmancs[] sportsmancs = new Sportsmancs[n];
                            vids[] vids = new vids[n];
                            Teems[] teems = new Teems[n];


                            for (int i = 0; i < n; i++)
                            {

                                sportsmancs[i] = new Sportsmancs();
                                for (; ; )
                                {
                                    try
                                    {
                                        Console.WriteLine("FIO");
                                        sportsmancs[i].setfio_s(Console.ReadLine());
                                        break;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("---Значение введено неверно!Пожалуйста повторите ввод---");
                                    }
                                }

                                for (; ; )
                                {
                                    try
                                    {
                                        Console.WriteLine("GOD rojd:");
                                        sportsmancs[i].setgod_r(int.Parse(Console.ReadLine()));
                                        break;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("---Значение введено неверно!Пожалуйста повторите ввод---");
                                    }
                                }



                                for (; ; )
                                {
                                    try
                                    {
                                        Console.WriteLine("teams:");
                                        sportsmancs[i].setteam((Console.ReadLine()));
                                        break;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("---Значение введено неверно!Пожалуйста повторите ввод---");
                                    }
                                }
                            for (; ; )
                            {
                                try
                                {
                                    Console.WriteLine("Sport raz:");
                                    sportsmancs[i].setsport_raz((Console.ReadLine()));
                                    break;
                                }
                                catch
                                {
                                    Console.WriteLine("---Значение введено неверно!Пожалуйста повторите ввод---");
                                }
                            }
                            for (; ; )
                            {
                                try
                                {
                                    Console.WriteLine("Lichniy record:");
                                    sportsmancs[i].setlich_record((Console.ReadLine()));
                                    break;
                                }
                                catch
                                {
                                    Console.WriteLine("---Значение введено неверно!Пожалуйста повторите ввод---");
                                }
                            }
                            for (; ; )
                            {
                                try
                                {
                                    Console.WriteLine("vid sporta:");
                                    sportsmancs[i].setvid_S((Console.ReadLine()));
                                    break;
                                }
                                catch
                                {
                                    Console.WriteLine("---Значение введено неверно!Пожалуйста повторите ввод---");
                                }
                            }


                            teems[i] = new Teems();
                                for (; ; )
                                {
                                    try
                                    {
                                        Console.WriteLine("Naz team");
                                        teems[i].setname_t(Console.ReadLine());
                                        break;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("---Значение введено неверно!Пожалуйста повторите ввод---");
                                    }
                                }

                                for (; ; )
                                {
                                try
                                {
                                    Console.WriteLine("FIO trenera");
                                    teems[i].setfio_t((Console.ReadLine()));

                                    break;
                                }
                                        
                                        
                                        
                                    catch
                                    {
                                        Console.WriteLine("---Значение введено неверно!Пожалуйста повторите ввод---");
                                    }
                                }
                                for (; ; )
                                {
                                    try
                                    {
                                        Console.WriteLine("GOROD");
                                        teems[i].setsity((Console.ReadLine()));
                                        
                                        
                                            break;
                                        
                                        
                                    }

                                    catch
                                    {
                                        Console.WriteLine("---Значение введено неверно!Пожалуйста повторите ввод---");
                                    }
                                }
                            for (; ; )
                            {
                                try
                                {
                                    Console.WriteLine("Naim sorev");
                                    teems[i].setnaim_sar((Console.ReadLine()));


                                    break;


                                }

                                catch
                                {
                                    Console.WriteLine("---Значение введено неверно!Пожалуйста повторите ввод---");
                                }
                            }
                            for (; ; )
                            {
                                try
                                {
                                    Console.WriteLine("mesto prov");
                                    teems[i].setmest_prov((Console.ReadLine()));


                                    break;


                                }

                                catch
                                {
                                    Console.WriteLine("---Значение введено неверно!Пожалуйста повторите ввод---");
                                }
                            }
                            for (; ; )
                            {
                                try
                                {
                                    Console.WriteLine("Data prov");
                                    teems[i].setdata_prov(DateTime.Parse(Console.ReadLine()));


                                    break;


                                }

                                catch
                                {
                                    Console.WriteLine("---Значение введено неверно!Пожалуйста повторите ввод---");
                                }
                            }

                        }

                              

                                







                            break;

                        case 3: file.Close(); return;
                        case 4: Environment.Exit(0); break;
                        default:
                            Console.WriteLine("Введено неверное значение");
                            Console.ReadKey();
                            break;
                    };


                }
            }
        }
    }
