// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details on the margin calculation per financial instrument or per currency.
/// </summary>
[IsoId("_-d50FKMOEeCojJW5vEuTEQ_1366752768")]
[DisplayName("Margin Calculation")]
public record MarginCalculation2
{
    /// <summary>
    /// Provides details about the security identification.
    /// </summary>
    [IsoId("_-d50FaMOEeCojJW5vEuTEQ_517225011")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Net total of the transaction exposure of all outstanding deals.
    /// </summary>
    [IsoId("_-d50FqMOEeCojJW5vEuTEQ_-479847342")]
    [DisplayName("Exposure Amount")]
    [IsoXmlTag("XpsrAmt")]
    public Amount2? ExposureAmount { get; init; }

    /// <summary>
    /// Provides the total margin amount.
    /// </summary>
    [IsoId("_-d50F6MOEeCojJW5vEuTEQ_-118385344")]
    [DisplayName("Total Margin Amount")]
    [IsoXmlTag("TtlMrgnAmt")]
    public required AmountAndDirection20 TotalMarginAmount { get; init; }

    /// <summary>
    /// Provides details on the valuation of the collateral on deposit.
    /// </summary>
    [IsoId("_-eDlEKMOEeCojJW5vEuTEQ_-2053475098")]
    [DisplayName("Collateral On Deposit")]
    [IsoXmlTag("CollOnDpst")]
    public ValueList<Collateral6> CollateralOnDeposit { get; init; } = [];

    /// <summary>
    /// Minimum requirement (expressed in the reporting currency) for a participant if their requirement falls below a specific amount set by the central counterparty.
    /// </summary>
    [IsoId("_-eDlEaMOEeCojJW5vEuTEQ_179304187")]
    [DisplayName("Minimum Requirement Deposit")]
    [IsoXmlTag("MinRqrmntDpst")]
    public ActiveCurrencyAndAmount? MinimumRequirementDeposit { get; init; }

    /// <summary>
    /// Provide details on the margin result taking into consideration the total margin amount and the minimum requirements deposit.
    /// </summary>
    [IsoId("_-eDlEqMOEeCojJW5vEuTEQ_1244419845")]
    [DisplayName("Margin Result")]
    [IsoXmlTag("MrgnRslt")]
    public MarginResult1Choice_? MarginResult { get; init; }

    /// <summary>
    /// Provides margin calculation details such as the initial margin amount, the variation margin amount or other margin type amounts.
    /// </summary>
    [IsoId("_-eDlE6MOEeCojJW5vEuTEQ_-640461449")]
    [DisplayName("Margin Type Amount")]
    [IsoXmlTag("MrgnTpAmt")]
    public Margin3? MarginTypeAmount { get; init; }
}
