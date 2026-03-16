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
[IsoId("_9KVakSqPEeyR9JrVGfaMKw")]
[DisplayName("Block Chain Address Wallet")]
public record BlockChainAddressWallet5
{
    /// <summary>
    /// Unique identification of the collateral account.
    /// </summary>
    [IsoId("_9hum4SqPEeyR9JrVGfaMKw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Identification { get; init; }

    /// <summary>
    /// Indicates the type of collateral account.
    /// </summary>
    [IsoId("_9hum4yqPEeyR9JrVGfaMKw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CollateralAccountIdentificationType3Choice_? Type { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_9hum5SqPEeyR9JrVGfaMKw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }
}
