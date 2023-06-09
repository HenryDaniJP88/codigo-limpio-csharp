﻿
        List<string> TaskList = new List<string>();

       
            TaskList = new List<string>();
            int menuSelected = 0;
            do
            {
                menuSelected = ShowMainMenu();
                if ((Menu)menuSelected == Menu.Add)
                {
                    ShowMenuAdd();
                }
                else if ((Menu)menuSelected == Menu.Remove)
                {
                    ShowMenuRemove();
                }
                else if ((Menu)menuSelected == Menu.List)
                {
                    ShowMenuTaskList();
                }
            } while ((Menu)menuSelected != Menu.Exit);
        
        /// <summary>
        /// Show the main menu 
        /// </summary>
        /// <returns>Returns option indicated by user</returns>
        int ShowMainMenu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("INGRESE LA OPERACION A REALIZAR: ");
            Console.WriteLine("1. Nueva tarea");
            Console.WriteLine("2. Remover tarea");
            Console.WriteLine("3. Tareas pendientes");
            Console.WriteLine("4. Salir");

            // Read line
            string codigoMenu = Console.ReadLine();
            return Convert.ToInt32(codigoMenu);
        }

        void ShowMenuRemove()
        {
            try
            {
                Console.WriteLine("Ingrese el número de la tarea a remover: ");
                // Show current taks
                ShowTaskList();

                string line = Console.ReadLine();
                // Remove one position
                int indexToRemove = Convert.ToInt32(line) - 1;

                if (indexToRemove > (TaskList.Count - 1) || indexToRemove < 0) 
                Console.WriteLine("Numero de tarea seleccionado fuera de rango");
                else
                {
                    if (indexToRemove > -1 && TaskList.Count > 0)
                    {

                        string task = TaskList[indexToRemove];
                        TaskList.RemoveAt(indexToRemove);
                        Console.WriteLine("Tarea " + task + " eliminada");

                    }
                }

                
            }
            catch (Exception)
            {
                Console.WriteLine("Ha Ocuerrido un error al internar remover el Numero de Tarea Ingresada");
            }
        }

        void ShowMenuAdd()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre de la tarea: ");
                string taskAdded = Console.ReadLine();
                TaskList.Add(taskAdded);
                Console.WriteLine("Tarea registrada");
            }
            catch (Exception)
            {
                Console.WriteLine("Ha Ocurrido un error al agreagr la Tarea");
            }
        }

        void ShowMenuTaskList()
        {
            if (TaskList?.Count>0)
            {
                Console.WriteLine("----------------------------------------");
                var indexTask = 1;
                //esto es como el for de abajo
                indexTask = 1;
                TaskList.ForEach(p => Console.WriteLine($"{indexTask++}  . {p}"));
                Console.WriteLine("----------------------------------------");

            } 
            else
            {
                Console.WriteLine("No hay tareas por realizar");
            }
        }

        void ShowTaskList()
        {
            Console.WriteLine("----------------------------------------");
            for (int i = 0; i < TaskList.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + TaskList[i]);
            }
            Console.WriteLine("----------------------------------------");
        }

        public enum Menu
        {
          Add = 1,
          Remove = 2,
          List = 3,
          Exit = 4

        }
    

