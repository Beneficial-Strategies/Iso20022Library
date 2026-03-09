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
/// Provides additional information regarding corporate action movement details.
/// </summary>
[IsoId("_GXpPkWHDEeORiK3bBeBzGg")]
[DisplayName("Corporate Action Movement Cash Movement Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionMovementCashMovementDetailsSD2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionMovementCashMovementDetailsSD2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionMovementCashMovementDetailsSD2( System.String reqPlaceAndName,CreditDebitCode reqCreditDebitIndicator )
    {
        PlaceAndName = reqPlaceAndName;
        CreditDebitIndicator = reqCreditDebitIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_GwVcZ2HDEeORiK3bBeBzGg")]
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
    [IsoId("_GwVcaWHDEeORiK3bBeBzGg")]
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
    /// Resulting cash amount concerned in this transaction.
    /// </summary>
    [IsoId("_GwVccWHDEeORiK3bBeBzGg")]
    [DisplayName("Transaction Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAmt")]
    #endif
    [IsoXmlTag("TxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? TransactionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? TransactionAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? TransactionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction reason.
    /// </summary>
    [IsoId("_GwVceWHDEeORiK3bBeBzGg")]
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
    [IsoId("_o5o48WfiEeOB5r-GpjGdRQ")]
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
    [IsoId("_GwVcgWHDEeORiK3bBeBzGg")]
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
    /// Date/Time on which the posting / draft of cash is scheduled to take place for a transaction.
    /// </summary>
    [IsoId("_GwVciWHDEeORiK3bBeBzGg")]
    [DisplayName("Earliest Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlstPmtDt")]
    #endif
    [IsoXmlTag("EarlstPmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat28Choice_? EarliestPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat28Choice_? EarliestPaymentDate { get; init; } 
    #else
    public DateFormat28Choice_? EarliestPaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Set of the DTC legacy sub reason codes representing tax rate. Used with reason codes ‘TJXD’ ‘TJXF’ ‘TJXI’ ‘TJXL’ ‘TJXR’ ‘TJXT’ ‘TJXU’ to identify the correct tax rate.
    /// </summary>
    [IsoId("_O0mNwWHDEeORiK3bBeBzGg")]
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
    
    
    #nullable disable
    
}
