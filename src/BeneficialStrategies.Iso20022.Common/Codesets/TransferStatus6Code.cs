// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a transfer or settlement instruction status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zBEicLshEeiTr4dQrTCaYA")]
[Description(@"Specifies a transfer or settlement instruction status.")]
[DerivedFrom(typeof(TransferStatusCode))]
public enum TransferStatus6Code
{
    /// <summary>
    /// Transfer or settlement instruction has been acknowledged / accepted for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_0cRVIbshEeiTr4dQrTCaYA")]
    [Description(
        @"Transfer or settlement instruction has been acknowledged / accepted for further processing."
    )]
    Accepted = TransferStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer or settlement instruction is fully executed and the confirmation is sent.
    /// Encoded/decoded by serializers as &quot;COSE&quot;.
    /// </summary>
    [EnumMember(Value = "COSE")]
    [IsoId("_0i9zAbshEeiTr4dQrTCaYA")]
    [Description(
        @"Transfer or settlement instruction is fully executed and the confirmation is sent."
    )]
    AlreadyExecuted = TransferStatusCode.AlreadyExecuted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Portfolio transfer is complete.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_1B6Y0bshEeiTr4dQrTCaYA")]
    [Description(@"Portfolio transfer is complete.")]
    Complete = TransferStatusCode.Complete, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer or settlement instruction is delayed.
    /// Encoded/decoded by serializers as &quot;DELY&quot;.
    /// </summary>
    [EnumMember(Value = "DELY")]
    [IsoId("_1IBA0bshEeiTr4dQrTCaYA")]
    [Description(@"Transfer or settlement instruction is delayed.")]
    Delayed = TransferStatusCode.Delayed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer or settlement instruction is matched.
    /// Encoded/decoded by serializers as &quot;MACH&quot;.
    /// </summary>
    [EnumMember(Value = "MACH")]
    [IsoId("_1kSGEbshEeiTr4dQrTCaYA")]
    [Description(@"Transfer or settlement instruction is matched.")]
    Matched = TransferStatusCode.Matched, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been received, that is, technical validation of the message is ok, and the message is now at the receiving side.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_1wxp8bshEeiTr4dQrTCaYA")]
    [Description(
        @"Instruction has been received, that is, technical validation of the message is ok, and the message is now at the receiving side."
    )]
    Received = TransferStatusCode.Received, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer or settlement instruction has been sent to the next party, that is, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_59ds0bshEeiTr4dQrTCaYA")]
    [Description(
        @"Transfer or settlement instruction has been sent to the next party, that is, the next intermediary."
    )]
    SentToNextParty = TransferStatusCode.SentToNextParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer or settlement instruction is settled.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_6FfncbshEeiTr4dQrTCaYA")]
    [Description(@"Transfer or settlement instruction is settled.")]
    Settled = TransferStatusCode.Settled, // same ordinal as derivation source for type conversions
}
