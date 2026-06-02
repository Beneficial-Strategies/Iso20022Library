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
[IsoId("_oSwlQZaPEfC2_67yGLymgA")]
[DisplayName("Financial Instrument Details49")]
public record FinancialInstrumentDetails49
{
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_oVV_MZaPEfC2_67yGLymgA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising an investment funds financial instrument.
    /// </summary>
    [IsoId("_oVV_NZaPEfC2_67yGLymgA")]
    [DisplayName("Investment Funds Financial Instrument Attributes")]
    [IsoXmlTag("InvstmtFndsFinInstrmAttrbts")]
    public FinancialInstrument72? InvestmentFundsFinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Information regarding the price of the instrument.
    /// </summary>
    [IsoId("_oVV_N5aPEfC2_67yGLymgA")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceInformation30? PriceDetails { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally.
    /// </summary>
    [IsoId("_oVV_O5aPEfC2_67yGLymgA")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace5? SafekeepingPlace { get; init; }

    /// <summary>
    /// Opening balance for the statement period.
    /// </summary>
    [IsoId("_oVV_P5aPEfC2_67yGLymgA")]
    [DisplayName("Opening Balance")]
    [IsoXmlTag("OpngBal")]
    public OpeningBalance5? OpeningBalance { get; init; }

    /// <summary>
    /// Closing balance for the statement period.
    /// </summary>
    [IsoId("_oVV_Q5aPEfC2_67yGLymgA")]
    [DisplayName("Closing Balance")]
    [IsoXmlTag("ClsgBal")]
    public ClosingBalance5? ClosingBalance { get; init; }

    /// <summary>
    /// Transaction details.
    /// </summary>
    [IsoId("_oVV_R5aPEfC2_67yGLymgA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    [MinLength(1)]
    public ValueList<Transaction167> Transaction { get; init; } = [];
}
