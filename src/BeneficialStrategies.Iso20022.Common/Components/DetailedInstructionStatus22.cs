// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a meeting instruction vote.
/// </summary>
[IsoId("_Kxz5EajIEfCzuLlmLrhIvA")]
[DisplayName("Detailed Instruction Status22")]
public record DetailedInstructionStatus22
{
    /// <summary>
    /// Identification of the specific individual instruction from the original meeting instruction message for which the confirmation is provided.
    /// </summary>
    [IsoId("_K5kt9ajIEfCzuLlmLrhIvA")]
    [DisplayName("Single Instruction Identification")]
    [IsoXmlTag("SnglInstrId")]
    public required IsoMax35Text SingleInstructionIdentification { get; init; }

    /// <summary>
    /// Identification of the safekeeping account.
    /// </summary>
    [IsoId("_K5kt96jIEfCzuLlmLrhIvA")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_K5kt-ajIEfCzuLlmLrhIvA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification231Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Identification of the subaccount within the safekeeping account.
    /// </summary>
    [IsoId("_K5kt-6jIEfCzuLlmLrhIvA")]
    [DisplayName("Sub Account Identification")]
    [IsoXmlTag("SubAcctId")]
    public IsoMax35Text? SubAccountIdentification { get; init; }

    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [IsoId("_K5kt_ajIEfCzuLlmLrhIvA")]
    [DisplayName("Rights Holder")]
    [IsoXmlTag("RghtsHldr")]
    public ValueList<PartyIdentification246Choice_> RightsHolder { get; init; } = [];

    /// <summary>
    /// Identification of the person appointed by the security holder as the proxy.
    /// </summary>
    [IsoId("_K5kt_6jIEfCzuLlmLrhIvA")]
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public PartyIdentification232Choice_? Proxy { get; init; }

    /// <summary>
    /// Indicates whether standing instructions have been applied or not.
    /// </summary>
    [IsoId("_K5kuAajIEfCzuLlmLrhIvA")]
    [DisplayName("Standing Instruction")]
    [IsoXmlTag("StgInstr")]
    public IsoYesNoIndicator? StandingInstruction { get; init; }

    /// <summary>
    /// Modality through which the votes that have been recorded and counted were received by the issuer, including whether this is ahead of the meeting or at the meeting.
    /// </summary>
    [IsoId("_K5kuA6jIEfCzuLlmLrhIvA")]
    [DisplayName("Modality Of Counting")]
    [IsoXmlTag("ModltyOfCntg")]
    public required ModalityOfCounting1Choice_ ModalityOfCounting { get; init; }

    /// <summary>
    /// Date or date and time at which the votes that have been recorded and counted were received.
    /// </summary>
    [IsoId("_K5kuBajIEfCzuLlmLrhIvA")]
    [DisplayName("Vote Receipt Date Time")]
    [IsoXmlTag("VoteRctDtTm")]
    public DateAndDateTime1Choice_? VoteReceiptDateTime { get; init; }

    /// <summary>
    /// Details of the vote.
    /// </summary>
    [IsoId("_K5kuB6jIEfCzuLlmLrhIvA")]
    [DisplayName("Vote Per Resolution")]
    [IsoXmlTag("VotePerRsltn")]
    public ValueList<Vote22> VotePerResolution { get; init; } = [];
}
