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
[IsoId("_SsowIQxrEeqdx6buGpCCQw")]
[DisplayName("Stored Value Account")]
public record StoredValueAccount2
{
    /// <summary>
    /// Type of stored value account.
    /// </summary>
    [IsoId("_S3y3QQxrEeqdx6buGpCCQw")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public StoredValueAccountType1Code? AccountType { get; init; }

    /// <summary>
    /// Type of identification for this Stored Value Account.
    /// </summary>
    [IsoId("_S3y3QwxrEeqdx6buGpCCQw")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public CardIdentificationType1Code? IdentificationType { get; init; }

    /// <summary>
    /// Identification of Stored Value Account.
    /// </summary>
    [IsoId("_S3y3RQxrEeqdx6buGpCCQw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Brand to which belong the account.
    /// </summary>
    [IsoId("_S3y3RwxrEeqdx6buGpCCQw")]
    [DisplayName("Brand")]
    [IsoXmlTag("Brnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Brand { get; init; }

    /// <summary>
    /// Provider of the Stored Value Account.
    /// </summary>
    [IsoId("_S3y3SQxrEeqdx6buGpCCQw")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Provider { get; init; }

    /// <summary>
    /// Owner name of an account.
    /// </summary>
    [IsoId("_S3y3SwxrEeqdx6buGpCCQw")]
    [DisplayName("Owner Name")]
    [IsoXmlTag("OwnrNm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45, MinimumLength = 1)]
    public IsoMax45Text? OwnerName { get; init; }

    /// <summary>
    /// Expiry date of the account of card.
    /// </summary>
    [IsoId("_S3y3TQxrEeqdx6buGpCCQw")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? ExpiryDate { get; init; }

    /// <summary>
    /// Standard or last entry mode to access the Stored Value account or card.
    /// </summary>
    [IsoId("_S3y3TwxrEeqdx6buGpCCQw")]
    [DisplayName("Entry Mode")]
    [IsoXmlTag("NtryMd")]
    public CardDataReading8Code? EntryMode { get; init; }

    /// <summary>
    /// Currency of the Stored Value account.
    /// </summary>
    [IsoId("_S3y3UQxrEeqdx6buGpCCQw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Current balance of the Stored Value account.
    /// </summary>
    [IsoId("_S3y3UwxrEeqdx6buGpCCQw")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ImpliedCurrencyAndAmount? Balance { get; init; }
}
