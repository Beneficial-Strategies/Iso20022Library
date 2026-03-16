// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the identification of a billing subservice.
/// </summary>
[IsoId("_6Oww65qlEeGSON8vddiWzQ_-1562075356")]
[DisplayName("Billing Sub Service Identification")]
public record BillingSubServiceIdentification1
{
    /// <summary>
    /// Specifies the qualifier of the sub service.
    /// </summary>
    [IsoId("_6Oww7JqlEeGSON8vddiWzQ_-1383956684")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public required BillingSubServiceQualifier1Choice_ Issuer { get; init; }

    /// <summary>
    /// Further defines a financial institution service, through the provision of the value required by the sub service qualifier, such as the actual lockbox number or store number.
    /// </summary>
    [IsoId("_6Oww7ZqlEeGSON8vddiWzQ_83192079")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }
}
