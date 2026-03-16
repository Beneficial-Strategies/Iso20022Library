// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cancellation status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9iJXMJM7EemQB_8XA98K0Q")]
[Description(@"Specifies the cancellation status.")]
[DerivedFrom(typeof(CancellationStatusCode))]
public enum CancellationStatus5Code
{
    /// <summary>
    /// Cancellation instruction/request has been received, that is, technical validation of the message is ok, and the message is now at the receiving side.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_Ar4IQZM8EemQB_8XA98K0Q")]
    [Description(
        @"Cancellation instruction/request has been received, that is, technical validation of the message is ok, and the message is now at the receiving side."
    )]
    Received = CancellationStatusCode.Received, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation instruction / request has been received and has been acknowledged / accepted for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_EBOTcZM8EemQB_8XA98K0Q")]
    [Description(
        @"Cancellation instruction / request has been received and has been acknowledged / accepted for further processing."
    )]
    Accepted = CancellationStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation instruction/request has been sent to the next party, that is, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_ESebgZM8EemQB_8XA98K0Q")]
    [Description(
        @"Cancellation instruction/request has been sent to the next party, that is, the next intermediary."
    )]
    SentToNextParty = CancellationStatusCode.SentToNextParty, // same ordinal as derivation source for type conversions
}
