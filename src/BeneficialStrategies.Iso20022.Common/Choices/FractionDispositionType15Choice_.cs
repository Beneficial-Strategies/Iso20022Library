// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of fraction disposition.
    /// </summary>
    [KnownType(typeof(FractionDispositionType15Choice.Code))]
    [KnownType(typeof(FractionDispositionType15Choice.Proprietary))]
    [JsonDerivedType(typeof(FractionDispositionType15Choice.Code),nameof(FractionDispositionType15Choice.Code))]
    [JsonDerivedType(typeof(FractionDispositionType15Choice.Proprietary),nameof(FractionDispositionType15Choice.Proprietary))]
    [IsoId("_D3_naWSDEeKFfdK0gKYFLQ")]
    [DisplayName("Fraction Disposition Type 15 Choice")]
    public abstract partial record FractionDispositionType15Choice_
    {
    }
}
