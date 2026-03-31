// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Response codes for verification
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gImmcPBkEeesZ516Jn5sHw")]
[Description(@"Response codes for verification")]
[DerivedFrom(typeof(ResponseCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Response10Code>))]
#endif
public enum Response10Code
{
    /// <summary>
    /// Request is still in progress.
    /// Encoded/decoded by serializers as &quot;INPS&quot;.
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_SpLhgX0mEemfrNOe0zHQyg")]
    [Description(@"Request is still in progress.")]
    InProgress = ResponseCode.InProgress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service is under review.
    /// Encoded/decoded by serializers as &quot;UNRV&quot;.
    /// </summary>
    [EnumMember(Value = "UNRV")]
    [IsoId("_SpLhg30mEemfrNOe0zHQyg")]
    [Description(@"Service is under review.")]
    UnderReview = ResponseCode.UnderReview, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of processing result defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_SpLhhX0mEemfrNOe0zHQyg")]
    [Description(@"Other type of processing result defined at private level.")]
    OtherPrivate = ResponseCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of processing result defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_SpLhh30mEemfrNOe0zHQyg")]
    [Description(@"Other type of processing result defined at national level.")]
    OtherNational = ResponseCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing of the request fails for various reasons. Some further processing according to the type of requested service, the context of the process, and some additional precision about the failure notified in the ErrorCondition data element.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_bt7vcX06Eem0U9m89kippg")]
    [Description(
        @"Processing of the request fails for various reasons. Some further processing according to the type of requested service, the context of the process, and some additional precision about the failure notified in the ErrorCondition data element."
    )]
    Failure = ResponseCode.Failure, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing OK. Information related to the result of the processing is contained in other parts of the response message.
    /// Encoded/decoded by serializers as &quot;SUCC&quot;.
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_cQcmoX06Eem0U9m89kippg")]
    [Description(
        @"Processing OK. Information related to the result of the processing is contained in other parts of the response message."
    )]
    Success = ResponseCode.Success, // same ordinal as derivation source for type conversions
}
