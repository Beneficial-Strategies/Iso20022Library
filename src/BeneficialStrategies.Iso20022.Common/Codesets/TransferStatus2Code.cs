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
[IsoId("_YvIRVtp-Ed-ak6NoX_4Aeg_82230147")]
[Description(@"Specifies the transfer or settlement instruction status.")]
[DerivedFrom(typeof(TransferStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransferStatus2Code>))]
#endif
public enum TransferStatus2Code
{
    /// <summary>
    /// Transfer or settlement instruction has been acknowledged / accepted for further processing.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_YvIRV9p-Ed-ak6NoX_4Aeg_82230149")]
    [Description(
        @"Transfer or settlement instruction has been acknowledged / accepted for further processing."
    )]
    Accepted = TransferStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer or settlement instruction has been sent to the next party, that is, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_YvIRWNp-Ed-ak6NoX_4Aeg_82230165")]
    [Description(
        @"Transfer or settlement instruction has been sent to the next party, that is, the next intermediary."
    )]
    SentToNextParty = TransferStatusCode.SentToNextParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer or settlement instruction is matched.
    /// Encoded/decoded by serializers as &quot;MACH&quot;.
    /// </summary>
    [EnumMember(Value = "MACH")]
    [IsoId("_YvRbQNp-Ed-ak6NoX_4Aeg_82230182")]
    [Description(@"Transfer or settlement instruction is matched.")]
    Matched = TransferStatusCode.Matched, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer or settlement instruction is fully executed and the confirmation is sent.
    /// Encoded/decoded by serializers as &quot;COSE&quot;.
    /// </summary>
    [EnumMember(Value = "COSE")]
    [IsoId("_YvRbQdp-Ed-ak6NoX_4Aeg_82230200")]
    [Description(
        @"Transfer or settlement instruction is fully executed and the confirmation is sent."
    )]
    AlreadyExecuted = TransferStatusCode.AlreadyExecuted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer or settlement instruction is settled.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_YvRbQtp-Ed-ak6NoX_4Aeg_630620620")]
    [Description(@"Transfer or settlement instruction is settled.")]
    Settled = TransferStatusCode.Settled, // same ordinal as derivation source for type conversions
}
