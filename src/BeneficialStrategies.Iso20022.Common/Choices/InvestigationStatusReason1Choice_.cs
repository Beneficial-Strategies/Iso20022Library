// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Investigation Status Reason1Choice.
    /// </summary>
    [KnownType(typeof(InvestigationStatusReason1Choice.Code))]
    [KnownType(typeof(InvestigationStatusReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestigationStatusReason1Choice.Code),nameof(InvestigationStatusReason1Choice.Code))]
    [JsonDerivedType(typeof(InvestigationStatusReason1Choice.Proprietary),nameof(InvestigationStatusReason1Choice.Proprietary))]
    [IsoId("_CXmCpFRtEe23M4WgERMsYw")]
    [DisplayName("Investigation Status Reason1Choice")]
    public abstract partial record InvestigationStatusReason1Choice_
    {
    }
}
