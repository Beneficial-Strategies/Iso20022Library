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
/// Provides the details on the reference and status of the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
[IsoId("_AwVOp249EeiU9cctagi5ow")]
[DisplayName("Original Payment Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalPaymentInstruction30
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OriginalPaymentInstruction30 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OriginalPaymentInstruction30( System.String reqOriginalPaymentInformationIdentification )
    {
        OriginalPaymentInformationIdentification = reqOriginalPaymentInformationIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the original assigner, to unambiguously identify the original payment information cancellation request.
    /// </summary>
    [IsoId("_A5kqOW49EeiU9cctagi5ow")]
    [DisplayName("Original Payment Information Cancellation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPmtInfCxlId")]
    #endif
    [IsoXmlTag("OrgnlPmtInfCxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalPaymentInformationCancellationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalPaymentInformationCancellationIdentification { get; init; } 
    #else
    public System.String? OriginalPaymentInformationCancellationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the resolved case.
    /// </summary>
    [IsoId("_A5kqO249EeiU9cctagi5ow")]
    [DisplayName("Resolved Case")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RslvdCase")]
    #endif
    [IsoXmlTag("RslvdCase")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Case5? ResolvedCase { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Case5? ResolvedCase { get; init; } 
    #else
    public Case5? ResolvedCase { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [IsoId("_A5kqPW49EeiU9cctagi5ow")]
    [DisplayName("Original Payment Information Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPmtInfId")]
    #endif
    [IsoXmlTag("OrgnlPmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalPaymentInformationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalPaymentInformationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalPaymentInformationIdentification { get; init; } 
    #else
    public System.String OriginalPaymentInformationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_A5kqP249EeiU9cctagi5ow")]
    [DisplayName("Original Group Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlGrpInf")]
    #endif
    [IsoXmlTag("OrgnlGrpInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; } 
    #else
    public OriginalGroupInformation29? OriginalGroupInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    [IsoId("_A5kqQW49EeiU9cctagi5ow")]
    [DisplayName("Original Number Of Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlNbOfTxs")]
    #endif
    [IsoXmlTag("OrgnlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? OriginalNumberOfTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalNumberOfTransactions { get; init; } 
    #else
    public System.String? OriginalNumberOfTransactions { get; set; } 
    #endif
    
    /// <summary>
    /// Total of all individual amounts included in the original payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("_A5kqQ249EeiU9cctagi5ow")]
    [DisplayName("Original Control Sum")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCtrlSum")]
    #endif
    [IsoXmlTag("OrgnlCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? OriginalControlSum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? OriginalControlSum { get; init; } 
    #else
    public System.UInt64? OriginalControlSum { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of a cancellation request, related to a payment information group.
    /// </summary>
    [IsoId("_A5kqRW49EeiU9cctagi5ow")]
    [DisplayName("Payment Information Cancellation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInfCxlSts")]
    #endif
    [IsoXmlTag("PmtInfCxlSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GroupCancellationStatus1Code? PaymentInformationCancellationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupCancellationStatus1Code? PaymentInformationCancellationStatus { get; init; } 
    #else
    public GroupCancellationStatus1Code? PaymentInformationCancellationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the cancellation status reason.
    /// </summary>
    [IsoId("_A5kqR249EeiU9cctagi5ow")]
    [DisplayName("Cancellation Status Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlStsRsnInf")]
    #endif
    [IsoXmlTag("CxlStsRsnInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationStatusReason4? CancellationStatusReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationStatusReason4? CancellationStatusReasonInformation { get; init; } 
    #else
    public CancellationStatusReason4? CancellationStatusReasonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information on the number of transactions for each identical cancellation status.
    /// </summary>
    [IsoId("_A5kqSW49EeiU9cctagi5ow")]
    [DisplayName("Number Of Transactions Per Cancellation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfTxsPerCxlSts")]
    #endif
    [IsoXmlTag("NbOfTxsPerCxlSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberOfCancellationsPerStatus1? NumberOfTransactionsPerCancellationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberOfCancellationsPerStatus1? NumberOfTransactionsPerCancellationStatus { get; init; } 
    #else
    public NumberOfCancellationsPerStatus1? NumberOfTransactionsPerCancellationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the original transactions to which the cancellation request message refers.
    /// </summary>
    [IsoId("_A5kqS249EeiU9cctagi5ow")]
    [DisplayName("Transaction Information And Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxInfAndSts")]
    #endif
    [IsoXmlTag("TxInfAndSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction103? TransactionInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction103? TransactionInformationAndStatus { get; init; } 
    #else
    public PaymentTransaction103? TransactionInformationAndStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
