// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of a trading party in a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2MHegIoREeahcZ3Nzs1Qag")]
[Description(@"Specifies the role of a trading party in a transaction.")]
[DerivedFrom(typeof(TradingCapacityCode))]
public enum TradingCapacity8Code
{
    /// <summary>
    /// Trading as Agent on behalf of a customer.
    /// Encoded/decoded by serializers as &quot;AGEN&quot;.
    /// </summary>
    [EnumMember(Value = "AGEN")]
    [IsoId("_4RHcIYoREeahcZ3Nzs1Qag")]
    [Description(@"Trading as Agent on behalf of a customer.")]
    Agent = TradingCapacityCode.Agent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading as Principal.
    /// Encoded/decoded by serializers as &quot;PRIN&quot;.
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("_4lzSsYoREeahcZ3Nzs1Qag")]
    [Description(@"Trading as Principal.")]
    Principal = TradingCapacityCode.Principal, // same ordinal as derivation source for type conversions
}
