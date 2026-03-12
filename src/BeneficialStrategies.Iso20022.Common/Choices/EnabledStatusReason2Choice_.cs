// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for an enabled reason code.
    /// </summary>
    [KnownType(typeof(EnabledStatusReason2Choice.Code))]
    [KnownType(typeof(EnabledStatusReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(EnabledStatusReason2Choice.Code),nameof(EnabledStatusReason2Choice.Code))]
    [JsonDerivedType(typeof(EnabledStatusReason2Choice.Proprietary),nameof(EnabledStatusReason2Choice.Proprietary))]
    [IsoId("_PtrCQEy-EeafiMTDrtSnyw")]
    [DisplayName("Enabled Status Reason 2 Choice")]
    public abstract partial record EnabledStatusReason2Choice_
    {
    }
}
