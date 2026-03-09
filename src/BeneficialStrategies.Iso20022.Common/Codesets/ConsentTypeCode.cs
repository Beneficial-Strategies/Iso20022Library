// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of consent announced.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_T9qiUCHmEeOQ7qT4JUI53A")]
[Description(@"Specifies the type of consent announced.")]
[Derivations(typeof(ConsentType1Code))]
public enum ConsentTypeCode
{
    /// <summary>
    /// Change in the terms and conditions of the bond.
    /// Encoded/decoded by serializers as &quot;CTRM&quot;.
    /// </summary>
    [EnumMember(Value = "CTRM")]
    [IsoId("_-6d_4CHmEeOQ7qT4JUI53A")]
    [Description(@"Change in the terms and conditions of the bond.")]
    ChangeInTerms,
    
    /// <summary>
    /// Change in the due and payable conditions.
    /// Encoded/decoded by serializers as &quot;DUPY&quot;.
    /// </summary>
    [EnumMember(Value = "DUPY")]
    [IsoId("_LOQFsCHnEeOQ7qT4JUI53A")]
    [Description(@"Change in the due and payable conditions.")]
    DueAndPayable,
    
}
