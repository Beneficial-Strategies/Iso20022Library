// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType9Choice.Code))]
    [KnownType(typeof(FractionDispositionType9Choice.Proprietary))]
    [JsonDerivedType(
        typeof(FractionDispositionType9Choice.Code),
        nameof(FractionDispositionType9Choice.Code)
    )]
    [JsonDerivedType(
        typeof(FractionDispositionType9Choice.Proprietary),
        nameof(FractionDispositionType9Choice.Proprietary)
    )]
    [IsoId("_zfe2weHDEd-1Ktb5rVaajw")]
    [DisplayName("Fraction Disposition Type 9 Choice")]
    public abstract record FractionDispositionType9Choice_ { }
}
