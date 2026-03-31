// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the cash compensation such as the fees and the total settlement amount.
/// </summary>
[IsoId("_UokEmtp-Ed-ak6NoX_4Aeg_-1006073827")]
[DisplayName("Cash Compensation")]
public record CashCompensation1
{
    /// <summary>
    /// Provides the original amount to be settled.
    /// </summary>
    [IsoId("_UokEm9p-Ed-ak6NoX_4Aeg_1436012936")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required AmountAndDirection20 SettlementAmount { get; init; }

    /// <summary>
    /// Amount of fees linked to the cash compensation process.
    /// </summary>
    [IsoId("_UokEnNp-Ed-ak6NoX_4Aeg_796992332")]
    [DisplayName("Fees")]
    [IsoXmlTag("Fees")]
    public AmountAndDirection20? Fees { get; init; }

    /// <summary>
    /// Indicates the value date of the cash compensation.
    /// </summary>
    [IsoId("_Uot1kNp-Ed-ak6NoX_4Aeg_1587929881")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; }
}
