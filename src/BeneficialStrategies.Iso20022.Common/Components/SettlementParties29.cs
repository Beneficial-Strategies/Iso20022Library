// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a settlement party by a choice between a BIC or a name and address or a party identification.
/// </summary>
[IsoId("_4CRAsSjaEeK1Sbo8NpBROA")]
[DisplayName("Settlement Parties")]
public record SettlementParties29
{
    /// <summary>
    /// Financial institution from which cash will be transferred.
    /// </summary>
    [IsoId("_4PJmJSjaEeK1Sbo8NpBROA")]
    [DisplayName("Delivery Agent")]
    [IsoXmlTag("DlvryAgt")]
    public PartyIdentification73Choice_? DeliveryAgent { get; init; }

    /// <summary>
    /// Party, within the settlement chain, between the delivery and receiving agents.
    /// </summary>
    [IsoId("_4PJmKSjaEeK1Sbo8NpBROA")]
    [DisplayName("Intermediary")]
    [IsoXmlTag("Intrmy")]
    public PartyIdentification73Choice_? Intermediary { get; init; }

    /// <summary>
    /// Financial institution where the payee will receive the funds.
    /// </summary>
    [IsoId("_4PJmLSjaEeK1Sbo8NpBROA")]
    [DisplayName("Receiving Agent")]
    [IsoXmlTag("RcvgAgt")]
    public required PartyIdentification73Choice_ ReceivingAgent { get; init; }

    /// <summary>
    /// Ultimate institution that will receive the funds when different from the trading or counterparty side.
    /// </summary>
    [IsoId("_4PJmMSjaEeK1Sbo8NpBROA")]
    [DisplayName("Beneficiary Institution")]
    [IsoXmlTag("BnfcryInstn")]
    public PartyIdentification73Choice_? BeneficiaryInstitution { get; init; }
}
