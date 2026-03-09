// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the priority level of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aKLTANp-Ed-ak6NoX_4Aeg_-636884160")]
[Description(@"Specifies the priority level of an event.")]
[DerivedFrom(typeof(PriorityCode))]
public enum Priority1Code
{
    /// <summary>
    /// Priority level is high.
    /// Encoded/decoded by serializers as &quot;HIGH&quot;.
    /// </summary>
    [EnumMember(Value = "HIGH")]
    [IsoId("_aKLTAdp-Ed-ak6NoX_4Aeg_-291486778")]
    [Description(@"Priority level is high.")]
    High = PriorityCode.High, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Priority level is normal.
    /// Encoded/decoded by serializers as &quot;NORM&quot;.
    /// </summary>
    [EnumMember(Value = "NORM")]
    [IsoId("_aKLTAtp-Ed-ak6NoX_4Aeg_-262855798")]
    [Description(@"Priority level is normal.")]
    Normal = PriorityCode.Normal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Priority level is low.
    /// Encoded/decoded by serializers as &quot;LOWW&quot;.
    /// </summary>
    [EnumMember(Value = "LOWW")]
    [IsoId("_aKLTA9p-Ed-ak6NoX_4Aeg_-248081725")]
    [Description(@"Priority level is low.")]
    Low = PriorityCode.Low, // same ordinal as derivation source for type conversions
    
}
