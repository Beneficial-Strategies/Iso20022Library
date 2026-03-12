// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Elements used to calculate the collateral margin call for the variation margin.
/// </summary>
[IsoId("_UnE22tp-Ed-ak6NoX_4Aeg_12968577")]
[DisplayName("Variation Margin")]
public partial record VariationMargin1
{
    #nullable enable
    
    /// <summary>
    /// Amount of unsecured exposure a counterparty will accept before issuing a margin call in the base currency.
    /// </summary>
    [IsoId("_UnOn0Np-Ed-ak6NoX_4Aeg_-1210355091")]
    [DisplayName("Threshold Amount")]
    [IsoXmlTag("ThrshldAmt")]
    public required ActiveCurrencyAndAmount ThresholdAmount { get; init; } 
    
    /// <summary>
    /// Specifies if the threshold amount is secured or unsecured.
    /// </summary>
    [IsoId("_UnOn0dp-Ed-ak6NoX_4Aeg_-554608677")]
    [DisplayName("Threshold Type")]
    [IsoXmlTag("ThrshldTp")]
    public ThresholdType1Code? ThresholdType { get; init; } 
    
    /// <summary>
    /// Minimum amount to pay/receive as specified in the agreement in the base currency (to avoid the need to transfer an inconveniently small amount of variation margin).
    /// </summary>
    [IsoId("_UnOn0tp-Ed-ak6NoX_4Aeg_1747658948")]
    [DisplayName("Minimum Transfer Amount")]
    [IsoXmlTag("MinTrfAmt")]
    public required ActiveCurrencyAndAmount MinimumTransferAmount { get; init; } 
    
    /// <summary>
    /// Amount specified to avoid the need to transfer uneven amounts of collateral.
    /// </summary>
    [IsoId("_UnOn09p-Ed-ak6NoX_4Aeg_-1680572847")]
    [DisplayName("Rounding Amount")]
    [IsoXmlTag("RndgAmt")]
    public required ActiveCurrencyAndAmount RoundingAmount { get; init; } 
    
    /// <summary>
    /// Defines how the rounding amount was applied in the calculation. For example, should the amount of collateral required be rounded up, down, to the closer integral multiple specified or not rounded.
    /// </summary>
    [IsoId("_UnOn1Np-Ed-ak6NoX_4Aeg_2069494905")]
    [DisplayName("Rounding Method")]
    [IsoXmlTag("RndgMtd")]
    public required RoundingMethod1Code RoundingMethod { get; init; } 
    
    
    #nullable disable
    
}
