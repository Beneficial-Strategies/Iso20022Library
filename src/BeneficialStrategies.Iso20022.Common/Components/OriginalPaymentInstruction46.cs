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
/// Provides details on the original transactions, to which the status report message refers.
/// </summary>
[IsoId("_OJv0exlWEe2Do_UtrNmb2g")]
[DisplayName("Original Payment Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalPaymentInstruction46
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OriginalPaymentInstruction46 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OriginalPaymentInstruction46( System.String reqOriginalPaymentInformationIdentification )
    {
        OriginalPaymentInformationIdentification = reqOriginalPaymentInformationIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    [IsoId("_OTaGuRlWEe2Do_UtrNmb2g")]
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
    /// Number of individual transactions contained in the original payment information group.
    /// </summary>
    [IsoId("_OTaGuxlWEe2Do_UtrNmb2g")]
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
    [IsoId("_OTaGvRlWEe2Do_UtrNmb2g")]
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
    /// Specifies the status of the payment information group.
    /// </summary>
    [IsoId("_OTaGvxlWEe2Do_UtrNmb2g")]
    [DisplayName("Payment Information Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInfSts")]
    #endif
    [IsoXmlTag("PmtInfSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; init; } 
    #else
    public ExternalPaymentGroupStatus1Code? PaymentInformationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_OTaGwRlWEe2Do_UtrNmb2g")]
    [DisplayName("Status Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsnInf")]
    #endif
    [IsoXmlTag("StsRsnInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusReasonInformation12? StatusReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusReasonInformation12? StatusReasonInformation { get; init; } 
    #else
    public StatusReasonInformation12? StatusReasonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information on the number of transactions for each identical transaction status.
    /// </summary>
    [IsoId("_OTaGwxlWEe2Do_UtrNmb2g")]
    [DisplayName("Number Of Transactions Per Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfTxsPerSts")]
    #endif
    [IsoXmlTag("NbOfTxsPerSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberOfTransactionsPerStatus5? NumberOfTransactionsPerStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberOfTransactionsPerStatus5? NumberOfTransactionsPerStatus { get; init; } 
    #else
    public NumberOfTransactionsPerStatus5? NumberOfTransactionsPerStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the original transactions to which the status report message refers.
    /// </summary>
    [IsoId("_OTaGxRlWEe2Do_UtrNmb2g")]
    [DisplayName("Transaction Information And Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxInfAndSts")]
    #endif
    [IsoXmlTag("TxInfAndSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction145? TransactionInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction145? TransactionInformationAndStatus { get; init; } 
    #else
    public PaymentTransaction145? TransactionInformationAndStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
