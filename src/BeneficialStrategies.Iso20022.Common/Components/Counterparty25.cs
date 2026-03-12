// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the counterparty identification.
/// </summary>
[IsoId("_f-cucZQDEeiILOjNP8ro1w")]
[DisplayName("Counterparty")]
public partial record Counterparty25
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the reporting counterparty of the contract.
    /// </summary>
    [IsoId("_gJvYcZQDEeiILOjNP8ro1w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required OrganisationIdentification7Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Identifies the nature of thereporting counterparty in accordance with regulation.
    /// </summary>
    [IsoId("_gJvYc5QDEeiILOjNP8ro1w")]
    [DisplayName("Nature")]
    [IsoXmlTag("Ntr")]
    public required CounterpartyTradeNature5Choice_ Nature { get; init; } 
    
    /// <summary>
    /// Identifies the trading capacity of the seller.
    /// </summary>
    [IsoId("_gJvYdZQDEeiILOjNP8ro1w")]
    [DisplayName("Trading Capacity")]
    [IsoXmlTag("TradgCpcty")]
    public TradingCapacity7Code? TradingCapacity { get; init; } 
    
    /// <summary>
    /// Identifies whether the reporting counterparty is a buyer or a seller.
    /// </summary>
    [IsoId("_gJvYd5QDEeiILOjNP8ro1w")]
    [DisplayName("Counterparty Side")]
    [IsoXmlTag("CtrPtySd")]
    public OptionParty1Code? CounterpartySide { get; init; } 
    
    
    #nullable disable
    
}
