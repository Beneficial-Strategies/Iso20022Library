// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates what type of interface an agent has with DTC (The Depository Trust Corporation).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1oFf0DL3EeKU9IrkkToqcw_-1688796996")]
[Description(
    @"Indicates what type of interface an agent has with DTC (The Depository Trust Corporation)."
)]
[Derivations(typeof(DTCAutoOfferProgram1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DTCAutoOfferProgramCode>))]
#endif
public enum DTCAutoOfferProgramCode
{
    /// <summary>
    /// No automated interface. Hardcopy reporting required.
    /// Encoded/decoded by serializers as &quot;OFFL&quot;.
    /// </summary>
    [EnumMember(Value = "OFFL")]
    [IsoId("_1oFf0TL3EeKU9IrkkToqcw_413864714")]
    [Description(@"No automated interface. Hardcopy reporting required.")]
    Offine,

    /// <summary>
    /// Automated interface for instruction processing is present.
    /// Encoded/decoded by serializers as &quot;ONLN&quot;.
    /// </summary>
    [EnumMember(Value = "ONLN")]
    [IsoId("_1oFf0jL3EeKU9IrkkToqcw_-1859526812")]
    [Description(@"Automated interface for instruction processing is present.")]
    Online,
}
