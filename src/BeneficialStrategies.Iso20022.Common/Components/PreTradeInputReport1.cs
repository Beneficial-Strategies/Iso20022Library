// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// New pre-trade input related data report.
/// </summary>
[IsoId("_fOqVAGF9EfC07JR6e2JJ-w")]
[DisplayName("Pre Trade Input Report1")]
public record PreTradeInputReport1
{
    /// <summary>
    /// Identification of the report.
    /// </summary>
    [IsoId("_qmOqMGF9EfC07JR6e2JJ-w")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public IsoMax140Text? ReportIdentification { get; init; }

    /// <summary>
    /// Information related to the pre-trade transparency data of financial instruments.
    /// </summary>
    [IsoId("_vLhaUGF9EfC07JR6e2JJ-w")]
    [DisplayName("Pre Trade Input")]
    [IsoXmlTag("PreTradInpt")]
    [MinLength(1)]
    public ValueList<PreTradeInputData1> PreTradeInput { get; init; } = [];
}
