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
[IsoId("_uWrZANtkEeipuvJHTHIw9A")]
[DisplayName("Loyalty Account")]
public record LoyaltyAccount1
{
    /// <summary>
    /// Identification of Loyalty Account.
    /// </summary>
    [IsoId("_4U7x4NtkEeipuvJHTHIw9A")]
    [DisplayName("Loyalty Identification")]
    [IsoXmlTag("LltyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LoyaltyIdentification { get; init; }

    /// <summary>
    /// Standard or last entry mode to access the Loyalty account or card.
    /// </summary>
    [IsoId("_8Pe74NtkEeipuvJHTHIw9A")]
    [DisplayName("Entry Mode")]
    [IsoXmlTag("NtryMd")]
    public CardDataReading6Code? EntryMode { get; init; }

    /// <summary>
    /// Type of identification for this Loyalty Account.
    /// </summary>
    [IsoId("_AqnDYNtlEeipuvJHTHIw9A")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public CardIdentificationType1Code? IdentificationType { get; init; }

    /// <summary>
    /// Brand to which belong the account.
    /// </summary>
    [IsoId("_FwAP4NtlEeipuvJHTHIw9A")]
    [DisplayName("Brand")]
    [IsoXmlTag("Brnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Brand { get; init; }

    /// <summary>
    /// Provider of the Loyalty Account.
    /// </summary>
    [IsoId("_JM3_YNtlEeipuvJHTHIw9A")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Provider { get; init; }

    /// <summary>
    /// Owner name of an account.
    /// </summary>
    [IsoId("_OnLE4NtlEeipuvJHTHIw9A")]
    [DisplayName("Owner Name")]
    [IsoXmlTag("OwnrNm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45, MinimumLength = 1)]
    public IsoMax45Text? OwnerName { get; init; }

    /// <summary>
    /// Unit of a Loyalty Account (Point or Currency).
    /// </summary>
    [IsoId("_TrhvkNtlEeipuvJHTHIw9A")]
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    public AmountUnit1Code? Unit { get; init; }

    /// <summary>
    /// Currency of a Loyalty Account if any.
    /// </summary>
    [IsoId("_2GE4MNtlEeipuvJHTHIw9A")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Balance of a Loyalty Account.
    /// </summary>
    [IsoId("_696w4NtlEeipuvJHTHIw9A")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ImpliedCurrencyAndAmount? Balance { get; init; }
}
