// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_P03FCtp-Ed-ak6NoX_4Aeg_130586071")]
public interface IGroupHeader37 : IIsoComponent
{
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the next party in the chain to unambiguously identify the message.|Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_P1AO8Np-Ed-ak6NoX_4Aeg_130586102")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    Max35Text MessageIdentification { get; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_P1AO8dp-Ed-ak6NoX_4Aeg_130586380")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    ISODateTime CreationDateTime { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).||Usage: The instructing agent is the party sending the status message and not the party that sent the original instruction that is being reported on.
    /// </summary>
    [IsoId("_P1AO8tp-Ed-ak6NoX_4Aeg_-4271305")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification4? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).||Usage: The instructed agent is the party receiving the status message and not the party that received the original instruction that is being reported on.
    /// </summary>
    [IsoId("_P1AO89p-Ed-ak6NoX_4Aeg_-4271366")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification4? InstructedAgent { get; }
}
