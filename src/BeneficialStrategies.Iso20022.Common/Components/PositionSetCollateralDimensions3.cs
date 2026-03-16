// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Position Set Collateral Dimensions3.
/// </summary>
[IsoId("_W4kaVRT8Ee61h9tfoUrWyw")]
[DisplayName("Position Set Collateral Dimensions3")]
public partial record PositionSetCollateralDimensions3
{
    #nullable enable

    /// <summary>
    /// Collateral.
    /// </summary>
    [DisplayName("Collateral")]
    [IsoXmlTag("Coll")]
    public MarginCollateralReport4? Collateral { get; init; } 

    /// <summary>
    /// Counterparty Identification.
    /// </summary>
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public TradeCounterpartyReport20? CounterpartyIdentification { get; init; } 

    /// <summary>
    /// Excess Collateral Posted Currency.
    /// </summary>
    [DisplayName("Excess Collateral Posted Currency")]
    [IsoXmlTag("XcssCollPstdCcy")]
    public ActiveOrHistoricCurrencyCode? ExcessCollateralPostedCurrency { get; init; } 

    /// <summary>
    /// Excess Collateral Received Currency.
    /// </summary>
    [DisplayName("Excess Collateral Received Currency")]
    [IsoXmlTag("XcssCollRcvdCcy")]
    public ActiveOrHistoricCurrencyCode? ExcessCollateralReceivedCurrency { get; init; } 

    /// <summary>
    /// Initial Margin Posted Currency.
    /// </summary>
    [DisplayName("Initial Margin Posted Currency")]
    [IsoXmlTag("InitlMrgnPstdCcy")]
    public ActiveOrHistoricCurrencyCode? InitialMarginPostedCurrency { get; init; } 

    /// <summary>
    /// Initial Margin Received Currency.
    /// </summary>
    [DisplayName("Initial Margin Received Currency")]
    [IsoXmlTag("InitlMrgnRcvdCcy")]
    public ActiveOrHistoricCurrencyCode? InitialMarginReceivedCurrency { get; init; } 

    /// <summary>
    /// Variation Margin Posted Currency.
    /// </summary>
    [DisplayName("Variation Margin Posted Currency")]
    [IsoXmlTag("VartnMrgnPstdCcy")]
    public ActiveOrHistoricCurrencyCode? VariationMarginPostedCurrency { get; init; } 

    /// <summary>
    /// Variation Margin Received Currency.
    /// </summary>
    [DisplayName("Variation Margin Received Currency")]
    [IsoXmlTag("VartnMrgnRcvdCcy")]
    public ActiveOrHistoricCurrencyCode? VariationMarginReceivedCurrency { get; init; } 

    
    #nullable disable
    
}
