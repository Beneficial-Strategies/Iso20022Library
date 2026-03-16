// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a demand.
/// </summary>
[IsoId("_-BZCMnltEeG7BsjMvd1mEw_76112237")]
[DisplayName("Demand")]
public record Demand4
{
    /// <summary>
    /// Unique and unambiguous identifier assigned by the presenting party to the demand.
    /// </summary>
    [IsoId("_-BZCM3ltEeG7BsjMvd1mEw_-920960116")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Amount and currency of the demand.
    /// </summary>
    [IsoId("_-BZCNHltEeG7BsjMvd1mEw_-100293454")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }
}
