// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed Instruction Status19.
/// </summary>
[IsoId("_PCvhwVxyEe6fgZt44_IqFA")]
[DisplayName("Detailed Instruction Status19")]
public record DetailedInstructionStatus19
{
    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Account Owner.
    /// </summary>
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification231Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Modality Of Counting.
    /// </summary>
    [DisplayName("Modality Of Counting")]
    [IsoXmlTag("ModltyOfCntg")]
    public required ModalityOfCounting1Choice_ ModalityOfCounting { get; init; }

    /// <summary>
    /// Proxy.
    /// </summary>
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public PartyIdentification232Choice_? Proxy { get; init; }

    /// <summary>
    /// Rights Holder.
    /// </summary>
    [DisplayName("Rights Holder")]
    [IsoXmlTag("RghtsHldr")]
    public PartyIdentification246Choice_? RightsHolder { get; init; }

    /// <summary>
    /// Single Instruction Identification.
    /// </summary>
    [DisplayName("Single Instruction Identification")]
    [IsoXmlTag("SnglInstrId")]
    public required IsoMax35Text SingleInstructionIdentification { get; init; }

    /// <summary>
    /// Standing Instruction.
    /// </summary>
    [DisplayName("Standing Instruction")]
    [IsoXmlTag("StgInstr")]
    public IsoYesNoIndicator? StandingInstruction { get; init; }

    /// <summary>
    /// Sub Account Identification.
    /// </summary>
    [DisplayName("Sub Account Identification")]
    [IsoXmlTag("SubAcctId")]
    public IsoMax35Text? SubAccountIdentification { get; init; }

    /// <summary>
    /// Vote Per Resolution.
    /// </summary>
    [DisplayName("Vote Per Resolution")]
    [IsoXmlTag("VotePerRsltn")]
    public Vote19? VotePerResolution { get; init; }

    /// <summary>
    /// Vote Receipt Date Time.
    /// </summary>
    [DisplayName("Vote Receipt Date Time")]
    [IsoXmlTag("VoteRctDtTm")]
    public DateAndDateTime1Choice_? VoteReceiptDateTime { get; init; }
}
