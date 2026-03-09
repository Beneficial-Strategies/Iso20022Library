// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a not available value code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hKMZUBvaEeWeg9zOuV6DZQ")]
[Description(@"Specifies a not available value code.")]
[DerivedFrom(typeof(SpecialPurposeCode))]
public enum NotAvailable1Code
{
    /// <summary>
    /// Not available (N/A).
    /// Encoded/decoded by serializers as &quot;NTAV&quot;.
    /// </summary>
    [EnumMember(Value = "NTAV")]
    [IsoId("_n4ZWsRvaEeWeg9zOuV6DZQ")]
    [Description(@"Not available (N/A).")]
    NotAvailable = SpecialPurposeCode.NotAvailable, // same ordinal as derivation source for type conversions
    
}
