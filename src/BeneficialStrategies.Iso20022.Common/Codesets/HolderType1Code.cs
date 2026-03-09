// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of holder.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_i8_PME4SEeiQHa-q1Uephw")]
[Description(@"Specifies a type of holder.")]
[DerivedFrom(typeof(HolderTypeCode))]
public enum HolderType1Code
{
    /// <summary>
    /// Holder is the transferee party. The transferee party may also be known as the acquiring party.
    /// Encoded/decoded by serializers as &quot;TFEE&quot;.
    /// </summary>
    [EnumMember(Value = "TFEE")]
    [IsoId("_nUYtQU4SEeiQHa-q1Uephw")]
    [Description(@"Holder is the transferee party. The transferee party may also be known as the acquiring party.")]
    Transferee = HolderTypeCode.Transferee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Holder is the transferor party. The transferee party may also be known as the ceding party.
    /// Encoded/decoded by serializers as &quot;TFOR&quot;.
    /// </summary>
    [EnumMember(Value = "TFOR")]
    [IsoId("_naLzQU4SEeiQHa-q1Uephw")]
    [Description(@"Holder is the transferor party. The transferee party may also be known as the ceding party.")]
    Transferor = HolderTypeCode.Transferor, // same ordinal as derivation source for type conversions
    
}
