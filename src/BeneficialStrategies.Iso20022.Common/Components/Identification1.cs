// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identifier of a document, message or transaction.
/// </summary>
[IsoId("_QtVlKtp-Ed-ak6NoX_4Aeg_-28410593")]
[DisplayName("Identification")]
public record Identification1
{
    /// <summary>
    /// Unique identifier of a document, message or transaction.
    /// </summary>
    [IsoId("_QtevENp-Ed-ak6NoX_4Aeg_270812202")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }
}
