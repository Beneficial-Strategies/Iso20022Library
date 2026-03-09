// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the collateral is to be delivered or returned.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YcMuQtp-Ed-ak6NoX_4Aeg_2021261628")]
[Description(@"Specifies if the collateral is to be delivered or returned.")]
[DerivedFrom(typeof(DeliverReturnCode))]
public enum DeliverReturn1Code
{
    /// <summary>
    /// Specifies that the collateral is to be delivered.
    /// Encoded/decoded by serializers as &quot;DELV&quot;.
    /// </summary>
    [EnumMember(Value = "DELV")]
    [IsoId("_YcMuQ9p-Ed-ak6NoX_4Aeg_1267443780")]
    [Description(@"Specifies that the collateral is to be delivered.")]
    Deliver = DeliverReturnCode.Deliver, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that the collateral is to be returned.
    /// Encoded/decoded by serializers as &quot;RETN&quot;.
    /// </summary>
    [EnumMember(Value = "RETN")]
    [IsoId("_YcMuRNp-Ed-ak6NoX_4Aeg_1710432272")]
    [Description(@"Specifies that the collateral is to be returned.")]
    Return = DeliverReturnCode.Return, // same ordinal as derivation source for type conversions
    
}
