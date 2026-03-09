// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies when date is open.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ayZwoNp-Ed-ak6NoX_4Aeg_-768563003")]
[Description(@"Specifies when date is open.")]
[DerivedFrom(typeof(DateTypeCode))]
public enum DateType2Code
{
    /// <summary>
    /// Open-dated, which indicates that the date has not been established.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_ayZwodp-Ed-ak6NoX_4Aeg_-723309217")]
    [Description(@"Open-dated, which indicates that the date has not been established.")]
    Open = DateTypeCode.Open, // same ordinal as derivation source for type conversions
    
}
