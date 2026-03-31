// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType23Choice.Code))]
    [KnownType(typeof(FractionDispositionType23Choice.Proprietary))]
    [JsonDerivedType(
        typeof(FractionDispositionType23Choice.Code),
        nameof(FractionDispositionType23Choice.Code)
    )]
    [JsonDerivedType(
        typeof(FractionDispositionType23Choice.Proprietary),
        nameof(FractionDispositionType23Choice.Proprietary)
    )]
    [IsoId("_2CF8MWSEEeKFfdK0gKYFLQ")]
    [DisplayName("Fraction Disposition Type 23 Choice")]
    public abstract record FractionDispositionType23Choice_ { }
}
