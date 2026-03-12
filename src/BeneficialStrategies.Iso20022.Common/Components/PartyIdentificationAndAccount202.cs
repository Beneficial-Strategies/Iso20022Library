// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parties involved in the triparty collateral transaction.
/// </summary>
[IsoId("_XveIESs-EeySlt9bF77XfA")]
[DisplayName("Party Identification And Account")]
public partial record PartyIdentificationAndAccount202
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_YHwsQSs-EeySlt9bF77XfA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification120Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    [IsoId("_YHwsQys-EeySlt9bF77XfA")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; } 
    
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_YHwsRSs-EeySlt9bF77XfA")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification7? AlternateIdentification { get; init; } 
    
    /// <summary>
    /// Account of the party.
    /// </summary>
    [IsoId("_YHwsRys-EeySlt9bF77XfA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_RkInMis-EeySlt9bF77XfA")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; } 
    
    /// <summary>
    /// Account from which the collateral is sourced.
    /// </summary>
    [IsoId("_YHwsSSs-EeySlt9bF77XfA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification136? AccountOwner { get; init; } 
    
    /// <summary>
    /// Specifies the role of the party in the transaction.
    /// </summary>
    [IsoId("_YHwsSys-EeySlt9bF77XfA")]
    [DisplayName("Party Capacity")]
    [IsoXmlTag("PtyCpcty")]
    public TradingPartyCapacity5Choice_? PartyCapacity { get; init; } 
    
    
    #nullable disable
    
}
