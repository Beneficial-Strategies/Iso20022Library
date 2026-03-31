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
[IsoId("_gdOLY833Eee5nJBZsW8MFQ")]
[DisplayName("Financial Instrument Details")]
public record FinancialInstrumentDetails31
{
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_gdOLZc33Eee5nJBZsW8MFQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Information regarding the price of the instrument.
    /// </summary>
    [IsoId("_gdOLac33Eee5nJBZsW8MFQ")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceInformation19? PriceDetails { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_gdOLbc33Eee5nJBZsW8MFQ")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace2? SafekeepingPlace { get; init; }

    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    [IsoId("_gdOLcc33Eee5nJBZsW8MFQ")]
    [DisplayName("Opening Balance")]
    [IsoXmlTag("OpngBal")]
    public OpeningBalance4? OpeningBalance { get; init; }

    /// <summary>
    /// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
    /// </summary>
    [IsoId("_gdOLdc33Eee5nJBZsW8MFQ")]
    [DisplayName("Closing Balance")]
    [IsoXmlTag("ClsgBal")]
    public ClosingBalance4? ClosingBalance { get; init; }

    /// <summary>
    /// Transaction details.
    /// </summary>
    [IsoId("_gdOLec33Eee5nJBZsW8MFQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<Transaction65> Transaction { get; init; } = [];
    // ID for the above is _gdOLec33Eee5nJBZsW8MFQ
}
