// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a whole message processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-yEE8NHAEeaokquJJ-K6uA")]
[Description(@"Specifies the status of a whole message processing.")]
[Derivations(typeof(ReportingMessageStatus1Code),typeof(ReportingMessageStatus2Code))]
public enum MessageStatusCode
{
    /// <summary>
    /// Whole message has been accepted.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_n1aGgNHBEeaokquJJ-K6uA")]
    [Description(@"Whole message has been accepted.")]
    Accepted,
    
    /// <summary>
    /// Message has passed syntactical validation but further validations have not been completed yet.
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_uMYPodHBEeaokquJJ-K6uA")]
    [Description(@"Message has passed syntactical validation but further validations have not been completed yet.")]
    AcceptedTechnicalValidation,
    
    /// <summary>
    /// Message has been partially accepted. A number of transactions have been accepted, whereas another number of transactions have not yet been accepted.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_5SxVQdHBEeaokquJJ-K6uA")]
    [Description(@"Message has been partially accepted. A number of transactions have been accepted, whereas another number of transactions have not yet been accepted.")]
    PartiallyAccepted,
    
    /// <summary>
    /// Message has been received but not processed yet.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_72vG0dHBEeaokquJJ-K6uA")]
    [Description(@"Message has been received but not processed yet.")]
    Received,
    
    /// <summary>
    /// Message has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_9-UeYdHBEeaokquJJ-K6uA")]
    [Description(@"Message has been rejected.")]
    Rejected,
    
    /// <summary>
    /// Reminder of a non received message.
    /// Encoded/decoded by serializers as &quot;RMDR&quot;.
    /// </summary>
    [EnumMember(Value = "RMDR")]
    [IsoId("_ADeNAdHCEeaokquJJ-K6uA")]
    [Description(@"Reminder of a non received message.")]
    Reminder,
    
    /// <summary>
    /// Message has been accepted with warnings.
    /// Encoded/decoded by serializers as &quot;WARN&quot;.
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_CZx9EdHCEeaokquJJ-K6uA")]
    [Description(@"Message has been accepted with warnings.")]
    Warning,
    
    /// <summary>
    /// File containing the report is corrupted.
    /// Encoded/decoded by serializers as &quot;CRPT&quot;.
    /// </summary>
    [EnumMember(Value = "CRPT")]
    [IsoId("_IxXeM-vBEealxoQGKU9EVQ")]
    [Description(@"File containing the report is corrupted.")]
    CorruptedFile,
    
    /// <summary>
    /// File containing the report has an incorrect filename.
    /// Encoded/decoded by serializers as &quot;INCF&quot;.
    /// </summary>
    [EnumMember(Value = "INCF")]
    [IsoId("_PXYv8evBEealxoQGKU9EVQ")]
    [Description(@"File containing the report has an incorrect filename.")]
    IncorrectFilename,
    
    /// <summary>
    /// Message was rejected due to authorisation/permission issues.
    /// Encoded/decoded by serializers as &quot;NAUT&quot;.
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_g4XRYD5-Ee2Z1_pdMHu4SA")]
    [Description(@"Message was rejected due to authorisation/permission issues.")]
    NotAuthorised,
    
}
