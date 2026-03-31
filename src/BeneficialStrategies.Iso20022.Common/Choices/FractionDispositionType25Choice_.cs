// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType25Choice.Code))]
    [KnownType(typeof(FractionDispositionType25Choice.Proprietary))]
    [JsonDerivedType(
        typeof(FractionDispositionType25Choice.Code),
        nameof(FractionDispositionType25Choice.Code)
    )]
    [JsonDerivedType(
        typeof(FractionDispositionType25Choice.Proprietary),
        nameof(FractionDispositionType25Choice.Proprietary)
    )]
    [IsoId("_CAVnIUECEeWVgfuHGaKtRQ")]
    [DisplayName("Fraction Disposition Type 25 Choice")]
    public abstract record FractionDispositionType25Choice_ { }
}
