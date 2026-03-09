// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of usage of the account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LjTZABKCEeKj15WxqwlXPw")]
[Description(@"Specifies the type of usage of the account.")]
[Derivations(typeof(AccountUsageType1Code),typeof(AccountUsageType2Code))]
public enum AccountUsageTypeCode
{
    /// <summary>
    /// Investor.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_Tv_toBKCEeKj15WxqwlXPw")]
    [Description(@"Investor.")]
    Investor,
    
    /// <summary>
    /// Settlement participant.
    /// Encoded/decoded by serializers as &quot;SETP&quot;.
    /// </summary>
    [EnumMember(Value = "SETP")]
    [IsoId("_YImsoBKCEeKj15WxqwlXPw")]
    [Description(@"Settlement participant.")]
    SettlementParticipant,
    
    /// <summary>
    /// Trading participant.
    /// Encoded/decoded by serializers as &quot;TRDP&quot;.
    /// </summary>
    [EnumMember(Value = "TRDP")]
    [IsoId("_vsNZ0L-EEeWfsa741pI6WA")]
    [Description(@"Trading participant.")]
    TradingParticipant,
    
    /// <summary>
    /// Issuing participant.
    /// Encoded/decoded by serializers as &quot;ISSP&quot;.
    /// </summary>
    [EnumMember(Value = "ISSP")]
    [IsoId("_v5KQsL-EEeWfsa741pI6WA")]
    [Description(@"Issuing participant.")]
    IssuingParticipant,
    
}
