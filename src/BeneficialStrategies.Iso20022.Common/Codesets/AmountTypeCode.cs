// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why an amount is not specified.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_be0KtNp-Ed-ak6NoX_4Aeg_-1456928482")]
[Description(@"Specifies the reason why an amount is not specified.")]
[Derivations(typeof(AmountType2Code),typeof(AmountType1Code))]
public enum AmountTypeCode
{
    /// <summary>
    /// The amount is open.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_be0Ktdp-Ed-ak6NoX_4Aeg_-1173408141")]
    [Description(@"The amount is open.")]
    Open,
    
    /// <summary>
    /// The amount is unkown.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_be0Kttp-Ed-ak6NoX_4Aeg_-1173408110")]
    [Description(@"The amount is unkown.")]
    Unknown,
    
    /// <summary>
    /// The amount represents a fixed value.
    /// Encoded/decoded by serializers as &quot;FIXD&quot;.
    /// </summary>
    [EnumMember(Value = "FIXD")]
    [IsoId("_T2GUUHySEeGAm6xykg3ebQ")]
    [Description(@"The amount represents a fixed value.")]
    FixedAmount,
    
    /// <summary>
    /// The amount represents the minimum value.
    /// Encoded/decoded by serializers as &quot;MINI&quot;.
    /// </summary>
    [EnumMember(Value = "MINI")]
    [IsoId("_pR68sHySEeGAm6xykg3ebQ")]
    [Description(@"The amount represents the minimum value.")]
    MinimumAmount,
    
    /// <summary>
    /// The amount represents the maximum value.
    /// Encoded/decoded by serializers as &quot;MAXI&quot;.
    /// </summary>
    [EnumMember(Value = "MAXI")]
    [IsoId("_yv5TAHySEeGAm6xykg3ebQ")]
    [Description(@"The amount represents the maximum value.")]
    MaximumAmount,
    
}
