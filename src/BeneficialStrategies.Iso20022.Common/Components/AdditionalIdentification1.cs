// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains additional identification details of additional card acceptor data.
/// </summary>
[IsoId("_0eiKZPJVEeiJn9rM2Znz2w")]
[DisplayName("Additional Identification")]
public record AdditionalIdentification1
{
    /// <summary>
    /// Type of additional identification.
    /// </summary>
    [IsoId("_0eiKZvJVEeiJn9rM2Znz2w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required AdditionalIdentificationType1Code Type { get; init; }

    /// <summary>
    /// Other Additional Identification applied to the transaction.
    /// </summary>
    [IsoId("_0eiKZfJVEeiJn9rM2Znz2w")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Additional identification value.
    /// </summary>
    [IsoId("_0eiKZ_JVEeiJn9rM2Znz2w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Value { get; init; }
}
