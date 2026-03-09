// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a currency is settled offshore or onshore.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Bru94Ad2EeSPHJIdUs1USg")]
[Description(@"Specifies whether a currency is settled offshore or onshore.")]
[DerivedFrom(typeof(CurrencyDesignationCode))]
public enum CurrencyDesignation1Code
{
    /// <summary>
    /// Onshore.
    /// Encoded/decoded by serializers as &quot;ONSH&quot;.
    /// </summary>
    [EnumMember(Value = "ONSH")]
    [IsoId("_D0dk8Qd2EeSPHJIdUs1USg")]
    [Description(@"Onshore.")]
    Onshore = CurrencyDesignationCode.Onshore, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offshore.
    /// Encoded/decoded by serializers as &quot;OFFS&quot;.
    /// </summary>
    [EnumMember(Value = "OFFS")]
    [IsoId("_D8gGoQd2EeSPHJIdUs1USg")]
    [Description(@"Offshore.")]
    Offshore = CurrencyDesignationCode.Offshore, // same ordinal as derivation source for type conversions
    
}
