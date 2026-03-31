// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the dispute
/// </summary>
[IsoId("_a9s9oOCnEee9RadpHmUgYw")]
[DisplayName("Dispute Identification")]
public record DisputeIdentification1
{
    /// <summary>
    /// Type of dispute.
    /// </summary>
    [IsoId("_jRRWUOCnEee9RadpHmUgYw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; }

    /// <summary>
    /// Identification of dispute.
    /// </summary>
    [IsoId("_nbkzkOCnEee9RadpHmUgYw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text Identification { get; init; }
}
