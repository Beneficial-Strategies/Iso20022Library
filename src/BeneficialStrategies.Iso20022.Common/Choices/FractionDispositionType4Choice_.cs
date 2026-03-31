// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType4Choice.Code))]
    [KnownType(typeof(FractionDispositionType4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(FractionDispositionType4Choice.Code),
        nameof(FractionDispositionType4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(FractionDispositionType4Choice.Proprietary),
        nameof(FractionDispositionType4Choice.Proprietary)
    )]
    [IsoId("_Q08B8Np-Ed-ak6NoX_4Aeg_-1812394474")]
    [DisplayName("Fraction Disposition Type 4 Choice")]
    public abstract record FractionDispositionType4Choice_ { }
}
