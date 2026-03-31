// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to a requested Loyalty program or account.
/// </summary>
[IsoId("_XTSd4U7WEeyGi9JAv6wq7Q")]
[DisplayName("Loyalty Account Request")]
public record LoyaltyAccountRequest3
{
    /// <summary>
    /// To retrieve Card Acquisition Data.
    /// </summary>
    [IsoId("_XZZF4U7WEeyGi9JAv6wq7Q")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; }

    /// <summary>
    /// Loyalty account information.
    /// </summary>
    [IsoId("_XZZF407WEeyGi9JAv6wq7Q")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public LoyaltyAccount3? Account { get; init; }
}
