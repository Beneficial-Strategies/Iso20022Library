// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the value of a rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZaVxgNp-Ed-ak6NoX_4Aeg_-1378979923")]
[Description(@"Specifies the value of a rate.")]
[DerivedFrom(typeof(RateTypeCode))]
public enum RateValueType6Code
{
    /// <summary>
    /// Rate is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ZaVxgdp-Ed-ak6NoX_4Aeg_-1378979921")]
    [Description(@"Rate is unknown by the sender or has not been established.")]
    Unknown = RateTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate has not been established.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_ZaVxgtp-Ed-ak6NoX_4Aeg_-1378979892")]
    [Description(@"Rate has not been established.")]
    Open = RateTypeCode.Open, // same ordinal as derivation source for type conversions
    
}
