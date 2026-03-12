// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional details on the underlying. In securities financing deals, it is used to identify and provide information on the collateral.
/// </summary>
[IsoId("_1RJ4sWp7EemmaZLSPtWX5A")]
[DisplayName("Underlying Attributes")]
public partial record UnderlyingAttributes4
{
    #nullable enable
    
    /// <summary>
    /// Percent of the strike price that this underlying represents.
    /// </summary>
    [IsoId("_1cvdoWp7EemmaZLSPtWX5A")]
    [DisplayName("Allocation Percentage")]
    [IsoXmlTag("AllcnPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? AllocationPercentage { get; init; } 
    
    /// <summary>
    /// Unit amount of the underlying security.
    /// </summary>
    [IsoId("_1cwEt2p7EemmaZLSPtWX5A")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public UnitOrFaceAmount1Choice_? Quantity { get; init; } 
    
    /// <summary>
    /// Indicates order settlement period for the underlying instrument. Represents the number of days until settlement; for example, 2 means T+1 settlement, 4 means T+3 settlement, 5 means T+4 settlement.
    /// </summary>
    [IsoId("_1cwEuWp7EemmaZLSPtWX5A")]
    [DisplayName("Settlement Type")]
    [IsoXmlTag("SttlmTp")]
    public SettlementType3Choice_? SettlementType { get; init; } 
    
    /// <summary>
    /// Cash amount associated with the underlying component. Necessary for derivatives that deliver into more than one underlying instrument and one of the underlying&apos;s is a fixed cash value.
    /// </summary>
    [IsoId("_1cwEwWp7EemmaZLSPtWX5A")]
    [DisplayName("Cash Amount")]
    [IsoXmlTag("CshAmt")]
    public ActiveCurrencyAndAmount? CashAmount { get; init; } 
    
    /// <summary>
    /// Represents how the cash will be calculated. Indicates that the cash is either fixed or a difference value (difference between strike and current underlying price).
    /// </summary>
    [IsoId("_1cwEyWp7EemmaZLSPtWX5A")]
    [DisplayName("Cash Type")]
    [IsoXmlTag("CshTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CashType { get; init; } 
    
    /// <summary>
    /// In a financing deal, clean price (percent-of-par or per unit) of the underlying security or basket.
    /// </summary>
    [IsoId("_1cwE0Wp7EemmaZLSPtWX5A")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public Price8? Price { get; init; } 
    
    /// <summary>
    /// In a financing deal, price (percent-of-par or per unit) of the underlying security or basket. &quot;Dirty&quot; means it includes accrued interest.
    /// </summary>
    [IsoId("_1cwE2Wp7EemmaZLSPtWX5A")]
    [DisplayName("Dirty Price")]
    [IsoXmlTag("DrtyPric")]
    public Price8? DirtyPrice { get; init; } 
    
    /// <summary>
    /// In a financing deal, price (percent-of-par or per unit) of the underlying security or basket at the end of the agreement.
    /// </summary>
    [IsoId("_1cwE4Wp7EemmaZLSPtWX5A")]
    [DisplayName("End Price")]
    [IsoXmlTag("EndPric")]
    public Price8? EndPrice { get; init; } 
    
    /// <summary>
    /// Currency value attributed to this collateral at the start of the agreement.
    /// </summary>
    [IsoId("_1cwE6Wp7EemmaZLSPtWX5A")]
    [DisplayName("Start Value")]
    [IsoXmlTag("StartVal")]
    public ActiveCurrencyAndAmount? StartValue { get; init; } 
    
    /// <summary>
    /// Currency value currently attributed to this collateral.
    /// </summary>
    [IsoId("_1cwE8Wp7EemmaZLSPtWX5A")]
    [DisplayName("Current Value")]
    [IsoXmlTag("CurVal")]
    public ActiveCurrencyAndAmount? CurrentValue { get; init; } 
    
    /// <summary>
    /// Currency value attributed to this collateral at the end of the agreement.
    /// </summary>
    [IsoId("_1cwE-Wp7EemmaZLSPtWX5A")]
    [DisplayName("End Value")]
    [IsoXmlTag("EndVal")]
    public ActiveCurrencyAndAmount? EndValue { get; init; } 
    
    /// <summary>
    /// Unit amount of the underlying security (shares) adjusted for pending corporate action not yet allocated.
    /// </summary>
    [IsoId("_1cwFAWp7EemmaZLSPtWX5A")]
    [DisplayName("Adjusted Quantity")]
    [IsoXmlTag("AdjstdQty")]
    public UnitOrFaceAmount1Choice_? AdjustedQuantity { get; init; } 
    
    /// <summary>
    /// Foreign exchange rate used to compute the current value.
    /// </summary>
    [IsoId("_1cwFA2p7EemmaZLSPtWX5A")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? ExchangeRate { get; init; } 
    
    /// <summary>
    /// Maximum notional value for a financial instrument that is capped.
    /// </summary>
    [IsoId("_1cwFC2p7EemmaZLSPtWX5A")]
    [DisplayName("Cap Value")]
    [IsoXmlTag("CapVal")]
    public ActiveCurrencyAndAmount? CapValue { get; init; } 
    
    
    #nullable disable
    
}
