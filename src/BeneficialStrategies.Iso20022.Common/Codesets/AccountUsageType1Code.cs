// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of usage of the account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mtUTQBKCEeKj15WxqwlXPw")]
[Description(@"Specifies the type of usage of the account.")]
[DerivedFrom(typeof(AccountUsageTypeCode))]
public enum AccountUsageType1Code
{
    /// <summary>
    /// Investor.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_ayRoIRKDEeKj15WxqwlXPw")]
    [Description(@"Investor.")]
    Investor = AccountUsageTypeCode.Investor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement participant.
    /// Encoded/decoded by serializers as &quot;SETP&quot;.
    /// </summary>
    [EnumMember(Value = "SETP")]
    [IsoId("_a6Uw4RKDEeKj15WxqwlXPw")]
    [Description(@"Settlement participant.")]
    SettlementParticipant = AccountUsageTypeCode.SettlementParticipant, // same ordinal as derivation source for type conversions
    
}
