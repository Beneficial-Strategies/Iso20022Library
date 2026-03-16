// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Externally Defined Data5.
/// </summary>
[IsoId("_82uV0ZB9Ee6FLLjWp95ntQ")]
[DisplayName("Externally Defined Data5")]
public record ExternallyDefinedData5
{
    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax1025Text Identification { get; init; }

    /// <summary>
    /// Protected Value.
    /// </summary>
    [DisplayName("Protected Value")]
    [IsoXmlTag("PrtctdVal")]
    public ContentInformationType39? ProtectedValue { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public IsoMax1025Text? Type { get; init; }

    /// <summary>
    /// Value.
    /// </summary>
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public IsoMax100KBinary? Value { get; init; }
}
