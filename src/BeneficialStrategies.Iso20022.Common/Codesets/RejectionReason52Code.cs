// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the identification disclosure response has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ovWd0MAWEembi_x1QDJfxw")]
[Description(@"Specifies the reason why the identification disclosure response has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason52Code
{
    /// <summary>
    /// Disclosure request identification is invalid or unknown.
    /// Encoded/decoded by serializers as &quot;IDRI&quot;.
    /// </summary>
    [EnumMember(Value = "IDRI")]
    [IsoId("_v9mNMcAWEembi_x1QDJfxw")]
    [Description(@"Disclosure request identification is invalid or unknown.")]
    InvalidDisclosureRequestIdentification = RejectionReasonV3Code.InvalidDisclosureRequestIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Disclosure response identification is invalid or unknown.
    /// Encoded/decoded by serializers as &quot;IDRJ&quot;.
    /// </summary>
    [EnumMember(Value = "IDRJ")]
    [IsoId("_wFLb4cAWEembi_x1QDJfxw")]
    [Description(@"Disclosure response identification is invalid or unknown.")]
    InvalidDisclosureResponseIdentification = RejectionReasonV3Code.InvalidDisclosureResponseIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service for which the information was sent is not offered.
    /// Encoded/decoded by serializers as &quot;SVNO&quot;.
    /// </summary>
    [EnumMember(Value = "SVNO")]
    [IsoId("_2dH1YcAWEembi_x1QDJfxw")]
    [Description(@"Service for which the information was sent is not offered.")]
    ServiceNotOffered = RejectionReasonV3Code.ServiceNotOffered, // same ordinal as derivation source for type conversions
    
}
