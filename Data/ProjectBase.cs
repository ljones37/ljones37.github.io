using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Data
{
    public abstract class ProjectBase : ComponentBase
    {
        public abstract string Name { get; }

        public abstract string Url { get; }

        public abstract string IconicImagePath { get; }

        public abstract Context ProjectContexts { get; }

        public abstract Area ProjectAreas { get; }

        public abstract Skill ProjectSkills { get; }
    }
    [Flags]
    public enum Context
    {
        WORK,
        SCHOOL,
        VOLUNTEER
    }

    [Flags]
    public enum Area
    {
        SOFTWARE,
        DESIGN,
        ENVIRONMENTAL
    }

    [Flags]
    public enum Skill
    {
        DOTNET = 0,
        CSS = 1,
        HTML = 2,
        JAVASCRIPT = 4,
        TEACHING = 8,
        WATER = 16,
        SOIL = 32,
        MATERIALSCIENCE = 64,
        MODELLING3D = 128,
        MODELLING2D = 256,
        DATAANALYSIS = 512,
        PLANTS = 1024,
        PRESENTATION = 2048
    }
}
