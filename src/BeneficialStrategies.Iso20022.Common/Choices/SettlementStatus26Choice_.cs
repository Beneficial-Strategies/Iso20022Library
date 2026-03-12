// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus26Choice.Code))]
    [KnownType(typeof(SettlementStatus26Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementStatus26Choice.Code),nameof(SettlementStatus26Choice.Code))]
    [JsonDerivedType(typeof(SettlementStatus26Choice.Proprietary),nameof(SettlementStatus26Choice.Proprietary))]
    [IsoId("_Xr1O0eFWEeWIA4E9cYSxxQ")]
    [DisplayName("Settlement Status 26 Choice")]
    public abstract partial record SettlementStatus26Choice_
    {
    }
}
