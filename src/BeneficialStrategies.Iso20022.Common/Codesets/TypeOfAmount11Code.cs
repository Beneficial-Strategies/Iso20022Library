// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Qualifies the amount of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4ydHoFKQEeeFcfYfFkVztg")]
[Description(@"Qualifies the amount of the transaction.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
public enum TypeOfAmount11Code
{
    /// <summary>
    /// Actual amount.
    /// Encoded/decoded by serializers as &quot;ACTL&quot;.
    /// </summary>
    [EnumMember(Value = "ACTL")]
    [IsoId("_-phBoVKQEeeFcfYfFkVztg")]
    [Description(@"Actual amount.")]
    Actual = TypeOfAmountCode.Actual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Default amount.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("__S4HsVKQEeeFcfYfFkVztg")]
    [Description(@"Default amount.")]
    Default = TypeOfAmountCode.Default, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Estimated amount (the final amount could be above or below).
    /// Encoded/decoded by serializers as &quot;ESTM&quot;.
    /// </summary>
    [EnumMember(Value = "ESTM")]
    [IsoId("__uZmEVKQEeeFcfYfFkVztg")]
    [Description(@"Estimated amount (the final amount could be above or below).")]
    Estimated = TypeOfAmountCode.Estimated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum amount (the final amount must be less or equal).
    /// Encoded/decoded by serializers as &quot;MAXI&quot;.
    /// </summary>
    [EnumMember(Value = "MAXI")]
    [IsoId("_BBtoEVKREeeFcfYfFkVztg")]
    [Description(@"Maximum amount (the final amount must be less or equal).")]
    Maximum = TypeOfAmountCode.Maximum, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reserved or updated reserved amount for reservation.
    /// Encoded/decoded by serializers as &quot;RESD&quot;.
    /// </summary>
    [EnumMember(Value = "RESD")]
    [IsoId("_BkrLMVKREeeFcfYfFkVztg")]
    [Description(@"Reserved or updated reserved amount for reservation.")]
    Reserved = TypeOfAmountCode.Reserved, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Substitute for an amount to be authorised.
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_TiJCwUNGEeiut6dbx3wnBg")]
    [Description(@"Substitute for an amount to be authorised.")]
    Proxy = TypeOfAmountCode.Proxy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deposit amount.
    /// Encoded/decoded by serializers as &quot;DPST&quot;.
    /// </summary>
    [EnumMember(Value = "DPST")]
    [IsoId("_jZ-6cbrBEeiRnc958wUXqA")]
    [Description(@"Deposit amount.")]
    Deposit = TypeOfAmountCode.Deposit, // same ordinal as derivation source for type conversions
    
}
