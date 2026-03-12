// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variables related to derivatives that are used to group derivatives together into positions for collateral position sets and currency collateral position sets reports. 
/// </summary>
[IsoId("_83N69eNfEeiTop2HXWk15w")]
[DisplayName("Position Set Collateral Dimensions")]
public partial record PositionSetCollateralDimensions2
{
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_9BppUeNfEeiTop2HXWk15w")]
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public TradeCounterpartyReport9? CounterpartyIdentification { get; init; } 
    
    /// <summary>
    /// Information indicating the type of collateral agreement existing between counterparties.
    /// </summary>
    [IsoId("_9BppU-NfEeiTop2HXWk15w")]
    [DisplayName("Collateralisation")]
    [IsoXmlTag("Collstn")]
    public CollateralisationType1Code? Collateralisation { get; init; } 
    
    /// <summary>
    /// A unique code determined by the reporting counterparty to identify the portfolio if collateral is reported on a portfolio basis.
    /// </summary>
    [IsoId("_9BppVeNfEeiTop2HXWk15w")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    public IsoMax52Text? Portfolio { get; init; } 
    
    /// <summary>
    /// Currency of the initial margin posted by the reporting counterparty to the other counterparty.
    /// </summary>
    [IsoId("_9BppV-NfEeiTop2HXWk15w")]
    [DisplayName("Initial Margin Posted Currency")]
    [IsoXmlTag("InitlMrgnPstdCcy")]
    public ActiveOrHistoricCurrencyCode? InitialMarginPostedCurrency { get; init; } 
    
    /// <summary>
    /// Currency of the variation margin posted, including cash settled, by the reporting counterparty to the other counterparty.
    /// </summary>
    [IsoId("_9BppWeNfEeiTop2HXWk15w")]
    [DisplayName("Variation Margin Posted Currency")]
    [IsoXmlTag("VartnMrgnPstdCcy")]
    public ActiveOrHistoricCurrencyCode? VariationMarginPostedCurrency { get; init; } 
    
    /// <summary>
    /// Currency of the initial margin received by the reporting counterparty from the other counterparty.
    /// </summary>
    [IsoId("_9BppW-NfEeiTop2HXWk15w")]
    [DisplayName("Initial Margin Received Currency")]
    [IsoXmlTag("InitlMrgnRcvdCcy")]
    public ActiveOrHistoricCurrencyCode? InitialMarginReceivedCurrency { get; init; } 
    
    /// <summary>
    /// Currency of the variation margin received, including cash settled, by the reporting counterparty from the other counterparty.
    /// </summary>
    [IsoId("_9BppXeNfEeiTop2HXWk15w")]
    [DisplayName("Variation Margin Received Currency")]
    [IsoXmlTag("VartnMrgnRcvdCcy")]
    public ActiveOrHistoricCurrencyCode? VariationMarginReceivedCurrency { get; init; } 
    
    /// <summary>
    /// Currency of collateral posted in excess of the required collateral.
    /// </summary>
    [IsoId("_9BppX-NfEeiTop2HXWk15w")]
    [DisplayName("Excess Collateral Posted Currency")]
    [IsoXmlTag("XcssCollPstdCcy")]
    public ActiveOrHistoricCurrencyCode? ExcessCollateralPostedCurrency { get; init; } 
    
    /// <summary>
    /// Currency of collateral received in excess of the required collateral.
    /// </summary>
    [IsoId("_9BppYeNfEeiTop2HXWk15w")]
    [DisplayName("Excess Collateral Received Currency")]
    [IsoXmlTag("XcssCollRcvdCcy")]
    public ActiveOrHistoricCurrencyCode? ExcessCollateralReceivedCurrency { get; init; } 
    
    
    #nullable disable
    
}
