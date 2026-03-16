// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cardholder verification capabilities performing the transaction at the point of service.
/// ISO 8583:87 bit 22-3, ISO 8583;93 bit 22-2, ISO 8583:2003 bit 27-2
/// </summary>
[IsoId("_X8FtUcZSEeiCDcGzDHI_9Q")]
[DisplayName("Cardholder Verification Capabilities")]
public record CardholderVerificationCapabilities1
{
    /// <summary>
    /// Cardholder verification capabilities performing the transaction at the point of service.
    /// ISO 8583:93 bit 22-2, ISO 8583:2003-1 bit 27-2
    /// </summary>
    [IsoId("_YIpiocZSEeiCDcGzDHI_9Q")]
    [DisplayName("Capability")]
    [IsoXmlTag("Cpblty")]
    public required CardholderVerificationCapability5Code Capability { get; init; }

    /// <summary>
    /// Other types of cardholder verification capabilities.
    /// </summary>
    [IsoId("_YIpio8ZSEeiCDcGzDHI_9Q")]
    [DisplayName("Other Capability")]
    [IsoXmlTag("OthrCpblty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherCapability { get; init; }
}
