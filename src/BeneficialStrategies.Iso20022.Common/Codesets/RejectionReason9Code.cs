// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of a rejection of an election cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZmQtotp-Ed-ak6NoX_4Aeg_1266787897")]
[Description(@"Specifies the reason of a rejection of an election cancellation request.")]
[DerivedFrom(typeof(RejectionReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RejectionReason9Code>))]
#endif
public enum RejectionReason9Code
{
    /// <summary>
    /// Cancellation is not allowed.
    /// Encoded/decoded by serializers as &quot;NCAN&quot;.
    /// </summary>
    [EnumMember(Value = "NCAN")]
    [IsoId("_ZmQto9p-Ed-ak6NoX_4Aeg_920218233")]
    [Description(@"Cancellation is not allowed.")]
    CancellationNotAllowed = RejectionReasonCode.CancellationNotAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction/Request arrives too late.
    /// Encoded/decoded by serializers as &quot;LATT&quot;.
    /// </summary>
    [EnumMember(Value = "LATT")]
    [IsoId("_ZmQtpNp-Ed-ak6NoX_4Aeg_920218264")]
    [Description(@"Instruction/Request arrives too late.")]
    Late = RejectionReasonCode.Late, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The election advice is already cancelled.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_ZmQtpdp-Ed-ak6NoX_4Aeg_920218294")]
    [Description(@"The election advice is already cancelled.")]
    ElectionAlreadyCancelled = RejectionReasonCode.ElectionAlreadyCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_ZmQtptp-Ed-ak6NoX_4Aeg_920218325")]
    [Description(@"The validation of the advice/instruction/request failed.")]
    FailedValidation = RejectionReasonCode.FailedValidation, // same ordinal as derivation source for type conversions
}
