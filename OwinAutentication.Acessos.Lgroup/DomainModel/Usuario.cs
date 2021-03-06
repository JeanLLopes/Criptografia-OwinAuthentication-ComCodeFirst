﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinAutentication.Acessos.Lgroup.DomainModel
{
    //Para que possamos usar o aspnet identity
    //Precisamos instalar os seguintes pacotes:

    //1 - Usar o aspnetIdentity com entityFramework
    //Install-package Microsoft.aspnet.identity.entityFramework

    //2 - Usar com o pipeline do Owin
    //Install-package Microsoft.aspnet.identity.owin

    //3 - Trabalharmos com login usando owin    
    //Install-package Microsoft.owin.security
    public class Usuario 
        : IdentityUser
    {
        //Para adicionar mais itens, basta coloca-lo na classe que herda de IdentityUser
        public string Cpf { get; set; }
    }
}
