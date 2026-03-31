// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) entitlement calculation logic.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1pueljL3EeKU9IrkkToqcw_678847441")]
[Description(@"Specifies DTC (The Depository Trust Company) entitlement calculation logic.")]
[Derivations(typeof(DTCMultiplyDivide1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DTCMultiplyDivideCode>))]
#endif
public enum DTCMultiplyDivideCode
{
    /// <summary>
    /// Positions multiplied by rate.
    /// Encoded/decoded by serializers as &quot;MULT&quot;.
    /// </summary>
    [EnumMember(Value = "MULT")]
    [IsoId("_1p3ogDL3EeKU9IrkkToqcw_-1315111461")]
    [Description(@"Positions multiplied by rate.")]
    Multiply,

    /// <summary>
    /// Positions divided by rate.
    /// Encoded/decoded by serializers as &quot;DVDE&quot;.
    /// </summary>
    [EnumMember(Value = "DVDE")]
    [IsoId("_1p3ogTL3EeKU9IrkkToqcw_-997320512")]
    [Description(@"Positions divided by rate.")]
    Divide,
}
