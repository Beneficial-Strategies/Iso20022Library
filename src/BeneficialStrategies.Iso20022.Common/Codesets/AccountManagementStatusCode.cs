// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an account management instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bqlV09p-Ed-ak6NoX_4Aeg_176271984")]
[Description(@"Specifies the status of an account management instruction.")]
[Derivations(typeof(AccountManagementStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AccountManagementStatusCode>))]
#endif
public enum AccountManagementStatusCode
{
    /// <summary>
    /// The account management instruction has been received and is acknowledged.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_bqlV1Np-Ed-ak6NoX_4Aeg_1504294962")]
    [Description(@"The account management instruction has been received and is acknowledged.")]
    Received,

    /// <summary>
    /// The account management instruction has been validated and accepted.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_bqlV1dp-Ed-ak6NoX_4Aeg_1748103715")]
    [Description(@"The account management instruction has been validated and accepted.")]
    Accepted,

    /// <summary>
    /// The account management instruction is being processed and the confirmation will follow.
    /// Encoded/decoded by serializers as &quot;EXEC&quot;.
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_bqlV1tp-Ed-ak6NoX_4Aeg_1760108911")]
    [Description(
        @"The account management instruction is being processed and the confirmation will follow."
    )]
    ProcessingOngoing,

    /// <summary>
    /// The account management instruction has been sent to the next party, for example, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_bqlV19p-Ed-ak6NoX_4Aeg_1773962673")]
    [Description(
        @"The account management instruction has been sent to the next party, for example, the next intermediary."
    )]
    SentToNextParty,
}
