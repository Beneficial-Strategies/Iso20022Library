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
[IsoId("_TyCFO9p-Ed-ak6NoX_4Aeg_-141135720")]
[DisplayName("Underlying Security")]
public record UnderlyingSecurity1
{
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_TyLPINp-Ed-ak6NoX_4Aeg_935687906")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification11 SecurityIdentification { get; init; }
}
