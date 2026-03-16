// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response to a secure input request.
/// </summary>
[IsoId("_-4VD4XGpEe2TbaNWBpRZpQ")]
[DisplayName("Device Secure Input Response")]
public record DeviceSecureInputResponse5
{
    /// <summary>
    /// Cardholder PIN data when needed.
    /// </summary>
    [IsoId("_--4X0XGpEe2TbaNWBpRZpQ")]
    [DisplayName("Cardholder PIN")]
    [IsoXmlTag("CrdhldrPIN")]
    public OnLinePIN10? CardholderPIN { get; init; }
}
