// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data specific to securities being subject to the transaction.
/// </summary>
[IsoId("_FF_rwdR6EemZdYGWu384Zw")]
[DisplayName("Security")]
public partial record Security17
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the values defined as ISIN identifier are matching or not.
    /// </summary>
    [IsoId("_FLfPwdR6EemZdYGWu384Zw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public CompareISINIdentifier2? Identification { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as CFI identifier are matching or not.
    /// </summary>
    [IsoId("_FLfPw9R6EemZdYGWu384Zw")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public CompareCFIIdentifier2? ClassificationType { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as decimal number are matching or not.
    /// </summary>
    [IsoId("_FLfPxdR6EemZdYGWu384Zw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public CompareDecimalNumber2? Quantity { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_FLf20dR6EemZdYGWu384Zw")]
    [DisplayName("Nominal Value")]
    [IsoXmlTag("NmnlVal")]
    public CompareAmountAndDirection1? NominalValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as collateral quality type code are matching or not.
    /// </summary>
    [IsoId("_FLf209R6EemZdYGWu384Zw")]
    [DisplayName("Quality")]
    [IsoXmlTag("Qlty")]
    public CompareCollateralQualityType2? Quality { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as ISO date are matching or not.
    /// </summary>
    [IsoId("_FLf21dR6EemZdYGWu384Zw")]
    [DisplayName("Maturity")]
    [IsoXmlTag("Mtrty")]
    public CompareDate2? Maturity { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as LEI identifier are matching or not.
    /// </summary>
    [IsoId("_FLf219R6EemZdYGWu384Zw")]
    [DisplayName("Issuer Identifier")]
    [IsoXmlTag("IssrIdr")]
    public CompareOrganisationIdentification1? IssuerIdentifier { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as country code are matching or not.
    /// </summary>
    [IsoId("_FLf22dR6EemZdYGWu384Zw")]
    [DisplayName("Issuer Country")]
    [IsoXmlTag("IssrCtry")]
    public CompareCountryCode2? IssuerCountry { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as securities lending type are matching or not.
    /// </summary>
    [IsoId("_FLf229R6EemZdYGWu384Zw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CompareSecuritiesLendingType2? Type { get; init; } 
    
    /// <summary>
    /// Specifies whether the the unit prices are matching or not.
    /// </summary>
    [IsoId("_FLf23dR6EemZdYGWu384Zw")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public CompareUnitPrice3? UnitPrice { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    [IsoId("_FLf239R6EemZdYGWu384Zw")]
    [DisplayName("Exclusive Arrangement")]
    [IsoXmlTag("ExclsvArrgmnt")]
    public CompareTrueFalseIndicator2? ExclusiveArrangement { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_FLf24dR6EemZdYGWu384Zw")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public CompareActiveOrHistoricCurrencyAndAmount2? MarketValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    [IsoId("_FLf249R6EemZdYGWu384Zw")]
    [DisplayName("Available For Reuse")]
    [IsoXmlTag("AvlblForReuse")]
    public CompareTrueFalseIndicator2? AvailableForReuse { get; init; } 
    
    /// <summary>
    /// Collateral haircut, a risk control measure applied to underlying collateral whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// In the case of margin lending, collateral haircut or margin requirement, a risk control measure applied to the entire collateral portfolio whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// Only actual values, as opposed to estimated or default values are to be reported for this attribute.
    /// </summary>
    [IsoId("_FLf25dR6EemZdYGWu384Zw")]
    [DisplayName("Haircut Or Margin")]
    [IsoXmlTag("HrcutOrMrgn")]
    public ComparePercentageRate2? HaircutOrMargin { get; init; } 
    
    
    #nullable disable
    
}
