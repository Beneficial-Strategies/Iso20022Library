// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of standing order, such as a user defined standing order or a predefined liquidity transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8OFBU6MgEeCJ6YNENx4h-w_-143150650")]
[Description(
    @"Specifies the type of standing order, such as a user defined standing order or a predefined liquidity transfer."
)]
[DerivedFrom(typeof(StandingOrderTypeCode))]
public enum StandingOrderType1Code
{
    /// <summary>
    /// Liquidity transfer standing order type, that has been customised or defined to the specific need of the user.
    /// Encoded/decoded by serializers as &quot;USTO&quot;.
    /// </summary>
    [EnumMember(Value = "USTO")]
    [IsoId("_8OFBVKMgEeCJ6YNENx4h-w_1846866247")]
    [Description(
        @"Liquidity transfer standing order type, that has been customised or defined to the specific need of the user."
    )]
    UserDefinedStandingOrder = StandingOrderTypeCode.UserDefinedStandingOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Liquidity transfer standing order type, as predefined in the system.
    /// Encoded/decoded by serializers as &quot;PSTO&quot;.
    /// </summary>
    [EnumMember(Value = "PSTO")]
    [IsoId("_8OFBVaMgEeCJ6YNENx4h-w_328114765")]
    [Description(@"Liquidity transfer standing order type, as predefined in the system.")]
    PredefinedStandingOrder = StandingOrderTypeCode.PredefinedStandingOrder, // same ordinal as derivation source for type conversions
}
