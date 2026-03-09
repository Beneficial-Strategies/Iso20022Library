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
/// Provides additional information regarding corporate action confirmation securities movement details.
/// </summary>
[IsoId("_dlol4ZFBEeanIpS4qvJ1tw")]
[DisplayName("Corporate Action Confirmation Securities Movement Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionConfirmationSecuritiesMovementDetailsSD5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionConfirmationSecuritiesMovementDetailsSD5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionConfirmationSecuritiesMovementDetailsSD5( System.String reqPlaceAndName,CreditDebitCode reqCreditDebitIndicator,DTCCPayoutType4Code reqPayoutType )
    {
        PlaceAndName = reqPlaceAndName;
        CreditDebitIndicator = reqCreditDebitIndicator;
        PayoutType = reqPayoutType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_eCDcIZFBEeanIpS4qvJ1tw")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_eCDcI5FBEeanIpS4qvJ1tw")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of payout associated with the event (for example: principal, long term capital gain).
    /// </summary>
    [IsoId("_eCDcK5FBEeanIpS4qvJ1tw")]
    [DisplayName("Payout Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PyoutTp")]
    #endif
    [IsoXmlTag("PyoutTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DTCCPayoutType4Code PayoutType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DTCCPayoutType4Code PayoutType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCCPayoutType4Code PayoutType { get; init; } 
    #else
    public DTCCPayoutType4Code PayoutType { get; set; } 
    #endif
    
    /// <summary>
    /// Resulting quantity of securities concerned in this transaction.
    /// </summary>
    [IsoId("_eCDcLZFBEeanIpS4qvJ1tw")]
    [DisplayName("Transaction Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxQty")]
    #endif
    [IsoXmlTag("TxQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? TransactionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? TransactionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? TransactionQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction reason.
    /// </summary>
    [IsoId("_eCDcNZFBEeanIpS4qvJ1tw")]
    [DisplayName("Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsnCd")]
    #endif
    [IsoXmlTag("RsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCAdjustmentPaymentType2Code? ReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCAdjustmentPaymentType2Code? ReasonCode { get; init; } 
    #else
    public DTCAdjustmentPaymentType2Code? ReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction sub reason.
    /// </summary>
    [IsoId("_eCDcPZFBEeanIpS4qvJ1tw")]
    [DisplayName("Sub Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubRsnCd")]
    #endif
    [IsoXmlTag("SubRsnCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCAdjustmentPaymentSubReason1Code? SubReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCAdjustmentPaymentSubReason1Code? SubReasonCode { get; init; } 
    #else
    public DTCAdjustmentPaymentSubReason1Code? SubReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction contra participant identification when shares are distributed / delivered to / from another participant.
    /// </summary>
    [IsoId("_eCDcP5FBEeanIpS4qvJ1tw")]
    [DisplayName("Contra Participant Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ContraPtcptNb")]
    #endif
    [IsoXmlTag("ContraPtcptNb")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ContraParticipantNumber { get; init; } 
    #else
    public System.String? ContraParticipantNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a financial instrument becomes due and assets are to be repaid.
    /// </summary>
    [IsoId("_eCDcR5FBEeanIpS4qvJ1tw")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? MaturityDate { get; init; } 
    #else
    public System.DateOnly? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/Time on which the posting /draft of the securities took place.
    /// </summary>
    [IsoId("_eCDcT5FBEeanIpS4qvJ1tw")]
    [DisplayName("Posting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstngDt")]
    #endif
    [IsoXmlTag("PstngDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat28Choice_? PostingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat28Choice_? PostingDate { get; init; } 
    #else
    public DateFormat28Choice_? PostingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Set of the DTC legacy sub reason codes representing tax rate. Used with reason codes ‘TJXD’ ‘TJXF’ ‘TJXI’ ‘TJXL’ ‘TJXR’ ‘TJXT’ ‘TJXU’ to identify the correct tax rate.
    /// </summary>
    [IsoId("_eCDcV5FBEeanIpS4qvJ1tw")]
    [DisplayName("Tax Adjustment Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxAdjstmntRate")]
    #endif
    [IsoXmlTag("TaxAdjstmntRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? TaxAdjustmentRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TaxAdjustmentRate { get; init; } 
    #else
    public System.Decimal? TaxAdjustmentRate { get; set; } 
    #endif
    
    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (Event Details, Options, Movements) where applicable to indicate how values are sourced from CCF legacy files. For example: event has 2 related Activity Types 74, and 54. If event details and cash option are sourced from the Activity Type 74, then Activity Type 74 will be in RDP Reference Number in event details, and also on the cash option. The activity type 54 will be &quot;on&quot; the security option. Also, usage rules will specify the different layouts of the RDP Reference Number based on DTCC event group (reorganization, distribution, or redemption).
    /// </summary>
    [IsoId("_eCDcWZFBEeanIpS4qvJ1tw")]
    [DisplayName("RDP Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RDPRefNb")]
    #endif
    [IsoXmlTag("RDPRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact32AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RDPReferenceNumber { get; init; } 
    #else
    public System.String? RDPReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Decimal above which numbers are rounded. For an example if rounding factor is 0.6 this means that fractional units greater than or equal to 6 will be rounded up and less than 6 will be rounded down.
    /// </summary>
    [IsoId("_YfqxpJFBEeanIpS4qvJ1tw")]
    [DisplayName("Rounding Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RndgFctr")]
    #endif
    [IsoXmlTag("RndgFctr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? RoundingFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? RoundingFactor { get; init; } 
    #else
    public System.UInt64? RoundingFactor { get; set; } 
    #endif
    
    
    #nullable disable
    
}
