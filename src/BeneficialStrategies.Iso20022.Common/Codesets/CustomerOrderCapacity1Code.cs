// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Designation of the capacity of the firm placing the order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_axz6wNp-Ed-ak6NoX_4Aeg_-690589295")]
[Description(@"Designation of the capacity of the firm placing the order.")]
[DerivedFrom(typeof(CustomerOrderCapacityCode))]
public enum CustomerOrderCapacity1Code
{
    /// <summary>
    /// Member trading for their own account.
    /// Encoded/decoded by serializers as &quot;OWNE&quot;.
    /// </summary>
    [EnumMember(Value = "OWNE")]
    [IsoId("_axz6wdp-Ed-ak6NoX_4Aeg_-1833251929")]
    [Description(@"Member trading for their own account.")]
    MemberOwnAccount = CustomerOrderCapacityCode.MemberOwnAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Clearing firm trading for its proprietary account.
    /// Encoded/decoded by serializers as &quot;CLAR&quot;.
    /// </summary>
    [EnumMember(Value = "CLAR")]
    [IsoId("_axz6wtp-Ed-ak6NoX_4Aeg_-1833251887")]
    [Description(@"Clearing firm trading for its proprietary account.")]
    ClearingProprietary = CustomerOrderCapacityCode.ClearingProprietary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Member trading for another member.
    /// Encoded/decoded by serializers as &quot;OTHM&quot;.
    /// </summary>
    [EnumMember(Value = "OTHM")]
    [IsoId("_axz6w9p-Ed-ak6NoX_4Aeg_-1833251869")]
    [Description(@"Member trading for another member.")]
    MemberOtherMember = CustomerOrderCapacityCode.MemberOtherMember, // same ordinal as derivation source for type conversions
    
}
