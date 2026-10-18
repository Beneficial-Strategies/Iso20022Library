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
[IsoId("_JRq2sX2-Ee6YlIMyoxWMJA")]
[Description(@"Type of funding source used for a financial service.")]
[DerivedFrom(typeof(FundingSourceTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<FundingSourceType3Code>))]
public enum FundingSourceType3Code
{
    /// <summary>
    /// Cash as a source type to perform the transaction.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_JcDhy32-Ee6YlIMyoxWMJA")]
    [Description(@"Cash as a source type  to perform the transaction.")]
    Cash = FundingSourceTypeCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Debit card account.
    /// Encoded/decoded by serializers as &quot;CDBT&quot;.
    /// </summary>
    [EnumMember(Value = "CDBT")]
    [IsoId("_JcDhz32-Ee6YlIMyoxWMJA")]
    [Description(@"Debit card account.")]
    DebitCard = FundingSourceTypeCode.DebitCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque.
    /// Encoded/decoded by serializers as &quot;CHQE&quot;.
    /// </summary>
    [EnumMember(Value = "CHQE")]
    [IsoId("_JcDh132-Ee6YlIMyoxWMJA")]
    [Description(@"Cheque")]
    Cheque = FundingSourceTypeCode.Cheque, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Credit card account.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_JcDhzX2-Ee6YlIMyoxWMJA")]
    [Description(@"Credit card account.")]
    CreditCard = FundingSourceTypeCode.CreditCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Current account.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_JcDh1X2-Ee6YlIMyoxWMJA")]
    [Description(@"Current account.")]
    Current = FundingSourceTypeCode.Current, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account for debiting funds.
    /// Encoded/decoded by serializers as &quot;DBAC&quot;.
    /// </summary>
    [EnumMember(Value = "DBAC")]
    [IsoId("_JcDh032-Ee6YlIMyoxWMJA")]
    [Description(@"Account for debiting funds.")]
    DebitAccount = FundingSourceTypeCode.DebitAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic purse card account.
    /// Encoded/decoded by serializers as &quot;EPRS&quot;.
    /// </summary>
    [EnumMember(Value = "EPRS")]
    [IsoId("_JcDh0X2-Ee6YlIMyoxWMJA")]
    [Description(@"Electronic purse card account.")]
    EpurseCard = FundingSourceTypeCode.EpurseCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line of credit account.
    /// Encoded/decoded by serializers as &quot;LCDT&quot;.
    /// </summary>
    [EnumMember(Value = "LCDT")]
    [IsoId("_JcDh232-Ee6YlIMyoxWMJA")]
    [Description(@"Line of credit account.")]
    LineOfCredit = FundingSourceTypeCode.LineOfCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Loyalty points converted into cash.
    /// Encoded/decoded by serializers as &quot;LOYT&quot;.
    /// </summary>
    [EnumMember(Value = "LOYT")]
    [IsoId("_N9lzQX2-Ee6YlIMyoxWMJA")]
    [Description(@"Loyalty points converted into cash.")]
    Loyalty = FundingSourceTypeCode.Loyalty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of account defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_JcDhw32-Ee6YlIMyoxWMJA")]
    [Description(@"Other type of account defined at national level.")]
    OtherNational = FundingSourceTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of account defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_JcDhxX2-Ee6YlIMyoxWMJA")]
    [Description(@"Other type of account defined at private level.")]
    OtherPrivate = FundingSourceTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pre-paid account.
    /// Encoded/decoded by serializers as &quot;PRPD&quot;.
    /// </summary>
    [EnumMember(Value = "PRPD")]
    [IsoId("_JcDh2X2-Ee6YlIMyoxWMJA")]
    [Description(@"Pre-paid account.")]
    PrePaid = FundingSourceTypeCode.PrePaid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Savings account.
    /// Encoded/decoded by serializers as &quot;SVNG&quot;.
    /// </summary>
    [EnumMember(Value = "SVNG")]
    [IsoId("_JcDhx32-Ee6YlIMyoxWMJA")]
    [Description(@"Savings account.")]
    Savings = FundingSourceTypeCode.Savings, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Universal account.
    /// Encoded/decoded by serializers as &quot;UVRL&quot;.
    /// </summary>
    [EnumMember(Value = "UVRL")]
    [IsoId("_JcDhyX2-Ee6YlIMyoxWMJA")]
    [Description(@"Universal account.")]
    Universal = FundingSourceTypeCode.Universal, // same ordinal as derivation source for type conversions
}
