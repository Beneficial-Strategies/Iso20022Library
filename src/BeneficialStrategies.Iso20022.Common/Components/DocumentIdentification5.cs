// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a document by a unique identification and its issuer.
/// </summary>
[IsoId("_RJWLsdp-Ed-ak6NoX_4Aeg_-86119846")]
[DisplayName("Document Identification")]
public record DocumentIdentification5
{
    /// <summary>
    /// Identification of a set of data.
    /// </summary>
    [IsoId("_RJWLstp-Ed-ak6NoX_4Aeg_109665302")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Uniquely identifies the financial institution which has issued the identification of the set of data by using a BIC.
    /// </summary>
    [IsoId("_RJWLs9p-Ed-ak6NoX_4Aeg_601412896")]
    [DisplayName("Identification Issuer")]
    [IsoXmlTag("IdIssr")]
    public required BICIdentification1 IdentificationIssuer { get; init; }
}
