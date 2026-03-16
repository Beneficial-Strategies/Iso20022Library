// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted personal identification number (PIN) and related information.
/// </summary>
[IsoId("_--rKsS_tEeO4w-IWHJMI9g")]
[DisplayName("On Line PIN")]
public record OnLinePIN3
{
    /// <summary>
    /// Encrypted PIN (Personal Identification Number).
    /// </summary>
    [IsoId("__NZjMS_tEeO4w-IWHJMI9g")]
    [DisplayName("Encrypted PIN Block")]
    [IsoXmlTag("NcrptdPINBlck")]
    public required ContentInformationType7 EncryptedPINBlock { get; init; }

    /// <summary>
    /// PIN (Personal Identification Number) format before encryption.
    /// </summary>
    [IsoId("__NZjMy_tEeO4w-IWHJMI9g")]
    [DisplayName("PIN Format")]
    [IsoXmlTag("PINFrmt")]
    public required PINFormat3Code PINFormat { get; init; }

    /// <summary>
    /// Additional information required to verify the PIN (Personal Identification Number.
    /// </summary>
    [IsoId("__NZjNS_tEeO4w-IWHJMI9g")]
    [DisplayName("Additional Input")]
    [IsoXmlTag("AddtlInpt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalInput { get; init; }
}
