﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using YYA.CleanArchitecture.Application.Repositories;
using YYA.CleanArchitecture.Persistence.Context;
using YYA.CleanArchitecture.Persistence.Repositories;

namespace YYA.CleanArchitecture.Persistence
{
    public static class ServiceRegistrar
    {
        public static void AddPersistanceServices(this IServiceCollection serviceCollection , bool useInMemoryDb = false)
        {
            if (useInMemoryDb)
                serviceCollection.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("memoryDatabase"));


            serviceCollection.AddTransient<IProductRepository, ProductRepository>();

            
        }

    }
}