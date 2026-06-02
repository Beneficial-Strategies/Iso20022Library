// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details for fees and charges.
/// </summary>
[IsoId("_Qp56pvsYEemYNq6Sxm5nlg")]
[DisplayName("Billing Fee Record1")]
public record BillingFeeRecord1
{
    /// <summary>
    /// Type of the fees or charges.
    /// </summary>
    [IsoId("_syeH0PsYEemYNq6Sxm5nlg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public IsoMax4Text? Type { get; init; }

    /// <summary>
    /// Further details on the charges or fees.
    /// </summary>
    [IsoId("_Qp56qfsYEemYNq6Sxm5nlg")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax35Text? Description { get; init; }

    /// <summary>
    /// Rate used to calculate the charges or fees.
    /// </summary>
    [IsoId("_Qp56p_sYEemYNq6Sxm5nlg")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public IsoPercentageRate? Rate { get; init; }

    /// <summary>
    /// Amount of money asked or paid for the charges or fees.
    /// </summary>
    [IsoId("_Qp56qvsYEemYNq6Sxm5nlg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; }
}
