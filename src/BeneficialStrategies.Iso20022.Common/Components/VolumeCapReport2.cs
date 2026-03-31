// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Double volume cap report.
/// </summary>
[IsoId("_7YvFaeJBEeWWKb0jFHxViQ")]
[DisplayName("Volume Cap Report")]
public record VolumeCapReport2
{
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and feedback messages.
    /// Usage:
    /// This identification will be used in the status advice report sent back.
    /// </summary>
    [IsoId("_7YvsdOJBEeWWKb0jFHxViQ")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_7YvsduJBEeWWKb0jFHxViQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier Identification { get; init; }

    /// <summary>
    /// Currency of the transaction.
    /// </summary>
    [IsoId("_7YvsdeJBEeWWKb0jFHxViQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveOrHistoricCurrencyCode Currency { get; init; }

    /// <summary>
    /// Total traded volume of the instrument in this specific reporting period.
    /// </summary>
    [IsoId("_7YvscuJBEeWWKb0jFHxViQ")]
    [DisplayName("Total Trading Volume")]
    [IsoXmlTag("TtlTradgVol")]
    public required ImpliedCurrencyAndAmount TotalTradingVolume { get; init; }

    /// <summary>
    /// Total volume of trading under reference price waiver as defined under the local regulation.
    /// </summary>
    [IsoId("_7Yvsd-JBEeWWKb0jFHxViQ")]
    [DisplayName("Total Reference Price Trading Volume")]
    [IsoXmlTag("TtlRefPricTradgVol")]
    public required ImpliedCurrencyAndAmount TotalReferencePriceTradingVolume { get; init; }

    /// <summary>
    /// Total volume of trading under negotiated transactions waiver as defined under the local regulation.
    /// </summary>
    [IsoId("_7YvsceJBEeWWKb0jFHxViQ")]
    [DisplayName("Total Negotiated Transactions Trading Volume")]
    [IsoXmlTag("TtlNgtdTxsTradgVol")]
    public required ImpliedCurrencyAndAmount TotalNegotiatedTransactionsTradingVolume { get; init; }
}
