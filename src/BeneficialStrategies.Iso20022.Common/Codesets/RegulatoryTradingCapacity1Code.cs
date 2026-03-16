// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regulatory trading capacity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_905ZYO8bEeSLA89yUYsVSw")]
[Description(@"Specifies the regulatory trading capacity.")]
[DerivedFrom(typeof(RegulatoryTradingCapacityCode))]
public enum RegulatoryTradingCapacity1Code
{
    /// <summary>
    /// Transaction was carried out as a matched principal trading.
    /// Encoded/decoded by serializers as &quot;MTCH&quot;.
    /// </summary>
    [EnumMember(Value = "MTCH")]
    [IsoId("_Am-fce8cEeSLA89yUYsVSw")]
    [Description(@"Transaction was carried out as a matched principal trading.")]
    MatchedPrincipal = RegulatoryTradingCapacityCode.MatchedPrincipal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction was carried out as a deal under own account.
    /// Encoded/decoded by serializers as &quot;DEAL&quot;.
    /// </summary>
    [EnumMember(Value = "DEAL")]
    [IsoId("_AuSBUe8cEeSLA89yUYsVSw")]
    [Description(@"Transaction was carried out as a deal under own account.")]
    DealOnOwnAccount = RegulatoryTradingCapacityCode.DealOnOwnAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction was carried out as an agent.
    /// Encoded/decoded by serializers as &quot;AOTC&quot;.
    /// </summary>
    [EnumMember(Value = "AOTC")]
    [IsoId("_A1hRwe8cEeSLA89yUYsVSw")]
    [Description(@"Transaction was carried out as an agent.")]
    AnyOtherCapacity = RegulatoryTradingCapacityCode.AnyOtherCapacity, // same ordinal as derivation source for type conversions
}
