// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the interest statement.
/// </summary>
[IsoId("_Rvb0MWjgEeSwb7MzI8qnfQ")]
[DisplayName("Interest Statement")]
public record InterestStatement3
{
    /// <summary>
    /// Provides the period during which the interest rate has been applied.
    /// </summary>
    [IsoId("_SM5MQWjgEeSwb7MzI8qnfQ")]
    [DisplayName("Interest Period")]
    [IsoXmlTag("IntrstPrd")]
    public required DatePeriodDetails InterestPeriod { get; init; }

    /// <summary>
    /// Provides the total amount of interest that is due to partyA.
    /// </summary>
    [IsoId("_SM5MQ2jgEeSwb7MzI8qnfQ")]
    [DisplayName("Total Interest Amount Due To A")]
    [IsoXmlTag("TtlIntrstAmtDueToA")]
    public ActiveCurrencyAndAmount? TotalInterestAmountDueToA { get; init; }

    /// <summary>
    /// Provides the total amount of interest that is due to partyB.
    /// </summary>
    [IsoId("_SM5MRWjgEeSwb7MzI8qnfQ")]
    [DisplayName("Total Interest Amount Due To B")]
    [IsoXmlTag("TtlIntrstAmtDueToB")]
    public ActiveCurrencyAndAmount? TotalInterestAmountDueToB { get; init; }

    /// <summary>
    /// Indicates the value date of the interest statement.
    /// </summary>
    [IsoId("_SM5MR2jgEeSwb7MzI8qnfQ")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValueDate { get; init; }

    /// <summary>
    /// Provides the reference to the interest payment request.
    /// </summary>
    [IsoId("_SM5MSWjgEeSwb7MzI8qnfQ")]
    [DisplayName("Interest Payment Request Identification")]
    [IsoXmlTag("IntrstPmtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InterestPaymentRequestIdentification { get; init; }

    /// <summary>
    /// Provides the details of the interest calculation.
    /// </summary>
    [IsoId("_SM5MS2jgEeSwb7MzI8qnfQ")]
    [DisplayName("Interest Calculation")]
    [IsoXmlTag("IntrstClctn")]
    public ValueList<InterestCalculation3> InterestCalculation { get; init; } = [];
}
