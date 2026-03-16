// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the processing of the transaction.
/// </summary>
[IsoId("_Sxhy0EXaEeegp_DADCe7HQ")]
[DisplayName("Processing Result")]
public record ProcessingResult1
{
    /// <summary>
    /// Data pertaining to the approval of the transaction.
    /// </summary>
    [IsoId("_kD-yEEXaEeegp_DADCe7HQ")]
    [DisplayName("Approval Data")]
    [IsoXmlTag("ApprvlData")]
    public ApprovalData1? ApprovalData { get; init; }

    /// <summary>
    /// Result of the processing.
    /// </summary>
    [IsoId("_swXTYEXaEeegp_DADCe7HQ")]
    [DisplayName("Result Data")]
    [IsoXmlTag("RsltData")]
    public ResultData1? ResultData { get; init; }

    /// <summary>
    /// Outcome of a previous processing, for example, in response to a duplicate request.
    /// </summary>
    [IsoId("_1nUKgRs2EeqrvK3udMUsNQ")]
    [DisplayName("Original Result Data")]
    [IsoXmlTag("OrgnlRsltData")]
    public ResultData1? OriginalResultData { get; init; }

    /// <summary>
    /// Action required flag.
    /// Default: False: Action Not Required.
    /// True: Action Required.
    /// </summary>
    [IsoId("_Uw1bwJ1IEeeuzZPGP9QqVw")]
    [DisplayName("Action Required")]
    [IsoXmlTag("ActnReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ActionRequired { get; init; }

    /// <summary>
    /// Set of actions to be performed.
    /// ISO 8583 bit 39
    /// </summary>
    [IsoId("_2E0hUEXaEeegp_DADCe7HQ")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public Action9? Action { get; init; }

    /// <summary>
    /// Additional action to perform.
    /// </summary>
    [IsoId("__dsVMEXaEeegp_DADCe7HQ")]
    [DisplayName("Additional Action")]
    [IsoXmlTag("AddtlActn")]
    public AdditionalAction1? AdditionalAction { get; init; }

    /// <summary>
    /// Additional information relevant for the destination.
    /// ISO 8583 bit 44
    /// </summary>
    [IsoId("_jTNnAEXbEeegp_DADCe7HQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation20? AdditionalInformation { get; init; }
}
