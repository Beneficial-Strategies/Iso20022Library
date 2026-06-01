// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of funding source used for a financial service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KISIAT_aEfCQAqQ9lolFUg")]
[Description(@"Type of funding source used for a financial service.")]
[DerivedFrom(typeof(FundingSourceTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<FundingSourceType4Code>))]
public enum FundingSourceType4Code
{
    /// <summary>
    /// Card.
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_0ZQk4T_bEfCQAqQ9lolFUg")]
    [Description(@"Card.")]
    Card = FundingSourceTypeCode.Card, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash as a source type to perform the transaction.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_KKpfiT_aEfCQAqQ9lolFUg")]
    [Description(@"Cash as a source type  to perform the transaction.")]
    Cash = FundingSourceTypeCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Debit card account.
    /// Encoded/decoded by serializers as &quot;CDBT&quot;.
    /// </summary>
    [EnumMember(Value = "CDBT")]
    [IsoId("_KKpfjT_aEfCQAqQ9lolFUg")]
    [Description(@"Debit card account.")]
    DebitCard = FundingSourceTypeCode.DebitCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque.
    /// Encoded/decoded by serializers as &quot;CHQE&quot;.
    /// </summary>
    [EnumMember(Value = "CHQE")]
    [IsoId("_KKpflT_aEfCQAqQ9lolFUg")]
    [Description(@"Cheque")]
    Cheque = FundingSourceTypeCode.Cheque, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Credit card account.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_KKpfiz_aEfCQAqQ9lolFUg")]
    [Description(@"Credit card account.")]
    CreditCard = FundingSourceTypeCode.CreditCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Current account.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_KKpfkz_aEfCQAqQ9lolFUg")]
    [Description(@"Current account.")]
    Current = FundingSourceTypeCode.Current, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account for debiting funds.
    /// Encoded/decoded by serializers as &quot;DBAC&quot;.
    /// </summary>
    [EnumMember(Value = "DBAC")]
    [IsoId("_KKpfkT_aEfCQAqQ9lolFUg")]
    [Description(@"Account for debiting funds.")]
    DebitAccount = FundingSourceTypeCode.DebitAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic purse card account.
    /// Encoded/decoded by serializers as &quot;EPRS&quot;.
    /// </summary>
    [EnumMember(Value = "EPRS")]
    [IsoId("_KKpfjz_aEfCQAqQ9lolFUg")]
    [Description(@"Electronic purse card account.")]
    EpurseCard = FundingSourceTypeCode.EpurseCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line of credit account.
    /// Encoded/decoded by serializers as &quot;LCDT&quot;.
    /// </summary>
    [EnumMember(Value = "LCDT")]
    [IsoId("_KKpfmT_aEfCQAqQ9lolFUg")]
    [Description(@"Line of credit account.")]
    LineOfCredit = FundingSourceTypeCode.LineOfCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Loyalty points converted into cash.
    /// Encoded/decoded by serializers as &quot;LOYT&quot;.
    /// </summary>
    [EnumMember(Value = "LOYT")]
    [IsoId("_KKpfmz_aEfCQAqQ9lolFUg")]
    [Description(@"Loyalty points converted into cash.")]
    Loyalty = FundingSourceTypeCode.Loyalty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pre-paid account.
    /// Encoded/decoded by serializers as &quot;PRPD&quot;.
    /// </summary>
    [EnumMember(Value = "PRPD")]
    [IsoId("_KKpflz_aEfCQAqQ9lolFUg")]
    [Description(@"Pre-paid account.")]
    PrePaid = FundingSourceTypeCode.PrePaid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Savings account.
    /// Encoded/decoded by serializers as &quot;SVNG&quot;.
    /// </summary>
    [EnumMember(Value = "SVNG")]
    [IsoId("_KKpfhT_aEfCQAqQ9lolFUg")]
    [Description(@"Savings account.")]
    Savings = FundingSourceTypeCode.Savings, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Universal account.
    /// Encoded/decoded by serializers as &quot;UVRL&quot;.
    /// </summary>
    [EnumMember(Value = "UVRL")]
    [IsoId("_KKpfhz_aEfCQAqQ9lolFUg")]
    [Description(@"Universal account.")]
    Universal = FundingSourceTypeCode.Universal, // same ordinal as derivation source for type conversions
}
