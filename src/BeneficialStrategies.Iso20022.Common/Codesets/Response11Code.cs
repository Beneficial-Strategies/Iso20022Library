// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the processing of the message
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Tya4MS8NEeu125Ip9zFcsQ")]
[Description(@"Result of the processing of the message")]
[DerivedFrom(typeof(ResponseCode))]
public enum Response11Code
{
    /// <summary>
    /// An additional Response Code, mainly a functional one, should be considered to identify the outcome of the request.
    /// Encoded/decoded by serializers as &quot;WARN&quot;.
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_UGttMS8NEeu125Ip9zFcsQ")]
    [Description(
        @"An additional Response Code, mainly a functional one, should be considered to identify the outcome of the request."
    )]
    Warning = ResponseCode.Warning, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing of the request fails for various reasons. Some further processing according to the type of requested service, the context of the process, and some additional precision about the failure notified in the ErrorCondition data element.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_UGttMy8NEeu125Ip9zFcsQ")]
    [Description(
        @"Processing of the request fails for various reasons. Some further processing according to the type of requested service, the context of the process, and some additional precision about the failure notified in the ErrorCondition data element."
    )]
    Failure = ResponseCode.Failure, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing OK. Information related to the result of the processing is contained in other parts of the response message.
    /// Encoded/decoded by serializers as &quot;SUCC&quot;.
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_ZqPAIS8NEeu125Ip9zFcsQ")]
    [Description(
        @"Processing OK. Information related to the result of the processing is contained in other parts of the response message."
    )]
    Success = ResponseCode.Success, // same ordinal as derivation source for type conversions
}
