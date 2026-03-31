// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the total margin amount, the collateral amount on deposit and the total minimum requirement that used to calculate the margin result, either an excess or a deficit.
/// </summary>
[IsoId("_-dwqLKMOEeCojJW5vEuTEQ_1443454160")]
[DisplayName("Margin Calculation")]
public record MarginCalculation1
{
    /// <summary>
    /// Total margin requirement (expressed in the reporting currency) that must be provided by the clearing member to the central counterparty. This is the total requirement calculated to cover the initial margin and the variation margin.
    /// </summary>
    [IsoId("_-d50EKMOEeCojJW5vEuTEQ_536108073")]
    [DisplayName("Total Margin Amount")]
    [IsoXmlTag("TtlMrgnAmt")]
    public required AmountAndDirection20 TotalMarginAmount { get; init; }

    /// <summary>
    /// Provides details on the valuation of the collateral on deposit.
    /// </summary>
    [IsoId("_-d50EaMOEeCojJW5vEuTEQ_-1508761602")]
    [DisplayName("Collateral On Deposit")]
    [IsoXmlTag("CollOnDpst")]
    public ValueList<Collateral6> CollateralOnDeposit { get; init; } = [];

    /// <summary>
    /// Minimum requirement (expressed in the reporting currency) for a participant if their requirement falls below a specific amount set by the central counterparty.
    /// </summary>
    [IsoId("_-d50EqMOEeCojJW5vEuTEQ_-2109217986")]
    [DisplayName("Minimum Requirement Deposit")]
    [IsoXmlTag("MinRqrmntDpst")]
    public ActiveCurrencyAndAmount? MinimumRequirementDeposit { get; init; }

    /// <summary>
    /// Provide details on the margin result taking into consideration the total margin amount and the minimum requirements deposit.
    /// </summary>
    [IsoId("_-d50E6MOEeCojJW5vEuTEQ_193184719")]
    [DisplayName("Margin Result")]
    [IsoXmlTag("MrgnRslt")]
    public MarginResult1Choice_? MarginResult { get; init; }
}
