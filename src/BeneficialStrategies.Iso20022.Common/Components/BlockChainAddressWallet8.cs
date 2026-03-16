// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Digital account where digital assets or digital tokens can be stored and where an entry is made.
/// </summary>
[IsoId("_SRLpsUY1EeyIDL5Gtobnyw")]
[DisplayName("Block Chain Address Wallet")]
public record BlockChainAddressWallet8
{
    /// <summary>
    /// Unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_ShIKMUY1EeyIDL5Gtobnyw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoRestrictedFINXMax140Text Identification { get; init; }

    /// <summary>
    /// Specifies the type of securities account.
    /// </summary>
    [IsoId("_ShIKRUY1EeyIDL5Gtobnyw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public GenericIdentification47? Type { get; init; }

    /// <summary>
    /// Description of the account.
    /// </summary>
    [IsoId("_ShIKWUY1EeyIDL5Gtobnyw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoRestrictedFINXMax70Text? Name { get; init; }

    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to be reconciled individually.
    /// </summary>
    [IsoId("_ShIKYUY1EeyIDL5Gtobnyw")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? Designation { get; init; }
}
