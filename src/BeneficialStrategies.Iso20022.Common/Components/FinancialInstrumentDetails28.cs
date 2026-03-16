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
[IsoId("_v--6saOAEeeDTpy0mhI4TQ")]
[DisplayName("Financial Instrument Details")]
public record FinancialInstrumentDetails28
{
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_wNROUaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Information regarding the price of the instrument.
    /// </summary>
    [IsoId("_wNROVaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceInformation18? PriceDetails { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_wNROWaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace1? SafekeepingPlace { get; init; }

    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    [IsoId("_wNROXaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Opening Balance")]
    [IsoXmlTag("OpngBal")]
    public OpeningBalance3? OpeningBalance { get; init; }

    /// <summary>
    /// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
    /// </summary>
    [IsoId("_wNROYaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Closing Balance")]
    [IsoXmlTag("ClsgBal")]
    public ClosingBalance3? ClosingBalance { get; init; }

    /// <summary>
    /// Transaction details.
    /// </summary>
    [IsoId("_wNROZaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<Transaction62> Transaction { get; init; } = [];
    // ID for the above is _wNROZaOAEeeDTpy0mhI4TQ
}
