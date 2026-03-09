// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a whole message processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WlAyQT5-Ee2Z1_pdMHu4SA")]
[Description(@"Specifies the status of a whole message processing.")]
[DerivedFrom(typeof(MessageStatusCode))]
public enum ReportingMessageStatus2Code
{
    /// <summary>
    /// Whole message has been accepted.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_Wl48AT5-Ee2Z1_pdMHu4SA")]
    [Description(@"Whole message has been accepted.")]
    Accepted = MessageStatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_Wl48CT5-Ee2Z1_pdMHu4SA")]
    [Description(@"Message has been rejected.")]
    Rejected = MessageStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// File containing the report has an incorrect filename.
    /// Encoded/decoded by serializers as &quot;INCF&quot;.
    /// </summary>
    [EnumMember(Value = "INCF")]
    [IsoId("_Wl48Dz5-Ee2Z1_pdMHu4SA")]
    [Description(@"File containing the report has an incorrect filename.")]
    IncorrectFilename = MessageStatusCode.IncorrectFilename, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// File containing the report is corrupted.
    /// Encoded/decoded by serializers as &quot;CRPT&quot;.
    /// </summary>
    [EnumMember(Value = "CRPT")]
    [IsoId("_Wl48ET5-Ee2Z1_pdMHu4SA")]
    [Description(@"File containing the report is corrupted.")]
    CorruptedFile = MessageStatusCode.CorruptedFile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message was rejected due to authorisation/permission issues.
    /// Encoded/decoded by serializers as &quot;NAUT&quot;.
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_zlZYQT5-Ee2Z1_pdMHu4SA")]
    [Description(@"Message was rejected due to authorisation/permission issues.")]
    NotAuthorised = MessageStatusCode.NotAuthorised, // same ordinal as derivation source for type conversions
    
}
