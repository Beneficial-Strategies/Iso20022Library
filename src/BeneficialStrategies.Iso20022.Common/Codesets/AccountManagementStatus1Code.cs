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
[IsoId("_bqbk1tp-Ed-ak6NoX_4Aeg_226141002")]
[Description(@"Specifies the status of an account management instruction.")]
[DerivedFrom(typeof(AccountManagementStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AccountManagementStatus1Code>))]
#endif
public enum AccountManagementStatus1Code
{
    /// <summary>
    /// The account management instruction has been received and is acknowledged.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_bqbk19p-Ed-ak6NoX_4Aeg_1951278736")]
    [Description(@"The account management instruction has been received and is acknowledged.")]
    Received = AccountManagementStatusCode.Received, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The account management instruction has been validated and accepted.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_bqlV0Np-Ed-ak6NoX_4Aeg_1951279701")]
    [Description(@"The account management instruction has been validated and accepted.")]
    Accepted = AccountManagementStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The account management instruction is being processed and the confirmation will follow.
    /// Encoded/decoded by serializers as &quot;EXEC&quot;.
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_bqlV0dp-Ed-ak6NoX_4Aeg_1958664380")]
    [Description(
        @"The account management instruction is being processed and the confirmation will follow."
    )]
    ProcessingOngoing = AccountManagementStatusCode.ProcessingOngoing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The account management instruction has been sent to the next party, for example, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_bqlV0tp-Ed-ak6NoX_4Aeg_1958664440")]
    [Description(
        @"The account management instruction has been sent to the next party, for example, the next intermediary."
    )]
    SentToNextParty = AccountManagementStatusCode.SentToNextParty, // same ordinal as derivation source for type conversions
}
