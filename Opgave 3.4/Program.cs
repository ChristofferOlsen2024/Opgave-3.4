// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hvor mange sider indholder dokomentet?");
int sideantal = Convert.ToInt32(Console.ReadLine());

int besparelse = sideantal / 2;

Console.WriteLine($"Du spare {besparelse} sider ved at printe på begge sider.");