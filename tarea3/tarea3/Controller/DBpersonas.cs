using System;
using System.Collections.Generic;
using System.Text;
using tarea3.Models;
using SQLite;
using System.Threading.Tasks;

namespace tarea3.Controller
{
    public class DBpersonas
    {
        readonly SQLiteAsyncConnection dbbase;
        
        //Constructor de la clase  

        public DBpersonas(string dbpath)
        {
            //condision a la base de datos 
            dbbase = new SQLiteAsyncConnection(dbpath);


            //crearemos las tablas en la base de datos 
            dbbase.CreateTableAsync<personas>();
        }
        //hacemos la creacion del crud
        

        //Create
        public Task<int> personaSave(personas perso)
        {
            if (perso.id != 0)
            {
                return dbbase.UpdateAsync(perso);//actualizamos
            }
            else
            {
                return dbbase.InsertAsync(perso);//i si no esta lo inserta
            }
        }

        //con read podemos leer informacion de la tabla 
        //read
        public Task<List<personas>> obtnerlistapersonas()

        {
            return dbbase.Table<personas>().ToListAsync();
        }


        //para traer solo una persona 
        //read v2
        public Task<personas> obtnerpersonas(int pid)
        {
            return dbbase.Table<personas>().Where(i => i.id == pid).FirstOrDefaultAsync();
        }


        //eliminar
        public Task<int> eliminarpersonas(personas perso)
        {
            return dbbase.DeleteAsync(perso);

        }
    }
}
