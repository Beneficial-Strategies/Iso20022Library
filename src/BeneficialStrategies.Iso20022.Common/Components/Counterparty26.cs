// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to counterparty identification.
/// </summary>
[IsoId("_7aiv0ZQGEeiILOjNP8ro1w")]
[DisplayName("Counterparty")]
public partial record Counterparty26
{
    #nullable enable
    
    /// <summary>
    /// Unique code identifying the reporting counterparty of the contract.
    /// </summary>
    [IsoId("_7mHtsZQGEeiILOjNP8ro1w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required OrganisationIdentification7Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Indicates if the reporting counterparty is a central counterparty, a financial, non-financial counterparty or other type of counterparty in accordance with regulation.
    /// </summary>
    [IsoId("_7mHts5QGEeiILOjNP8ro1w")]
    [DisplayName("Nature")]
    [IsoXmlTag("Ntr")]
    public CounterpartyTradeNature5Choice_? Nature { get; init; } 
    
    /// <summary>
    /// Identifies the trading capacity of the seller.
    /// </summary>
    [IsoId("_7mHttZQGEeiILOjNP8ro1w")]
    [DisplayName("Trading Capacity")]
    [IsoXmlTag("TradgCpcty")]
    public TradingCapacity7Code? TradingCapacity { get; init; } 
    
    /// <summary>
    /// Identifies whether the reporting counterparty is a buyer or a seller.
    /// </summary>
    [IsoId("_7mHtt5QGEeiILOjNP8ro1w")]
    [DisplayName("Counterparty Side")]
    [IsoXmlTag("CtrPtySd")]
    public OptionParty1Code? CounterpartySide { get; init; } 
    
    
    #nullable disable
    
}
