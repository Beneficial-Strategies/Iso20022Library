// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report Header7.
/// </summary>
[IsoId("_1LHsITEyEe6g-ffJsqGiSA")]
[DisplayName("Report Header7")]
public record ReportHeader7
{
    /// <summary>
    /// Creation Date Time.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// From.
    /// </summary>
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    public required Party50Choice_ From { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// To.
    /// </summary>
    [DisplayName("To")]
    [IsoXmlTag("To")]
    public required Party50Choice_ To { get; init; }
}
