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
[IsoId("_EhbFNW4-EeiU9cctagi5ow")]
[DisplayName("Claim Non Receipt")]
public record ClaimNonReceipt2
{
    /// <summary>
    /// Specifies the date the original payment instruction was processed.
    /// </summary>
    [IsoId("_EtCfUW4-EeiU9cctagi5ow")]
    [DisplayName("Date Processed")]
    [IsoXmlTag("DtPrcd")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate DateProcessed { get; init; }

    /// <summary>
    /// Specifies the next party the original payment instruction was sent to.
    /// </summary>
    [IsoId("_EtCfU24-EeiU9cctagi5ow")]
    [DisplayName("Original Next Agent")]
    [IsoXmlTag("OrgnlNxtAgt")]
    public BranchAndFinancialInstitutionIdentification6? OriginalNextAgent { get; init; }
}
