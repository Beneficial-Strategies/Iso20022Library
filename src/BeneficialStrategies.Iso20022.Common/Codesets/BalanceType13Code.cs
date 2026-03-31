// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the kind of the balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m5hTdfNBEeCuA5Tr22BnwA_454049868")]
[Description(@"Specifies the kind of the balance.")]
[DerivedFrom(typeof(BalanceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BalanceType13Code>))]
#endif
public enum BalanceType13Code
{
    /// <summary>
    /// Balance attributed to investments at value.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_m5rEcPNBEeCuA5Tr22BnwA_937976833")]
    [Description(@"Balance attributed to investments at value.")]
    Investments = BalanceTypeCode.Investments, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance attributed to cash and cash equivalents.
    /// Encoded/decoded by serializers as &quot;CASE&quot;.
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_m5rEcfNBEeCuA5Tr22BnwA_937976858")]
    [Description(@"Balance attributed to cash and cash equivalents.")]
    CashAndCashEquivalents = BalanceTypeCode.CashAndCashEquivalents, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance attributed to borrowings.
    /// Encoded/decoded by serializers as &quot;BORR&quot;.
    /// </summary>
    [EnumMember(Value = "BORR")]
    [IsoId("_m5rEcvNBEeCuA5Tr22BnwA_937976893")]
    [Description(@"Balance attributed to borrowings.")]
    Borrowings = BalanceTypeCode.Borrowings, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance attributed to revenues; including dividends, interest, net realised gains/losses etc.
    /// Encoded/decoded by serializers as &quot;REVE&quot;.
    /// </summary>
    [EnumMember(Value = "REVE")]
    [IsoId("_m5rEc_NBEeCuA5Tr22BnwA_937976935")]
    [Description(
        @"Balance attributed to revenues; including dividends, interest, net realised gains/losses etc."
    )]
    Revenues = BalanceTypeCode.Revenues, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance attributed to expenses.
    /// Encoded/decoded by serializers as &quot;EXPN&quot;.
    /// </summary>
    [EnumMember(Value = "EXPN")]
    [IsoId("_m5rEdPNBEeCuA5Tr22BnwA_937976988")]
    [Description(@"Balance attributed to expenses.")]
    Expenses = BalanceTypeCode.Expenses, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance attributed to investor inflow/outflow (creations, cancellations, income distributions).
    /// Encoded/decoded by serializers as &quot;IIOF&quot;.
    /// </summary>
    [EnumMember(Value = "IIOF")]
    [IsoId("_m5rEdfNBEeCuA5Tr22BnwA_481531555")]
    [Description(
        @"Balance attributed to investor inflow/outflow (creations, cancellations, income distributions)."
    )]
    InvestorInflowOutflow = BalanceTypeCode.InvestorInflowOutflow, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance attributed according to a different classification, which is not explictly defined.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_m50OYPNBEeCuA5Tr22BnwA_1924228507")]
    [Description(
        @"Balance attributed according to a different classification, which is not explictly defined."
    )]
    Other = BalanceTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance attributed to payables.
    /// Encoded/decoded by serializers as &quot;PAYA&quot;.
    /// </summary>
    [EnumMember(Value = "PAYA")]
    [IsoId("_m50OYfNBEeCuA5Tr22BnwA_236468793")]
    [Description(@"Balance attributed to payables.")]
    Payables = BalanceTypeCode.Payables, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance attributed to receivables.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_m50OYvNBEeCuA5Tr22BnwA_147557580")]
    [Description(@"Balance attributed to receivables.")]
    Receivables = BalanceTypeCode.Receivables, // same ordinal as derivation source for type conversions
}
