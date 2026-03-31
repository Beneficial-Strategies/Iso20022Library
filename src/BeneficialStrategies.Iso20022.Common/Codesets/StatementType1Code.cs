// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the statement message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQM-E9p-Ed-ak6NoX_4Aeg_757727458")]
[Description(@"Specifies the statement message.")]
[DerivedFrom(typeof(MessageTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<StatementType1Code>))]
#endif
public enum StatementType1Code
{
    /// <summary>
    /// Accounting Statement of Holdings (semt 003).
    /// Encoded/decoded by serializers as &quot;ST03&quot;.
    /// </summary>
    [EnumMember(Value = "ST03")]
    [IsoId("_ZQM-FNp-Ed-ak6NoX_4Aeg_757727475")]
    [Description(@"Accounting Statement of Holdings (semt 003).")]
    AccountingHoldings = MessageTypeCode.AccountingHoldings, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Custody Statement of Holdings (semt 002).
    /// Encoded/decoded by serializers as &quot;ST02&quot;.
    /// </summary>
    [EnumMember(Value = "ST02")]
    [IsoId("_ZQM-Fdp-Ed-ak6NoX_4Aeg_757727518")]
    [Description(@"Custody Statement of Holdings (semt 002).")]
    CustodyHoldings = MessageTypeCode.CustodyHoldings, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Statement of Investment Fund Transactions (semt 006).
    /// Encoded/decoded by serializers as &quot;ST06&quot;.
    /// </summary>
    [EnumMember(Value = "ST06")]
    [IsoId("_ZQM-Ftp-Ed-ak6NoX_4Aeg_757727535")]
    [Description(@"Statement of Investment Fund Transactions (semt 006).")]
    InvestmentFundTransactions = MessageTypeCode.InvestmentFundTransactions, // same ordinal as derivation source for type conversions
}
