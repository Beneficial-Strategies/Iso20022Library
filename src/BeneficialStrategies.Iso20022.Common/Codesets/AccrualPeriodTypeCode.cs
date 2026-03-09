// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the first accrual period for debt instruments compared to the normal accrual period of the security.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1zs59jL3EeKU9IrkkToqcw_1280025433")]
[Description(@"Specifies the type of the first accrual period for debt instruments compared to the normal accrual period of the security.")]
[Derivations(typeof(AccrualPeriodType1Code))]
public enum AccrualPeriodTypeCode
{
    /// <summary>
    /// Long first payment period is applicable.
    /// Encoded/decoded by serializers as &quot;LONG&quot;.
    /// </summary>
    [EnumMember(Value = "LONG")]
    [IsoId("_1z2q8DL3EeKU9IrkkToqcw_1530482558")]
    [Description(@"Long first payment period is applicable.")]
    LongFirstPaymentPeriod,
    
    /// <summary>
    /// Regular first payment period is applicable.
    /// Encoded/decoded by serializers as &quot;FREG&quot;.
    /// </summary>
    [EnumMember(Value = "FREG")]
    [IsoId("_1z2q8TL3EeKU9IrkkToqcw_-1113628847")]
    [Description(@"Regular first payment period is applicable.")]
    FirstRegularPaymentPeriod,
    
    /// <summary>
    /// Short first payment period is applicable.
    /// Encoded/decoded by serializers as &quot;SHRT&quot;.
    /// </summary>
    [EnumMember(Value = "SHRT")]
    [IsoId("_1z2q8jL3EeKU9IrkkToqcw_751017904")]
    [Description(@"Short first payment period is applicable.")]
    ShortFirstPaymentperiod,
    
    /// <summary>
    /// First year of payment is applicable.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_1z2q8zL3EeKU9IrkkToqcw_1599898201")]
    [Description(@"First year of payment is applicable.")]
    FirstYearOfPayment,
    
    /// <summary>
    /// Extra long payment period is applicable.
    /// Encoded/decoded by serializers as &quot;XLNG&quot;.
    /// </summary>
    [EnumMember(Value = "XLNG")]
    [IsoId("_1z2q9DL3EeKU9IrkkToqcw_973611791")]
    [Description(@"Extra long payment period is applicable.")]
    ExtraLongPaymentPeriod,
    
    /// <summary>
    /// Default payment period is applicable.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_1z2q9TL3EeKU9IrkkToqcw_-1800034999")]
    [Description(@"Default payment period is applicable.")]
    DefaultPeriod,
    
    /// <summary>
    /// Payment has not been done.
    /// Encoded/decoded by serializers as &quot;OMIT&quot;.
    /// </summary>
    [EnumMember(Value = "OMIT")]
    [IsoId("_1z2q9jL3EeKU9IrkkToqcw_1213629179")]
    [Description(@"Payment has not been done.")]
    PaymentOmitted,
    
}
