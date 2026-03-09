// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the location of the search
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KkDnQKHoEeagRbKvRt3LnA")]
[Description(@"Specifies the location of the search")]
[DerivedFrom(typeof(LocationCode))]
public enum Location1Code
{
    /// <summary>
    /// At another institution
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_MGitsaHoEeagRbKvRt3LnA")]
    [Description(@"At another institution")]
    AtAnotherInstitution = LocationCode.AtAnotherInstitution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// At my institution.
    /// Encoded/decoded by serializers as &quot;MYIN&quot;.
    /// </summary>
    [EnumMember(Value = "MYIN")]
    [IsoId("_MbH2kqHoEeagRbKvRt3LnA")]
    [Description(@"At my institution.")]
    AtMyInstitution = LocationCode.AtMyInstitution, // same ordinal as derivation source for type conversions
    
}
