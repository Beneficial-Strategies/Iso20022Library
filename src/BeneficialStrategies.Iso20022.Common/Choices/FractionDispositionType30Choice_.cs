// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType30Choice.Code))]
    [KnownType(typeof(FractionDispositionType30Choice.Proprietary))]
    [JsonDerivedType(
        typeof(FractionDispositionType30Choice.Code),
        nameof(FractionDispositionType30Choice.Code)
    )]
    [JsonDerivedType(
        typeof(FractionDispositionType30Choice.Proprietary),
        nameof(FractionDispositionType30Choice.Proprietary)
    )]
    [IsoId("_cj7rQ5KQEeWHWpTQn1FFVg")]
    [DisplayName("Fraction Disposition Type 30 Choice")]
    public abstract record FractionDispositionType30Choice_ { }
}
