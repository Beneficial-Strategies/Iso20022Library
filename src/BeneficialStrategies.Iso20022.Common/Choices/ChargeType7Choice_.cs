// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of cost or charge.
    /// </summary>
    [KnownType(typeof(ChargeType7Choice.Code))]
    [KnownType(typeof(ChargeType7Choice.Proprietary))]
    [JsonDerivedType(typeof(ChargeType7Choice.Code), nameof(ChargeType7Choice.Code))]
    [JsonDerivedType(typeof(ChargeType7Choice.Proprietary), nameof(ChargeType7Choice.Proprietary))]
    [IsoId("_tM9ZIDcnEeidBoT_PugKiA")]
    [DisplayName("Charge Type 7 Choice")]
    public abstract record ChargeType7Choice_ { }
}
