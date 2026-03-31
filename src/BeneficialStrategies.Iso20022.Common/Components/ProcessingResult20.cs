// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the processing of the batch.
/// </summary>
[IsoId("_GTEtASFWEey8XKHwKquEQw")]
[DisplayName("Processing Result")]
public record ProcessingResult20
{
    /// <summary>
    /// Result information related to the processing of the transaction.
    /// </summary>
    [IsoId("_GYzhkSFWEey8XKHwKquEQw")]
    [DisplayName("Result Data")]
    [IsoXmlTag("RsltData")]
    public required ResultData8 ResultData { get; init; }

    /// <summary>
    /// Outcome of a previous processing, for example, in response to a duplicate request.
    /// </summary>
    [IsoId("_GYzhkyFWEey8XKHwKquEQw")]
    [DisplayName("Original Result Data")]
    [IsoXmlTag("OrgnlRsltData")]
    public ResultData7? OriginalResultData { get; init; }
}
