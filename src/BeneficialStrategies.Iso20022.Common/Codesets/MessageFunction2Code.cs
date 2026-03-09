// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the function of the message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TRnmlQEcEeCQm6a_G2yO_w_1237934743")]
[Description(@"Specifies the function of the message.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction2Code
{
    /// <summary>
    /// Message function is a request.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_TRnmlgEcEeCQm6a_G2yO_w_-162813602")]
    [Description(@"Message function is a request.")]
    Request = MessageFunctionCode.Request, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message function is a response.
    /// Encoded/decoded by serializers as &quot;RESP&quot;.
    /// </summary>
    [EnumMember(Value = "RESP")]
    [IsoId("_TRnmlwEcEeCQm6a_G2yO_w_218407664")]
    [Description(@"Message function is a response.")]
    Response = MessageFunctionCode.Response, // same ordinal as derivation source for type conversions
    
}
