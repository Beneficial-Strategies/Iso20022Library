// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies blank or not available codes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UdgZYMVcEeiYpLQka876sg")]
[Description(@"Specifies blank or not available codes.")]
[DerivedFrom(typeof(SpecialPurposeCode))]
public enum SpecialPurpose2Code
{
    /// <summary>
    /// Blank value.
    /// Encoded/decoded by serializers as &quot;BLNK&quot;.
    /// </summary>
    [EnumMember(Value = "BLNK")]
    [IsoId("_V-aLccVcEeiYpLQka876sg")]
    [Description(@"Blank value.")]
    Blank = SpecialPurposeCode.Blank, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Not available (N/A).
    /// Encoded/decoded by serializers as &quot;NTAV&quot;.
    /// </summary>
    [EnumMember(Value = "NTAV")]
    [IsoId("_WJ0xQsVcEeiYpLQka876sg")]
    [Description(@"Not available (N/A).")]
    NotAvailable = SpecialPurposeCode.NotAvailable, // same ordinal as derivation source for type conversions
    
}
