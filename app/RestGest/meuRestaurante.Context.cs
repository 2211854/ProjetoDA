﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestGest
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class meuRestauranteContainer : DbContext
    {
        public meuRestauranteContainer()
            : base("name=meuRestauranteContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CategoriaSet> CategoriaSet { get; set; }
        public virtual DbSet<EstadoSet> EstadoSet { get; set; }
        public virtual DbSet<ItemMenuSet> ItemMenuSet { get; set; }
        public virtual DbSet<MetodoPagamentoSet> MetodoPagamentoSet { get; set; }
        public virtual DbSet<MoradaSet> MoradaSet { get; set; }
        public virtual DbSet<PagamentoSet> PagamentoSet { get; set; }
        public virtual DbSet<PedidoSet> PedidoSet { get; set; }
        public virtual DbSet<PessoaSet> PessoaSet { get; set; }
        public virtual DbSet<PessoaSet_Cliente> PessoaSet_Cliente { get; set; }
        public virtual DbSet<PessoaSet_Trabalhador> PessoaSet_Trabalhador { get; set; }
        public virtual DbSet<RestauranteSet> RestauranteSet { get; set; }
    }
}
