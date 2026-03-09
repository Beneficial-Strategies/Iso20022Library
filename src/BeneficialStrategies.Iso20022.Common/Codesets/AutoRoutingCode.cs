// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether an automatic routing system is involved.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bj4Q59p-Ed-ak6NoX_4Aeg_686608073")]
[Description(@"Indicates whether an automatic routing system is involved.")]
[Derivations(typeof(AutoRouting1Code))]
public enum AutoRoutingCode
{
    /// <summary>
    /// Indicates the Designated Order Turnaround system: computerized order routing system (used at the New York Stock Exchange) is to be used.
    /// Encoded/decoded by serializers as &quot;DDOT&quot;.
    /// </summary>
    [EnumMember(Value = "DDOT")]
    [IsoId("_bkBa0Np-Ed-ak6NoX_4Aeg_1056016458")]
    [Description(@"Indicates the Designated Order Turnaround system: computerized order routing system (used at the New York Stock Exchange) is to be used.")]
    DOTSystem,
    
    /// <summary>
    /// Indicates the evolution of the DOT system, a Designated Order Turnaround system: computerized order routing system (used at the New York Stock Exchange) is to be used.
    /// Encoded/decoded by serializers as &quot;SDOT&quot;.
    /// </summary>
    [EnumMember(Value = "SDOT")]
    [IsoId("_bkBa0dp-Ed-ak6NoX_4Aeg_1056016502")]
    [Description(@"Indicates the evolution of the DOT system, a Designated Order Turnaround system: computerized order routing system (used at the New York Stock Exchange) is to be used.")]
    SuperDOTSystem,
    
}
