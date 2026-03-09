// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the relationship between two variables.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aO8eQ9p-Ed-ak6NoX_4Aeg_1634410135")]
[Description(@"Indicates the relationship between two variables.")]
[DerivedFrom(typeof(OperationCode))]
public enum Operation1Code
{
    /// <summary>
    /// Indicates a range delimited by two variables.
    /// Encoded/decoded by serializers as &quot;TILL&quot;.
    /// </summary>
    [EnumMember(Value = "TILL")]
    [IsoId("_aO8eRNp-Ed-ak6NoX_4Aeg_-2087974128")]
    [Description(@"Indicates a range delimited by two variables.")]
    Till = OperationCode.Till, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates either of two variables is valid, but not both.
    /// Encoded/decoded by serializers as &quot;ORRR&quot;.
    /// </summary>
    [EnumMember(Value = "ORRR")]
    [IsoId("_aO8eRdp-Ed-ak6NoX_4Aeg_-2087974093")]
    [Description(@"Indicates either of two variables is valid, but not both.")]
    Or = OperationCode.Or, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that only when both variables are given, the operation is valid.
    /// Encoded/decoded by serializers as &quot;ANDD&quot;.
    /// </summary>
    [EnumMember(Value = "ANDD")]
    [IsoId("_aO8eRtp-Ed-ak6NoX_4Aeg_-2087974033")]
    [Description(@"Indicates that only when both variables are given, the operation is valid.")]
    And = OperationCode.And, // same ordinal as derivation source for type conversions
    
}
