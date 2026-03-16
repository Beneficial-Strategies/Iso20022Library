// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a whole message processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1YwhUNHCEeaokquJJ-K6uA")]
[Description(@"Specifies the status of a whole message processing.")]
[DerivedFrom(typeof(MessageStatusCode))]
public enum ReportingMessageStatus1Code
{
    /// <summary>
    /// Whole message has been accepted.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_-d9yUdHCEeaokquJJ-K6uA")]
    [Description(@"Whole message has been accepted.")]
    Accepted = MessageStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message has passed syntactical validation but further validations have not been completed yet.
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_-0GaYtHCEeaokquJJ-K6uA")]
    [Description(
        @"Message has passed syntactical validation but further validations have not been completed yet."
    )]
    AcceptedTechnicalValidation = MessageStatusCode.AcceptedTechnicalValidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message has been partially accepted. A number of transactions have been accepted, whereas another number of transactions have not yet been accepted.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_-1bQEdHCEeaokquJJ-K6uA")]
    [Description(
        @"Message has been partially accepted. A number of transactions have been accepted, whereas another number of transactions have not yet been accepted."
    )]
    PartiallyAccepted = MessageStatusCode.PartiallyAccepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message has been received but not processed yet.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_-2rNQdHCEeaokquJJ-K6uA")]
    [Description(@"Message has been received but not processed yet.")]
    Received = MessageStatusCode.Received, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_-8aB0dHCEeaokquJJ-K6uA")]
    [Description(@"Message has been rejected.")]
    Rejected = MessageStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reminder of a non received message.
    /// Encoded/decoded by serializers as &quot;RMDR&quot;.
    /// </summary>
    [EnumMember(Value = "RMDR")]
    [IsoId("__UTkctHCEeaokquJJ-K6uA")]
    [Description(@"Reminder of a non received message.")]
    Reminder = MessageStatusCode.Reminder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message has been accepted with warnings.
    /// Encoded/decoded by serializers as &quot;WARN&quot;.
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("__rYnstHCEeaokquJJ-K6uA")]
    [Description(@"Message has been accepted with warnings.")]
    Warning = MessageStatusCode.Warning, // same ordinal as derivation source for type conversions

    /// <summary>
    /// File containing the report has an incorrect filename.
    /// Encoded/decoded by serializers as &quot;INCF&quot;.
    /// </summary>
    [EnumMember(Value = "INCF")]
    [IsoId("_UanZQevBEealxoQGKU9EVQ")]
    [Description(@"File containing the report has an incorrect filename.")]
    IncorrectFilename = MessageStatusCode.IncorrectFilename, // same ordinal as derivation source for type conversions

    /// <summary>
    /// File containing the report is corrupted.
    /// Encoded/decoded by serializers as &quot;CRPT&quot;.
    /// </summary>
    [EnumMember(Value = "CRPT")]
    [IsoId("_UeMRsevBEealxoQGKU9EVQ")]
    [Description(@"File containing the report is corrupted.")]
    CorruptedFile = MessageStatusCode.CorruptedFile, // same ordinal as derivation source for type conversions
}
