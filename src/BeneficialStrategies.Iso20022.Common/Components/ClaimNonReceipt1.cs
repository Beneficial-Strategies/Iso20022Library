// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies details of a claim non receipt status advice.
/// </summary>
[IsoId("_xyjo8IjYEeeDW7_wB-eK_g")]
[DisplayName("Claim Non Receipt")]
public record ClaimNonReceipt1
{
    /// <summary>
    /// Specifies the date the original payment instruction was processed.
    /// </summary>
    [IsoId("_hPoCUItuEee-OJ-wXSj3YQ")]
    [DisplayName("Date Processed")]
    [IsoXmlTag("DtPrcd")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate DateProcessed { get; init; }

    /// <summary>
    /// Specifies the next party the original payment instruction was sent to.
    /// </summary>
    [IsoId("_jfyHEItuEee-OJ-wXSj3YQ")]
    [DisplayName("Original Next Agent")]
    [IsoXmlTag("OrgnlNxtAgt")]
    public required BranchAndFinancialInstitutionIdentification5 OriginalNextAgent { get; init; }
}
