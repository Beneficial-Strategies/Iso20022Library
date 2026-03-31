// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method used to settle the credit transfer instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZMCPwdp-Ed-ak6NoX_4Aeg_-115267772")]
[Description(@"Specifies the method used to settle the credit transfer instruction.")]
[DerivedFrom(typeof(SettlementMethodCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SettlementMethod1Code>))]
#endif
public enum SettlementMethod1Code
{
    /// <summary>
    /// Settlement is done by the agent instructed to execute a payment instruction.
    /// Encoded/decoded by serializers as &quot;INDA&quot;.
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_ZMCPwtp-Ed-ak6NoX_4Aeg_301241605")]
    [Description(@"Settlement is done by the agent instructed to execute a payment instruction.")]
    InstructedAgent = SettlementMethodCode.InstructedAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is done by the agent instructing and forwarding the payment to the next party in the payment chain.
    /// Encoded/decoded by serializers as &quot;INGA&quot;.
    /// </summary>
    [EnumMember(Value = "INGA")]
    [IsoId("_ZMCPw9p-Ed-ak6NoX_4Aeg_543203158")]
    [Description(
        @"Settlement is done by the agent instructing and forwarding the payment to the next party in the payment chain."
    )]
    InstructingAgent = SettlementMethodCode.InstructingAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is done through a cover payment.
    /// Encoded/decoded by serializers as &quot;COVE&quot;.
    /// </summary>
    [EnumMember(Value = "COVE")]
    [IsoId("_ZMCPxNp-Ed-ak6NoX_4Aeg_546899109")]
    [Description(@"Settlement is done through a cover payment.")]
    CoverMethod = SettlementMethodCode.CoverMethod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is done through a payment clearing system.
    /// Encoded/decoded by serializers as &quot;CLRG&quot;.
    /// </summary>
    [EnumMember(Value = "CLRG")]
    [IsoId("_ZMCPxdp-Ed-ak6NoX_4Aeg_569985423")]
    [Description(@"Settlement is done through a payment clearing system.")]
    ClearingSystem = SettlementMethodCode.ClearingSystem, // same ordinal as derivation source for type conversions
}
