// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the adjustment is added or subtracted to the total amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bnKOYNp-Ed-ak6NoX_4Aeg_-559278803")]
[Description(@"Specifies whether the adjustment is added or subtracted to the total amount.")]
[DerivedFrom(typeof(AdjustmentDirectionCode))]
public enum AdjustmentDirection1Code
{
    /// <summary>
    /// Adjustment amount must be added to the total amount.
    /// Encoded/decoded by serializers as &quot;ADDD&quot;.
    /// </summary>
    [EnumMember(Value = "ADDD")]
    [IsoId("_bnKOYdp-Ed-ak6NoX_4Aeg_-512177233")]
    [Description(@"Adjustment amount must be added to the total amount.")]
    Added = AdjustmentDirectionCode.Added, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Adjustment amount must be substracted from the total amount.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_bnKOYtp-Ed-ak6NoX_4Aeg_-512177198")]
    [Description(@"Adjustment amount must be substracted from the total amount.")]
    Substracted = AdjustmentDirectionCode.Substracted, // same ordinal as derivation source for type conversions
    
}
