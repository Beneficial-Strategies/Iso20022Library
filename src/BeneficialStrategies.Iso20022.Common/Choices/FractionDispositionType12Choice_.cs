// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType12Choice.Code))]
    [KnownType(typeof(FractionDispositionType12Choice.Proprietary))]
    [JsonDerivedType(
        typeof(FractionDispositionType12Choice.Code),
        nameof(FractionDispositionType12Choice.Code)
    )]
    [JsonDerivedType(
        typeof(FractionDispositionType12Choice.Proprietary),
        nameof(FractionDispositionType12Choice.Proprietary)
    )]
    [IsoId("_ozHvwfYREd-STaetCa3CBw")]
    [DisplayName("Fraction Disposition Type 12 Choice")]
    public abstract record FractionDispositionType12Choice_ { }
}
