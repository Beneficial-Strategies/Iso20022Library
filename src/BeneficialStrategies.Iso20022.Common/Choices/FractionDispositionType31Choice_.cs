// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType31Choice.Code))]
    [KnownType(typeof(FractionDispositionType31Choice.Proprietary))]
    [JsonDerivedType(typeof(FractionDispositionType31Choice.Code),nameof(FractionDispositionType31Choice.Code))]
    [JsonDerivedType(typeof(FractionDispositionType31Choice.Proprietary),nameof(FractionDispositionType31Choice.Proprietary))]
    [IsoId("_ctaYB5KQEeWHWpTQn1FFVg")]
    [DisplayName("Fraction Disposition Type 31 Choice")]
    public abstract partial record FractionDispositionType31Choice_
    {
    }
}
