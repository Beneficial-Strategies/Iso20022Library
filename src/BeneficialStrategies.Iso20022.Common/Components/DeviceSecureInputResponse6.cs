// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Device Secure Input Response6.
/// </summary>
[IsoId("_OBFKMZCYEe6zroekBXoFoQ")]
[DisplayName("Device Secure Input Response6")]
public record DeviceSecureInputResponse6
{
    /// <summary>
    /// Cardholder PIN.
    /// </summary>
    [DisplayName("Cardholder PIN")]
    [IsoXmlTag("CrdhldrPIN")]
    public OnLinePIN11? CardholderPIN { get; init; }
}
