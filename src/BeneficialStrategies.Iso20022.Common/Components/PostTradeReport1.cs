// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// New post-trade related data report.
/// </summary>
[IsoId("_0jlHEGIgEfCeoPFCHQnhvA")]
[DisplayName("Post Trade Report1")]
public record PostTradeReport1
{
    /// <summary>
    /// Identification of the report.
    /// </summary>
    [IsoId("_DPUiwGIhEfCeoPFCHQnhvA")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public IsoMax140Text? ReportIdentification { get; init; }

    /// <summary>
    /// Information related to the post-trade transparency data for equity and bond instruments.
    /// </summary>
    [IsoId("_G_yjsGIhEfCeoPFCHQnhvA")]
    [DisplayName("Post Trade")]
    [IsoXmlTag("PstTrad")]
    [MinLength(1)]
    public ValueList<PostTradeData1> PostTrade { get; init; } = [];
}
