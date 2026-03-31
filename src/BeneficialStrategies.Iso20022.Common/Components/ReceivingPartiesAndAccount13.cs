// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
/// </summary>
[IsoId("_I-FT8SSIEeWdoOFYMt-Lzw")]
[DisplayName("Receiving Parties And Account")]
public record ReceivingPartiesAndAccount13
{
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_JagKNSSIEeWdoOFYMt-Lzw")]
    [DisplayName("Receiver Details")]
    [IsoXmlTag("RcvrDtls")]
    public InvestmentAccount55? ReceiverDetails { get; init; }

    /// <summary>
    /// Party that acts on behalf of the buyer of securities when the buyer does not have a direct relationship with the receiving agent.
    /// </summary>
    [IsoId("_JagKNySIEeWdoOFYMt-Lzw")]
    [DisplayName("Receivers Custodian Details")]
    [IsoXmlTag("RcvrsCtdnDtls")]
    public PartyIdentificationAndAccount124? ReceiversCustodianDetails { get; init; }

    /// <summary>
    /// Party that the receiver&apos;s custodian uses to effect the receipt of a security, when the receiver&apos;s custodian does not have a direct relationship with the receiving agent.
    /// </summary>
    [IsoId("_JagKOSSIEeWdoOFYMt-Lzw")]
    [DisplayName("Receivers Intermediary 1 Details")]
    [IsoXmlTag("RcvrsIntrmy1Dtls")]
    public PartyIdentificationAndAccount124? ReceiversIntermediary1Details { get; init; }

    /// <summary>
    /// Party that interacts with the receiver’s intermediary.
    /// </summary>
    [IsoId("_GRaRUSSTEeWdoOFYMt-Lzw")]
    [DisplayName("Receivers Intermediary 2 Details")]
    [IsoXmlTag("RcvrsIntrmy2Dtls")]
    public PartyIdentificationAndAccount124? ReceiversIntermediary2Details { get; init; }

    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, for example, securities central depository.
    /// </summary>
    [IsoId("_JagKOySIEeWdoOFYMt-Lzw")]
    [DisplayName("Receiving Agent Details")]
    [IsoXmlTag("RcvgAgtDtls")]
    public required PartyIdentificationAndAccount123 ReceivingAgentDetails { get; init; }

    /// <summary>
    /// Identifies the securities settlement system to be used.
    /// </summary>
    [IsoId("_JagKPSSIEeWdoOFYMt-Lzw")]
    [DisplayName("Securities Settlement System")]
    [IsoXmlTag("SctiesSttlmSys")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SecuritiesSettlementSystem { get; init; }

    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    [IsoId("_JagKPySIEeWdoOFYMt-Lzw")]
    [DisplayName("Place Of Settlement Details")]
    [IsoXmlTag("PlcOfSttlmDtls")]
    public PartyIdentification97? PlaceOfSettlementDetails { get; init; }
}
