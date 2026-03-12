// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType26Choice.Code))]
    [KnownType(typeof(FractionDispositionType26Choice.Proprietary))]
    [JsonDerivedType(typeof(FractionDispositionType26Choice.Code),nameof(FractionDispositionType26Choice.Code))]
    [JsonDerivedType(typeof(FractionDispositionType26Choice.Proprietary),nameof(FractionDispositionType26Choice.Proprietary))]
    [IsoId("_lsfIQUEHEeWVgfuHGaKtRQ")]
    [DisplayName("Fraction Disposition Type 26 Choice")]
    public abstract partial record FractionDispositionType26Choice_
    {
    }
}
