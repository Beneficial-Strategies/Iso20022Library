// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Related Subscription1.
/// </summary>
[IsoId("_F_zyQBvzEe6BvtAMnhq3zw")]
[DisplayName("Related Subscription1")]
public partial record RelatedSubscription1
{
    #nullable enable

    /// <summary>
    /// Contingent Liquidation Per Unit.
    /// </summary>
    [DisplayName("Contingent Liquidation Per Unit")]
    [IsoXmlTag("CntngntLqdtnPerUnit")]
    public ActiveOrHistoricCurrencyAndAmount? ContingentLiquidationPerUnit { get; init; } 

    /// <summary>
    /// Depreciation Deposit Per Unit.
    /// </summary>
    [DisplayName("Depreciation Deposit Per Unit")]
    [IsoXmlTag("DprctnDpstPerUnit")]
    public ActiveOrHistoricCurrencyAndAmount? DepreciationDepositPerUnit { get; init; } 

    /// <summary>
    /// Equalisation Credit Per Unit.
    /// </summary>
    [DisplayName("Equalisation Credit Per Unit")]
    [IsoXmlTag("EqulstnCdtPerUnit")]
    public ActiveOrHistoricCurrencyAndAmount? EqualisationCreditPerUnit { get; init; } 

    /// <summary>
    /// Reference.
    /// </summary>
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required AdditionalReference11 Reference { get; init; } 

    /// <summary>
    /// Related Amount.
    /// </summary>
    [DisplayName("Related Amount")]
    [IsoXmlTag("RltdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? RelatedAmount { get; init; } 

    /// <summary>
    /// Related Quantity.
    /// </summary>
    [DisplayName("Related Quantity")]
    [IsoXmlTag("RltdQty")]
    public IsoDecimalNumber? RelatedQuantity { get; init; } 

    
    #nullable disable
    
}
