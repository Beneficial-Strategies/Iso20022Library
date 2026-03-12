// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
/// </summary>
[IsoId("_t-54W4FvEeWtPe6Crjmeug")]
[DisplayName("Settlement Details")]
public partial record SettlementDetails102
{
    #nullable enable
    
    /// <summary>
    /// Indicates the date as known by the two parties to be used for matching purposes when settlement of securities occurs.
    /// </summary>
    [IsoId("_uU7LkYFvEeWtPe6Crjmeug")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TradeDate { get; init; } 
    
    /// <summary>
    /// Provides details on either the delivering or receiving settlement parties.
    /// </summary>
    [IsoId("_uU7Lk4FvEeWtPe6Crjmeug")]
    [DisplayName("Settlement Parties")]
    [IsoXmlTag("SttlmPties")]
    public SettlementParties5Choice_? SettlementParties { get; init; } 
    
    /// <summary>
    /// Indicates the collateral ownership.
    /// </summary>
    [IsoId("_uU7LlYFvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Ownership")]
    [IsoXmlTag("CollOwnrsh")]
    public required CollateralOwnership2 CollateralOwnership { get; init; } 
    
    
    #nullable disable
    
}
