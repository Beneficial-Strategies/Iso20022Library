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
[IsoId("_dToRhemrEemUgrefIx730g")]
[DisplayName("Financial Instrument Details")]
public record FinancialInstrumentDetails35
{
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_d9bcQemrEemUgrefIx730g")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising an investment funds financial instrument.
    /// </summary>
    [IsoId("_d9bcRemrEemUgrefIx730g")]
    [DisplayName("Investment Funds Financial Instrument Attributes")]
    [IsoXmlTag("InvstmtFndsFinInstrmAttrbts")]
    public FinancialInstrument72? InvestmentFundsFinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Information regarding the price of the instrument.
    /// </summary>
    [IsoId("_d9bcR-mrEemUgrefIx730g")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceInformation21? PriceDetails { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_d9bcS-mrEemUgrefIx730g")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace3? SafekeepingPlace { get; init; }

    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    [IsoId("_d9bcT-mrEemUgrefIx730g")]
    [DisplayName("Opening Balance")]
    [IsoXmlTag("OpngBal")]
    public OpeningBalance3? OpeningBalance { get; init; }

    /// <summary>
    /// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
    /// </summary>
    [IsoId("_d9bcU-mrEemUgrefIx730g")]
    [DisplayName("Closing Balance")]
    [IsoXmlTag("ClsgBal")]
    public ClosingBalance3? ClosingBalance { get; init; }

    /// <summary>
    /// Transaction details.
    /// </summary>
    [IsoId("_d9bcV-mrEemUgrefIx730g")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<Transaction110> Transaction { get; init; } = [];
    // ID for the above is _d9bcV-mrEemUgrefIx730g
}
