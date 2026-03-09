// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of securities proceeds newly issued.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8eWckKFQEeSK_vfd3NHBGg")]
[Description(@"Specifies the type of securities proceeds newly issued.")]
[DerivedFrom(typeof(NewSecuritiesIssuanceTypeCode))]
public enum NewSecuritiesIssuanceType4Code
{
    /// <summary>
    /// New security issued that has been refunded to an earlier maturity date. Applicable only in the frame of a partial defeasance PDEF corporate action event.
    /// Encoded/decoded by serializers as &quot;REFU&quot;.
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_OQnkUaFREeSK_vfd3NHBGg")]
    [Description(@"New security issued that has been refunded to an earlier maturity date. Applicable only in the frame of a partial defeasance PDEF corporate action event.")]
    RefundedSecurityIndicator = NewSecuritiesIssuanceTypeCode.RefundedSecurityIndicator, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// New Security issued that has not been refunded and the maturity date of the original underlying security is unchanged. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.
    /// Encoded/decoded by serializers as &quot;NREF&quot;.
    /// </summary>
    [EnumMember(Value = "NREF")]
    [IsoId("_OgPUs6FREeSK_vfd3NHBGg")]
    [Description(@"New Security issued that has not been refunded and the maturity date of the original underlying security is unchanged. Applicable only in the frame of a Partial Defeasance PDEF corporate action event.")]
    NonRefundedSecurityIndicator = NewSecuritiesIssuanceTypeCode.NonRefundedSecurityIndicator, // same ordinal as derivation source for type conversions
    
}
