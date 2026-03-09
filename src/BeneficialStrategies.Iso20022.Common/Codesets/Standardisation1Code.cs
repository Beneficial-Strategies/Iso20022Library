// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the terms of the security (underlying instruments, expiration date, contract size) are defined according to the exchange specifications or whether they can be user defined.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__p7yAIQCEeeCVYNDbDZB1g")]
[Description(@"Specifies whether the terms of the security (underlying instruments, expiration date, contract size) are defined according to the exchange specifications or whether they can be user defined.")]
[DerivedFrom(typeof(StandardisationCode))]
public enum Standardisation1Code
{
    /// <summary>
    /// Derivatives defined according to exchange specifications, but certain characteristics can be user defined.
    /// Encoded/decoded by serializers as &quot;FLEX&quot;.
    /// </summary>
    [EnumMember(Value = "FLEX")]
    [IsoId("_SRUj4YQDEeeCVYNDbDZB1g")]
    [Description(@"Derivatives defined according to exchange specifications, but certain characteristics can be user defined.")]
    Flexible = StandardisationCode.Flexible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Custom-made instrument between two parties. Underlying|instruments, expiration date and contract size of the derivatives are not standardised.
    /// Encoded/decoded by serializers as &quot;NSTA&quot;.
    /// </summary>
    [EnumMember(Value = "NSTA")]
    [IsoId("_SUJOYYQDEeeCVYNDbDZB1g")]
    [Description(@"Custom-made instrument between two parties. Underlying|instruments, expiration date and contract size of the derivatives are not standardised.")]
    NonStandardised = StandardisationCode.NonStandardised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The underlying instruments, expiration date and contract size of the derivatives are standardised.
    /// Encoded/decoded by serializers as &quot;STAN&quot;.
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("_SYwooYQDEeeCVYNDbDZB1g")]
    [Description(@"The underlying instruments, expiration date and contract size of the derivatives are standardised.")]
    Standardised = StandardisationCode.Standardised, // same ordinal as derivation source for type conversions
    
}
