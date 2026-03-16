// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Method for booking out an order. Used when notifying a broker that an order to be settled by that broker is to be booked out as an Over The Counter derivative (for example, Contract For Difference - CFD or similar).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bU1IRdp-Ed-ak6NoX_4Aeg_909907363")]
[Description(
    @"Method for booking out an order. Used when notifying a broker that an order to be settled by that broker is to be booked out as an Over The Counter derivative (for example, Contract For Difference - CFD or similar)."
)]
[DerivedFrom(typeof(BookingTypeCode))]
public enum BookingType1Code
{
    /// <summary>
    /// Booking type is regular.
    /// Encoded/decoded by serializers as &quot;REGU&quot;.
    /// </summary>
    [EnumMember(Value = "REGU")]
    [IsoId("_bU1IRtp-Ed-ak6NoX_4Aeg_-626502093")]
    [Description(@"Booking type is regular.")]
    Regular = BookingTypeCode.Regular, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is to be booked out as a CFD.
    /// Encoded/decoded by serializers as &quot;CFOD&quot;.
    /// </summary>
    [EnumMember(Value = "CFOD")]
    [IsoId("_bU-SMNp-Ed-ak6NoX_4Aeg_-626502041")]
    [Description(@"Order is to be booked out as a CFD.")]
    ContractForDifference = BookingTypeCode.ContractForDifference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is to be booked out as an OTC derivative (for example, Swap).
    /// Encoded/decoded by serializers as &quot;TRSW&quot;.
    /// </summary>
    [EnumMember(Value = "TRSW")]
    [IsoId("_bU-SMdp-Ed-ak6NoX_4Aeg_-626501775")]
    [Description(@"Order is to be booked out as an OTC derivative (for example, Swap).")]
    TotalReturnSwap = BookingTypeCode.TotalReturnSwap, // same ordinal as derivation source for type conversions
}
