// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an entry in a report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sjRYp0irEeSlHoYg_EudVQ")]
[Description(@"Specifies the status of an entry in a report.")]
[Derivations(typeof(ReportItemStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ReportItemStatusCode>))]
#endif
public enum ReportItemStatusCode
{
    /// <summary>
    /// Entry has been accepted with exceptions by the receiver of the report.
    /// Encoded/decoded by serializers as &quot;ACWE&quot;.
    /// </summary>
    [EnumMember(Value = "ACWE")]
    [IsoId("_sjRYqkirEeSlHoYg_EudVQ")]
    [Description(@"Entry has been accepted with exceptions by the receiver of the report.")]
    AcceptedWithException,

    /// <summary>
    /// Entry has been rejected by the receiver of the report.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_sjRYqEirEeSlHoYg_EudVQ")]
    [Description(@"Entry has been rejected by the receiver of the report.")]
    Rejected,

    /// <summary>
    /// Entry has been accepted by the receiver of the report.
    /// Encoded/decoded by serializers as &quot;ACPD&quot;.
    /// </summary>
    [EnumMember(Value = "ACPD")]
    [IsoId("_Ff6cYUisEeSlHoYg_EudVQ")]
    [Description(@"Entry has been accepted by the receiver of the report.")]
    Accepted,
}
