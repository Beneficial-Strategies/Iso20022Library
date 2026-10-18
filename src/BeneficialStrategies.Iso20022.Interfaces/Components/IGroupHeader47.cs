// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_s3oCIFkyEeGeoaLUQk__nA_-839305610")]
public interface IGroupHeader47 : IIsoComponent
{
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the instructed party, to unambiguously identify the message.|Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_s3oCIVkyEeGeoaLUQk__nA_1542027670")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    IsoMax35Text MessageIdentification { get; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_s3xzIFkyEeGeoaLUQk__nA_431116251")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    IsoISODateTime CreationDateTime { get; }

    /// <summary>
    /// User identification or any user key to be used to check the authority of the initiating party.||Usage: The content is not of a technical nature, but reflects the organisational structure at the initiating side. The authorisation element can typically be used in relay scenarios, payment initiations, payment returns or payment reversals that are initiated on behalf of a party different from the initiating party.
    /// </summary>
    [IsoId("_s37kIFkyEeGeoaLUQk__nA_1704157201")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    IEnumerable<IAuthorisation1Choice> Authorisation { get; }

    /// <summary>
    /// Party that initiates the mandate message.
    /// </summary>
    [IsoId("_s4EuEFkyEeGeoaLUQk__nA_1970233")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    IPartyIdentification43? InitiatingParty { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out an instruction.||Usage Rule: |In case of amendment and cancellation request messages, the instructing agent is the party sending the amendment and cancellation request message and not the party that sent the original mandate initiation request message.|In case of acceptance report message, the instructing agent is the party sending the acceptance report message and not the party that sent the original mandate request message.
    /// </summary>
    [IsoId("_s4OfEFkyEeGeoaLUQk__nA_-1022013049")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out an instruction.||Usage Rule: |In case of amendment and cancellation request messages, the instructed agent is the party receiving the amendment and cancellation request message and not the party that received the original mandate initiation request message.|In case of acceptance report message, the instructed agent is the party receiving the acceptance report message and not the party that received the original mandate request message.
    /// </summary>
    [IsoId("_s4OfEVkyEeGeoaLUQk__nA_989269376")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructedAgent { get; }
}
