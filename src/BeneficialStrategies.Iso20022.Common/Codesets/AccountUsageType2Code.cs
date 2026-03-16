// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of usage of the account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CYsHEL-FEeWfsa741pI6WA")]
[Description(@"Specifies the type of usage of the account.")]
[DerivedFrom(typeof(AccountUsageTypeCode))]
public enum AccountUsageType2Code
{
    /// <summary>
    /// Investor.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_FcoZMb-FEeWfsa741pI6WA")]
    [Description(@"Investor.")]
    Investor = AccountUsageTypeCode.Investor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuing participant.
    /// Encoded/decoded by serializers as &quot;ISSP&quot;.
    /// </summary>
    [EnumMember(Value = "ISSP")]
    [IsoId("_FjxjAb-FEeWfsa741pI6WA")]
    [Description(@"Issuing participant.")]
    IssuingParticipant = AccountUsageTypeCode.IssuingParticipant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement participant.
    /// Encoded/decoded by serializers as &quot;SETP&quot;.
    /// </summary>
    [EnumMember(Value = "SETP")]
    [IsoId("_Fqw70b-FEeWfsa741pI6WA")]
    [Description(@"Settlement participant.")]
    SettlementParticipant = AccountUsageTypeCode.SettlementParticipant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading participant.
    /// Encoded/decoded by serializers as &quot;TRDP&quot;.
    /// </summary>
    [EnumMember(Value = "TRDP")]
    [IsoId("_FyD2ob-FEeWfsa741pI6WA")]
    [Description(@"Trading participant.")]
    TradingParticipant = AccountUsageTypeCode.TradingParticipant, // same ordinal as derivation source for type conversions
}
