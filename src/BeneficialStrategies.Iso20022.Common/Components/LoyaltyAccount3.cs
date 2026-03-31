// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Loyalty Account description.
/// </summary>
[IsoId("_JSd9kU7NEeyGi9JAv6wq7Q")]
[DisplayName("Loyalty Account")]
public record LoyaltyAccount3
{
    /// <summary>
    /// Identification of Loyalty Account.
    /// </summary>
    [IsoId("_JY9AEU7NEeyGi9JAv6wq7Q")]
    [DisplayName("Loyalty Identification")]
    [IsoXmlTag("LltyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text LoyaltyIdentification { get; init; }

    /// <summary>
    /// Standard or last entry mode to access the Loyalty account or card.
    /// </summary>
    [IsoId("_JY9AE07NEeyGi9JAv6wq7Q")]
    [DisplayName("Entry Mode")]
    [IsoXmlTag("NtryMd")]
    public CardDataReading8Code? EntryMode { get; init; }

    /// <summary>
    /// Type of identification for this Loyalty Account.
    /// </summary>
    [IsoId("_JY9AFU7NEeyGi9JAv6wq7Q")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public CardIdentificationType1Code? IdentificationType { get; init; }

    /// <summary>
    /// Brand to which belong the account.
    /// </summary>
    [IsoId("_JY9AF07NEeyGi9JAv6wq7Q")]
    [DisplayName("Brand")]
    [IsoXmlTag("Brnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Brand { get; init; }

    /// <summary>
    /// Provider of the Loyalty Account.
    /// </summary>
    [IsoId("_JY9AGU7NEeyGi9JAv6wq7Q")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Provider { get; init; }

    /// <summary>
    /// Owner name of an account.
    /// </summary>
    [IsoId("_JY9AG07NEeyGi9JAv6wq7Q")]
    [DisplayName("Owner Name")]
    [IsoXmlTag("OwnrNm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45, MinimumLength = 1)]
    public IsoMax45Text? OwnerName { get; init; }

    /// <summary>
    /// Unit of a Loyalty Account (Point or Currency).
    /// </summary>
    [IsoId("_JY9AHU7NEeyGi9JAv6wq7Q")]
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    public AmountUnit1Code? Unit { get; init; }

    /// <summary>
    /// Currency of a Loyalty Account if any.
    /// </summary>
    [IsoId("_JY9AH07NEeyGi9JAv6wq7Q")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Balance of a Loyalty Account.
    /// </summary>
    [IsoId("_JY9AIU7NEeyGi9JAv6wq7Q")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ImpliedCurrencyAndAmount? Balance { get; init; }
}
