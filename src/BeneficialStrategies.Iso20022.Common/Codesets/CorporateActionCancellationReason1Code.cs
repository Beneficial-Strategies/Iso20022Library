// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies reasons for cancellation of a corporate action event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bCpME9p-Ed-ak6NoX_4Aeg_-232047484")]
[Description(@"Specifies reasons for cancellation of a corporate action event.")]
[DerivedFrom(typeof(CorporateActionCancellationReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionCancellationReason1Code>))]
#endif
public enum CorporateActionCancellationReason1Code
{
    /// <summary>
    /// Cancellation due to the corporate action event being cancelled by the issuer.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_bCpMFNp-Ed-ak6NoX_4Aeg_-232047422")]
    [Description(@"Cancellation due to the corporate action event being cancelled by the issuer.")]
    Withrawal = CorporateActionCancellationReasonCode.Withrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation due to a processing error.
    /// Encoded/decoded by serializers as &quot;PROC&quot;.
    /// </summary>
    [EnumMember(Value = "PROC")]
    [IsoId("_bCpMFdp-Ed-ak6NoX_4Aeg_167838210")]
    [Description(@"Cancellation due to a processing error.")]
    Processing = CorporateActionCancellationReasonCode.Processing, // same ordinal as derivation source for type conversions
}
