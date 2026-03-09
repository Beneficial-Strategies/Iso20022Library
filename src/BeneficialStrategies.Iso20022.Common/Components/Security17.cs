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
/// Data specific to securities being subject to the transaction.
/// </summary>
[IsoId("_FF_rwdR6EemZdYGWu384Zw")]
[DisplayName("Security")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Security17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the values defined as ISIN identifier are matching or not.
    /// </summary>
    [IsoId("_FLfPwdR6EemZdYGWu384Zw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareISINIdentifier2? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareISINIdentifier2? Identification { get; init; } 
    #else
    public CompareISINIdentifier2? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as CFI identifier are matching or not.
    /// </summary>
    [IsoId("_FLfPw9R6EemZdYGWu384Zw")]
    [DisplayName("Classification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnTp")]
    #endif
    [IsoXmlTag("ClssfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareCFIIdentifier2? ClassificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareCFIIdentifier2? ClassificationType { get; init; } 
    #else
    public CompareCFIIdentifier2? ClassificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as decimal number are matching or not.
    /// </summary>
    [IsoId("_FLfPxdR6EemZdYGWu384Zw")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDecimalNumber2? Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDecimalNumber2? Quantity { get; init; } 
    #else
    public CompareDecimalNumber2? Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_FLf20dR6EemZdYGWu384Zw")]
    [DisplayName("Nominal Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmnlVal")]
    #endif
    [IsoXmlTag("NmnlVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareAmountAndDirection1? NominalValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareAmountAndDirection1? NominalValue { get; init; } 
    #else
    public CompareAmountAndDirection1? NominalValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as collateral quality type code are matching or not.
    /// </summary>
    [IsoId("_FLf209R6EemZdYGWu384Zw")]
    [DisplayName("Quality")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qlty")]
    #endif
    [IsoXmlTag("Qlty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareCollateralQualityType2? Quality { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareCollateralQualityType2? Quality { get; init; } 
    #else
    public CompareCollateralQualityType2? Quality { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as ISO date are matching or not.
    /// </summary>
    [IsoId("_FLf21dR6EemZdYGWu384Zw")]
    [DisplayName("Maturity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mtrty")]
    #endif
    [IsoXmlTag("Mtrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate2? Maturity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate2? Maturity { get; init; } 
    #else
    public CompareDate2? Maturity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as LEI identifier are matching or not.
    /// </summary>
    [IsoId("_FLf219R6EemZdYGWu384Zw")]
    [DisplayName("Issuer Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrIdr")]
    #endif
    [IsoXmlTag("IssrIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareOrganisationIdentification1? IssuerIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareOrganisationIdentification1? IssuerIdentifier { get; init; } 
    #else
    public CompareOrganisationIdentification1? IssuerIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as country code are matching or not.
    /// </summary>
    [IsoId("_FLf22dR6EemZdYGWu384Zw")]
    [DisplayName("Issuer Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrCtry")]
    #endif
    [IsoXmlTag("IssrCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareCountryCode2? IssuerCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareCountryCode2? IssuerCountry { get; init; } 
    #else
    public CompareCountryCode2? IssuerCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as securities lending type are matching or not.
    /// </summary>
    [IsoId("_FLf229R6EemZdYGWu384Zw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareSecuritiesLendingType2? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareSecuritiesLendingType2? Type { get; init; } 
    #else
    public CompareSecuritiesLendingType2? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the the unit prices are matching or not.
    /// </summary>
    [IsoId("_FLf23dR6EemZdYGWu384Zw")]
    [DisplayName("Unit Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitPric")]
    #endif
    [IsoXmlTag("UnitPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareUnitPrice3? UnitPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareUnitPrice3? UnitPrice { get; init; } 
    #else
    public CompareUnitPrice3? UnitPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    [IsoId("_FLf239R6EemZdYGWu384Zw")]
    [DisplayName("Exclusive Arrangement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExclsvArrgmnt")]
    #endif
    [IsoXmlTag("ExclsvArrgmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareTrueFalseIndicator2? ExclusiveArrangement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareTrueFalseIndicator2? ExclusiveArrangement { get; init; } 
    #else
    public CompareTrueFalseIndicator2? ExclusiveArrangement { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_FLf24dR6EemZdYGWu384Zw")]
    [DisplayName("Market Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktVal")]
    #endif
    [IsoXmlTag("MktVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareActiveOrHistoricCurrencyAndAmount2? MarketValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareActiveOrHistoricCurrencyAndAmount2? MarketValue { get; init; } 
    #else
    public CompareActiveOrHistoricCurrencyAndAmount2? MarketValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    [IsoId("_FLf249R6EemZdYGWu384Zw")]
    [DisplayName("Available For Reuse")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvlblForReuse")]
    #endif
    [IsoXmlTag("AvlblForReuse")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareTrueFalseIndicator2? AvailableForReuse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareTrueFalseIndicator2? AvailableForReuse { get; init; } 
    #else
    public CompareTrueFalseIndicator2? AvailableForReuse { get; set; } 
    #endif
    
    /// <summary>
    /// Collateral haircut, a risk control measure applied to underlying collateral whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// In the case of margin lending, collateral haircut or margin requirement, a risk control measure applied to the entire collateral portfolio whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// Only actual values, as opposed to estimated or default values are to be reported for this attribute.
    /// </summary>
    [IsoId("_FLf25dR6EemZdYGWu384Zw")]
    [DisplayName("Haircut Or Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HrcutOrMrgn")]
    #endif
    [IsoXmlTag("HrcutOrMrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ComparePercentageRate2? HaircutOrMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ComparePercentageRate2? HaircutOrMargin { get; init; } 
    #else
    public ComparePercentageRate2? HaircutOrMargin { get; set; } 
    #endif
    
    
    #nullable disable
    
}
