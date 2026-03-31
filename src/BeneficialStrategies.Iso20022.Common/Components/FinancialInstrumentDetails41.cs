// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reporting per financial instrument.
/// </summary>
[IsoId("_9ZziUSgQEeym1_Zp1BTvEw")]
[DisplayName("Financial Instrument Details")]
public record FinancialInstrumentDetails41
{
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_9vjv4SgQEeym1_Zp1BTvEw")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising an investment funds financial instrument.
    /// </summary>
    [IsoId("_9vjv5SgQEeym1_Zp1BTvEw")]
    [DisplayName("Investment Funds Financial Instrument Attributes")]
    [IsoXmlTag("InvstmtFndsFinInstrmAttrbts")]
    public FinancialInstrument72? InvestmentFundsFinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Information regarding the price of the instrument.
    /// </summary>
    [IsoId("_9vjv5ygQEeym1_Zp1BTvEw")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceInformation21? PriceDetails { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_9vjv6ygQEeym1_Zp1BTvEw")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace3? SafekeepingPlace { get; init; }

    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    [IsoId("_9vjv7ygQEeym1_Zp1BTvEw")]
    [DisplayName("Opening Balance")]
    [IsoXmlTag("OpngBal")]
    public OpeningBalance5? OpeningBalance { get; init; }

    /// <summary>
    /// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
    /// </summary>
    [IsoId("_9vjv8ygQEeym1_Zp1BTvEw")]
    [DisplayName("Closing Balance")]
    [IsoXmlTag("ClsgBal")]
    public ClosingBalance5? ClosingBalance { get; init; }

    /// <summary>
    /// Transaction details.
    /// </summary>
    [IsoId("_9vjv9ygQEeym1_Zp1BTvEw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<Transaction123> Transaction { get; init; } = [];
    // ID for the above is _9vjv9ygQEeym1_Zp1BTvEw
}
