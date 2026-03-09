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
/// Set of elements used to provide reference and status information on the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
[IsoId("_PnAPNdp-Ed-ak6NoX_4Aeg_1902930206")]
[DisplayName("Original Payment Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalPaymentInformation4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OriginalPaymentInformation4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OriginalPaymentInformation4( System.String reqOriginalPaymentInformationIdentification )
    {
        OriginalPaymentInformationIdentification = reqOriginalPaymentInformationIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the assigner, to unambiguously identify the cancellation request.||Usage: The cancellation request identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    [IsoId("_PnAPNtp-Ed-ak6NoX_4Aeg_1902930208")]
    [DisplayName("Payment Cancellation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtCxlId")]
    #endif
    [IsoXmlTag("PmtCxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PaymentCancellationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentCancellationIdentification { get; init; } 
    #else
    public System.String? PaymentCancellationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the case.
    /// </summary>
    [IsoId("_PnAPN9p-Ed-ak6NoX_4Aeg_622398900")]
    [DisplayName("Case")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Case")]
    #endif
    [IsoXmlTag("Case")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Case2? Case { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Case2? Case { get; init; } 
    #else
    public Case2? Case { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of the original payment information block, as assigned by the original sending party.
    /// </summary>
    [IsoId("_PnAPONp-Ed-ak6NoX_4Aeg_1902930515")]
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
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_PnAPOdp-Ed-ak6NoX_4Aeg_1444860875")]
    [DisplayName("Original Group Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlGrpInf")]
    #endif
    [IsoXmlTag("OrgnlGrpInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
    #else
    public OriginalGroupInformation3? OriginalGroupInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Number of individual transactions contained in the cancellation payment information group.
    /// </summary>
    [IsoId("_PnAPOtp-Ed-ak6NoX_4Aeg_-1211527919")]
    [DisplayName("Number Of Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfTxs")]
    #endif
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? NumberOfTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NumberOfTransactions { get; init; } 
    #else
    public System.String? NumberOfTransactions { get; set; } 
    #endif
    
    /// <summary>
    /// Total of all individual amounts included in the cancellation payment information group, irrespective of currencies.
    /// </summary>
    [IsoId("_PnAPO9p-Ed-ak6NoX_4Aeg_-1212448074")]
    [DisplayName("Control Sum")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrlSum")]
    #endif
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ControlSum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ControlSum { get; init; } 
    #else
    public System.UInt64? ControlSum { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the cancellation applies to a whole group of transactions or to individual transactions within the original group.
    /// </summary>
    [IsoId("_PnAPPNp-Ed-ak6NoX_4Aeg_-1212448013")]
    [DisplayName("Payment Information Cancellation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInfCxl")]
    #endif
    [IsoXmlTag("PmtInfCxl")]
    [IsoSimpleType(IsoSimpleType.GroupCancellationIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoGroupCancellationIndicator? PaymentInformationCancellation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentInformationCancellation { get; init; } 
    #else
    public System.String? PaymentInformationCancellation { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_PnJZINp-Ed-ak6NoX_4Aeg_1903851095")]
    [DisplayName("Cancellation Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsnInf")]
    #endif
    [IsoXmlTag("CxlRsnInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationReasonInformation3? CancellationReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationReasonInformation3? CancellationReasonInformation { get; init; } 
    #else
    public CancellationReasonInformation3? CancellationReasonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the original transactions, to which the cancellation request message refers.
    /// </summary>
    [IsoId("_PnJZIdp-Ed-ak6NoX_4Aeg_1444861176")]
    [DisplayName("Transaction Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxInf")]
    #endif
    [IsoXmlTag("TxInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransactionInformation30? TransactionInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransactionInformation30? TransactionInformation { get; init; } 
    #else
    public PaymentTransactionInformation30? TransactionInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
