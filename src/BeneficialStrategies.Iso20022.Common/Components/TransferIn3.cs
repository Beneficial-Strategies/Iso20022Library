// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a transfer in transaction.
/// </summary>
[IsoId("_RNhhENp-Ed-ak6NoX_4Aeg_-1300755125")]
[DisplayName("Transfer In")]
public record TransferIn3
{
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_RNhhEdp-Ed-ak6NoX_4Aeg_-1300755106")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public required Transfer6 TransferDetails { get; init; }

    /// <summary>
    /// Information related to the financial instrument to be received.
    /// </summary>
    [IsoId("_RNhhEtp-Ed-ak6NoX_4Aeg_-1300755012")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument13 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Information related to the account into which the financial instrument is to be received.
    /// </summary>
    [IsoId("_RNhhE9p-Ed-ak6NoX_4Aeg_932233695")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount22 AccountDetails { get; init; }

    /// <summary>
    /// Information related to the delivering side of the transfer.
    /// </summary>
    [IsoId("_RNhhFNp-Ed-ak6NoX_4Aeg_-1300755064")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public required DeliverInformation3 SettlementDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RNhhFdp-Ed-ak6NoX_4Aeg_-1299834998")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}
