// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code for specifying the type of charge.
    /// </summary>
    [KnownType(typeof(ChargeTypeFormat3Choice.Code))]
    [KnownType(typeof(ChargeTypeFormat3Choice.Proprietary))]
    [JsonDerivedType(typeof(ChargeTypeFormat3Choice.Code),nameof(ChargeTypeFormat3Choice.Code))]
    [JsonDerivedType(typeof(ChargeTypeFormat3Choice.Proprietary),nameof(ChargeTypeFormat3Choice.Proprietary))]
    [IsoId("_SumZGAEcEeCQm6a_G2yO_w_-323624829")]
    [DisplayName("Charge Type Format 3 Choice")]
    public abstract partial record ChargeTypeFormat3Choice_
    {
    }
}
