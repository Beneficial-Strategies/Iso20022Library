// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates how a date is adjusted when it falls on a non-business day.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bVIDNdp-Ed-ak6NoX_4Aeg_1684551992")]
[Description(@"Indicates how a date is adjusted when it falls on a non-business day.")]
[DerivedFrom(typeof(BusinessDayConventionCode))]
public enum BusinessDayConvention1Code
{
    /// <summary>
    /// The date will be the first following day that is a business day.
    /// Encoded/decoded by serializers as &quot;FWNG&quot;.
    /// </summary>
    [EnumMember(Value = "FWNG")]
    [IsoId("_bVIDNtp-Ed-ak6NoX_4Aeg_1252936265")]
    [Description(@"The date will be the first following day that is a business day.")]
    Following = BusinessDayConventionCode.Following, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The date will be the first preceding day that is a business day.
    /// Encoded/decoded by serializers as &quot;PREC&quot;.
    /// </summary>
    [EnumMember(Value = "PREC")]
    [IsoId("_bVIDN9p-Ed-ak6NoX_4Aeg_-522159377")]
    [Description(@"The date will be the first preceding day that is a business day.")]
    Preceding = BusinessDayConventionCode.Preceding, // same ordinal as derivation source for type conversions
    
}
