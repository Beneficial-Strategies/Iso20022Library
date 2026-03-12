// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType32Choice.Code))]
    [KnownType(typeof(FractionDispositionType32Choice.Proprietary))]
    [JsonDerivedType(typeof(FractionDispositionType32Choice.Code),nameof(FractionDispositionType32Choice.Code))]
    [JsonDerivedType(typeof(FractionDispositionType32Choice.Proprietary),nameof(FractionDispositionType32Choice.Proprietary))]
    [IsoId("_c5Lh-5KQEeWHWpTQn1FFVg")]
    [DisplayName("Fraction Disposition Type 32 Choice")]
    public abstract partial record FractionDispositionType32Choice_
    {
    }
}
