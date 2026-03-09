// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of transaction price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yx9i4Np-Ed-ak6NoX_4Aeg_-1404906082")]
[Description(@"Specifies the type of transaction price.")]
[DerivedFrom(typeof(TypeOfPriceCode))]
public enum TypeOfPrice14Code
{
    /// <summary>
    /// Price is an average execution price.
    /// Encoded/decoded by serializers as &quot;AVER&quot;.
    /// </summary>
    [EnumMember(Value = "AVER")]
    [IsoId("_Yx9i4dp-Ed-ak6NoX_4Aeg_-1357807596")]
    [Description(@"Price is an average execution price.")]
    Average = TypeOfPriceCode.Average, // same ordinal as derivation source for type conversions
    
}
