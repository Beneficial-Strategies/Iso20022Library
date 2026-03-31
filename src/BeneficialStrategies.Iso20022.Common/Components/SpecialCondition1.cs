// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Special conditions for the loan.
/// </summary>
[IsoId("_pqRrgdOCEeSQ_-lmj1tzfw")]
[DisplayName("Special Condition")]
public record SpecialCondition1
{
    /// <summary>
    /// Incoming amount on special conditions.
    /// </summary>
    [IsoId("_uNbGkNOCEeSQ_-lmj1tzfw")]
    [DisplayName("Incoming Amount")]
    [IsoXmlTag("IncmgAmt")]
    public required ActiveCurrencyAndAmount IncomingAmount { get; init; }

    /// <summary>
    /// Outgoing amount on special conditions.
    /// </summary>
    [IsoId("_xOYWINOCEeSQ_-lmj1tzfw")]
    [DisplayName("Outgoing Amount")]
    [IsoXmlTag("OutgngAmt")]
    public required ActiveCurrencyAndAmount OutgoingAmount { get; init; }

    /// <summary>
    /// Incoming amount to other account on special conditions.
    /// </summary>
    [IsoId("_9TKtYwtLEeWkxvNyFrBT8Q")]
    [DisplayName("Incoming Amount To Other Account")]
    [IsoXmlTag("IncmgAmtToOthrAcct")]
    public ActiveCurrencyAndAmount? IncomingAmountToOtherAccount { get; init; }

    /// <summary>
    /// Outgoing payment amount from other account on special conditions.
    /// </summary>
    [IsoId("_HfRVAAtMEeWkxvNyFrBT8Q")]
    [DisplayName("Payment From Other Account")]
    [IsoXmlTag("PmtFrOthrAcct")]
    public ActiveCurrencyAndAmount? PaymentFromOtherAccount { get; init; }
}
