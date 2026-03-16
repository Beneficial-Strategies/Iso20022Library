// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the details of the billing amount
/// </summary>
[IsoId("_c2afgSCEEey8XKHwKquEQw")]
[DisplayName("Amount")]
public record Amount19
{
    /// <summary>
    /// Description of the amount details.
    /// </summary>
    [IsoId("_c8He4SCEEey8XKHwKquEQw")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Description { get; init; }

    /// <summary>
    /// Contains the amount.
    /// </summary>
    [IsoId("_c8He4yCEEey8XKHwKquEQw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// A code to indicate the tax amount is credit or debit
    /// </summary>
    [IsoId("_z5R6MTapEeyjpIf0r_Ojqw")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }

    /// <summary>
    /// Tax applicable to the billing amount.
    /// </summary>
    [IsoId("_c8He5yCEEey8XKHwKquEQw")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax39? Tax { get; init; }
}
