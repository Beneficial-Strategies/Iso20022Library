// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_PrK9iNp-Ed-ak6NoX_4Aeg_-727218247")]
public interface IGroupHeader31 : IIsoComponent
{
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the instructed party, to unambiguously identify the message.|Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_PrUugNp-Ed-ak6NoX_4Aeg_-726298236")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    IsoMax35Text MessageIdentification { get; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_PrUugdp-Ed-ak6NoX_4Aeg_-726298215")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    IsoISODateTime CreationDateTime { get; }

    /// <summary>
    /// User identification or any user key to be used to check the authority of the initiating party.||Usage: The content is not of a technical nature, but reflects the organisational structure at the initiating side. The authorisation element can typically be used in relay scenarios, payment initiations, payment returns or payment reversals that are initiated on behalf of a party different from the initiating party.
    /// </summary>
    [IsoId("_PrUugtp-Ed-ak6NoX_4Aeg_263177191")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    IEnumerable<IAuthorisation1Choice> Authorisation { get; }

    /// <summary>
    /// Party that initiates the mandate message.
    /// </summary>
    [IsoId("_PrUug9p-Ed-ak6NoX_4Aeg_-726298169")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    IPartyIdentification32? InitiatingParty { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out an instruction.||Usage Rule: |In case of amendment and cancellation request messages, the instructing agent is the party sending the amendment and cancellation request message and not the party that sent the original mandate initiation request message.|In case of acceptance report message, the instructing agent is the party sending the acceptance report message and not the party that sent the original mandate request message.
    /// </summary>
    [IsoId("_PrUuhNp-Ed-ak6NoX_4Aeg_-726298030")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification4? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out an instruction.||Usage Rule: |In case of amendment and cancellation request messages, the instructed agent is the party receiving the amendment and cancellation request message and not the party that received the original mandate initiation request message.|In case of acceptance report message, the instructed agent is the party receiving the acceptance report message and not the party that received the original mandate request message.
    /// </summary>
    [IsoId("_PrUuhdp-Ed-ak6NoX_4Aeg_-726298061")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification4? InstructedAgent { get; }
}
