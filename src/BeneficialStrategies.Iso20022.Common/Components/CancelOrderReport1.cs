// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancel Order Report1.
/// </summary>
[IsoId("_8nSgMGsYEe25qph5Y8_eYQ")]
[DisplayName("Cancel Order Report1")]
public record CancelOrderReport1
{
    /// <summary>
    /// Report Identification.
    /// </summary>
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public required IsoMax140Text ReportIdentification { get; init; }
}
