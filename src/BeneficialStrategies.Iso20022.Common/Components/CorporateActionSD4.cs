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
/// Provides additional information regarding corporate action details.
/// </summary>
[IsoId("_1dzicDL3EeKU9IrkkToqcw_-1985913164")]
[DisplayName("Corporate Action SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionSD4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionSD4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionSD4( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1dzicTL3EeKU9IrkkToqcw_1311981779")]
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
    /// New par value of a security.
    /// </summary>
    [IsoId("_1dzicjL3EeKU9IrkkToqcw_-1252990966")]
    [DisplayName("New Par Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewParVal")]
    #endif
    [IsoXmlTag("NewParVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? NewParValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? NewParValue { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? NewParValue { get; set; } 
    #endif
    
    /// <summary>
    /// Old par value of the event security represents the previously established par value that has changed in par value event. Used in combination with new par value element to represent the difference.
    /// </summary>
    [IsoId("_1dziczL3EeKU9IrkkToqcw_1931064911")]
    [DisplayName("Old Par Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OdParVal")]
    #endif
    [IsoXmlTag("OdParVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? OldParValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? OldParValue { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? OldParValue { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the event agent is charging a cancellation and or issuance fee upon the exchange of securities.
    /// </summary>
    [IsoId("_1dzidDL3EeKU9IrkkToqcw_-1824148456")]
    [DisplayName("Exchange Fee Required Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgFeeReqrdFlg")]
    #endif
    [IsoXmlTag("XchgFeeReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ExchangeFeeRequiredFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExchangeFeeRequiredFlag { get; init; } 
    #else
    public System.String? ExchangeFeeRequiredFlag { get; set; } 
    #endif
    
    /// <summary>
    /// GCA VS-specific flag that indicates whether a composite record has been generated as a result of custodian information that has not yet been confirmed in the market.
    /// </summary>
    [IsoId("_1dzidTL3EeKU9IrkkToqcw_166643569")]
    [DisplayName("Custodian Shell Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtdnShellFlg")]
    #endif
    [IsoXmlTag("CtdnShellFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CustodianShellFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustodianShellFlag { get; init; } 
    #else
    public System.String? CustodianShellFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the issuer requires a holder to present the entire account balance in order to be eligible for the offer.
    /// </summary>
    [IsoId("_1dzidjL3EeKU9IrkkToqcw_512871924")]
    [DisplayName("Must All Shares Be Submitted Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MustAllShrsBeSubmittdFlg")]
    #endif
    [IsoXmlTag("MustAllShrsBeSubmittdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? MustAllSharesBeSubmittedFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MustAllSharesBeSubmittedFlag { get; init; } 
    #else
    public System.String? MustAllSharesBeSubmittedFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the lottery that has been drawn as a part of the corporate action event.
    /// </summary>
    [IsoId("_1d8sYDL3EeKU9IrkkToqcw_-643503849")]
    [DisplayName("Lottery Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LtryDtls")]
    #endif
    [IsoXmlTag("LtryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionSD6? LotteryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionSD6? LotteryDetails { get; init; } 
    #else
    public CorporateActionSD6? LotteryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the dividend as whole or in part qualifies for lower/ favourable tax rate.
    /// </summary>
    [IsoId("_1d8sYTL3EeKU9IrkkToqcw_-308326275")]
    [DisplayName("Qualified Dividend Tax Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QlfdDvddTaxInd")]
    #endif
    [IsoXmlTag("QlfdDvddTaxInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedDividendTax1Code? QualifiedDividendTaxIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedDividendTax1Code? QualifiedDividendTaxIndicator { get; init; } 
    #else
    public QualifiedDividendTax1Code? QualifiedDividendTaxIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the company that will remain (possibly a new name), usually designated after a merger.
    /// </summary>
    [IsoId("_1d8sYjL3EeKU9IrkkToqcw_-1163046817")]
    [DisplayName("Surviving Company")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrvvgCpny")]
    #endif
    [IsoXmlTag("SrvvgCpny")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? SurvivingCompany { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SurvivingCompany { get; init; } 
    #else
    public System.String? SurvivingCompany { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates when all or part of the distribution is paid from foreign sourced income of the issuer.
    /// </summary>
    [IsoId("_1d8sYzL3EeKU9IrkkToqcw_1468724564")]
    [DisplayName("Foreign Income Source Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrgnIncmSrcFlg")]
    #endif
    [IsoXmlTag("FrgnIncmSrcFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ForeignIncomeSourceFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ForeignIncomeSourceFlag { get; init; } 
    #else
    public System.String? ForeignIncomeSourceFlag { get; set; } 
    #endif
    
    
    #nullable disable
    
}
