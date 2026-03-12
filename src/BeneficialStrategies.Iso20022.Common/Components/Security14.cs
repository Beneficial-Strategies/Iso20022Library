// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of security used as collateral.
/// </summary>
[IsoId("_wBMu18peEem6kd3Y9uIDqg")]
[DisplayName("Security")]
public partial record Security14
{
    #nullable enable
    
    /// <summary>
    /// Identification of a financial instrument used as a collateral.
    /// </summary>
    [IsoId("_wFEiMcpeEem6kd3Y9uIDqg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public IsoISINOct2015Identifier? Identification { get; init; } 
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, that is common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_wFEiM8peEem6kd3Y9uIDqg")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    public IsoCFIOct2015Identifier? ClassificationType { get; init; } 
    
    /// <summary>
    /// Information on the securities quantity or bonds nominal amount.
    /// </summary>
    [IsoId("_wFEiNcpeEem6kd3Y9uIDqg")]
    [DisplayName("Quantity Or Nominal Value")]
    [IsoXmlTag("QtyOrNmnlVal")]
    public QuantityNominalValue1Choice_? QuantityOrNominalValue { get; init; } 
    
    /// <summary>
    /// Price of unit of collateral component, including accrued interest for interest-bearing securities, used to value the security.
    /// </summary>
    [IsoId("_wFEiN8peEem6kd3Y9uIDqg")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public SecuritiesTransactionPrice2Choice_? UnitPrice { get; init; } 
    
    /// <summary>
    /// Fair value of the individual collateral component expressed in price currency.
    /// </summary>
    [IsoId("_wFEiOcpeEem6kd3Y9uIDqg")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public AmountAndDirection53? MarketValue { get; init; } 
    
    /// <summary>
    /// Collateral haircut, a risk control measure applied to underlying collateral whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// In the case of margin lending, collateral haircut or margin requirement, a risk control measure applied to the entire collateral portfolio whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// Only actual values, as opposed to estimated or default values are to be reported for this attribute.
    /// </summary>
    [IsoId("_wFEiO8peEem6kd3Y9uIDqg")]
    [DisplayName("Haircut Or Margin")]
    [IsoXmlTag("HrcutOrMrgn")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? HaircutOrMargin { get; init; } 
    
    /// <summary>
    /// Risk classification of the security used as collateral.
    /// </summary>
    [IsoId("_wFEiPcpeEem6kd3Y9uIDqg")]
    [DisplayName("Quality")]
    [IsoXmlTag("Qlty")]
    public CollateralQualityType1Code? Quality { get; init; } 
    
    /// <summary>
    /// Maturity date of the security used as collateral.
    /// </summary>
    [IsoId("_wFEiP8peEem6kd3Y9uIDqg")]
    [DisplayName("Maturity")]
    [IsoXmlTag("Mtrty")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Maturity { get; init; } 
    
    /// <summary>
    /// Data on the securities issuer.
    /// </summary>
    [IsoId("_wFEiQcpeEem6kd3Y9uIDqg")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public SecurityIssuer2? Issuer { get; init; } 
    
    /// <summary>
    /// Type of a security used as collateral.
    /// </summary>
    [IsoId("_wFEiQ8peEem6kd3Y9uIDqg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public SecuritiesLendingType3Choice_? Type { get; init; } 
    
    /// <summary>
    /// Indication whether the collateral taker can reuse the securities provided as a collateral.
    /// </summary>
    [IsoId("_wFEiRcpeEem6kd3Y9uIDqg")]
    [DisplayName("Available For Collateral Reuse")]
    [IsoXmlTag("AvlblForCollReuse")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AvailableForCollateralReuse { get; init; } 
    
    
    #nullable disable
    
}
