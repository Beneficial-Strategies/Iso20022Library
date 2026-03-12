// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
/// </summary>
[IsoId("_VP5xZ9p-Ed-ak6NoX_4Aeg_2096007708")]
[DisplayName("Receiving Parties And Account")]
public partial record ReceivingPartiesAndAccount1
{
    #nullable enable
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_VP5xaNp-Ed-ak6NoX_4Aeg_1920137751")]
    [DisplayName("Receiver Details")]
    [IsoXmlTag("RcvrDtls")]
    public required InvestmentAccount11 ReceiverDetails { get; init; } 
    
    /// <summary>
    /// Party that acts on behalf of the buyer of securities when the buyer does not have a direct relationship with the receiving agent.
    /// </summary>
    [IsoId("_VP5xadp-Ed-ak6NoX_4Aeg_-953327782")]
    [DisplayName("Receivers Custodian Details")]
    [IsoXmlTag("RcvrsCtdnDtls")]
    public PartyIdentificationAndAccount2? ReceiversCustodianDetails { get; init; } 
    
    /// <summary>
    /// Party that the Receiver&apos;s custodian uses to effect the receipt of a security, when the Receiver&apos;s custodian does not have a direct relationship with the Receiver agent.
    /// </summary>
    [IsoId("_VP5xatp-Ed-ak6NoX_4Aeg_-962563141")]
    [DisplayName("Receivers Intermediary Details")]
    [IsoXmlTag("RcvrsIntrmyDtls")]
    public PartyIdentificationAndAccount2? ReceiversIntermediaryDetails { get; init; } 
    
    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, eg, securities central depository.
    /// </summary>
    [IsoId("_VP5xa9p-Ed-ak6NoX_4Aeg_-992117644")]
    [DisplayName("Receiving Agent Details")]
    [IsoXmlTag("RcvgAgtDtls")]
    public required PartyIdentificationAndAccount2 ReceivingAgentDetails { get; init; } 
    
    /// <summary>
    /// Identifies the securities settlement system to be used.
    /// </summary>
    [IsoId("_VP5xbNp-Ed-ak6NoX_4Aeg_-796229294")]
    [DisplayName("Securities Settlement System")]
    [IsoXmlTag("SctiesSttlmSys")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SecuritiesSettlementSystem { get; init; } 
    
    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    [IsoId("_VP5xbdp-Ed-ak6NoX_4Aeg_443129355")]
    [DisplayName("Place Of Settlement Details")]
    [IsoXmlTag("PlcOfSttlmDtls")]
    public required PartyIdentificationAndAccount2 PlaceOfSettlementDetails { get; init; } 
    
    
    #nullable disable
    
}
