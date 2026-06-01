// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Context of a party verification service, in a codified form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8De4wIVWEe-IQaB-yw3sIw")]
[Description(@"Context of a party verification service, in a codified form.")]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PartyVerificationScopeCode>))]
public enum PartyVerificationScopeCode
{
    /// <summary>
    /// Verification is in scope of a credit transfer process.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_QLqvAIVXEe-IQaB-yw3sIw")]
    [Description(@"Verification is in scope of a credit transfer process.")]
    CreditTransfer,

    /// <summary>
    /// Verification is in scope of a direct debit process.
    /// Encoded/decoded by serializers as &quot;DDEB&quot;.
    /// </summary>
    [EnumMember(Value = "DDEB")]
    [IsoId("_075VkIVXEe-IQaB-yw3sIw")]
    [Description(@"Verification is in scope of a direct debit process.")]
    DirectDebit,

    /// <summary>
    /// Verification is in scope of a different process than those covered by the other codes.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Dp1JoIVYEe-IQaB-yw3sIw")]
    [Description(@"Verification is in scope of a different process than those covered by the other codes.")]
    Other,

    /// <summary>
    /// Verification is in scope of a party account registration or maintenance process.
    /// Encoded/decoded by serializers as &quot;REGI&quot;.
    /// </summary>
    [EnumMember(Value = "REGI")]
    [IsoId("_59MsQIVXEe-IQaB-yw3sIw")]
    [Description(@"Verification is in scope of a party account registration or maintenance process.")]
    Registration,
}
