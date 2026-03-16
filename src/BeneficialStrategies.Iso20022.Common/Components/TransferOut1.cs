// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the confirmation of a transfer out transaction.
/// </summary>
[IsoId("_U07soNp-Ed-ak6NoX_4Aeg_1214453177")]
[DisplayName("Transfer Out")]
public record TransferOut1
{
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_U07sodp-Ed-ak6NoX_4Aeg_1410805507")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public required Transfer2 TransferDetails { get; init; }

    /// <summary>
    /// Information related to the financial instrument withdrawn.
    /// </summary>
    [IsoId("_U07sotp-Ed-ak6NoX_4Aeg_1380342850")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument3 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Information related to the account from which the financial instrument was withdrawn.
    /// </summary>
    [IsoId("_U07so9p-Ed-ak6NoX_4Aeg_1429277182")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount10 AccountDetails { get; init; }

    /// <summary>
    /// Information related to the receiving side of the transfer.
    /// </summary>
    [IsoId("_U07spNp-Ed-ak6NoX_4Aeg_1416348018")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public required ReceiveInformation2 SettlementDetails { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_U07spdp-Ed-ak6NoX_4Aeg_-779468033")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}
