// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Relates to non-standard orders, to handle them differently, probably in a manual fashion.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aUAkeNp-Ed-ak6NoX_4Aeg_-1311872043")]
[Description(@"Relates to non-standard orders, to handle them differently, probably in a manual fashion.")]
[DerivedFrom(typeof(OrderWaiverReasonCode))]
public enum OrderWaiverReason1Code
{
    /// <summary>
    /// Dealing of the trade is outside the normal limit.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_aUAkedp-Ed-ak6NoX_4Aeg_1092977119")]
    [Description(@"Dealing of the trade is outside the normal limit.")]
    LateTradeDealing = OrderWaiverReasonCode.LateTradeDealing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Front end load charge differs from PPM.
    /// Encoded/decoded by serializers as &quot;FEND&quot;.
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_aUJuYNp-Ed-ak6NoX_4Aeg_1092977150")]
    [Description(@"Front end load charge differs from PPM.")]
    FrontEndLoadCharge = OrderWaiverReasonCode.FrontEndLoadCharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of subscription is below the minimum initial investment amount.
    /// Encoded/decoded by serializers as &quot;BMIN&quot;.
    /// </summary>
    [EnumMember(Value = "BMIN")]
    [IsoId("_aUJuYdp-Ed-ak6NoX_4Aeg_1092977180")]
    [Description(@"Amount of subscription is below the minimum initial investment amount.")]
    BelowMinimumInvestmentAmount = OrderWaiverReasonCode.BelowMinimumInvestmentAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cut off date has been passed.
    /// Encoded/decoded by serializers as &quot;CUTO&quot;.
    /// </summary>
    [EnumMember(Value = "CUTO")]
    [IsoId("_aUJuYtp-Ed-ak6NoX_4Aeg_1092977211")]
    [Description(@"Cut off date has been passed.")]
    CutOffDate = OrderWaiverReasonCode.CutOffDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Standard commission is waived.
    /// Encoded/decoded by serializers as &quot;COMW&quot;.
    /// </summary>
    [EnumMember(Value = "COMW")]
    [IsoId("_aUJuY9p-Ed-ak6NoX_4Aeg_-417659720")]
    [Description(@"Standard commission is waived.")]
    CommissionWaiver = OrderWaiverReasonCode.CommissionWaiver, // same ordinal as derivation source for type conversions
    
}
