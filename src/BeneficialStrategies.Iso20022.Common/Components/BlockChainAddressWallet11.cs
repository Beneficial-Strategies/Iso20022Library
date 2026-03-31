// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Block Chain Address Wallet11.
/// </summary>
[IsoId("_y6JfAaDcEe-CRv8HNM1RKw")]
[DisplayName("Block Chain Address Wallet11")]
public record BlockChainAddressWallet11
{
    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax140Text Identification { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public GenericIdentification47? Type { get; init; }
}
