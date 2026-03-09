// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the margin call request was sent on a non valuation day or was received after notification time.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YdGGINp-Ed-ak6NoX_4Aeg_420355985")]
[Description(@"Specifies whether the margin call request was sent on a non valuation day or was received after notification time.")]
[Derivations(typeof(MarginCallResponse1Code))]
public enum MarginCallResponseCode
{
    /// <summary>
    /// Indicates that the margin call request was sent on a non valuation day.
    /// Encoded/decoded by serializers as &quot;NVDA&quot;.
    /// </summary>
    [EnumMember(Value = "NVDA")]
    [IsoId("_YdGGIdp-Ed-ak6NoX_4Aeg_-1089065484")]
    [Description(@"Indicates that the margin call request was sent on a non valuation day.")]
    NonValuationDay,
    
    /// <summary>
    /// Indicates that the margin call request was sent after the notification time.
    /// Encoded/decoded by serializers as &quot;RANT&quot;.
    /// </summary>
    [EnumMember(Value = "RANT")]
    [IsoId("_YdGGItp-Ed-ak6NoX_4Aeg_-1747873600")]
    [Description(@"Indicates that the margin call request was sent after the notification time.")]
    ReceivedAfterNotificationTime,
    
}
