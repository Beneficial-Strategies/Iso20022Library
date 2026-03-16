// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the confirmation of a transfer in transaction.
/// </summary>
[IsoId("_U0oxtdp-Ed-ak6NoX_4Aeg_-421696178")]
[DisplayName("Transfer In")]
public record TransferIn1
{
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_U0oxttp-Ed-ak6NoX_4Aeg_-663952944")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public required Transfer4 TransferDetails { get; init; }

    /// <summary>
    /// Information related to the financial instrument received.
    /// </summary>
    [IsoId("_U0oxt9p-Ed-ak6NoX_4Aeg_-1649338796")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument3 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Information related to the account into which the financial instrument was received.
    /// </summary>
    [IsoId("_U0oxuNp-Ed-ak6NoX_4Aeg_-647329399")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount10 AccountDetails { get; init; }

    /// <summary>
    /// Information related to the delivering side of the transfer.
    /// </summary>
    [IsoId("_U0oxudp-Ed-ak6NoX_4Aeg_-638095158")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public required DeliverInformation2 SettlementDetails { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_U0oxutp-Ed-ak6NoX_4Aeg_-1798379417")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}
