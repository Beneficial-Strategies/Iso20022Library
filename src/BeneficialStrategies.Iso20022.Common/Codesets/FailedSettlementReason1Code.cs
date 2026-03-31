// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of a settlement failure.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_amoliNp-Ed-ak6NoX_4Aeg_-707965689")]
[Description(@"Specifies the reason of a settlement failure.")]
[DerivedFrom(typeof(FailedSettlementReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FailedSettlementReason1Code>))]
#endif
public enum FailedSettlementReason1Code
{
    /// <summary>
    /// Credit account is not eligible.
    /// Encoded/decoded by serializers as &quot;CANE&quot;.
    /// </summary>
    [EnumMember(Value = "CANE")]
    [IsoId("_amyWgNp-Ed-ak6NoX_4Aeg_-641474163")]
    [Description(@"Credit account is not eligible.")]
    CreditAccountNotEligible = FailedSettlementReasonCode.CreditAccountNotEligible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Credit account is disabled.
    /// Encoded/decoded by serializers as &quot;CADI&quot;.
    /// </summary>
    [EnumMember(Value = "CADI")]
    [IsoId("_amyWgdp-Ed-ak6NoX_4Aeg_-641474133")]
    [Description(@"Credit account is disabled.")]
    CreditAccountDisabled = FailedSettlementReasonCode.CreditAccountDisabled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Debit account is not eligible.
    /// Encoded/decoded by serializers as &quot;DANE&quot;.
    /// </summary>
    [EnumMember(Value = "DANE")]
    [IsoId("_amyWgtp-Ed-ak6NoX_4Aeg_-641474102")]
    [Description(@"Debit account is not eligible.")]
    DebitAccountNotEligible = FailedSettlementReasonCode.DebitAccountNotEligible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Debit account is disabled.
    /// Encoded/decoded by serializers as &quot;AADI&quot;.
    /// </summary>
    [EnumMember(Value = "AADI")]
    [IsoId("_amyWg9p-Ed-ak6NoX_4Aeg_-641474101")]
    [Description(@"Debit account is disabled.")]
    DebitAccountDisabled = FailedSettlementReasonCode.DebitAccountDisabled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient securities on the account to settle.
    /// Encoded/decoded by serializers as &quot;INSE&quot;.
    /// </summary>
    [EnumMember(Value = "INSE")]
    [IsoId("_amyWhNp-Ed-ak6NoX_4Aeg_-641474072")]
    [Description(@"Insufficient securities on the account to settle.")]
    InsufficientSecurities = FailedSettlementReasonCode.InsufficientSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The distribution is incomplete.
    /// Encoded/decoded by serializers as &quot;INDI&quot;.
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_amyWhdp-Ed-ak6NoX_4Aeg_-641473762")]
    [Description(@"The distribution is incomplete.")]
    IncompleteDistribution = FailedSettlementReasonCode.IncompleteDistribution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient cash on the account to settle.
    /// Encoded/decoded by serializers as &quot;INCA&quot;.
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("_amyWhtp-Ed-ak6NoX_4Aeg_-641473739")]
    [Description(@"Insufficient cash on the account to settle.")]
    InsufficientCash = FailedSettlementReasonCode.InsufficientCash, // same ordinal as derivation source for type conversions
}
