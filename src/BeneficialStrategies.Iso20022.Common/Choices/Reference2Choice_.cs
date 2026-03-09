// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the identification of the MarginCallRequest message, the MarginCallResponse message, the CollateralProposal message, the CollateralProposalResponse message, the CollateralSubstitutionRequest message, the CollateralSubstitutionResponse message, the CollateralSubstitutionConfirmation message, the InterestPaymentRequest message, the InterestPaymentResponse message, the InterestPaymentStatement message or the MarginCallDisputeNotification message.
    /// </summary>
    [KnownType(typeof(Reference2Choice.MarginCallRequestIdentification))]
    [KnownType(typeof(Reference2Choice.MarginCallResponseIdentification))]
    [KnownType(typeof(Reference2Choice.CollateralProposalIdentification))]
    [KnownType(typeof(Reference2Choice.CollateralProposalResponseIdentification))]
    [KnownType(typeof(Reference2Choice.DisputeNotificationIdentification))]
    [KnownType(typeof(Reference2Choice.CollateralSubstitutionRequestIdentification))]
    [KnownType(typeof(Reference2Choice.CollateralSubstitutionResponseIdentification))]
    [KnownType(typeof(Reference2Choice.CollateralSubstitutionConfirmationIdentification))]
    [KnownType(typeof(Reference2Choice.InterestPaymentRequestIdentification))]
    [KnownType(typeof(Reference2Choice.InterestPaymentResponseIdentification))]
    [KnownType(typeof(Reference2Choice.InterestPaymentStatementIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Reference2Choice.MarginCallRequestIdentification),nameof(Reference2Choice.MarginCallRequestIdentification))]
    [JsonDerivedType(typeof(Reference2Choice.MarginCallResponseIdentification),nameof(Reference2Choice.MarginCallResponseIdentification))]
    [JsonDerivedType(typeof(Reference2Choice.CollateralProposalIdentification),nameof(Reference2Choice.CollateralProposalIdentification))]
    [JsonDerivedType(typeof(Reference2Choice.CollateralProposalResponseIdentification),nameof(Reference2Choice.CollateralProposalResponseIdentification))]
    [JsonDerivedType(typeof(Reference2Choice.DisputeNotificationIdentification),nameof(Reference2Choice.DisputeNotificationIdentification))]
    [JsonDerivedType(typeof(Reference2Choice.CollateralSubstitutionRequestIdentification),nameof(Reference2Choice.CollateralSubstitutionRequestIdentification))]
    [JsonDerivedType(typeof(Reference2Choice.CollateralSubstitutionResponseIdentification),nameof(Reference2Choice.CollateralSubstitutionResponseIdentification))]
    [JsonDerivedType(typeof(Reference2Choice.CollateralSubstitutionConfirmationIdentification),nameof(Reference2Choice.CollateralSubstitutionConfirmationIdentification))]
    [JsonDerivedType(typeof(Reference2Choice.InterestPaymentRequestIdentification),nameof(Reference2Choice.InterestPaymentRequestIdentification))]
    [JsonDerivedType(typeof(Reference2Choice.InterestPaymentResponseIdentification),nameof(Reference2Choice.InterestPaymentResponseIdentification))]
    [JsonDerivedType(typeof(Reference2Choice.InterestPaymentStatementIdentification),nameof(Reference2Choice.InterestPaymentStatementIdentification))]
    #endif
    [IsoId("_TYNGkKerEeCq2KR6DaC1kQ_992102367")]
    [DisplayName("Reference 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Reference2Choice_
    #else
    public abstract partial class Reference2Choice_
    #endif
    {
    }
}
