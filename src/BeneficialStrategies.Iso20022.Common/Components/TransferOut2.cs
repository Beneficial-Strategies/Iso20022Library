// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a transfer out transaction.
/// </summary>
[IsoId("_U07sptp-Ed-ak6NoX_4Aeg_1855595755")]
[DisplayName("Transfer Out")]
public record TransferOut2
{
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_U07sp9p-Ed-ak6NoX_4Aeg_1926708843")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public required Transfer1 TransferDetails { get; init; }

    /// <summary>
    /// Information related to the financial instrument to be withdrawn.
    /// </summary>
    [IsoId("_U07sqNp-Ed-ak6NoX_4Aeg_1802390690")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument3 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Information related to the account from which the financial instrument is to be withdrawn.
    /// </summary>
    [IsoId("_U1FdoNp-Ed-ak6NoX_4Aeg_-2021938121")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount10 AccountDetails { get; init; }

    /// <summary>
    /// Information related to the receiving side of the transfer.
    /// </summary>
    [IsoId("_U1Fdodp-Ed-ak6NoX_4Aeg_-2024711583")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public required ReceiveInformation1 SettlementDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_U1Fdotp-Ed-ak6NoX_4Aeg_300046229")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}
