﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using ScreenColor.Common.Interfaces;
using ScreenColor.Common.Services;

namespace ScreenColor
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            _kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            _kernel.Bind<IColorService>().To<BlueService>();
        }
    }
}