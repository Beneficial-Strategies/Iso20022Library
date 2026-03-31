// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a bank account
/// </summary>
[IsoId("_Ma6g8csSEeuNe7RtB4qFHw")]
[DisplayName("Account Details")]
public record AccountDetails3
{
    /// <summary>
    /// Name of the account as assigned by the account servicing institution in an agreement with the account owner in order to provide an additional means of identification of the account.
    /// </summary>
    [IsoId("_MfKu0csSEeuNe7RtB4qFHw")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AccountName { get; init; }

    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// Conforms to ISO 8583, Account type codes, which are maintained by the ISO 8583/MA (Maintenance Agency).
    /// </summary>
    [IsoId("_MfKu08sSEeuNe7RtB4qFHw")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public ISO8583AccountTypeCode? AccountType { get; init; }

    /// <summary>
    /// Identification of an account.
    /// ISO 8583 bit 102 or bit 103
    /// </summary>
    [IsoId("_MfKu1csSEeuNe7RtB4qFHw")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AccountIdentification { get; init; }
}
