// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType17Choice.Code))]
    [KnownType(typeof(FractionDispositionType17Choice.Proprietary))]
    [JsonDerivedType(typeof(FractionDispositionType17Choice.Code),nameof(FractionDispositionType17Choice.Code))]
    [JsonDerivedType(typeof(FractionDispositionType17Choice.Proprietary),nameof(FractionDispositionType17Choice.Proprietary))]
    [IsoId("_ootVsWSDEeKFfdK0gKYFLQ")]
    [DisplayName("Fraction Disposition Type 17 Choice")]
    public abstract partial record FractionDispositionType17Choice_
    {
    }
}
