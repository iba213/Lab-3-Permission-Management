﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Permission_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add 4 users with none permissions (Admin, operator, manager,senior)
            User operatorUser = new User("operator");
            User SeniorUser = new User("senior");
            User managerUser = new User("manager");
            User adminUser = new User("admin");
            /**
             * 
             * Add read permission to operatorUser look at line 25 to line 31
             * Add read, write, execute permissions to manager
             * Add read, write permissions to senior
             * Add full permission(read,write,execution) to admin
             */
            operatorUser.AddPermission(Permissions.Read);
            if(operatorUser.HasPermission(Permissions.Read))
                Console.WriteLine("Operator has read permission");
            else
                Console.WriteLine("Operator does not have read permission");

            /**
             * Look at tasks description in lab3.1 and complete the remaining tasks
             */

            managerUser.multiplyPermission(Permission.read, Permission.write);
            managerUser.addPermission(Permission.execute);

            seniorUser.multiplyPermission(Permission.read, Permission.write);
            


        }
    }
}
