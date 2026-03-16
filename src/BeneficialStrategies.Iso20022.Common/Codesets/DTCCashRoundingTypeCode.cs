// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies types of cash rounding.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1sQOJjL3EeKU9IrkkToqcw_321509472")]
[Description(@"Specifies types of cash rounding.")]
[Derivations(typeof(DTCCashRoundingType1Code))]
public enum DTCCashRoundingTypeCode
{
    /// <summary>
    /// Round down to the nearest cent.
    /// Encoded/decoded by serializers as &quot;RDNC&quot;.
    /// </summary>
    [EnumMember(Value = "RDNC")]
    [IsoId("_1sZ_IDL3EeKU9IrkkToqcw_-232119891")]
    [Description(@"Round down to the nearest cent.")]
    RoundDownToTheNearestCent,

    /// <summary>
    /// Round down to the nearest dollar.
    /// Encoded/decoded by serializers as &quot;RDND&quot;.
    /// </summary>
    [EnumMember(Value = "RDND")]
    [IsoId("_1sZ_ITL3EeKU9IrkkToqcw_1453354338")]
    [Description(@"Round down to the nearest dollar.")]
    RoundDownToTheNearestDollar,

    /// <summary>
    /// Round up to the nearest cent.
    /// Encoded/decoded by serializers as &quot;RUNC&quot;.
    /// </summary>
    [EnumMember(Value = "RUNC")]
    [IsoId("_1sZ_IjL3EeKU9IrkkToqcw_1668730619")]
    [Description(@"Round up to the nearest cent.")]
    RoundUpToTheNearestCent,

    /// <summary>
    /// Round up to the nearest dollar.
    /// Encoded/decoded by serializers as &quot;RUND&quot;.
    /// </summary>
    [EnumMember(Value = "RUND")]
    [IsoId("_1sZ_IzL3EeKU9IrkkToqcw_-1607281533")]
    [Description(@"Round up to the nearest dollar.")]
    RoundUpToTheNearestDollar,
}
