// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Designation of the capacity of the firm placing the order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_axz6xNp-Ed-ak6NoX_4Aeg_335336023")]
[Description(@"Designation of the capacity of the firm placing the order.")]
[Derivations(typeof(CustomerOrderCapacity1Code))]
public enum CustomerOrderCapacityCode
{
    /// <summary>
    /// Member trading for their own account.
    /// Encoded/decoded by serializers as &quot;OWNE&quot;.
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("_axz6xdp-Ed-ak6NoX_4Aeg_335336024")]
    [Description(@"Member trading for their own account.")]
    MemberOwnAccount,
    
    /// <summary>
    /// Clearing firm trading for its proprietary account.
    /// Encoded/decoded by serializers as &quot;CLAR&quot;.
    /// </summary>
    [EnumMember(Value = "CLAR")]
    [IsoId("_axz6xtp-Ed-ak6NoX_4Aeg_335336025")]
    [Description(@"Clearing firm trading for its proprietary account.")]
    ClearingProprietary,
    
    /// <summary>
    /// Member trading for another member.
    /// Encoded/decoded by serializers as &quot;OTHM&quot;.
    /// </summary>
    [EnumMember(Value = "OTHM")]
    [IsoId("_axz6x9p-Ed-ak6NoX_4Aeg_335336026")]
    [Description(@"Member trading for another member.")]
    MemberOtherMember,
    
}
