// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction in the cancellation response.
/// </summary>
[IsoId("_TEDrvQEcEeCQm6a_G2yO_w_-370572216")]
[DisplayName("Card Payment Transaction Details")]
public record CardPaymentTransactionDetails6
{
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_TEDrvgEcEeCQm6a_G2yO_w_-2142367313")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required CurrencyCode Currency { get; init; }

    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_TEDrvwEcEeCQm6a_G2yO_w_-1174406910")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; }
}
