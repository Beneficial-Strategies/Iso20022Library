// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amounts linked to a securities balance, for example, holding value.
/// </summary>
[IsoId("_WQRpSNp-Ed-ak6NoX_4Aeg_-87925160")]
[DisplayName("Balance Amounts")]
public record BalanceAmounts6
{
    /// <summary>
    /// Value of an individual financial instrument holding within a safekeeping account.
    /// </summary>
    [IsoId("_WQbaQNp-Ed-ak6NoX_4Aeg_1920939692")]
    [DisplayName("Holding Value")]
    [IsoXmlTag("HldgVal")]
    public required AmountAndDirection14 HoldingValue { get; init; }

    /// <summary>
    /// Value of a financial instrument, as booked/acquired in an account. It may be used to establish capital gain tax liability.
    /// </summary>
    [IsoId("_WQbaQdp-Ed-ak6NoX_4Aeg_-1396676687")]
    [DisplayName("Book Value")]
    [IsoXmlTag("BookVal")]
    public AmountAndDirection14? BookValue { get; init; }

    /// <summary>
    /// Difference between holding value and the book value.
    /// </summary>
    [IsoId("_WQbaQtp-Ed-ak6NoX_4Aeg_20912616")]
    [DisplayName("Unrealised Gain Loss")]
    [IsoXmlTag("UrlsdGnLoss")]
    public AmountAndDirection14? UnrealisedGainLoss { get; init; }
}
