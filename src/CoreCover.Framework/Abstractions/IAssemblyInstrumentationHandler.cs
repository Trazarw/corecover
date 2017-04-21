﻿// MIT License
// Copyright (c) 2017 Paulo Gomes

using Mono.Cecil;
using OpenCover.Framework.Model;

namespace CoreCover.Framework.Abstractions
{
    public interface IAssemblyInstrumentationHandler
    {
        void Handle(CoverageSession coverageSession, AssemblyDefinition assemblyDefinition);
    }
}