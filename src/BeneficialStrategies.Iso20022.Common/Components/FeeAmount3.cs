// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount, currency, exchange rate and quotation date, sign and label.
/// </summary>
[IsoId("_pFtW8ZF2EeukDPgU2BMkjQ")]
[DisplayName("Fee Amount")]
public record FeeAmount3
{
    /// <summary>
    /// Amount exclusive of currency.
    /// </summary>
    [IsoId("_pMXYkZF2EeukDPgU2BMkjQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Contains code list for a credit or debit transaction
    /// </summary>
    [IsoId("_436O8JF3EeukDPgU2BMkjQ")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }

    /// <summary>
    /// Currency for the type of amount.
    /// </summary>
    [IsoId("_pMXYk5F2EeukDPgU2BMkjQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Exchange rate of the currency code associated with the amount.
    /// </summary>
    [IsoId("_pMXYlZF2EeukDPgU2BMkjQ")]
    [DisplayName("Effective Exchange Rate")]
    [IsoXmlTag("FctvXchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOne25Rate)]
    public IsoBaseOne25Rate? EffectiveExchangeRate { get; init; }

    /// <summary>
    /// Date at which the exchange rate effective.
    /// </summary>
    [IsoId("_pMXYl5F2EeukDPgU2BMkjQ")]
    [DisplayName("Conversion Date")]
    [IsoXmlTag("ConvsDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ConversionDate { get; init; }

    /// <summary>
    /// Time at which the exchange rate effective.
    /// </summary>
    [IsoId("_65GgEJF2EeukDPgU2BMkjQ")]
    [DisplayName("Conversion Time")]
    [IsoXmlTag("ConvsTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? ConversionTime { get; init; }
}
