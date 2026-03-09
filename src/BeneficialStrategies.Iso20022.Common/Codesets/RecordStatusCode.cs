// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the processing of an individual record within a message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_P8v9YNHDEeaokquJJ-K6uA")]
[Description(@"Specifies the status of the processing of an individual record within a message.")]
[Derivations(typeof(ReportingRecordStatus1Code))]
public enum RecordStatusCode
{
    /// <summary>
    /// Record has been accepted.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_iqDKAdHDEeaokquJJ-K6uA")]
    [Description(@"Record has been accepted.")]
    Accepted,
    
    /// <summary>
    /// Record has been accepted, following a pending status.
    /// Encoded/decoded by serializers as &quot;ACPD&quot;.
    /// </summary>
    [EnumMember(Value = "ACPD")]
    [IsoId("_oWERptHDEeaokquJJ-K6uA")]
    [Description(@"Record has been accepted, following a pending status.")]
    AcceptedAfterPending,
    
    /// <summary>
    /// Processing of the record is pending (some validation rules have been executed but some have not and the final status is not known yet).
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_oWERp9HDEeaokquJJ-K6uA")]
    [Description(@"Processing of the record is pending (some validation rules have been executed but some have not and the final status is not known yet).")]
    Pending,
    
    /// <summary>
    /// Recrod has been received but not processed yet.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_oWERqNHDEeaokquJJ-K6uA")]
    [Description(@"Recrod has been received but not processed yet.")]
    Received,
    
    /// <summary>
    /// Record has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_oWERqdHDEeaokquJJ-K6uA")]
    [Description(@"Record has been rejected.")]
    Rejected,
    
    /// <summary>
    /// Record has been rejected, following a pending status.
    /// Encoded/decoded by serializers as &quot;RJPD&quot;.
    /// </summary>
    [EnumMember(Value = "RJPD")]
    [IsoId("_oWERqtHDEeaokquJJ-K6uA")]
    [Description(@"Record has been rejected, following a pending status.")]
    RejectedAfterPending,
    
    /// <summary>
    /// Record has been accepted with warnings.
    /// Encoded/decoded by serializers as &quot;WARN&quot;.
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_oWERq9HDEeaokquJJ-K6uA")]
    [Description(@"Record has been accepted with warnings.")]
    Warning,
    
}
