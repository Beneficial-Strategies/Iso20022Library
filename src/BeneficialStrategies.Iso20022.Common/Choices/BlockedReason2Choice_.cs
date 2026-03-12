// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the reason.
    /// </summary>
    [KnownType(typeof(BlockedReason2Choice.Code))]
    [KnownType(typeof(BlockedReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(BlockedReason2Choice.Code),nameof(BlockedReason2Choice.Code))]
    [JsonDerivedType(typeof(BlockedReason2Choice.Proprietary),nameof(BlockedReason2Choice.Proprietary))]
    [IsoId("_Pc7lEVr3Eea4y99eritluQ")]
    [DisplayName("Blocked Reason 2 Choice")]
    public abstract partial record BlockedReason2Choice_
    {
    }
}
