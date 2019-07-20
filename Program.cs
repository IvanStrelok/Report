	using System;
using System.Collections.Generic;

namespace Report
{
	class Account
	{
		public string name;
		public string surname;
		public string patronymic;
		public string phone;
		public string country;
		public int day;
		public int month;
		public int year;
		public string organisation;
		public string post;
		public string other;

		public void Output()
		{
			Console.WriteLine("Имя = {0}", name);
			Console.WriteLine("Фамилия = {0}", surname);
			Console.WriteLine("Отчество = {0}", patronymic);
			Console.WriteLine("Номер телефона = {0}", phone);
			Console.WriteLine("Страна = {0}", country);
			Console.WriteLine("День рождения = {0}", day);
			Console.WriteLine("Месяц рождения = {0}", month);
			Console.WriteLine("Год рождения = {0}", year);
			Console.WriteLine("Организация = {0}", organisation);
			Console.WriteLine("Должность = {0}", post);
			Console.WriteLine("Прочая информация = {0}", other);
			Console.WriteLine();
		}
	}

	class PhoneBook
	{
		public List<Account> accounts = new List<Account>();

		public void AddAccount()
		{
			Account New = new Account();

			Console.Write("Введите имя: ");
			New.name = Console.ReadLine();
			Console.Write("Введите фамилию: ");
			New.surname = Console.ReadLine();
			Console.Write("Введите отчество: ");
			New.patronymic = Console.ReadLine();
			Console.Write("Введите телефон: ");
			New.phone = Console.ReadLine();
			Console.Write("Введите страну: ");
			New.country = Console.ReadLine();
			Console.Write("Введите день рождения: ");
			New.day = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите месяц рождения: ");
			New.month = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите год рождения: ");
			New.year = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите организацию: ");
			New.organisation = Console.ReadLine();
			Console.Write("Введите должность: ");
			New.post = Console.ReadLine();
			Console.Write("Введите прочие заметки: ");
			New.other = Console.ReadLine();

			accounts.Add(New);
		}  
		public void EditAccount( ) 
		{
			int number, number2;

			Console.Write("Введите номер учетной записи (начиная с 0): ");
			number = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("1 - Изменить имя: ");
			Console.WriteLine("2 - Изменить фамилию: ");
			Console.WriteLine("3 - Изменить отчество: ");
			Console.WriteLine("4 - Изменить телефон: ");
			Console.WriteLine("5 - Изменить страну: ");
			Console.WriteLine("6 - Изменить день рождения: ");
			Console.WriteLine("7 - Изменить месяц рождения: ");
			Console.WriteLine("8 - Изменить год рождения: ");
			Console.WriteLine("9 - Изменить организацию: ");
			Console.WriteLine("10 - Изменить должность: ");
			Console.WriteLine("11 - Изменить прочие заметки: ");
			number2 = Convert.ToInt32(Console.ReadLine());
			switch (number2)
			{
				case 1:
					Console.Write("Введите имя: ");
					string name = Console.ReadLine();
					accounts[number].name = name;
					break;
				case 2:
					Console.Write("Введите фамилию: ");
					string surname = Console.ReadLine();
					accounts[number].surname = surname;
					break;
				case 3:
					Console.Write("Введите отчество: ");
					string patronymic= Console.ReadLine();
					accounts[number].patronymic = patronymic;
					break;
				case 4:
					Console.Write("Введите телефон: ");
					string phone = Console.ReadLine();
					accounts[number].phone = phone;
					break;
				case 5:
					Console.Write("Введите страну: ");
					string country = Console.ReadLine();
					accounts[number].country = country;
					break;
				case 6:
					Console.Write("Введите день рождения: ");
					int day = Convert.ToInt32(Console.ReadLine());
					accounts[number].day = day;
					break;
				case 7:
					Console.Write("Введите месяц рождения: ");
					int month = Convert.ToInt32(Console.ReadLine());
					accounts[number].month = month;
					break;
				case 8:
					Console.Write("Введите год рождения: ");
					int year = Convert.ToInt32(Console.ReadLine());
					accounts[number].year = year;
					break;
				case 9:
					Console.Write("Введите организацию: ");
					string organisation = Console.ReadLine();
					accounts[number].organisation = organisation;
					break;
				case 10:
					Console.Write("Введите должность: ");
					string post = Console.ReadLine();
					accounts[number].post = post;
					break;
				case 11:
					Console.Write("Введите прочую информацию: ");
					string other = Console.ReadLine();
					accounts[number].other = other;
					break;
			}
		}	
			
		public void DeleteAccount()
		{
			int number;

			Console.Write("Введите номер учетной записи (начиная с 0): ");
			number = Convert.ToInt32(Console.ReadLine());
			accounts.RemoveRange(number, 1);
		}

		public void OutputAccount()
		{
			int number;

			Console.Write("Введите номер учетной записи (начиная с 0): ");
			number = Convert.ToInt32(Console.ReadLine());
			accounts[number].Output();
		}
		public void Output()
		{
			foreach (var a in accounts)
				a.Output();																				 
		}
	}

	class Program
	{
		static void Main( string[] args )
		{
			PhoneBook book = new PhoneBook();
			while (true)
			{
				Console.WriteLine("1 - Создание новой учетной записи.");
				Console.WriteLine("2 - Редактирование созданных записей.");
				Console.WriteLine("3 - Удаление созданных записей.");
				Console.WriteLine("4 - Просмотр созданных учетных записей.");
				Console.WriteLine("5 - Просмотр всех созданных учетных записей.");
				Console.WriteLine("6 - Выход.");
				
				int a = Convert.ToInt32(Console.ReadLine());

				Console.Clear();
				switch (a)
				{
					case 1:
						book.AddAccount();
						break;
					case 2:
						book.EditAccount();
						break;
					case 3:
						book.DeleteAccount();
						break;
					case 4:
						book.OutputAccount();
						break;
					case 5:
						book.Output();
						break;
					case 6:
						return;
				}
			}
		}
	}
} 
