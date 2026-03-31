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
[IsoId("_fPPmUR6bEeOolf0-cMYhrw")]
[DisplayName("Receiving Parties And Account")]
public record ReceivingPartiesAndAccount9
{
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_fl2vhR6bEeOolf0-cMYhrw")]
    [DisplayName("Receiver Details")]
    [IsoXmlTag("RcvrDtls")]
    public InvestmentAccount41? ReceiverDetails { get; init; }

    /// <summary>
    /// Party that acts on behalf of the buyer of securities when the buyer does not have a direct relationship with the receiving agent.
    /// </summary>
    [IsoId("_fl2vhx6bEeOolf0-cMYhrw")]
    [DisplayName("Receivers Custodian Details")]
    [IsoXmlTag("RcvrsCtdnDtls")]
    public PartyIdentificationAndAccount5? ReceiversCustodianDetails { get; init; }

    /// <summary>
    /// Party that the Receiver&apos;s custodian uses to effect the receipt of a security, when the Receiver&apos;s custodian does not have a direct relationship with the Receiver agent.
    /// </summary>
    [IsoId("_fl2viR6bEeOolf0-cMYhrw")]
    [DisplayName("Receivers Intermediary Details")]
    [IsoXmlTag("RcvrsIntrmyDtls")]
    public PartyIdentificationAndAccount5? ReceiversIntermediaryDetails { get; init; }

    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, eg, securities central depository.
    /// </summary>
    [IsoId("_fl2vix6bEeOolf0-cMYhrw")]
    [DisplayName("Receiving Agent Details")]
    [IsoXmlTag("RcvgAgtDtls")]
    public required PartyIdentificationAndAccount4 ReceivingAgentDetails { get; init; }

    /// <summary>
    /// Identifies the securities settlement system to be used.
    /// </summary>
    [IsoId("_fl2vjR6bEeOolf0-cMYhrw")]
    [DisplayName("Securities Settlement System")]
    [IsoXmlTag("SctiesSttlmSys")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SecuritiesSettlementSystem { get; init; }

    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    [IsoId("_fl2vjx6bEeOolf0-cMYhrw")]
    [DisplayName("Place Of Settlement Details")]
    [IsoXmlTag("PlcOfSttlmDtls")]
    public PartyIdentification21? PlaceOfSettlementDetails { get; init; }
}
