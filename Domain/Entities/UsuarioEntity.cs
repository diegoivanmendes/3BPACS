﻿namespace _3BPACS.Domain.Entities
{
    public class UsuarioEntity
    {
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }


        public UsuarioEntity(string nomeUsuario, string senha) { 
            NomeUsuario = nomeUsuario;
            Senha = senha;  
        }    
    }

}