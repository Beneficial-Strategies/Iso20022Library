// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType27Choice.Code))]
    [KnownType(typeof(FractionDispositionType27Choice.Proprietary))]
    [JsonDerivedType(typeof(FractionDispositionType27Choice.Code),nameof(FractionDispositionType27Choice.Code))]
    [JsonDerivedType(typeof(FractionDispositionType27Choice.Proprietary),nameof(FractionDispositionType27Choice.Proprietary))]
    [IsoId("_61TwIUGLEeWqy4niLuXETA")]
    [DisplayName("Fraction Disposition Type 27 Choice")]
    public abstract partial record FractionDispositionType27Choice_
    {
    }
}
