// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transfer transaction amounts.
/// </summary>
[IsoId("_pgqcMa4uEeWLdt0vLARX2Q")]
[DisplayName("Detailed Amount")]
public record DetailedAmount17
{
    /// <summary>
    /// Amount to be transferred from the source account to the destination account.
    /// </summary>
    [IsoId("_pri2g64uEeWLdt0vLARX2Q")]
    [DisplayName("Amount To Transfer")]
    [IsoXmlTag("AmtToTrf")]
    public required ImpliedCurrencyAndAmount AmountToTransfer { get; init; }

    /// <summary>
    /// Currency of the amount to be transferred.
    /// </summary>
    [IsoId("_pri2ha4uEeWLdt0vLARX2Q")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Transfer fees, accepted by the customer.
    /// </summary>
    [IsoId("_pri2h64uEeWLdt0vLARX2Q")]
    [DisplayName("Fees")]
    [IsoXmlTag("Fees")]
    public ValueList<DetailedAmount18> Fees { get; init; } = [];

    /// <summary>
    /// Amount of the donation.
    /// </summary>
    [IsoId("_pri2ia4uEeWLdt0vLARX2Q")]
    [DisplayName("Donation")]
    [IsoXmlTag("Dontn")]
    public ValueList<DetailedAmount18> Donation { get; init; } = [];
}
