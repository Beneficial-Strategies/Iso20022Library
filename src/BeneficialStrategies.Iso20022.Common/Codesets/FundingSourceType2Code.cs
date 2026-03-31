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
[IsoId("_yKJtINwoEeeiWo5KG3eipw")]
[Description(@"Type of funding source used for a financial service.")]
[DerivedFrom(typeof(FundingSourceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FundingSourceType2Code>))]
#endif
public enum FundingSourceType2Code
{
    /// <summary>
    /// Loyalty points converted into cash
    /// Encoded/decoded by serializers as &quot;LOYL&quot;.
    /// </summary>
    [EnumMember(Value = "LOYL")]
    [IsoId("_4MzzIdwoEeeiWo5KG3eipw")]
    [Description(@"Loyalty points converted into cash")]
    Loyaly = FundingSourceTypeCode.Loyaly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of account defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_46oicdwoEeeiWo5KG3eipw")]
    [Description(@"Other type of account defined at national level.")]
    OtherNational = FundingSourceTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of account defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_5EAg4dwoEeeiWo5KG3eipw")]
    [Description(@"Other type of account defined at private level.")]
    OtherPrivate = FundingSourceTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Savings account.
    /// Encoded/decoded by serializers as &quot;SVNG&quot;.
    /// </summary>
    [EnumMember(Value = "SVNG")]
    [IsoId("_6QVKEdwoEeeiWo5KG3eipw")]
    [Description(@"Savings account.")]
    Savings = FundingSourceTypeCode.Savings, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Universal account.
    /// Encoded/decoded by serializers as &quot;UVRL&quot;.
    /// </summary>
    [EnumMember(Value = "UVRL")]
    [IsoId("_7OOVsdwoEeeiWo5KG3eipw")]
    [Description(@"Universal account.")]
    Universal = FundingSourceTypeCode.Universal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash as a source type  to perform the transaction.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_9LyOkdwoEeeiWo5KG3eipw")]
    [Description(@"Cash as a source type  to perform the transaction.")]
    Cash = FundingSourceTypeCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Credit card account.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_-ayYUdwoEeeiWo5KG3eipw")]
    [Description(@"Credit card account.")]
    CreditCard = FundingSourceTypeCode.CreditCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Debit card account.
    /// Encoded/decoded by serializers as &quot;CDBT&quot;.
    /// </summary>
    [EnumMember(Value = "CDBT")]
    [IsoId("__Y0t4dwoEeeiWo5KG3eipw")]
    [Description(@"Debit card account.")]
    DebitCard = FundingSourceTypeCode.DebitCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic purse card account.
    /// Encoded/decoded by serializers as &quot;EPRS&quot;.
    /// </summary>
    [EnumMember(Value = "EPRS")]
    [IsoId("__r3lsdwoEeeiWo5KG3eipw")]
    [Description(@"Electronic purse card account.")]
    EpurseCard = FundingSourceTypeCode.EpurseCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account for debiting funds.
    /// Encoded/decoded by serializers as &quot;DBAC&quot;.
    /// </summary>
    [EnumMember(Value = "DBAC")]
    [IsoId("_Av_8MdwpEeeiWo5KG3eipw")]
    [Description(@"Account for debiting funds.")]
    DebitAccount = FundingSourceTypeCode.DebitAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Current account.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_BI_rAdwpEeeiWo5KG3eipw")]
    [Description(@"Current account.")]
    Current = FundingSourceTypeCode.Current, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheque
    /// Encoded/decoded by serializers as &quot;CHQE&quot;.
    /// </summary>
    [EnumMember(Value = "CHQE")]
    [IsoId("_BviGkdwpEeeiWo5KG3eipw")]
    [Description(@"Cheque")]
    Cheque = FundingSourceTypeCode.Cheque, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pre-paid account.
    /// Encoded/decoded by serializers as &quot;PRPD&quot;.
    /// </summary>
    [EnumMember(Value = "PRPD")]
    [IsoId("_DMhB8dwpEeeiWo5KG3eipw")]
    [Description(@"Pre-paid account.")]
    PrePaid = FundingSourceTypeCode.PrePaid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line of credit account.
    /// Encoded/decoded by serializers as &quot;LCDT&quot;.
    /// </summary>
    [EnumMember(Value = "LCDT")]
    [IsoId("_7u4G4eFmEeeA0cKTZTRL5g")]
    [Description(@"Line of credit account.")]
    LineOfCredit = FundingSourceTypeCode.LineOfCredit, // same ordinal as derivation source for type conversions
}
