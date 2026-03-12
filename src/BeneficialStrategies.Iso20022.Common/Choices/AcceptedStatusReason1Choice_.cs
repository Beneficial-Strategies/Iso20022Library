// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for an accepted status reason code.
    /// </summary>
    [KnownType(typeof(AcceptedStatusReason1Choice.Code))]
    [KnownType(typeof(AcceptedStatusReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(AcceptedStatusReason1Choice.Code),nameof(AcceptedStatusReason1Choice.Code))]
    [JsonDerivedType(typeof(AcceptedStatusReason1Choice.Proprietary),nameof(AcceptedStatusReason1Choice.Proprietary))]
    [IsoId("_wEWdkWBlEeaR1OOiVxm3Gg")]
    [DisplayName("Accepted Status Reason 1 Choice")]
    public abstract partial record AcceptedStatusReason1Choice_
    {
    }
}
