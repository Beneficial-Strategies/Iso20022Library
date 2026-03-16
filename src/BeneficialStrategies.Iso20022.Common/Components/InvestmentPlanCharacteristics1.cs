// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of an investment plan.
/// </summary>
[IsoId("_iMh2EF8-Eeicg40_9gK9vQ")]
[DisplayName("Investment Plan Characteristics")]
public record InvestmentPlanCharacteristics1
{
    /// <summary>
    /// Type of investment plan.
    /// </summary>
    [IsoId("_rvZTcF8-Eeicg40_9gK9vQ")]
    [DisplayName("Plan Type")]
    [IsoXmlTag("PlanTp")]
    public required InvestmentFundPlanType1Choice_ PlanType { get; init; }

    /// <summary>
    /// Frequency of the investment plan.
    /// </summary>
    [IsoId("_ucICoF9CEeicg40_9gK9vQ")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency20Choice_? Frequency { get; init; }

    /// <summary>
    /// Total number of times the amount must be invested at the predefined frequency as of the start date of the investment plan.
    /// </summary>
    [IsoId("_2xB4EV9CEeicg40_9gK9vQ")]
    [DisplayName("Total Number Of Instalments")]
    [IsoXmlTag("TtlNbOfInstlmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfInstalments { get; init; }

    /// <summary>
    /// Minimum amount of the periodical payments. (If there is no maximum, then &apos;0&apos; must be specified for the Amount or Units.)
    /// </summary>
    [IsoId("_Ag_WQV9DEeicg40_9gK9vQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public UnitsOrAmount1Choice_? Quantity { get; init; }

    /// <summary>
    /// Indicates whether it is possible to continue the savings plan after the end date.
    /// </summary>
    [IsoId("_MO0PUF9DEeicg40_9gK9vQ")]
    [DisplayName("Plan Continuation")]
    [IsoXmlTag("PlanConttn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PlanContinuation { get; init; }

    /// <summary>
    /// Indicates whether it is possible to subscribe to additional instalments over and above that permitted by the savings plan frequency.
    /// </summary>
    [IsoId("_lmY7kF9DEeicg40_9gK9vQ")]
    [DisplayName("Additional Subscription")]
    [IsoXmlTag("AddtlSbcpt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AdditionalSubscription { get; init; }

    /// <summary>
    /// Indicates whether any additional instalments will reduce the period of the life of the savings investment plan.
    /// </summary>
    [IsoId("_CyIdAF9EEeicg40_9gK9vQ")]
    [DisplayName("Additional Subscription Function")]
    [IsoXmlTag("AddtlSbcptFctn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AdditionalSubscriptionFunction { get; init; }

    /// <summary>
    /// Additional information about the investment plan.
    /// </summary>
    [IsoId("_qpMmsWAKEeiNMJ262H2pWg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
