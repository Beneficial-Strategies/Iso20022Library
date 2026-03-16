// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Proprietary or domestic identification scheme that uniquely identifies a security.
/// </summary>
[IsoId("_Ae2moSGPEeW7gKYhAMEFCw")]
[DisplayName("Alternate Security Identification")]
public record AlternateSecurityIdentification7
{
    /// <summary>
    /// Unique and unambiguous identifier of a security.
    /// </summary>
    [IsoId("_A7IS8yGPEeW7gKYhAMEFCw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Source of the identification, that is, domestic (national) or proprietary.
    /// </summary>
    [IsoId("_UwbpcCGPEeW7gKYhAMEFCw")]
    [DisplayName("Identification Source")]
    [IsoXmlTag("IdSrc")]
    public required IdentificationSource1Choice_ IdentificationSource { get; init; }
}
