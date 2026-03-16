// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the calculation basis.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VjbKVtp-Ed-ak6NoX_4Aeg_-1887209997")]
[Description(@"Specifies the calculation basis.")]
[DerivedFrom(typeof(CalculationBasisCode))]
public enum CalculationBasis1Code
{
    /// <summary>
    /// Average basis.
    /// Encoded/decoded by serializers as &quot;AVER&quot;.
    /// </summary>
    [EnumMember(Value = "AVER")]
    [IsoId("_VjbKV9p-Ed-ak6NoX_4Aeg_-1571364153")]
    [Description(@"Average basis.")]
    Average = CalculationBasisCode.Average, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Daily basis.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_VjbKWNp-Ed-ak6NoX_4Aeg_-1568592785")]
    [Description(@"Daily basis.")]
    Daily = CalculationBasisCode.Daily, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Another type of calculation basis.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Vjk7UNp-Ed-ak6NoX_4Aeg_-855201061")]
    [Description(@"Another type of calculation basis.")]
    Other = CalculationBasisCode.Other, // same ordinal as derivation source for type conversions
}
