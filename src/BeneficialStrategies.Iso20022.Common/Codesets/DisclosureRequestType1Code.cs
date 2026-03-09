// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of disclosure request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OQLLYEV3EemRx7jyevcLwg")]
[Description(@"Type of disclosure request.")]
[DerivedFrom(typeof(DisclosureRequestTypeCode))]
public enum DisclosureRequestType1Code
{
    /// <summary>
    /// New disclosure request.
    /// Encoded/decoded by serializers as &quot;NEWM&quot;.
    /// </summary>
    [EnumMember(Value = "NEWM")]
    [IsoId("_SWm1QUV3EemRx7jyevcLwg")]
    [Description(@"New disclosure request.")]
    New = DisclosureRequestTypeCode.New, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Disclosure request replacing a previously sent request.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_SdTTIUV3EemRx7jyevcLwg")]
    [Description(@"Disclosure request replacing a previously sent request.")]
    Replacement = DisclosureRequestTypeCode.Replacement, // same ordinal as derivation source for type conversions
    
}
