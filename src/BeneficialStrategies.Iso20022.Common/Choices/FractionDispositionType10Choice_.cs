// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType10Choice.Code))]
    [KnownType(typeof(FractionDispositionType10Choice.Proprietary))]
    [JsonDerivedType(typeof(FractionDispositionType10Choice.Code),nameof(FractionDispositionType10Choice.Code))]
    [JsonDerivedType(typeof(FractionDispositionType10Choice.Proprietary),nameof(FractionDispositionType10Choice.Proprietary))]
    [IsoId("_XZY5UeHEEd-1Ktb5rVaajw")]
    [DisplayName("Fraction Disposition Type 10 Choice")]
    public abstract partial record FractionDispositionType10Choice_
    {
    }
}
