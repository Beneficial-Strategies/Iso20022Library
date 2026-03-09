// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the status of the cancellation of a payment transaction.
/// </summary>
[IsoId("_UFAnxYEqEei51tn2YGQhvg")]
[DisplayName("Payment Transaction Cancellation Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTransactionCancellationStatus3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentTransactionCancellationStatus3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentTransactionCancellationStatus3( CancellationIndividualStatus2Code reqTransactionCancellationStatus,System.String reqAssignee,System.DateTime reqCancellationEventDateTime )
    {
        TransactionCancellationStatus = reqTransactionCancellationStatus;
        Assignee = reqAssignee;
        CancellationEventDateTime = reqCancellationEventDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the status of a cancellation request.
    /// </summary>
    [IsoId("_UFAnxoEqEei51tn2YGQhvg")]
    [DisplayName("Transaction Cancellation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxCxlSts")]
    #endif
    [IsoXmlTag("TxCxlSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancellationIndividualStatus2Code TransactionCancellationStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CancellationIndividualStatus2Code TransactionCancellationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationIndividualStatus2Code TransactionCancellationStatus { get; init; } 
    #else
    public CancellationIndividualStatus2Code TransactionCancellationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides status reason with regards to the cancellation of the payment.
    /// </summary>
    [IsoId("_UFAnyYEqEei51tn2YGQhvg")]
    [DisplayName("Cancellation Status Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlStsRsnInf")]
    #endif
    [IsoXmlTag("CxlStsRsnInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentCancellationStatusReason3Code? CancellationStatusReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCancellationStatusReason3Code? CancellationStatusReasonInformation { get; init; } 
    #else
    public PaymentCancellationStatusReason3Code? CancellationStatusReasonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party that the case is assigned to. This is also the receiver of the message.
    /// </summary>
    [IsoId("_UFAnyIEqEei51tn2YGQhvg")]
    [DisplayName("Assignee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgne")]
    #endif
    [IsoXmlTag("Assgne")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICIdentifier Assignee { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Assignee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Assignee { get; init; } 
    #else
    public System.String Assignee { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date and time at which the cancellation response message enters the tracking system and thus on which the status is provided.
    /// </summary>
    [IsoId("_UFAnx4EqEei51tn2YGQhvg")]
    [DisplayName("Cancellation Event Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlEvtDtTm")]
    #endif
    [IsoXmlTag("CxlEvtDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CancellationEventDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CancellationEventDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CancellationEventDateTime { get; init; } 
    #else
    public System.DateTime CancellationEventDateTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
