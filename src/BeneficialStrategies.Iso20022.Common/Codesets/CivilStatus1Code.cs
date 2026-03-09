// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the civil status of a person.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vaUrUCChEeWJd9HF2tO7BA")]
[Description(@"Specifies the civil status of a person.")]
[DerivedFrom(typeof(CivilStatusCode))]
public enum CivilStatus1Code
{
    /// <summary>
    /// Person is divorced.
    /// Encoded/decoded by serializers as &quot;DIVO&quot;.
    /// </summary>
    [EnumMember(Value = "DIVO")]
    [IsoId("_xZ1E8SChEeWJd9HF2tO7BA")]
    [Description(@"Person is divorced.")]
    Divorced = CivilStatusCode.Divorced, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Person is legally divorced.
    /// Encoded/decoded by serializers as &quot;LDIV&quot;.
    /// </summary>
    [EnumMember(Value = "LDIV")]
    [IsoId("_xhkEoSChEeWJd9HF2tO7BA")]
    [Description(@"Person is legally divorced.")]
    LegallyDivorced = CivilStatusCode.LegallyDivorced, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Person is married.
    /// Encoded/decoded by serializers as &quot;MARR&quot;.
    /// </summary>
    [EnumMember(Value = "MARR")]
    [IsoId("_xpAJYSChEeWJd9HF2tO7BA")]
    [Description(@"Person is married.")]
    Married = CivilStatusCode.Married, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Person is separated.
    /// Encoded/decoded by serializers as &quot;SEPA&quot;.
    /// </summary>
    [EnumMember(Value = "SEPA")]
    [IsoId("_xwl_ISChEeWJd9HF2tO7BA")]
    [Description(@"Person is separated.")]
    Separated = CivilStatusCode.Separated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Person is single.
    /// Encoded/decoded by serializers as &quot;SING&quot;.
    /// </summary>
    [EnumMember(Value = "SING")]
    [IsoId("_x34S4SChEeWJd9HF2tO7BA")]
    [Description(@"Person is single.")]
    Single = CivilStatusCode.Single, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Person is in a stable union.
    /// Encoded/decoded by serializers as &quot;UNIO&quot;.
    /// </summary>
    [EnumMember(Value = "UNIO")]
    [IsoId("_x6tkcSChEeWJd9HF2tO7BA")]
    [Description(@"Person is in a stable union.")]
    StableUnion = CivilStatusCode.StableUnion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Person is a widower.
    /// Encoded/decoded by serializers as &quot;WIDO&quot;.
    /// </summary>
    [EnumMember(Value = "WIDO")]
    [IsoId("_yBjMQSChEeWJd9HF2tO7BA")]
    [Description(@"Person is a widower.")]
    Widow = CivilStatusCode.Widow, // same ordinal as derivation source for type conversions
    
}
