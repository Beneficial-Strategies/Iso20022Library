// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Agent Document Identification And Status1Choice.
    /// </summary>
    [KnownType(typeof(AgentDocumentIdentificationAndStatus1Choice.AgentCANotificationAdviceIdentificationAndStatus))]
    [KnownType(typeof(AgentDocumentIdentificationAndStatus1Choice.AgentCANotificationCancellationRequestIdentificationAndStatus))]
    [JsonDerivedType(typeof(AgentDocumentIdentificationAndStatus1Choice.AgentCANotificationAdviceIdentificationAndStatus),nameof(AgentDocumentIdentificationAndStatus1Choice.AgentCANotificationAdviceIdentificationAndStatus))]
    [JsonDerivedType(typeof(AgentDocumentIdentificationAndStatus1Choice.AgentCANotificationCancellationRequestIdentificationAndStatus),nameof(AgentDocumentIdentificationAndStatus1Choice.AgentCANotificationCancellationRequestIdentificationAndStatus))]
    [IsoId("_p_Rg4FuGEe6gDOpEK7Q4ig")]
    [DisplayName("Agent Document Identification And Status1Choice")]
    public abstract partial record AgentDocumentIdentificationAndStatus1Choice_
    {
    }
}
