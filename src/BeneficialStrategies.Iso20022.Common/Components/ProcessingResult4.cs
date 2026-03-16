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
[IsoId("_q5sCQZizEeefZKJHxQTztg")]
[DisplayName("Processing Result")]
public record ProcessingResult4
{
    /// <summary>
    /// Result of the processing.
    /// </summary>
    [IsoId("_rG9pQ5izEeefZKJHxQTztg")]
    [DisplayName("Result Data")]
    [IsoXmlTag("RsltData")]
    public ResultData5? ResultData { get; init; }

    /// <summary>
    /// Outcome of a previous processing, for example, in response to a duplicate request.
    /// </summary>
    [IsoId("_6cKZkRs2EeqrvK3udMUsNQ")]
    [DisplayName("Original Result Data")]
    [IsoXmlTag("OrgnlRsltData")]
    public ResultData1? OriginalResultData { get; init; }

    /// <summary>
    /// Additional information relevant for the destination.
    /// ISO 8583 bit 44
    /// </summary>
    [IsoId("_rG9pSZizEeefZKJHxQTztg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation22> AdditionalInformation { get; init; } = [];
}
