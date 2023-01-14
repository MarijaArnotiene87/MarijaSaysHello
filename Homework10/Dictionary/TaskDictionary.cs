namespace Homework10.Dictionary
{
    public static class TaskDictionary
    {
        public static void SortAndMerge(List<int> list1, List<string> list2)
        {
            list1.Sort();
            list2.Sort();
            list2.Reverse();

            var mergedLists = new Dictionary<int, string>();
            for (int i = 0; i < list1.Count; i++)
            {
                mergedLists.Add(list1[i], list2[i]);
                Console.WriteLine($"{list1[i]} - {list2[i]}");
            }
        }

        public static void SortCities(Dictionary<string, KeyValuePair<string, City>> cities)
        {
            List<KeyValuePair<string, KeyValuePair<string, City>>> citiesSortedList = cities.ToList();

            citiesSortedList.Sort((firstValue, nextValue) => firstValue.Value.Value.Area.CompareTo(nextValue.Value.Value.Area));
            Dictionary<string, KeyValuePair<string, City>> citiesSortedDict = citiesSortedList.ToDictionary(keyItem => keyItem.Key, keyItem => keyItem.Value);

            foreach (var item in citiesSortedDict)
            {
                Console.WriteLine($"City {item.Key} area: {item.Value.Value.Area}");
            }
        }

        public static void BrowseByPopulationReverse(Dictionary<string, KeyValuePair<string, City>> cities)
        {
            List<KeyValuePair<string, KeyValuePair<string, City>>> citiesSortedList = cities.ToList();

            citiesSortedList.Sort((firstValue, nextValue) => firstValue.Value.Value.Population.CompareTo(nextValue.Value.Value.Population));
            citiesSortedList.Reverse();

            Dictionary<string, KeyValuePair<string, City>> citiesSortedDict = citiesSortedList.ToDictionary(keyItem => keyItem.Key, keyItem => keyItem.Value);

            foreach (var item in citiesSortedDict)
            {
                Console.WriteLine($"City {item.Key} population: {item.Value.Value.Population}");
            }
        }

        public static void CountTotalPopulation(Dictionary<string, KeyValuePair<string, City>> cities)
        {
            var populationSum = 0;
            foreach (var item in cities)
            {
                populationSum += item.Value.Value.Population;
            }

            Console.WriteLine($"Total population of all cities: {populationSum}");
        }

    }
}
