// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the processing of the message
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qSYuMNxWEeioifFt1dhnJA")]
[Description(@"Result of the processing of the message")]
[DerivedFrom(typeof(ResponseCode))]
public enum Response5Code
{
    /// <summary>
    /// Processing OK. Information related to the result of the processing is contained in other parts of the response message.
    /// Encoded/decoded by serializers as &quot;SUCC&quot;.
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_GZQ5UdxXEeioifFt1dhnJA")]
    [Description(
        @"Processing OK. Information related to the result of the processing is contained in other parts of the response message."
    )]
    Success = ResponseCode.Success, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing of the request fails for various reasons. Some further processing according to the type of requested service, the context of the process, and some additional precision about the failure notified in the ErrorCondition data element.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_Gf9-QdxXEeioifFt1dhnJA")]
    [Description(
        @"Processing of the request fails for various reasons. Some further processing according to the type of requested service, the context of the process, and some additional precision about the failure notified in the ErrorCondition data element."
    )]
    Failure = ResponseCode.Failure, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service has been partialy provided.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_G0YvEdxXEeioifFt1dhnJA")]
    [Description(@"Service has been partialy provided.")]
    PartialApproved = ResponseCode.PartialApproved, // same ordinal as derivation source for type conversions
}
