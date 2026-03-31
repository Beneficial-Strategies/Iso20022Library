// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// FX Supplementary Data2.
/// </summary>
[IsoId("_-VpvAOKDEe2QzKqbsy1xHQ")]
[DisplayName("FX Supplementary Data2")]
public record FXSupplementaryData2
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountType4Choice_ Amount { get; init; }

    /// <summary>
    /// Debtor Account.
    /// </summary>
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount38 DebtorAccount { get; init; }

    /// <summary>
    /// Exchange Rate Information.
    /// </summary>
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    public ExchangeRateInformation4? ExchangeRateInformation { get; init; }
}
