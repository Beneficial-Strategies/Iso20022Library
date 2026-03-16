// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of leg structuring a swap. For fixed income, it is used to requests the respondent to calculate the quantity based on the quantity on the opposite side of the swap.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aeSh0dp-Ed-ak6NoX_4Aeg_-167248068")]
[Description(
    @"Indicates the type of leg structuring a swap. For fixed income, it is used to requests the respondent to calculate the quantity based on the quantity on the opposite side of the swap."
)]
[DerivedFrom(typeof(LegSwapTypeCode))]
public enum LegSwapType1Code
{
    /// <summary>
    /// Type of leg involved in a swap whose purpose is to exchange principal.
    /// Encoded/decoded by serializers as &quot;PFPR&quot;.
    /// </summary>
    [EnumMember(Value = "PFPR")]
    [IsoId("_aeSh0tp-Ed-ak6NoX_4Aeg_-130309149")]
    [Description(@"Type of leg involved in a swap whose purpose is to exchange principal.")]
    ParForPar = LegSwapTypeCode.ParForPar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type of leg involved in a swap whose purpose is to exchange price volatility.
    /// Encoded/decoded by serializers as &quot;MODU&quot;.
    /// </summary>
    [EnumMember(Value = "MODU")]
    [IsoId("_aeSh09p-Ed-ak6NoX_4Aeg_-130309107")]
    [Description(@"Type of leg involved in a swap whose purpose is to exchange price volatility.")]
    ModifiedDuration = LegSwapTypeCode.ModifiedDuration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type of leg involved in a swap whose purpose is to increase the credit quality and reduce the default risk. Also known as quality swap.
    /// Encoded/decoded by serializers as &quot;RISK&quot;.
    /// </summary>
    [EnumMember(Value = "RISK")]
    [IsoId("_aeSh1Np-Ed-ak6NoX_4Aeg_-130309063")]
    [Description(
        @"Type of leg involved in a swap whose purpose is to increase the credit quality and reduce the default risk. Also known as quality swap."
    )]
    Risk = LegSwapTypeCode.Risk, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type of leg involved in a swap structured in the sale of a financial instrument and the simultaneous purchase of another instrument with the proceeds from the sale.
    /// Encoded/decoded by serializers as &quot;PRCD&quot;.
    /// </summary>
    [EnumMember(Value = "PRCD")]
    [IsoId("_aeSh1dp-Ed-ak6NoX_4Aeg_-130309011")]
    [Description(
        @"Type of leg involved in a swap structured in the sale of a financial instrument and the simultaneous purchase of another instrument with the proceeds from the sale."
    )]
    Proceeds = LegSwapTypeCode.Proceeds, // same ordinal as derivation source for type conversions
}
