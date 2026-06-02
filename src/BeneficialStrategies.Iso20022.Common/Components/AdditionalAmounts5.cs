// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limits and amounts not part of the transaction amount. Not included in reconciliation totals.
/// </summary>
[IsoId("_LnpvoSH3EfCkq6-p7S3J1Q")]
[DisplayName("Additional Amounts5")]
public record AdditionalAmounts5
{
    /// <summary>
    /// Code used to describe the accounts affected.
    /// </summary>
    [IsoId("_a8qx0CH3EfCkq6-p7S3J1Q")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public ISO8583AccountTypeCode? AccountType { get; init; }

    /// <summary>
    /// Type or class of amount.
    /// </summary>
    [IsoId("_LqhdcSH3EfCkq6-p7S3J1Q")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ISO8583AmountTypeCode Type { get; init; }

    /// <summary>
    /// Other type of amount.
    /// </summary>
    [IsoId("_LqhdcyH3EfCkq6-p7S3J1Q")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_LqhddSH3EfCkq6-p7S3J1Q")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Currency code associated with the applicable type of amount.
    /// </summary>
    [IsoId("_LqhddyH3EfCkq6-p7S3J1Q")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Sign of the Amount.
    /// </summary>
    [IsoId("_LqhdeSH3EfCkq6-p7S3J1Q")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }

    /// <summary>
    /// Short description of the additional amount.
    /// </summary>
    [IsoId("_LqhdeyH3EfCkq6-p7S3J1Q")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax70Text? Description { get; init; }
}
