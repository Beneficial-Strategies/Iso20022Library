// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of cost or charge.
    /// </summary>
    [KnownType(typeof(ChargeType8Choice.Code))]
    [KnownType(typeof(ChargeType8Choice.Proprietary))]
    [JsonDerivedType(typeof(ChargeType8Choice.Code), nameof(ChargeType8Choice.Code))]
    [JsonDerivedType(typeof(ChargeType8Choice.Proprietary), nameof(ChargeType8Choice.Proprietary))]
    [IsoId("_qPIXQZ9BEeqxTNfi5y7ywQ")]
    [DisplayName("Charge Type 8 Choice")]
    public abstract record ChargeType8Choice_ { }
}
