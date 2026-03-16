// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// New Order Report2.
/// </summary>
[IsoId("_q72RsRA2Ee6N57R8Wekj-w")]
[DisplayName("New Order Report2")]
public record NewOrderReport2
{
    /// <summary>
    /// Order.
    /// </summary>
    [DisplayName("Order")]
    [IsoXmlTag("Ordr")]
    public ValueList<OrderData3> Order { get; init; } = [];

    /// <summary>
    /// Report Identification.
    /// </summary>
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public required IsoMax140Text ReportIdentification { get; init; }
}
