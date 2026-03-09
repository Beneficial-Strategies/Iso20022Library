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
/// Provides additional information regarding corporate action option securities movement details.
/// </summary>
[IsoId("_qlkEwZ2FEeW-bsa36JFb9A")]
[DisplayName("Securities Option SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesOptionSD8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesOptionSD8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesOptionSD8( System.String reqPlaceAndName,DTCCPayoutType4Code reqPayoutType )
    {
        PlaceAndName = reqPlaceAndName;
        PayoutType = reqPayoutType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_q_53YZ2FEeW-bsa36JFb9A")]
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
    /// Specifies the type of payout associated with the event (for example: principal, long term capital gain).
    /// </summary>
    [IsoId("_q_53Y52FEeW-bsa36JFb9A")]
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
    /// Indicates the type of payment. Used in stock dividends processing at DTC(The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    [IsoId("_q_53ZZ2FEeW-bsa36JFb9A")]
    [DisplayName("DTC Pay Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCPayMtd")]
    #endif
    [IsoXmlTag("DTCPayMtd")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3Text? DTCPayMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DTCPayMethod { get; init; } 
    #else
    public System.String? DTCPayMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the payment order. Used in stock dividends processing at DTC (The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    [IsoId("_q_53bZ2FEeW-bsa36JFb9A")]
    [DisplayName("DTC Pay Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCPayOrdr")]
    #endif
    [IsoXmlTag("DTCPayOrdr")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3Text? DTCPayOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DTCPayOrder { get; init; } 
    #else
    public System.String? DTCPayOrder { get; set; } 
    #endif
    
    /// <summary>
    /// Income classification of the cash proceeds for dividend reinvestment.
    /// </summary>
    [IsoId("_q_53dZ2FEeW-bsa36JFb9A")]
    [DisplayName("Reinvestment Income Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinvstmtIncmClssfctn")]
    #endif
    [IsoXmlTag("RinvstmtIncmClssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReinvestmentIncomeClassification2Code? ReinvestmentIncomeClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReinvestmentIncomeClassification2Code? ReinvestmentIncomeClassification { get; init; } 
    #else
    public ReinvestmentIncomeClassification2Code? ReinvestmentIncomeClassification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates how the entitlements were calculated optional dividends.
    /// </summary>
    [IsoId("_q_53fZ2FEeW-bsa36JFb9A")]
    [DisplayName("Entitlement Calculation Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EntitlmntClctnMtd")]
    #endif
    [IsoXmlTag("EntitlmntClctnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCEntitlementCalculationMethod1Code? EntitlementCalculationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCEntitlementCalculationMethod1Code? EntitlementCalculationMethod { get; init; } 
    #else
    public DTCEntitlementCalculationMethod1Code? EntitlementCalculationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Price is based on either base or disbursed security.
    /// </summary>
    [IsoId("_q_53hZ2FEeW-bsa36JFb9A")]
    [DisplayName("Price Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricBsis")]
    #endif
    [IsoXmlTag("PricBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCBaseDisbursed1Code? PriceBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCBaseDisbursed1Code? PriceBasis { get; init; } 
    #else
    public DTCBaseDisbursed1Code? PriceBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason for DTC (The Depository Trust Corporation) to exit the shares.
    /// </summary>
    [IsoId("_q_53jZ2FEeW-bsa36JFb9A")]
    [DisplayName("DTC Exit Explanation Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCExitExpltnInd")]
    #endif
    [IsoXmlTag("DTCExitExpltnInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesExitReason1Code? DTCExitExplanationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesExitReason1Code? DTCExitExplanationIndicator { get; init; } 
    #else
    public SecuritiesExitReason1Code? DTCExitExplanationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a DTC (The Depository Trust Corporation) participant, using one or more payment bonds in connection with a warrant exercise, will be charged (through settlement on exercise date) the value of the upcoming interest payment on the bond(s).
    /// </summary>
    [IsoId("_q_53lZ2FEeW-bsa36JFb9A")]
    [DisplayName("Charge Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgFlg")]
    #endif
    [IsoXmlTag("ChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ChargeFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ChargeFlag { get; init; } 
    #else
    public System.String? ChargeFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a charge is levied on the protect instructions at the time when the protect is submitted or at the time of the cover. Applies to warrants or rights exercise scenario where the holder must put up money with rights or warrants execution. When this flag is set to yes - charges are due at the time of the protect, when it is set to &quot;no&quot; changes are due when protect is covered.
    /// </summary>
    [IsoId("_q_53nZ2FEeW-bsa36JFb9A")]
    [DisplayName("Protect Charge Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctChrgFlg")]
    #endif
    [IsoXmlTag("PrtctChrgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ProtectChargeFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProtectChargeFlag { get; init; } 
    #else
    public System.String? ProtectChargeFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the price from the offeror is estimated or final.
    /// </summary>
    [IsoId("_q_53pZ2FEeW-bsa36JFb9A")]
    [DisplayName("Estimated Price Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdPricFlg")]
    #endif
    [IsoXmlTag("EstmtdPricFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? EstimatedPriceFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EstimatedPriceFlag { get; init; } 
    #else
    public System.String? EstimatedPriceFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Time period during which instructions regarding the disposition of fractional entitlements will be accepted at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_q_53rZ2FEeW-bsa36JFb9A")]
    [DisplayName("DTC Fractional Share Instruction Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCFrctnlShrInstrPrd")]
    #endif
    [IsoXmlTag("DTCFrctnlShrInstrPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period3? DTCFractionalShareInstructionPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period3? DTCFractionalShareInstructionPeriod { get; init; } 
    #else
    public Period3? DTCFractionalShareInstructionPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the period during which the instructions for US Tax service will be accepted at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_q_53tZ2FEeW-bsa36JFb9A")]
    [DisplayName("DTCUS Tax Instruction Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCUSTaxInstrPrd")]
    #endif
    [IsoXmlTag("DTCUSTaxInstrPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period3? DTCUSTaxInstructionPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period3? DTCUSTaxInstructionPeriod { get; init; } 
    #else
    public Period3? DTCUSTaxInstructionPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (Event Details, Options, Movements) where applicable to indicate how values are sourced from CCF legacy files. For example: event has 2 related Activity Types 74, and 54. If event details and cash option are sourced from the Activity Type 74, then Activity Type 74 will be in RDP Reference Number in event details, and also on the cash option. The activity type 54 will be &quot;on&quot; the security option. Also, usage rules will specify the different layouts of the RDP Reference Number based on DTCC event group (reorganization, distribution, or redemption).
    /// </summary>
    [IsoId("_q_53vZ2FEeW-bsa36JFb9A")]
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
    
    
    #nullable disable
    
}
