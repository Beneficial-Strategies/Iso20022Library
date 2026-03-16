// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Cjj9AF25EeiFXdiLi_Nf4A")]
[Description(@"Specifies a type of amount.")]
[DerivedFrom(typeof(TaxWrapperAmountTypeCode))]
public enum TaxWrapperAmountType1Code
{
    /// <summary>
    /// Type of amount is a bonus, for example, a government bonus.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_Dpx-MV25EeiFXdiLi_Nf4A")]
    [Description(@"Type of amount is a bonus, for example, a government bonus.")]
    Bonus = TaxWrapperAmountTypeCode.Bonus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type of amount is a withdrawal, for example, a withdrawal for a first time residential purchase.
    /// Encoded/decoded by serializers as &quot;WTHD&quot;.
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("_DwLhIV25EeiFXdiLi_Nf4A")]
    [Description(
        @"Type of amount is a withdrawal, for example, a withdrawal for a first time residential purchase."
    )]
    Withdrawal = TaxWrapperAmountTypeCode.Withdrawal, // same ordinal as derivation source for type conversions
}
