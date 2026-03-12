// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status reason of the investigation request.
    /// </summary>
    [KnownType(typeof(InvestigationRequestStatusReason1Choice.Code))]
    [KnownType(typeof(InvestigationRequestStatusReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestigationRequestStatusReason1Choice.Code),nameof(InvestigationRequestStatusReason1Choice.Code))]
    [JsonDerivedType(typeof(InvestigationRequestStatusReason1Choice.Proprietary),nameof(InvestigationRequestStatusReason1Choice.Proprietary))]
    [IsoId("_xMmO4XbnEe2GR4CRzIB77g")]
    [DisplayName("Investigation Request Status Reason 1 Choice")]
    public abstract partial record InvestigationRequestStatusReason1Choice_
    {
    }
}
