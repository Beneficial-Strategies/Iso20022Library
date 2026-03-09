// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason of transmission of a rejection message in response to a request or an advice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVMfBgEcEeCQm6a_G2yO_w_-1586887773")]
[Description(@"Reason of transmission of a rejection message in response to a request or an advice.")]
[Derivations(typeof(RejectReason1Code),typeof(RejectReason2Code))]
public enum RejectReasonCode
{
    /// <summary>
    /// Not possible to process the message, for instance the security module is unavailable, the hardware is unavailable, or there is a problem of resource.
    /// Encoded/decoded by serializers as &quot;UNPR&quot;.
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_TVMfBwEcEeCQm6a_G2yO_w_47280885")]
    [Description(@"Not possible to process the message, for instance the security module is unavailable, the hardware is unavailable, or there is a problem of resource.")]
    UnableToProcess,
    
    /// <summary>
    /// Invalid envelope of the message.
    /// Encoded/decoded by serializers as &quot;IMSG&quot;.
    /// </summary>
    [EnumMember(Value = "IMSG")]
    [IsoId("_TVMfCAEcEeCQm6a_G2yO_w_7728196")]
    [Description(@"Invalid envelope of the message.")]
    InvalidMessage,
    
    /// <summary>
    /// Invalid message: At least one of the data element or data structure is not present, the format, or the content of one data element or one data structure is not correct.
    /// Encoded/decoded by serializers as &quot;PARS&quot;.
    /// </summary>
    [EnumMember(Value = "PARS")]
    [IsoId("_TVMfCQEcEeCQm6a_G2yO_w_-310048465")]
    [Description(@"Invalid message: At least one of the data element or data structure is not present, the format, or the content of one data element or one data structure is not correct.")]
    ParsingError,
    
    /// <summary>
    /// Security error (for example an invalid key or an incorrect MAC value).
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_TVMfCgEcEeCQm6a_G2yO_w_-400536099")]
    [Description(@"Security error (for example an invalid key or an incorrect MAC value).")]
    Security,
    
    /// <summary>
    /// Invalid identification data for the sender.
    /// Encoded/decoded by serializers as &quot;INTP&quot;.
    /// </summary>
    [EnumMember(Value = "INTP")]
    [IsoId("_TVMfCwEcEeCQm6a_G2yO_w_2050562208")]
    [Description(@"Invalid identification data for the sender.")]
    InitiatingParty,
    
    /// <summary>
    /// Invalid identification data for the the receiver.
    /// Encoded/decoded by serializers as &quot;RCPP&quot;.
    /// </summary>
    [EnumMember(Value = "RCPP")]
    [IsoId("_TVMfDAEcEeCQm6a_G2yO_w_-1919287581")]
    [Description(@"Invalid identification data for the the receiver.")]
    RecipientParty,
    
    /// <summary>
    /// Duplicate message, the identification of the exchange is the same than a previous message.
    /// Encoded/decoded by serializers as &quot;DPMG&quot;.
    /// </summary>
    [EnumMember(Value = "DPMG")]
    [IsoId("_TVMfDQEcEeCQm6a_G2yO_w_-1801416596")]
    [Description(@"Duplicate message, the identification of the exchange is the same than a previous message.")]
    DuplicateMessage,
    
    /// <summary>
    /// Version of the protocol couldn&apos;t be supported by the recipient.
    /// Encoded/decoded by serializers as &quot;VERS&quot;.
    /// </summary>
    [EnumMember(Value = "VERS")]
    [IsoId("_TVMfDgEcEeCQm6a_G2yO_w_365722857")]
    [Description(@"Version of the protocol couldn't be supported by the recipient.")]
    ProtocolVersion,
    
    /// <summary>
    /// Type of message the recipient receives is unknow or unsupported.
    /// Encoded/decoded by serializers as &quot;MSGT&quot;.
    /// </summary>
    [EnumMember(Value = "MSGT")]
    [IsoId("_TVMfDwEcEeCQm6a_G2yO_w_1443743195")]
    [Description(@"Type of message the recipient receives is unknow or unsupported.")]
    MessageType,
    
}
