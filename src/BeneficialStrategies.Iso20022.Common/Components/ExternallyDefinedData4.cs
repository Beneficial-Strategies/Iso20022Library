// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data container to exchange data elements defined by another standard.
/// </summary>
[IsoId("_kUooAXDTEe2MCaKO5AtGsA")]
[DisplayName("Externally Defined Data")]
public record ExternallyDefinedData4
{
    /// <summary>
    /// Identification of the set of data to exchange.
    /// </summary>
    [IsoId("_kcHwEXDTEe2MCaKO5AtGsA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public required IsoMax1025Text Identification { get; init; }

    /// <summary>
    /// Data to exchange according to an external standard.
    /// </summary>
    [IsoId("_kcHwE3DTEe2MCaKO5AtGsA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? Value { get; init; }

    /// <summary>
    /// Protection of the values to exchange.
    /// </summary>
    [IsoId("_kcHwFXDTEe2MCaKO5AtGsA")]
    [DisplayName("Protected Value")]
    [IsoXmlTag("PrtctdVal")]
    public ContentInformationType34? ProtectedValue { get; init; }

    /// <summary>
    /// Identification of the standard used to encode the values to exchange.
    /// </summary>
    [IsoId("_kcHwF3DTEe2MCaKO5AtGsA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? Type { get; init; }
}
