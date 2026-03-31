// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides transaction identification information.
/// </summary>
[IsoId("_KhcXke6MEeqc-LCjwLsUVg")]
[DisplayName("Transaction Identification")]
public record TransactionIdentification15
{
    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [IsoId("_K1hxMe6MEeqc-LCjwLsUVg")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MarketInfrastructureTransactionIdentification { get; init; }
}
