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
[IsoId("_-6GCUN8jEe-NrtAAlrBEgQ")]
[Description(@"Specifies the reason for an allegement removal.")]
[DerivedFrom(typeof(AllegementRemovalReasonCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<AllegementRemovalReason1Code>))]
public enum AllegementRemovalReason1Code
{
    /// <summary>
    /// Allegement removed as the counterparty has cancelled its instruction.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_AzKcwd8kEe-NrtAAlrBEgQ")]
    [Description(@"Allegement removed as the counterparty has cancelled its instruction.")]
    Cancelled = AllegementRemovalReasonCode.Cancelled,

    /// <summary>
    /// Allegement removed as a matching instruction has been received.
    /// Encoded/decoded by serializers as &quot;REMO&quot;.
    /// </summary>
    [EnumMember(Value = "REMO")]
    [IsoId("_A5NaYt8kEe-NrtAAlrBEgQ")]
    [Description(@"Allegement removed as a matching instruction has been received.")]
    Removed = AllegementRemovalReasonCode.Removed,
}
