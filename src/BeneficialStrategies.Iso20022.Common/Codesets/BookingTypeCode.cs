// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Method for booking out an order. Used when notifying a broker that an order to be settled by that broker is to be booked out as an OTC derivative (e.g. CFD or similar).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bU-SMtp-Ed-ak6NoX_4Aeg_-1785739759")]
[Description(
    @"Method for booking out an order. Used when notifying a broker that an order to be settled by that broker is to be booked out as an OTC derivative (e.g. CFD or similar)."
)]
[Derivations(typeof(BookingType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BookingTypeCode>))]
#endif
public enum BookingTypeCode
{
    /// <summary>
    /// Booking type is regular.
    /// Encoded/decoded by serializers as &quot;REGU&quot;.
    /// </summary>
    [EnumMember(Value = "REGU")]
    [IsoId("_bU-SM9p-Ed-ak6NoX_4Aeg_-1429261582")]
    [Description(@"Booking type is regular.")]
    Regular,

    /// <summary>
    /// Order is to be booked out as a CFD.
    /// Encoded/decoded by serializers as &quot;CFOD&quot;.
    /// </summary>
    [EnumMember(Value = "CFOD")]
    [IsoId("_bU-SNNp-Ed-ak6NoX_4Aeg_-1344295757")]
    [Description(@"Order is to be booked out as a CFD.")]
    ContractForDifference,

    /// <summary>
    /// Order is to be booked out as an OTC derivative (for example, Swap).
    /// Encoded/decoded by serializers as &quot;TRSW&quot;.
    /// </summary>
    [EnumMember(Value = "TRSW")]
    [IsoId("_bU-SNdp-Ed-ak6NoX_4Aeg_-999825381")]
    [Description(@"Order is to be booked out as an OTC derivative (for example, Swap).")]
    TotalReturnSwap,
}
