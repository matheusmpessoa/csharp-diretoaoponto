using System;
namespace CsharpDiretoAoPonto
{
	public class File
	{
		public File()
		{
            #region
            var file = @"pasta";

            if (!File.Exists(file))
            {
                File.CreateText(file);
            }

            var fileInfo = new FileInfo(file);

            Console.WriteLine($"Nome: {fileInfo.Name}, Tamanho: {fileInfo.Length}," +
                $"Data de atualização: {fileInfo.LastWriteTime}");

            #endregion

            Console.ReadKey();
        }
    }
}

