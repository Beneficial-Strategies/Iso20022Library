// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for an allegement removal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_O3cFQN8jEe-NrtAAlrBEgQ")]
[Description(@"Specifies the reason for an allegement removal.")]
[Derivations(typeof(AllegementRemovalReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AllegementRemovalReasonCode>))]
#endif
public enum AllegementRemovalReasonCode
{
    /// <summary>
    /// Allegement removed as the counterparty has cancelled its instruction.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_XuwEMN8jEe-NrtAAlrBEgQ")]
    [Description(@"Allegement removed as the counterparty has cancelled its instruction.")]
    Cancelled,

    /// <summary>
    /// Allegement removed as a matching instruction has been received.
    /// Encoded/decoded by serializers as &quot;REMO&quot;.
    /// </summary>
    [EnumMember(Value = "REMO")]
    [IsoId("_ceFhIN8jEe-NrtAAlrBEgQ")]
    [Description(@"Allegement removed as a matching instruction has been received.")]
    Removed,
}
