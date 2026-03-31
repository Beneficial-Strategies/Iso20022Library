// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Container for tenders used by the customer to perform the payment transaction.
/// </summary>
[IsoId("_kmWJIEanEeeIjf8aP9KbJA")]
[DisplayName("Wallet")]
public record Wallet1
{
    /// <summary>
    /// Identification of the provider of the wallet.
    /// </summary>
    [IsoId("_LWrmQEaoEeeIjf8aP9KbJA")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    public PartyIdentification197? Provider { get; init; }

    /// <summary>
    /// Additional data associated with wallet.
    /// </summary>
    [IsoId("_Xa5YkBWJEeiTbY4xN42WAw")]
    [DisplayName("Additional Wallet Data")]
    [IsoXmlTag("AddtlWlltData")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? AdditionalWalletData { get; init; }
}
