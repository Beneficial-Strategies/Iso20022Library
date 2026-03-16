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
[IsoId("_5KWOYSp4EeyR9JrVGfaMKw")]
[DisplayName("Block Chain Address Wallet")]
public record BlockChainAddressWallet2
{
    /// <summary>
    /// Unambiguous identification for the account between the account owner and the account servicer.”.
    /// </summary>
    [IsoId("_5h5Lsyp4EeyR9JrVGfaMKw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Identification { get; init; }

    /// <summary>
    /// Specifies the type of securities account.
    /// </summary>
    [IsoId("_5h5Lxyp4EeyR9JrVGfaMKw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PurposeCode7Choice_? Type { get; init; }

    /// <summary>
    /// Description of the account.
    /// </summary>
    [IsoId("_5h5L2yp4EeyR9JrVGfaMKw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }
}
