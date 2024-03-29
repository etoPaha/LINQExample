﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExample
{
    public class SimpleExample
    {
        private static string[] films =
        {
            "От заката до рассвета", "Ритуал", "Солнцестояние", 
            "Бешенные псы", "Криминальное чтиво", "Из ада", "Клетка"
        };
        
        /// <summary>
        /// Простой отбор
        /// </summary>
        public static void StartWithBasicExample()
        {
            var selectedFilms = new List<string>();
            foreach (string film in films)
            {
                if (film.ToUpper().StartsWith("Б"))
                    selectedFilms.Add(film);
            }
            selectedFilms.Sort();

            foreach (string selectedFilm in selectedFilms)
            {
                Console.WriteLine(selectedFilm);
            }
        }
        
        /// <summary>
        /// Использование LINQ запроса
        /// </summary>
        public static void StartLINQExample()
        {
            var selectedFilms = from film in films
                where film.ToUpper().StartsWith("Б")
                orderby film
                select film;

            foreach (string selectedFilm in selectedFilms)
            {
                Console.WriteLine(selectedFilm);
            }
        }

        /// <summary>
        /// Использование методов расширения
        /// </summary>
        public static void StartLinqExtentionExample()
        {
            var selectedFilms = films
                .Where(team => team.ToUpper().StartsWith("К"))
                .OrderBy(team => team);

            foreach (string selectedFilm in selectedFilms)
                Console.WriteLine(selectedFilm);
        }

        /// <summary>
        /// Комбиниованный вариант
        /// запрос + метод расширения
        /// </summary>
        public static void StartCombineExample()
        {
            int selectedFilmsCount = (from film in films where film.ToUpper().StartsWith("К") select film).Count();

            Console.WriteLine($"Количество фильмов с названием на 'К' {selectedFilmsCount}");
        }
    }
}