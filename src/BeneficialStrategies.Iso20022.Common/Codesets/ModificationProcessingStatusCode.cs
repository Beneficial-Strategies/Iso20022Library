// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jQp0g-5NEeCisYr99QEiWA_266324205")]
[Description(@"Specifies the status of a cancellation request.")]
[Derivations(typeof(ModificationProcessingStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ModificationProcessingStatusCode>))]
#endif
public enum ModificationProcessingStatusCode
{
    /// <summary>
    /// Modification has been completed.
    /// Encoded/decoded by serializers as &quot;MODC&quot;.
    /// </summary>
    [EnumMember(Value = "MODC")]
    [IsoId("_jQp0hO5NEeCisYr99QEiWA_152485139")]
    [Description(@"Modification has been completed.")]
    Completed,

    /// <summary>
    /// Modification is pending. It is not known at this time whether modified can be executed.
    /// Encoded/decoded by serializers as &quot;MODP&quot;.
    /// </summary>
    [EnumMember(Value = "MODP")]
    [IsoId("_jQzlgO5NEeCisYr99QEiWA_874616089")]
    [Description(
        @"Modification is pending. It is not known at this time whether modified can be executed."
    )]
    Pending,

    /// <summary>
    /// Modification will not be executed.
    /// Encoded/decoded by serializers as &quot;DEND&quot;.
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_jQzlge5NEeCisYr99QEiWA_-1727820501")]
    [Description(@"Modification will not be executed.")]
    Denied,

    /// <summary>
    /// Modification request has been acknowledged for further processing by the account servicer.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_jQzlgu5NEeCisYr99QEiWA_751120761")]
    [Description(
        @"Modification request has been acknowledged for further processing by the account servicer."
    )]
    Accepted,

    /// <summary>
    /// Modification has been rejected for further processing.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_jQzlg-5NEeCisYr99QEiWA_-359790658")]
    [Description(@"Modification has been rejected for further processing.")]
    Rejected,

    /// <summary>
    /// Modification request is in repair.
    /// Encoded/decoded by serializers as &quot;REPR&quot;.
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_jQzlhO5NEeCisYr99QEiWA_-1534981683")]
    [Description(@"Modification request is in repair.")]
    InRepair,
}
