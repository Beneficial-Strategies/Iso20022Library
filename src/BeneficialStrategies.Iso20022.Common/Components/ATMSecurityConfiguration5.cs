// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration of the PIN online verification.
/// </summary>
[IsoId("_Xf8qAYr9EeSvuOJS0mmL0g")]
[DisplayName("ATM Security Configuration")]
public record ATMSecurityConfiguration5
{
    /// <summary>
    /// PIN block format the security module is able to manage for online verification of the PIN.
    /// </summary>
    [IsoId("_lihz8Ir9EeSvuOJS0mmL0g")]
    [DisplayName("PIN Format")]
    [IsoXmlTag("PINFrmt")]
    public SimpleValueList<PINFormat4Code> PINFormat { get; init; } = [];

    /// <summary>
    /// Maximum number of digits the security module is able to accept when the cardholder enters its PIN.
    /// </summary>
    [IsoId("_5hgD0Ir9EeSvuOJS0mmL0g")]
    [DisplayName("PIN Length Capabilities")]
    [IsoXmlTag("PINLngthCpblties")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PINLengthCapabilities { get; init; }
}
