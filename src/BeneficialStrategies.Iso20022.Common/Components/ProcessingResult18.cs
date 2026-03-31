// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the verification processing of the transaction.
/// </summary>
[IsoId("_zA8IYR1MEey8XKHwKquEQw")]
[DisplayName("Processing Result")]
public record ProcessingResult18
{
    /// <summary>
    /// The information about entity that provides the response
    /// </summary>
    [IsoId("_bqMJoSFYEey8XKHwKquEQw")]
    [DisplayName("Response Source")]
    [IsoXmlTag("RspnSrc")]
    public ApprovalEntity2? ResponseSource { get; init; }

    /// <summary>
    /// Result of the processing.
    /// </summary>
    [IsoId("_zHVEQx1MEey8XKHwKquEQw")]
    [DisplayName("Result Data")]
    [IsoXmlTag("RsltData")]
    public required ResultData11 ResultData { get; init; }

    /// <summary>
    /// Value assigned by the entity when the transaction is approved.
    /// </summary>
    [IsoId("_d8FTwSFYEey8XKHwKquEQw")]
    [DisplayName("Approval Code")]
    [IsoXmlTag("ApprvlCd")]
    [IsoSimpleType(IsoSimpleType.Exact6AlphaNumericText)]
    public IsoExact6AlphaNumericText? ApprovalCode { get; init; }

    /// <summary>
    /// Error detail information.
    /// </summary>
    [IsoId("_fZg7ESFYEey8XKHwKquEQw")]
    [DisplayName("Error Detail")]
    [IsoXmlTag("ErrDtl")]
    public ValueList<ErrorDetails2> ErrorDetail { get; init; } = [];

    /// <summary>
    /// Outcome of a previous processing, for example, in response to a duplicate request.
    /// </summary>
    [IsoId("_zHVERR1MEey8XKHwKquEQw")]
    [DisplayName("Original Result Data")]
    [IsoXmlTag("OrgnlRsltData")]
    public ResultData7? OriginalResultData { get; init; }

    /// <summary>
    /// Action required flag.
    /// Default: False: Action Not Required.
    /// True: Action Required.
    /// </summary>
    [IsoId("_zHVERx1MEey8XKHwKquEQw")]
    [DisplayName("Action Required")]
    [IsoXmlTag("ActnReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ActionRequired { get; init; }

    /// <summary>
    /// Set of actions to be performed.
    /// </summary>
    [IsoId("_zHVESR1MEey8XKHwKquEQw")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<Action13> Action { get; init; } = [];

    /// <summary>
    /// Additional action to perform.
    /// </summary>
    [IsoId("_zHVESx1MEey8XKHwKquEQw")]
    [DisplayName("Additional Action")]
    [IsoXmlTag("AddtlActn")]
    public ValueList<AdditionalAction1> AdditionalAction { get; init; } = [];

    /// <summary>
    /// Additional information relevant for the destination.
    /// ISO 8583 bit 44
    /// </summary>
    [IsoId("_zHVETR1MEey8XKHwKquEQw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation29> AdditionalInformation { get; init; } = [];
}
