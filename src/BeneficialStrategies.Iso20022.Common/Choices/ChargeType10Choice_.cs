// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the type of charge.
    /// </summary>
    [KnownType(typeof(ChargeType10Choice.Code))]
    [KnownType(typeof(ChargeType10Choice.Proprietary))]
    [JsonDerivedType(typeof(ChargeType10Choice.Code), nameof(ChargeType10Choice.Code))]
    [JsonDerivedType(typeof(ChargeType10Choice.Proprietary), nameof(ChargeType10Choice.Proprietary))]
    [IsoId("77dc244b-7c26-4186-9c1f-7e174d4ab443")]
    [DisplayName("Charge Type 10 Choice")]
    public abstract record ChargeType10Choice_ { }
}
