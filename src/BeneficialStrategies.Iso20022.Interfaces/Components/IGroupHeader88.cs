// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_aHxYAW49EeiU9cctagi5ow")]
public interface IGroupHeader88 : IIsoComponent
{
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the next party in the chain to unambiguously identify the message.|Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_aT9Z5W49EeiU9cctagi5ow")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    IsoMax35Text MessageIdentification { get; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_aT9Z5249EeiU9cctagi5ow")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    IsoISODateTime CreationDateTime { get; }

    /// <summary>
    /// User identification or any user key to be used to check whether the initiating party is allowed to initiate transactions from the account specified in the message.||Usage: The content is not of a technical nature, but reflects the organisational structure at the initiating side.|The authorisation element can typically be used in relay scenarios, payment initiations, payment returns or payment reversals that are initiated on behalf of a party different from the initiating party.
    /// </summary>
    [IsoId("_aT9Z6W49EeiU9cctagi5ow")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    IEnumerable<IAuthorisation1Choice> Authorisation { get; }

    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [IsoId("_aT9Z6249EeiU9cctagi5ow")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    IsoMax15NumericText NumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_aT9Z7W49EeiU9cctagi5ow")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    IsoDecimalNumber? ControlSum { get; }

    /// <summary>
    /// Indicates whether the reversal applies to the whole group of transactions or to individual transactions within the original group.
    /// </summary>
    [IsoId("_aT9Z7249EeiU9cctagi5ow")]
    [DisplayName("Group Reversal")]
    [IsoXmlTag("GrpRvsl")]
    IsoTrueFalseIndicator? GroupReversal { get; }

    /// <summary>
    /// Party that initiates the reversal message. |Usage: This can be either the creditor or a party that initiates the reversal of the direct debit on behalf of the creditor.
    /// </summary>
    [IsoId("_aT9Z8W49EeiU9cctagi5ow")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    IPartyIdentification135? InitiatingParty { get; }

    /// <summary>
    /// Financial institution that receives the instruction from the initiating party and forwards it to the next agent in the payment chain.
    /// </summary>
    [IsoId("_aT9Z8249EeiU9cctagi5ow")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    IBranchAndFinancialInstitutionIdentification6? ForwardingAgent { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_aT9Z9W49EeiU9cctagi5ow")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification6? DebtorAgent { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_aT9Z9249EeiU9cctagi5ow")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification6? CreditorAgent { get; }
}
