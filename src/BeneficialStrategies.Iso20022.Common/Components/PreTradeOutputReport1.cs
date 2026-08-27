// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// New pre-trade output related data report.
/// </summary>
[IsoId("_pBEHIGIVEfCeoPFCHQnhvA")]
[DisplayName("Pre Trade Output Report1")]
public record PreTradeOutputReport1
{
    /// <summary>
    /// Identification of the report.
    /// </summary>
    [IsoId("_4MkA8GIVEfCeoPFCHQnhvA")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public IsoMax140Text? ReportIdentification { get; init; }

    /// <summary>
    /// Information related to the pre-trade transparency data of financial instruments.
    /// </summary>
    [IsoId("_A2ymIGIWEfCeoPFCHQnhvA")]
    [DisplayName("Pre Trade Data")]
    [IsoXmlTag("PreTradData")]
    [MinLength(1)]
    public ValueList<PreTradeOutputData1> PreTradeData { get; init; } = [];
}
