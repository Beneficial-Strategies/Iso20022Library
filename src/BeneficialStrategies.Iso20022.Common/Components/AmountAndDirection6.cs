// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
[IsoId("_SV76pdp-Ed-ak6NoX_4Aeg_-1438259650")]
[DisplayName("Amount And Direction")]
public record AmountAndDirection6
{
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_SV76ptp-Ed-ak6NoX_4Aeg_-1438258832")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates that the amount value is positive or negative.
    /// </summary>
    [IsoId("_SV76p9p-Ed-ak6NoX_4Aeg_-1437336265")]
    [DisplayName("Sign")]
    [IsoXmlTag("Sgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public required IsoPlusOrMinusIndicator Sign { get; init; }
}
