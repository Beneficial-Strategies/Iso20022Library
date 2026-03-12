// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status of the investigation request.
    /// </summary>
    [KnownType(typeof(InvestigationRequestStatus1Choice.Code))]
    [KnownType(typeof(InvestigationRequestStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestigationRequestStatus1Choice.Code),nameof(InvestigationRequestStatus1Choice.Code))]
    [JsonDerivedType(typeof(InvestigationRequestStatus1Choice.Proprietary),nameof(InvestigationRequestStatus1Choice.Proprietary))]
    [IsoId("_ffuncWQCEe297MhDQvVHLQ")]
    [DisplayName("Investigation Request Status 1 Choice")]
    public abstract partial record InvestigationRequestStatus1Choice_
    {
    }
}
