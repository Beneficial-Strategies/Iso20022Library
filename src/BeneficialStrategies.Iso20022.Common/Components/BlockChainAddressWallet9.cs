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
[IsoId("_HdKMsUfFEey6Is2iMqV8fg")]
[DisplayName("Block Chain Address Wallet")]
public record BlockChainAddressWallet9
{
    /// <summary>
    /// Unambiguous identification for the account between the account owner and the account servicer.”.
    /// </summary>
    [IsoId("_HszLM0fFEey6Is2iMqV8fg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoRestrictedFINXMax140Text Identification { get; init; }

    /// <summary>
    /// Specifies the type of securities account.
    /// </summary>
    [IsoId("_HszLR0fFEey6Is2iMqV8fg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PurposeCode8Choice_? Type { get; init; }

    /// <summary>
    /// Description of the account.
    /// </summary>
    [IsoId("_HszLW0fFEey6Is2iMqV8fg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoRestrictedFINXMax70Text? Name { get; init; }
}
