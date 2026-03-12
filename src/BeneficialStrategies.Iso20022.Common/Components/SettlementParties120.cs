// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides a settlement party by a choice between a BIC or a name and address or a party identification.
/// </summary>
[IsoId("_Box6QQN1Ee2-vqzwMUAewg")]
[DisplayName("Settlement Parties")]
public partial record SettlementParties120
{
    #nullable enable
    
    /// <summary>
    /// Financial institution from which cash will be transferred.
    /// </summary>
    [IsoId("_BuMlwQN1Ee2-vqzwMUAewg")]
    [DisplayName("Delivery Agent")]
    [IsoXmlTag("DlvryAgt")]
    public PartyIdentification242Choice_? DeliveryAgent { get; init; } 
    
    /// <summary>
    /// Party, within the settlement chain, between the delivery and receiving agents.
    /// </summary>
    [IsoId("_BuMlwwN1Ee2-vqzwMUAewg")]
    [DisplayName("Intermediary")]
    [IsoXmlTag("Intrmy")]
    public PartyIdentification242Choice_? Intermediary { get; init; } 
    
    /// <summary>
    /// Financial institution where the payee will receive the funds.
    /// </summary>
    [IsoId("_BuMlxQN1Ee2-vqzwMUAewg")]
    [DisplayName("Receiving Agent")]
    [IsoXmlTag("RcvgAgt")]
    public required PartyIdentification242Choice_ ReceivingAgent { get; init; } 
    
    /// <summary>
    /// Ultimate institution that will receive the funds when different from the trading or counterparty side.
    /// </summary>
    [IsoId("_BuMlxwN1Ee2-vqzwMUAewg")]
    [DisplayName("Beneficiary Institution")]
    [IsoXmlTag("BnfcryInstn")]
    public PartyIdentification242Choice_? BeneficiaryInstitution { get; init; } 
    
    
    #nullable disable
    
}
