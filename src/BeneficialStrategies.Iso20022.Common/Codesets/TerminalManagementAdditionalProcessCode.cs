// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Additional process to perform before starting or after completing a terminal management action.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KUh0kn1DEeCF8NjrBemJWQ_-888899515")]
[Description(
    @"Additional process to perform before starting or after completing a terminal management action."
)]
[Derivations(typeof(TerminalManagementAdditionalProcess1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TerminalManagementAdditionalProcessCode>))]
#endif
public enum TerminalManagementAdditionalProcessCode
{
    /// <summary>
    /// Manual confirmation of the merchant before the terminal management action.
    /// Encoded/decoded by serializers as &quot;MANC&quot;.
    /// </summary>
    [EnumMember(Value = "MANC")]
    [IsoId("_KUh0k31DEeCF8NjrBemJWQ_1927674034")]
    [Description(@"Manual confirmation of the merchant before the terminal management action.")]
    ManualConfirmation,

    /// <summary>
    /// Acquirer reconciliation to be performed before the terminal management action.
    /// Encoded/decoded by serializers as &quot;RCNC&quot;.
    /// </summary>
    [EnumMember(Value = "RCNC")]
    [IsoId("_KUh0lH1DEeCF8NjrBemJWQ_-2075335524")]
    [Description(@"Acquirer reconciliation to be performed before the terminal management action.")]
    Reconciliation,

    /// <summary>
    /// Restart the system after performing the terminal management action.
    /// Encoded/decoded by serializers as &quot;RSRT&quot;.
    /// </summary>
    [EnumMember(Value = "RSRT")]
    [IsoId("_KUh0lX1DEeCF8NjrBemJWQ_-765156131")]
    [Description(@"Restart the system after performing the terminal management action.")]
    RestartSystem,
}
