// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType28Choice.Code))]
    [KnownType(typeof(FractionDispositionType28Choice.Proprietary))]
    [JsonDerivedType(typeof(FractionDispositionType28Choice.Code),nameof(FractionDispositionType28Choice.Code))]
    [JsonDerivedType(typeof(FractionDispositionType28Choice.Proprietary),nameof(FractionDispositionType28Choice.Proprietary))]
    [IsoId("_1l-q4UGTEeWqy4niLuXETA")]
    [DisplayName("Fraction Disposition Type 28 Choice")]
    public abstract partial record FractionDispositionType28Choice_
    {
    }
}
