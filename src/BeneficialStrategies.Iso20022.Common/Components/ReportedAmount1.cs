// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount reported.
/// </summary>
[IsoId("_Q24J86-yEeGNi5z8K_XPKQ")]
[DisplayName("Reported Amount")]
public record ReportedAmount1
{
    /// <summary>
    /// Identification of the reported amount.
    /// </summary>
    [IsoId("_uFIh8K-0EeGNi5z8K_XPKQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Type of reported amount.
    /// </summary>
    [IsoId("_2p8boK-0EeGNi5z8K_XPKQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ExternalUndertakingAmountType1Code Type { get; init; }

    /// <summary>
    /// Amount reported.
    /// </summary>
    [IsoId("__BRdgK-1EeGNi5z8K_XPKQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }
}
