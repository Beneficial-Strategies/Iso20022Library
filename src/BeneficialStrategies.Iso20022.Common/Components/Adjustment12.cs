// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes each adjustment made to the original price.
/// </summary>
[IsoId("_MMRkATaqEeyjpIf0r_Ojqw")]
[DisplayName("Adjustment")]
public record Adjustment12
{
    /// <summary>
    /// Contains the adjusted amount (for example, discounts).
    /// </summary>
    [IsoId("_MRpMMTaqEeyjpIf0r_Ojqw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// A code to indicate the tax amount is credit or debit
    /// </summary>
    [IsoId("_8CXhMTapEeyjpIf0r_Ojqw")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }

    /// <summary>
    /// Reason for the adjustment.
    /// </summary>
    [IsoId("_MRpMNTaqEeyjpIf0r_Ojqw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Reason { get; init; }
}
