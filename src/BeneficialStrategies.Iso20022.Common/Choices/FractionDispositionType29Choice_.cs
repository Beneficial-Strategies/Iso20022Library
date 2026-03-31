// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType29Choice.Code))]
    [KnownType(typeof(FractionDispositionType29Choice.Proprietary))]
    [JsonDerivedType(
        typeof(FractionDispositionType29Choice.Code),
        nameof(FractionDispositionType29Choice.Code)
    )]
    [JsonDerivedType(
        typeof(FractionDispositionType29Choice.Proprietary),
        nameof(FractionDispositionType29Choice.Proprietary)
    )]
    [IsoId("_chdmX5KQEeWHWpTQn1FFVg")]
    [DisplayName("Fraction Disposition Type 29 Choice")]
    public abstract record FractionDispositionType29Choice_ { }
}
