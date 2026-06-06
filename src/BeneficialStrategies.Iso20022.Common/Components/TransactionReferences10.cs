// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the underlying transaction.
/// </summary>
[IsoId("848b7f50-1917-499a-9240-034cbc9fd1c1")]
[DisplayName("Transaction References10")]
public record TransactionReferences10
{
    /// <summary>
    /// Point to point reference, as assigned by the instructing party of the underlying message.
    /// </summary>
    [IsoId("d4004b33-651e-4e1d-94fe-c25f5381bd3b")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public IsoMax35Text? MessageIdentification { get; init; }

    /// <summary>
    /// Unique reference, as assigned by the account servicing institution, to unambiguously identify the instruction.
    /// </summary>
    [IsoId("d019eff3-cc3b-41ab-94d1-6aab3501393c")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the payment information group within the message.
    /// </summary>
    [IsoId("8088e9cd-e1f9-4ee1-8b87-25d351de91e7")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    public IsoMax35Text? PaymentInformationIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction.||Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    [IsoId("b92269e0-c05a-42a9-b0dd-312a411ac449")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public IsoMax35Text? InstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.||Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction. It can be included in several messages related to the transaction.||Usage: In case there are technical limitations to pass on multiple references, the end-to-end identification must be passed on throughout the entire end-to-end chain.
    /// </summary>
    [IsoId("bc7d2f26-d16a-4469-aed0-4267d236daba")]
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    public IsoMax35Text? EndToEndIdentification { get; init; }

    /// <summary>
    /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("e5b87b91-b2d9-436a-a300-4650c462bd96")]
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    public IsoUUIDv4Identifier? UETR { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain. |Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. |Usage: The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.
    /// </summary>
    [IsoId("3c384796-a879-483f-8d4e-030176c4c038")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public IsoMax35Text? TransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    [IsoId("ccafe8d1-299b-493c-85ac-fa6f7d71ddb9")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a cheque as assigned by the agent.
    /// </summary>
    [IsoId("f3d81efc-cbdd-438b-8b62-808c61769e8f")]
    [DisplayName("Cheque Number")]
    [IsoXmlTag("ChqNb")]
    public IsoMax35Text? ChequeNumber { get; init; }

    /// <summary>
    /// Unique reference, as assigned by a clearing system, to unambiguously identify the instruction.|Usage: In case there are technical limitations to pass on multiple references, the end-to-end identification must be passed on throughout the entire end-to-end chain.
    /// </summary>
    [IsoId("d47d60a5-3699-4f66-95e1-eb225ef7f4c3")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <summary>
    /// Unambiguous identification of the securities transaction as known by the securities account owner (or the instructing party managing the account).
    /// </summary>
    [IsoId("4db29bc6-f9e1-4c06-a1fe-885ec8150079")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    public IsoMax35Text? AccountOwnerTransactionIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the securities transaction as known by the securities account servicer.
    /// </summary>
    [IsoId("cc85499f-ef01-4e57-a4a9-578828c793aa")]
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of a securities transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [IsoId("0efec6ad-236f-4812-b101-c5db910a5c0c")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the securities transaction assigned by the processor of the instruction other than the securities account owner, the securities account servicer and the market infrastructure.
    /// </summary>
    [IsoId("1ee9c1f2-522d-4042-8b76-c90b6215ab75")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    public IsoMax35Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the returned transaction.|Usage: The instructing party is the party sending the return message and not the party that sent the original instruction that is being returned.
    /// </summary>
    [IsoId("84ad199a-ad0b-46a5-81d8-657fa073df82")]
    [DisplayName("Return Identification")]
    [IsoXmlTag("RtrId")]
    public IsoMax35Text? ReturnIdentification { get; init; }

    /// <summary>
    /// Proprietary reference related to the underlying transaction.
    /// </summary>
    [IsoId("608d933d-5282-4a91-881e-1edff93ca389")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ValueList<ProprietaryReference1> Proprietary { get; init; } = [];
}
