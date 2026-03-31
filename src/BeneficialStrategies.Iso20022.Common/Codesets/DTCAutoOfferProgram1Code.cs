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
[IsoId("_1pa8kjL3EeKU9IrkkToqcw_-896375538")]
[Description(
    @"Indicates what type of interface an agent has with DTC (The Depository Trust Corporation)."
)]
[DerivedFrom(typeof(DTCAutoOfferProgramCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DTCAutoOfferProgram1Code>))]
#endif
public enum DTCAutoOfferProgram1Code
{
    /// <summary>
    /// No automated interface. Hardcopy reporting required.
    /// Encoded/decoded by serializers as &quot;OFFL&quot;.
    /// </summary>
    [EnumMember(Value = "OFFL")]
    [IsoId("_1pa8kzL3EeKU9IrkkToqcw_1972857518")]
    [Description(@"No automated interface. Hardcopy reporting required.")]
    Offine = DTCAutoOfferProgramCode.Offine, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Automated interface for instruction processing is present.
    /// Encoded/decoded by serializers as &quot;ONLN&quot;.
    /// </summary>
    [EnumMember(Value = "ONLN")]
    [IsoId("_1pa8lDL3EeKU9IrkkToqcw_-2041250817")]
    [Description(@"Automated interface for instruction processing is present.")]
    Online = DTCAutoOfferProgramCode.Online, // same ordinal as derivation source for type conversions
}
