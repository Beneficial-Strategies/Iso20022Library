// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Adjustment Compensation1.
/// </summary>
[IsoId("_-0qJAG8xEe2aW4iy-zispA")]
[DisplayName("Adjustment Compensation1")]
public record AdjustmentCompensation1
{
    /// <summary>
    /// Amount Due.
    /// </summary>
    [DisplayName("Amount Due")]
    [IsoXmlTag("AmtDue")]
    public required ActiveCurrencyAndAmount AmountDue { get; init; }

    /// <summary>
    /// Compensation Account.
    /// </summary>
    [DisplayName("Compensation Account")]
    [IsoXmlTag("CompstnAcct")]
    public CashAccount40? CompensationAccount { get; init; }

    /// <summary>
    /// Compensation Agent.
    /// </summary>
    [DisplayName("Compensation Agent")]
    [IsoXmlTag("CompstnAgt")]
    public BranchAndFinancialInstitutionIdentification6? CompensationAgent { get; init; }

    /// <summary>
    /// Due Charges.
    /// </summary>
    [DisplayName("Due Charges")]
    [IsoXmlTag("DueChrgs")]
    public ActiveCurrencyAndAmount? DueCharges { get; init; }

    /// <summary>
    /// Initial Amount.
    /// </summary>
    [DisplayName("Initial Amount")]
    [IsoXmlTag("InitlAmt")]
    public ActiveCurrencyAndAmount? InitialAmount { get; init; }

    /// <summary>
    /// Interest Rate.
    /// </summary>
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public IsoPercentageRate? InterestRate { get; init; }

    /// <summary>
    /// Period.
    /// </summary>
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public DatePeriod5? Period { get; init; }

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public IsoMax140Text? Reason { get; init; }
}
