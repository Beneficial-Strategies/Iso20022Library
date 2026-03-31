// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the processing status of a request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aKnX59p-Ed-ak6NoX_4Aeg_980305985")]
[Description(@"Specifies the processing status of a request.")]
[DerivedFrom(typeof(CorporateActionProcessedStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ProcessedStatus5Code>))]
#endif
public enum ProcessedStatus5Code
{
    /// <summary>
    /// The instruction/request has been received.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_aKxI4Np-Ed-ak6NoX_4Aeg_-1913679382")]
    [Description(@"The instruction/request has been received.")]
    Received = CorporateActionProcessedStatusCode.Received, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The request is accepted.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_aKxI4dp-Ed-ak6NoX_4Aeg_-1913679351")]
    [Description(@"The request is accepted.")]
    Accepted = CorporateActionProcessedStatusCode.Accepted, // same ordinal as derivation source for type conversions
}
