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
[IsoId("_1fb6ITL3EeKU9IrkkToqcw_1903281277")]
[DisplayName("Cash Option SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashOptionSD4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashOptionSD4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashOptionSD4( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1fb6IjL3EeKU9IrkkToqcw_-981279800")]
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
    /// Income classification of the cash proceeds for dividend reinvestment.
    /// </summary>
    [IsoId("_1fb6IzL3EeKU9IrkkToqcw_-2100820287")]
    [DisplayName("Reinvestment Income Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinvstmtIncmClssfctn")]
    #endif
    [IsoXmlTag("RinvstmtIncmClssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReinvestmentIncomeClassification1Code? ReinvestmentIncomeClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReinvestmentIncomeClassification1Code? ReinvestmentIncomeClassification { get; init; } 
    #else
    public ReinvestmentIncomeClassification1Code? ReinvestmentIncomeClassification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the type of payment. Used in stock dividends processing at DTC (The Depository Trust Corporation). Valid values list will be maintained separately from the schema.
    /// </summary>
    [IsoId("_1fb6JDL3EeKU9IrkkToqcw_-1352743730")]
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
    [IsoId("_1fb6JTL3EeKU9IrkkToqcw_1061917926")]
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
    [IsoId("_1flrIDL3EeKU9IrkkToqcw_-241832311")]
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
    [IsoId("_1flrITL3EeKU9IrkkToqcw_1007857207")]
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
    [IsoId("_1flrIjL3EeKU9IrkkToqcw_-186668122")]
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
    /// Indicates whether a charge is levied on the protect instructions at the time when the protect is submitted or at the time of the cover. Applies to warrants or rights exercise scenario where the holder must put up money with rights or warrants execution. When this flag is set to yes - charges are due at the time of the protect, when it is set to &quot;no&quot; changes are due when protect is covered.
    /// </summary>
    [IsoId("_1flrIzL3EeKU9IrkkToqcw_-805502902")]
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
    [IsoId("_1flrJDL3EeKU9IrkkToqcw_1200182542")]
    [DisplayName("Declared Cash Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrdCshRate")]
    #endif
    [IsoXmlTag("DclrdCshRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat17Choice_? DeclaredCashRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat17Choice_? DeclaredCashRate { get; init; } 
    #else
    public RateAndAmountFormat17Choice_? DeclaredCashRate { get; set; } 
    #endif
    
    /// <summary>
    /// Gross cash rate associated to the payout as declared on the market by the issuer or offeror.
    /// </summary>
    [IsoId("_1flrJTL3EeKU9IrkkToqcw_156365267")]
    [DisplayName("Declared Gross Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrdGrssRate")]
    #endif
    [IsoXmlTag("DclrdGrssRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat17Choice_? DeclaredGrossRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat17Choice_? DeclaredGrossRate { get; init; } 
    #else
    public RateAndAmountFormat17Choice_? DeclaredGrossRate { get; set; } 
    #endif
    
    /// <summary>
    /// Net cash rate associated to the payout as declared on the market by the issuer or offeror.
    /// </summary>
    [IsoId("_1flrJjL3EeKU9IrkkToqcw_-380806719")]
    [DisplayName("Declared Net Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrdNetRate")]
    #endif
    [IsoXmlTag("DclrdNetRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat17Choice_? DeclaredNetRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat17Choice_? DeclaredNetRate { get; init; } 
    #else
    public RateAndAmountFormat17Choice_? DeclaredNetRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate at which the fee will be charged to a DTC participant.
    /// </summary>
    [IsoId("_1fvcIDL3EeKU9IrkkToqcw_1083235590")]
    [DisplayName("Declared Fee Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrdFeeRate")]
    #endif
    [IsoXmlTag("DclrdFeeRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat17Choice_? DeclaredFeeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat17Choice_? DeclaredFeeRate { get; init; } 
    #else
    public RateAndAmountFormat17Choice_? DeclaredFeeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the period during which the instructions for DTC (The Depository Trust Corporation) US Tax service will be accepted.
    /// </summary>
    [IsoId("_1fvcITL3EeKU9IrkkToqcw_-2746287")]
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
    
    
    #nullable disable
    
}
