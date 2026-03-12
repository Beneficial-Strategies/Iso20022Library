// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a settlement party by a choice between a BIC or a name and address.
/// </summary>
[IsoId("_S4bqgAEcEeCQm6a_G2yO_w_-1857619750")]
[DisplayName("Settlement Parties")]
public partial record SettlementParties9
{
    #nullable enable
    
    /// <summary>
    /// Financial institution from which cash will be transferred.
    /// </summary>
    [IsoId("_S4bqgQEcEeCQm6a_G2yO_w_-1971458816")]
    [DisplayName("Delivery Agent")]
    [IsoXmlTag("DlvryAgt")]
    public PartyIdentification19Choice_? DeliveryAgent { get; init; } 
    
    /// <summary>
    /// Party, within the settlement chain, between the delivery and receiving agents.
    /// </summary>
    [IsoId("_S4bqggEcEeCQm6a_G2yO_w_1326436127")]
    [DisplayName("Intermediary")]
    [IsoXmlTag("Intrmy")]
    public PartyIdentification19Choice_? Intermediary { get; init; } 
    
    /// <summary>
    /// Financial institution where the payee will receive the funds.
    /// </summary>
    [IsoId("_S4bqgwEcEeCQm6a_G2yO_w_329363774")]
    [DisplayName("Receiving Agent")]
    [IsoXmlTag("RcvgAgt")]
    public required PartyIdentification19Choice_ ReceivingAgent { get; init; } 
    
    /// <summary>
    /// Ultimate institution that will receive the funds when different than the trading or counterparty side.
    /// </summary>
    [IsoId("_S4bqhAEcEeCQm6a_G2yO_w_-667708579")]
    [DisplayName("Beneficiary Institution")]
    [IsoXmlTag("BnfcryInstn")]
    public PartyIdentification19Choice_? BeneficiaryInstitution { get; init; } 
    
    
    #nullable disable
    
}
