//1) Arquivo "nomes_telefones" para cada número de telefone, retirar os parenteses e traços e apresentar no console

//TextReader reader = new StreamReader("C:\\Aula6\\nomes_telefones.txt");
////TextReader tr = new StreamReader(@"C:\Users\...\Desktop\Test.txt"); 
//string linha = reader.ReadLine();
//string[] removerstring = { "(", ")", "-" };
//while (linha != null)
//{
//    foreach (var c in removerstring)
//    {
//        linha = linha.Replace(c, "");
//    }

//    Console.WriteLine(linha);
//    linha = reader.ReadLine();
//}

//2) Arquivo "nomes_telefones" para cada nome de pessoa, verificar os maiores de 12 caracteres e apresentar na tela os mesmos em UpperCase


//TextReader reader = new StreamReader("C:\\Aula6\\nomes_telefones.txt");
//string linha;

//while ((linha = reader.ReadLine()) != null)
//{
//    string[] campos = linha.Split(' ');

//    string nomeCompleto = campos[0] + " " + campos[1];

//    if (nomeCompleto.Length > 12)
//    {
//        Console.WriteLine(nomeCompleto.ToUpper());
//    }
//}
//reader.Close();

// 3) Arquivo "datas" extrair somente o ano e mostrar no console

//TextReader reader = new StreamReader("C:\\Aula6\\datas.txt");
//string linha;
//while ((linha = reader.ReadLine()) != null)
//{
//    DateTime data;
//    if (DateTime.TryParse(linha, out data))
//    {
//        int ano = data.Year;
//        Console.WriteLine(ano);
//    }
//}
//reader.Close();

// 4) Arquivo "marcas_carros" extrair somente as marcas e apresentar no console

//TextReader reader = new StreamReader("C:\\Aula6\\marcas_carros.txt");
//string linha;
//while ((linha = reader.ReadLine()) != null)
//{
//    int indiceArroba = linha.IndexOf('@');
//    if (indiceArroba != -1)
//    {
//        string marca = linha.Substring(0, indiceArroba).Trim();
//        Console.WriteLine(marca);
//    }
//}
//reader.Close();

//5) Arquivo “produtos_estoque” mostrar o valor total de itens em estoque e o valor total em $.


//TextReader reader = new StreamReader("C:\\Aula6\\produtos_estoque.txt");
//string linha;
//decimal valorTotalEstoque = 0;
//int quantidadeTotal = 0;

//while ((linha = reader.ReadLine()) != null)
//{
//    string[] partes = linha.Split('\t');

//    decimal preco = Decimal.Parse(partes[1].Replace("$", "").Replace(".",","));
//    int quantidade = Int32.Parse(partes[2].Replace("|", "").Trim());

//    if (quantidade > 0)
//    {
//        valorTotalEstoque += preco;
//        quantidadeTotal += quantidade;
//    }
//}

//reader.Close();

//Console.WriteLine("Quantidade total de itens em estoque: " + quantidadeTotal);
//Console.WriteLine("Valor total de itens em estoque: " + valorTotalEstoque.ToString("0.00"));







