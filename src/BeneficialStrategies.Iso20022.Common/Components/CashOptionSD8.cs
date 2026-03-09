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
/// Provides additional information regarding corporate action option cash movement details.
/// </summary>
[IsoId("_i1A5oaFKEeSK_vfd3NHBGg")]
[DisplayName("Cash Option SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashOptionSD8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashOptionSD8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashOptionSD8( System.String reqPlaceAndName,DTCCPayoutType3Code reqPayoutType,NRATax2Code reqNRATaxCode )
    {
        PlaceAndName = reqPlaceAndName;
        PayoutType = reqPayoutType;
        NRATaxCode = reqNRATaxCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_jBXTkaFKEeSK_vfd3NHBGg")]
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
    [IsoId("_PdDxAKFLEeSK_vfd3NHBGg")]
    [DisplayName("Payout Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PyoutTp")]
    #endif
    [IsoXmlTag("PyoutTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DTCCPayoutType3Code PayoutType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DTCCPayoutType3Code PayoutType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCCPayoutType3Code PayoutType { get; init; } 
    #else
    public DTCCPayoutType3Code PayoutType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the type of payment. Used in stock dividends processing at DTC (The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    [IsoId("_jBXTk6FKEeSK_vfd3NHBGg")]
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
    [IsoId("_jBXTm6FKEeSK_vfd3NHBGg")]
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
    /// Indicates how the entitlements were calculated optional dividends.
    /// </summary>
    [IsoId("_jBXTo6FKEeSK_vfd3NHBGg")]
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
    /// Denotes whether the rate is approximate.
    /// </summary>
    [IsoId("_jBXTq6FKEeSK_vfd3NHBGg")]
    [DisplayName("Estimated Rate Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdRateFlg")]
    #endif
    [IsoXmlTag("EstmtdRateFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? EstimatedRateFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EstimatedRateFlag { get; init; } 
    #else
    public System.String? EstimatedRateFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the income events which are subject to withholding tax if paid to a non-U.S. resident alien (NRA).
    /// </summary>
    [IsoId("_jBXTs6FKEeSK_vfd3NHBGg")]
    [DisplayName("NRA Tax Reportable Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NRATaxRptblFlg")]
    #endif
    [IsoXmlTag("NRATaxRptblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? NRATaxReportableFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NRATaxReportableFlag { get; init; } 
    #else
    public System.String? NRATaxReportableFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Non resident alien (NRA) tax code. Each U.S. tax withholding eligible distribution must have a determination of the tax liability. This code is relevant to tax withholding and U.S. IRS reporting. Foreign securities also have an applicable tax code, but all foreign issues have one standard code.
    /// </summary>
    [IsoId("_w8VhNKFsEeSpipW1FBSFVg")]
    [DisplayName("NRA Tax Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NRATaxCd")]
    #endif
    [IsoXmlTag("NRATaxCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NRATax2Code NRATaxCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NRATax2Code NRATaxCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NRATax2Code NRATaxCode { get; init; } 
    #else
    public NRATax2Code NRATaxCode { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a charge is levied on the protect instructions at the time when the protect is submitted or at the time of the cover. Applies to warrants or rights exercise scenario where the holder must put up money with rights or warrants execution. When this flag is set to yes - charges are due at the time of the protect, when it is set to &quot;no&quot; changes are due when protect is covered.
    /// </summary>
    [IsoId("_jBXTu6FKEeSK_vfd3NHBGg")]
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
    /// Cash rate associated to the payout as declared on the market by the issuer or offeror.
    /// </summary>
    [IsoId("_jBXTw6FKEeSK_vfd3NHBGg")]
    [DisplayName("Declared Cash Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrdCshRate")]
    #endif
    [IsoXmlTag("DclrdCshRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormatSD2Choice_? DeclaredCashRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormatSD2Choice_? DeclaredCashRate { get; init; } 
    #else
    public PriceFormatSD2Choice_? DeclaredCashRate { get; set; } 
    #endif
    
    /// <summary>
    /// Gross cash rate associated to the payout as declared on the market by the issuer or offeror.
    /// </summary>
    [IsoId("_jBXTy6FKEeSK_vfd3NHBGg")]
    [DisplayName("Declared Gross Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrdGrssRate")]
    #endif
    [IsoXmlTag("DclrdGrssRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormatSD2Choice_? DeclaredGrossRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormatSD2Choice_? DeclaredGrossRate { get; init; } 
    #else
    public PriceFormatSD2Choice_? DeclaredGrossRate { get; set; } 
    #endif
    
    /// <summary>
    /// Net cash rate associated to the payout as declared on the market by the issuer or offeror.
    /// </summary>
    [IsoId("_jBXT06FKEeSK_vfd3NHBGg")]
    [DisplayName("Declared Net Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrdNetRate")]
    #endif
    [IsoXmlTag("DclrdNetRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormatSD2Choice_? DeclaredNetRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormatSD2Choice_? DeclaredNetRate { get; init; } 
    #else
    public PriceFormatSD2Choice_? DeclaredNetRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate at which the fee will be charged to a DTC participant.
    /// </summary>
    [IsoId("_jBXT26FKEeSK_vfd3NHBGg")]
    [DisplayName("Declared Fee Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrdFeeRate")]
    #endif
    [IsoXmlTag("DclrdFeeRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormatSD2Choice_? DeclaredFeeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormatSD2Choice_? DeclaredFeeRate { get; init; } 
    #else
    public PriceFormatSD2Choice_? DeclaredFeeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the period during which the instructions for DTC (The Depository Trust Corporation) US Tax service will be accepted.
    /// </summary>
    [IsoId("_jBXT6aFKEeSK_vfd3NHBGg")]
    [DisplayName("DTCUS Tax Instruction Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCSTaxInstrPrd")]
    #endif
    [IsoXmlTag("DTCSTaxInstrPrd")]
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
    [IsoId("_jBXT96FKEeSK_vfd3NHBGg")]
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
