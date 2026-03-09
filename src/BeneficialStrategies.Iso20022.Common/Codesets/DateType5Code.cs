// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ayZwp9p-Ed-ak6NoX_4Aeg_609768006")]
[Description(@"Specifies a type of date.")]
[DerivedFrom(typeof(DateTypeCode))]
public enum DateType5Code
{
    /// <summary>
    /// Open-dated, which indicates that the date has not been established.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_ayjhoNp-Ed-ak6NoX_4Aeg_957934914")]
    [Description(@"Open-dated, which indicates that the date has not been established.")]
    Open = DateTypeCode.Open, // same ordinal as derivation source for type conversions
    
}
