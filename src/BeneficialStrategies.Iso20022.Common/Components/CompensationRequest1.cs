// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Compensation Request1.
/// </summary>
[IsoId("_ON_m8XY3Ee2HyLKFbMrSWQ")]
[DisplayName("Compensation Request1")]
public record CompensationRequest1
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Compensation Account.
    /// </summary>
    [DisplayName("Compensation Account")]
    [IsoXmlTag("CompstnAcct")]
    public CashAccount40? CompensationAccount { get; init; }

    /// <summary>
    /// Expected Value Date.
    /// </summary>
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    public ISODate? ExpectedValueDate { get; init; }

    /// <summary>
    /// Interest Rate.
    /// </summary>
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public PercentageRate? InterestRate { get; init; }

    /// <summary>
    /// Period.
    /// </summary>
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public required DatePeriod2 Period { get; init; }

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<Max140Text> Reason { get; init; } = [];
}
