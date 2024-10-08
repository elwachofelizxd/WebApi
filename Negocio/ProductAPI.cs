﻿using Negocio.Modelo_;

namespace Negocio
{
    public class ProductsAPI
    {
        public List<Products> GetAll()
        {
            return Datos.listaProductos.OrderBy(item => item.id).ToList();
        }
        public Products GetById(int id)
        {
            return Datos.listaProductos.Where(item => item.id == id).First();
        }
        public void Update(Products producto) { }
        public int Delete(int id)
        {
            if (Datos.listaProductos.Any(p => p.id == id))
            {
                return Datos.listaProductos.RemoveAll(item => item.id == id);
            }
            else
            {
                return 0;
            }
        }
        public Products Put(Products prod)
        {
         
                var product = Datos.listaProductos.Where(item => item.id == prod.id).First();
            Datos.listaProductos.Remove(product);
            Datos.listaProductos.Add(prod);
            return product;
        }
        public Products Post(Products producto)
        {
            producto.id = Datos.listaProductos.Count() + 1;
            Datos.listaProductos.Add(producto);

            return producto;
        }
    }
}