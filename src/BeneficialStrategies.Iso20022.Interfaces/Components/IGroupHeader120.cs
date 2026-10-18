// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_3jwXcTEyEe6g-ffJsqGiSA")]
public interface IGroupHeader120 : IIsoComponent
{
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the next party in the chain to unambiguously identify the message.
    /// </summary>
    /// <remarks>
    /// Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </remarks>
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    Max35Text MessageIdentification { get; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    ISODateTime CreationDateTime { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    /// <remarks>
    /// Usage: The instructing agent is the party sending the status message and not the party that sent the original instruction that is being reported on.
    /// </remarks>
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification8? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    /// <remarks>
    /// Usage: The instructed agent is the party receiving the status message and not the party that received the original instruction that is being reported on.
    /// </remarks>
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification8? InstructedAgent { get; }

    /// <summary>
    /// Unique identification, as assigned by the original requestor, to unambiguously identify the business query message.
    /// </summary>
    [DisplayName("Original Business Query")]
    [IsoXmlTag("OrgnlBizQry")]
    IOriginalBusinessQuery1? OriginalBusinessQuery { get; }
}
