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
[IsoId("_XA2xrdp-Ed-ak6NoX_4Aeg_-661527747")]
[DisplayName("Underlying Security")]
public record UnderlyingSecurity2
{
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_XA2xrtp-Ed-ak6NoX_4Aeg_1382534833")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification12 SecurityIdentification { get; init; }
}
