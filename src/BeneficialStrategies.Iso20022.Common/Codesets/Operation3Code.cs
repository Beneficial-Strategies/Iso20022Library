// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an AND or an OR operator.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mec4cNGyEeaokquJJ-K6uA")]
[Description(@"Specifies an AND or an OR operator.")]
[DerivedFrom(typeof(OperationV2Code))]
public enum Operation3Code
{
    /// <summary>
    /// Indicates that only when all if all of its elements are valid, the whole expression is valid.
    /// Encoded/decoded by serializers as &quot;ANDD&quot;.
    /// </summary>
    [EnumMember(Value = "ANDD")]
    [IsoId("_zxpM0dGyEeaokquJJ-K6uA")]
    [Description(@"Indicates that only when all if all of its elements are valid, the whole expression is valid.")]
    And = OperationV2Code.And, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that when at least one of its elements is valid, the whole expression is valid.
    /// Encoded/decoded by serializers as &quot;ORRR&quot;.
    /// </summary>
    [EnumMember(Value = "ORRR")]
    [IsoId("_0EAIItGyEeaokquJJ-K6uA")]
    [Description(@"Indicates that when at least one of its elements is valid, the whole expression is valid.")]
    Or = OperationV2Code.Or, // same ordinal as derivation source for type conversions
    
}
