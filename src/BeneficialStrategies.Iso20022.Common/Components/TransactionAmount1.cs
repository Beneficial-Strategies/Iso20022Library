// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Actual amount of the transaction.
/// </summary>
[IsoId("_SfRJwEUMEeea-M6VZkEPUw")]
[DisplayName("Transaction Amount")]
public record TransactionAmount1
{
    /// <summary>
    /// Amount of the transaction expressed in the currency of the terminal or as a reversed amount of a previous authorisation.
    /// ISO 8583 bit 4.
    /// </summary>
    [IsoId("_oIKk0EUMEeea-M6VZkEPUw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Currency code associated with the transaction amount.  ISO 4217 &quot;Codes for the representation of currencies and funds&quot;
    /// ISO 8583:87/93 bit 49
    /// ISO 8583:2003 bit 4
    /// </summary>
    [IsoId("_vWLqsEUMEeea-M6VZkEPUw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ISO3NumericCurrencyCode Currency { get; init; }
}
