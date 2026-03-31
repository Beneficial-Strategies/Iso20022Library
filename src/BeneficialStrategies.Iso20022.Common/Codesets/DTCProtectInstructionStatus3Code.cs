// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// DTC (The Depository Trust Company) system status code of protect instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CYfP4e2MEeiWtrflKsFqHg")]
[Description(@"DTC (The Depository Trust Company) system status code of protect instruction.")]
[DerivedFrom(typeof(DTCInstructionStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DTCProtectInstructionStatus3Code>))]
#endif
public enum DTCProtectInstructionStatus3Code
{
    /// <summary>
    /// Instruction pending release or delete from approval function.
    /// Encoded/decoded by serializers as &quot;PENA&quot;.
    /// </summary>
    [EnumMember(Value = "PENA")]
    [IsoId("_DAg5Me2MEeiWtrflKsFqHg")]
    [Description(@"Instruction pending release or delete from approval function.")]
    PendingApproval = DTCInstructionStatusCode.PendingApproval, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Client instruction withdrawn for events with withdrawal privilege.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_DAg5M-2MEeiWtrflKsFqHg")]
    [Description(@"Client instruction withdrawn for events with withdrawal privilege.")]
    Withdrawn = DTCInstructionStatusCode.Withdrawn, // same ordinal as derivation source for type conversions
}
