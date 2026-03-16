// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Incentive Premium6.
/// </summary>
[IsoId("_qQvCxZK5Ee-l-O3vIHRmRw")]
[DisplayName("Incentive Premium6")]
public record IncentivePremium6
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required PriceRateOrAmount8Choice_ Amount { get; init; }

    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax350Text? Description { get; init; }

    /// <summary>
    /// Payment Date.
    /// </summary>
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateFormat3Choice_? PaymentDate { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required IncentivePremiumType2Choice_ Type { get; init; }
}
