// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies amounts in the framework of a corporate action event.
/// </summary>
[IsoId("_oFtI0KNVEfC9id413JK-Ig")]
[DisplayName("Corporate Action Amounts80")]
public record CorporateActionAmounts80
{
    /// <summary>
    /// For partial prerefunding events, amount that the Issuer is refunding to an earlier maturity date which is guaranteed and deposited in escrow.
    /// </summary>
    [IsoId("_oNbhcaNVEfC9id413JK-Ig")]
    [DisplayName("Refunded Amount")]
    [IsoXmlTag("RfnddAmt")]
    public RestrictedFINImpliedCurrencyAndAmount? RefundedAmount { get; init; }

    /// <summary>
    /// For partial prerefunding events, remaining amount which will continue to have the same maturity date.
    /// </summary>
    [IsoId("_oNbhc6NVEfC9id413JK-Ig")]
    [DisplayName("Non Refunded Amount")]
    [IsoXmlTag("NonRfnddAmt")]
    public RestrictedFINImpliedCurrencyAndAmount? NonRefundedAmount { get; init; }

    /// <summary>
    /// Indicates the portion of the call amount which is held at the depository.
    /// </summary>
    [IsoId("_4hmTgKNVEfC9id413JK-Ig")]
    [DisplayName("Depository Called Amount")]
    [IsoXmlTag("DpstryClldAmt")]
    public RestrictedFINImpliedCurrencyAndAmount? DepositoryCalledAmount { get; init; }
}
