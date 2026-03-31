// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Securitised right for entitlement, for example, equity or bond.
/// </summary>
[IsoId("_-p04AeaUEd-q8fx_Zl_34A")]
[DisplayName("Underlying Security")]
public record UnderlyingSecurity3
{
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_-p04A-aUEd-q8fx_Zl_34A")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification14 SecurityIdentification { get; init; }
}
