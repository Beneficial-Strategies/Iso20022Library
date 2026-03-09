// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cancellation status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a0VqU9p-Ed-ak6NoX_4Aeg_453220269")]
[Description(@"Specifies the cancellation status.")]
[Derivations(typeof(CancellationStatus5Code),typeof(CancellationStatus4Code),typeof(CancellationStatus6Code),typeof(CancellationStatus1Code),typeof(CancellationStatus2Code),typeof(CancellationStatus3Code))]
public enum CancellationStatusCode
{
    /// <summary>
    /// Cancellation instruction/request has been sent to the next party, that is, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_a0VqVNp-Ed-ak6NoX_4Aeg_1086756710")]
    [Description(@"Cancellation instruction/request has been sent to the next party, that is, the next intermediary.")]
    SentToNextParty,
    
    /// <summary>
    /// Cancellation instruction / request has been received and has been acknowledged / accepted for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_a0VqVdp-Ed-ak6NoX_4Aeg_1230826484")]
    [Description(@"Cancellation instruction / request has been received and has been acknowledged / accepted for further processing.")]
    Accepted,
    
    /// <summary>
    /// Cancellation instruction / request is pending. It is not known at this time whether cancellation can be effected.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_a0VqVtp-Ed-ak6NoX_4Aeg_1301014139")]
    [Description(@"Cancellation instruction / request is pending. It is not known at this time whether cancellation can be effected.")]
    Pending,
    
    /// <summary>
    /// Cancellation instruction / request has been accepted and processed, the cancellation is complete.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_a0VqV9p-Ed-ak6NoX_4Aeg_-57487758")]
    [Description(@"Cancellation instruction / request has been accepted and processed, the cancellation is complete.")]
    Complete,
    
    /// <summary>
    /// Cancellation instruction / request has been rejected / denied for further processing.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_a0VqWNp-Ed-ak6NoX_4Aeg_1717519571")]
    [Description(@"Cancellation instruction / request has been rejected / denied for further processing.")]
    Rejected,
    
    /// <summary>
    /// Cancellation instruction / request has been received by issuer or registrar.
    /// Encoded/decoded by serializers as &quot;RCIS&quot;.
    /// </summary>
    [EnumMember(Value = "RCIS")]
    [IsoId("_a0fbUNp-Ed-ak6NoX_4Aeg_1947831859")]
    [Description(@"Cancellation instruction / request has been received by issuer or registrar.")]
    ReceivedByIssuerOrRegistrar,
    
    /// <summary>
    /// Cancellation instruction/request has been received, that is, technical validation of the message is ok, and the message is now at the receiving side.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_K7nvMJM7EemKz5EOjv82iQ")]
    [Description(@"Cancellation instruction/request has been received, that is, technical validation of the message is ok, and the message is now at the receiving side.")]
    Received,
    
}
