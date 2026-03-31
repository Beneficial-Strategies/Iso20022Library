// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the stored value account or the stored value card (Prepaid card).
/// </summary>
[IsoId("_QMJNsNtcEeipuvJHTHIw9A")]
[DisplayName("Stored Value Account")]
public record StoredValueAccount1
{
    /// <summary>
    /// Type of stored value account.
    /// </summary>
    [IsoId("_dQGzQNtcEeipuvJHTHIw9A")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public StoredValueAccountType1Code? AccountType { get; init; }

    /// <summary>
    /// Type of identification for this Stored Value Account.
    /// </summary>
    [IsoId("_AXDAcNtgEeipuvJHTHIw9A")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public CardIdentificationType1Code? IdentificationType { get; init; }

    /// <summary>
    /// Identification of Stored Value Account.
    /// </summary>
    [IsoId("_R7WSwNtiEeipuvJHTHIw9A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Brand to which belong the account.
    /// </summary>
    [IsoId("_WhYpwNtiEeipuvJHTHIw9A")]
    [DisplayName("Brand")]
    [IsoXmlTag("Brnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Brand { get; init; }

    /// <summary>
    /// Provider of the Stored Value Account.
    /// </summary>
    [IsoId("_dARYwNtiEeipuvJHTHIw9A")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Provider { get; init; }

    /// <summary>
    /// Owner name of an account.
    /// </summary>
    [IsoId("_kEd0QNtiEeipuvJHTHIw9A")]
    [DisplayName("Owner Name")]
    [IsoXmlTag("OwnrNm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45, MinimumLength = 1)]
    public IsoMax45Text? OwnerName { get; init; }

    /// <summary>
    /// Expiry date of the account of card.
    /// </summary>
    [IsoId("_p1McwNtiEeipuvJHTHIw9A")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? ExpiryDate { get; init; }

    /// <summary>
    /// Standard or last entry mode to access the Stored Value account or card.
    /// </summary>
    [IsoId("_s84xANtjEeipuvJHTHIw9A")]
    [DisplayName("Entry Mode")]
    [IsoXmlTag("NtryMd")]
    public CardDataReading6Code? EntryMode { get; init; }

    /// <summary>
    /// Currency of the Stored Value account.
    /// </summary>
    [IsoId("_yE6awNtjEeipuvJHTHIw9A")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Current balance of the Stored Value account.
    /// </summary>
    [IsoId("_28EW8NtjEeipuvJHTHIw9A")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ImpliedCurrencyAndAmount? Balance { get; init; }
}
