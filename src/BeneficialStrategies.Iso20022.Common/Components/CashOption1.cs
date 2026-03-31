// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash option.
/// </summary>
[IsoId("_UDBHg9p-Ed-ak6NoX_4Aeg_330926980")]
[DisplayName("Cash Option")]
public record CashOption1
{
    /// <summary>
    /// Indicates wether it is a debit or a credit.
    /// </summary>
    [IsoId("_UDBHhNp-Ed-ak6NoX_4Aeg_394650564")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Currency of the option.
    /// </summary>
    [IsoId("_UDBHhdp-Ed-ak6NoX_4Aeg_1392508065")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    [IsoId("_UDBHhtp-Ed-ak6NoX_4Aeg_-1232523878")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate5? DateDetails { get; init; }

    /// <summary>
    /// Provides information about the amounts related to a cash movement.
    /// </summary>
    [IsoId("_UDBHh9p-Ed-ak6NoX_4Aeg_-2008462728")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public CorporateActionAmounts1? AmountDetails { get; init; }

    /// <summary>
    /// Provides information about a foreign exchange.
    /// </summary>
    [IsoId("_UDBHiNp-Ed-ak6NoX_4Aeg_-180294912")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public ForeignExchangeTerms8? ExchangeRate { get; init; }
}
