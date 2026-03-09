// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of consent announced.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ux3xACHnEeOQ7qT4JUI53A")]
[Description(@"Specifies the type of consent announced.")]
[DerivedFrom(typeof(ConsentTypeCode))]
public enum ConsentType1Code
{
    /// <summary>
    /// Change in the terms and conditions of the bond.
    /// Encoded/decoded by serializers as &quot;CTRM&quot;.
    /// </summary>
    [EnumMember(Value = "CTRM")]
    [IsoId("_Wr3YgSHnEeOQ7qT4JUI53A")]
    [Description(@"Change in the terms and conditions of the bond.")]
    ChangeInTerms = ConsentTypeCode.ChangeInTerms, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change in the due and payable conditions.
    /// Encoded/decoded by serializers as &quot;DUPY&quot;.
    /// </summary>
    [EnumMember(Value = "DUPY")]
    [IsoId("_WzTdQSHnEeOQ7qT4JUI53A")]
    [Description(@"Change in the due and payable conditions.")]
    DueAndPayable = ConsentTypeCode.DueAndPayable, // same ordinal as derivation source for type conversions
    
}
