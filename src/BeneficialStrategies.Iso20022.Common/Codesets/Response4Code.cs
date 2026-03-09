// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the performed service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_q8cosCxQEeW0Obqrzm1X8Q")]
[Description(@"Result of the performed service.")]
[DerivedFrom(typeof(ResponseCode))]
public enum Response4Code
{
    /// <summary>
    /// Service has been successfuly provided.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_0y2tISxQEeW0Obqrzm1X8Q")]
    [Description(@"Service has been successfuly provided.")]
    Approved = ResponseCode.Approved, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service is declined.
    /// Encoded/decoded by serializers as &quot;DECL&quot;.
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("_040yQSxQEeW0Obqrzm1X8Q")]
    [Description(@"Service is declined.")]
    Declined = ResponseCode.Declined, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service has been partialy provided.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_1HPowSxQEeW0Obqrzm1X8Q")]
    [Description(@"Service has been partialy provided.")]
    PartialApproved = ResponseCode.PartialApproved, // same ordinal as derivation source for type conversions
    
}
