// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <inheritdoc cref="IChargeType3Choice"/>
    [KnownType(typeof(ChargeType3Choice.Code))]
    [KnownType(typeof(ChargeType3Choice.Proprietary))]
    [JsonDerivedType(typeof(ChargeType3Choice.Code), nameof(ChargeType3Choice.Code))]
    [JsonDerivedType(typeof(ChargeType3Choice.Proprietary), nameof(ChargeType3Choice.Proprietary))]
    [IsoId("_tjJEUVkyEeGeoaLUQk__nA_-594962709")]
    [DisplayName("Charge Type 3 Choice")]
    public abstract partial record ChargeType3Choice_ { }
}
