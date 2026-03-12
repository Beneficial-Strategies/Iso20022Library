// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType19Choice.Code))]
    [KnownType(typeof(FractionDispositionType19Choice.Proprietary))]
    [JsonDerivedType(typeof(FractionDispositionType19Choice.Code),nameof(FractionDispositionType19Choice.Code))]
    [JsonDerivedType(typeof(FractionDispositionType19Choice.Proprietary),nameof(FractionDispositionType19Choice.Proprietary))]
    [IsoId("_ImikQWSEEeKFfdK0gKYFLQ")]
    [DisplayName("Fraction Disposition Type 19 Choice")]
    public abstract partial record FractionDispositionType19Choice_
    {
    }
}
