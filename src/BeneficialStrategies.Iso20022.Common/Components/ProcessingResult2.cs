// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the processing of the authorisation.
/// </summary>
[IsoId("_U2HhkU9uEeePXdaAO32Uew")]
[DisplayName("Processing Result")]
public record ProcessingResult2
{
    /// <summary>
    /// Data pertaining to the approval of the transaction.
    /// </summary>
    [IsoId("_VBbZsU9uEeePXdaAO32Uew")]
    [DisplayName("Approval Data")]
    [IsoXmlTag("ApprvlData")]
    public ApprovalData1? ApprovalData { get; init; }

    /// <summary>
    /// Result of the processing.
    /// </summary>
    [IsoId("_VBbZs09uEeePXdaAO32Uew")]
    [DisplayName("Result Data")]
    [IsoXmlTag("RsltData")]
    public ResultData1? ResultData { get; init; }

    /// <summary>
    /// Outcome of a previous processing, for example, in response to a duplicate request.
    /// </summary>
    [IsoId("_fda3cE9uEeePXdaAO32Uew")]
    [DisplayName("Original Result Data")]
    [IsoXmlTag("OrgnlRsltData")]
    public ResultData1? OriginalResultData { get; init; }

    /// <summary>
    /// Action required flag.
    /// Default: False: Action Not Required.
    /// True: Action Required.
    /// </summary>
    [IsoId("_fiPv4Z1IEeeuzZPGP9QqVw")]
    [DisplayName("Action Required")]
    [IsoXmlTag("ActnReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ActionRequired { get; init; }

    /// <summary>
    /// Set of actions to be performed.
    /// </summary>
    [IsoId("_VBbZtU9uEeePXdaAO32Uew")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public Action9? Action { get; init; }

    /// <summary>
    /// Additional action to perform.
    /// </summary>
    [IsoId("_VBbZt09uEeePXdaAO32Uew")]
    [DisplayName("Additional Action")]
    [IsoXmlTag("AddtlActn")]
    public AdditionalAction1? AdditionalAction { get; init; }

    /// <summary>
    /// Additional information relevant for the destination.
    /// ISO 8583 bit 44
    /// </summary>
    [IsoId("_VBbZuU9uEeePXdaAO32Uew")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation20? AdditionalInformation { get; init; }
}
