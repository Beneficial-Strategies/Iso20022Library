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
[IsoId("_h8DYIYF0EeWtPe6Crjmeug")]
[DisplayName("Interest Statement")]
public record InterestStatement4
{
    /// <summary>
    /// Provides the period during which the interest rate has been applied.
    /// </summary>
    [IsoId("_iSErcYF0EeWtPe6Crjmeug")]
    [DisplayName("Interest Period")]
    [IsoXmlTag("IntrstPrd")]
    public required DatePeriodDetails InterestPeriod { get; init; }

    /// <summary>
    /// Provides the total amount of interest that is due to partyA.
    /// </summary>
    [IsoId("_iSErc4F0EeWtPe6Crjmeug")]
    [DisplayName("Total Interest Amount Due To A")]
    [IsoXmlTag("TtlIntrstAmtDueToA")]
    public ActiveCurrencyAndAmount? TotalInterestAmountDueToA { get; init; }

    /// <summary>
    /// Provides the total amount of interest that is due to partyB.
    /// </summary>
    [IsoId("_iSErdYF0EeWtPe6Crjmeug")]
    [DisplayName("Total Interest Amount Due To B")]
    [IsoXmlTag("TtlIntrstAmtDueToB")]
    public ActiveCurrencyAndAmount? TotalInterestAmountDueToB { get; init; }

    /// <summary>
    /// Indicates the value date of the interest statement.
    /// </summary>
    [IsoId("_iSErd4F0EeWtPe6Crjmeug")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValueDate { get; init; }

    /// <summary>
    /// Provides the reference to the interest payment request.
    /// </summary>
    [IsoId("_iSEreYF0EeWtPe6Crjmeug")]
    [DisplayName("Interest Payment Request Identification")]
    [IsoXmlTag("IntrstPmtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InterestPaymentRequestIdentification { get; init; }

    /// <summary>
    /// Provides the details of the interest calculation.
    /// </summary>
    [IsoId("_iSEre4F0EeWtPe6Crjmeug")]
    [DisplayName("Interest Calculation")]
    [IsoXmlTag("IntrstClctn")]
    public InterestCalculation4? InterestCalculation { get; init; }
}
