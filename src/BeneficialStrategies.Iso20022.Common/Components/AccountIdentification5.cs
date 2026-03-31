// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
/// </summary>
[IsoId("_nA01UvNBEeCuA5Tr22BnwA_-1479785847")]
[DisplayName("Account Identification")]
public record AccountIdentification5
{
    /// <summary>
    /// Unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_nA01U_NBEeCuA5Tr22BnwA_-1479785837")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Description of the account.
    /// </summary>
    [IsoId("_nA01VPNBEeCuA5Tr22BnwA_-1479785786")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }

    /// <summary>
    /// Specifies the type of account.
    /// </summary>
    [IsoId("_nA01VfNBEeCuA5Tr22BnwA_-1048499637")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public GenericIdentification30? Type { get; init; }
}
