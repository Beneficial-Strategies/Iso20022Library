// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transfer or settlement instruction status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ve9hFNp-Ed-ak6NoX_4Aeg_-2123998543")]
[Description(@"Specifies the transfer or settlement instruction status.")]
[DerivedFrom(typeof(TransferStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransferStatus1Code>))]
#endif
public enum TransferStatus1Code
{
    /// <summary>
    /// Transfer or settlement instruction has been acknowledged / accepted for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_Ve9hFdp-Ed-ak6NoX_4Aeg_670907080")]
    [Description(
        @"Transfer or settlement instruction has been acknowledged / accepted for further processing."
    )]
    Accepted = TransferStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer or settlement instruction has been sent to the next party, that is, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_Ve9hFtp-Ed-ak6NoX_4Aeg_966433169")]
    [Description(
        @"Transfer or settlement instruction has been sent to the next party, that is, the next intermediary."
    )]
    SentToNextParty = TransferStatusCode.SentToNextParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer or settlement instruction is matched.
    /// Encoded/decoded by serializers as &quot;MACH&quot;.
    /// </summary>
    [EnumMember(Value = "MACH")]
    [IsoId("_Ve9hF9p-Ed-ak6NoX_4Aeg_1070790523")]
    [Description(@"Transfer or settlement instruction is matched.")]
    Matched = TransferStatusCode.Matched, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer or settlement instruction is fully executed and the confirmation is sent.
    /// Encoded/decoded by serializers as &quot;COSE&quot;.
    /// </summary>
    [EnumMember(Value = "COSE")]
    [IsoId("_Ve9hGNp-Ed-ak6NoX_4Aeg_1114195595")]
    [Description(
        @"Transfer or settlement instruction is fully executed and the confirmation is sent."
    )]
    AlreadyExecuted = TransferStatusCode.AlreadyExecuted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer cancellation instruction or settlement cancellation instruction is pending.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_VfGrANp-Ed-ak6NoX_4Aeg_1812559642")]
    [Description(
        @"Transfer cancellation instruction or settlement cancellation instruction is pending."
    )]
    CancellationPending = TransferStatusCode.CancellationPending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer or settlement instruction has been executed, confirmed and then the confirmation has been reversed.
    /// Encoded/decoded by serializers as &quot;RVSD&quot;.
    /// </summary>
    [EnumMember(Value = "RVSD")]
    [IsoId("_VfGrAdp-Ed-ak6NoX_4Aeg_-1711269451")]
    [Description(
        @"Transfer or settlement instruction has been executed, confirmed and then the confirmation has been reversed."
    )]
    Reversed = TransferStatusCode.Reversed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer or settlement instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_VfGrAtp-Ed-ak6NoX_4Aeg_287637623")]
    [Description(@"Transfer or settlement instruction has been cancelled.")]
    Cancelled = TransferStatusCode.Cancelled, // same ordinal as derivation source for type conversions
}
