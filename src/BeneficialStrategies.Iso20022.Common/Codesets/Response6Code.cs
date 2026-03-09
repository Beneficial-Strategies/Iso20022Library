// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of processing for a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IczmAFAzEeedyPuM0kK2EQ")]
[Description(@"Result of processing for a transaction.")]
[DerivedFrom(typeof(ResponseCode))]
public enum Response6Code
{
    /// <summary>
    /// Advice message could not be processed.
    /// Encoded/decoded by serializers as &quot;UNPR&quot;.
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_Q-D1YlAzEeedyPuM0kK2EQ")]
    [Description(@"Advice message could not be processed.")]
    NotProcessed = ResponseCode.NotProcessed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Processing of the service has been partially performed.
    /// Encoded/decoded by serializers as &quot;PPRC&quot;.
    /// </summary>
    [EnumMember(Value = "PPRC")]
    [IsoId("_SUWS4lAzEeedyPuM0kK2EQ")]
    [Description(@"Processing of the service has been partially performed.")]
    PartiallyProcessed = ResponseCode.PartiallyProcessed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice message is processed.
    /// Encoded/decoded by serializers as &quot;PRCS&quot;.
    /// </summary>
    [EnumMember(Value = "PRCS")]
    [IsoId("_SoIxklAzEeedyPuM0kK2EQ")]
    [Description(@"Advice message is processed.")]
    Processed = ResponseCode.Processed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service was rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_S7UzUlAzEeedyPuM0kK2EQ")]
    [Description(@"Service was rejected.")]
    Rejected = ResponseCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of processing result defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_lroQoVAzEeedyPuM0kK2EQ")]
    [Description(@"Other type of processing result defined at private level.")]
    OtherPrivate = ResponseCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of processing result defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_l31golAzEeedyPuM0kK2EQ")]
    [Description(@"Other type of processing result defined at national level.")]
    OtherNational = ResponseCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service cannot be provided for technical reason (eg timeout contacting the Issuer, security problem).
    /// Encoded/decoded by serializers as &quot;TECH&quot;.
    /// </summary>
    [EnumMember(Value = "TECH")]
    [IsoId("_PewkAaY6Eeiva6IOmhpVHw")]
    [Description(@"Service cannot be provided for technical reason (eg timeout contacting the Issuer, security problem).")]
    TechnicalError = ResponseCode.TechnicalError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service is under review.
    /// Encoded/decoded by serializers as &quot;UNRV&quot;.
    /// </summary>
    [EnumMember(Value = "UNRV")]
    [IsoId("_hEBh8WqEEemXfKijhrqa-Q")]
    [Description(@"Service is under review.")]
    UnderReview = ResponseCode.UnderReview, // same ordinal as derivation source for type conversions
    
}
