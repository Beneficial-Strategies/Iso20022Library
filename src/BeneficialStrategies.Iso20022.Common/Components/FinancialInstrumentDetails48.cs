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
[IsoId("42aca925-68dd-4039-af05-d5ba64d4712a")]
[DisplayName("Financial Instrument Details48")]
public record FinancialInstrumentDetails48
{
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("f21c6bad-b974-4bee-8251-b684af90abf8")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising an investment funds financial instrument.
    /// </summary>
    [IsoId("5e5db598-c2a3-476a-bdeb-f4f54fbe9f49")]
    [DisplayName("Investment Funds Financial Instrument Attributes")]
    [IsoXmlTag("InvstmtFndsFinInstrmAttrbts")]
    public FinancialInstrument72? InvestmentFundsFinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Information regarding the price of the instrument.
    /// </summary>
    [IsoId("e7c5b4a8-47b2-4777-b92d-b4b608d330a1")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceInformation30? PriceDetails { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally.
    /// </summary>
    [IsoId("a5ada642-c553-464d-b63d-e058036fde88")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace5? SafekeepingPlace { get; init; }

    /// <summary>
    /// Opening balance for the statement period.
    /// </summary>
    [IsoId("f0817288-205c-4385-a030-a94efb9eb4a8")]
    [DisplayName("Opening Balance")]
    [IsoXmlTag("OpngBal")]
    public OpeningBalance5? OpeningBalance { get; init; }

    /// <summary>
    /// Closing balance for the statement period.
    /// </summary>
    [IsoId("87291b67-0875-4d06-880e-6337db31057d")]
    [DisplayName("Closing Balance")]
    [IsoXmlTag("ClsgBal")]
    public ClosingBalance5? ClosingBalance { get; init; }

    /// <summary>
    /// Transaction details.
    /// </summary>
    [IsoId("5fb5174f-ed17-4511-9c57-b0a47fb15051")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    [MinLength(1)]
    public ValueList<Transaction165> Transaction { get; init; } = [];
}
