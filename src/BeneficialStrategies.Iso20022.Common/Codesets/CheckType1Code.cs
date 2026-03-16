// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of bank check.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fyQcYNtbEeipuvJHTHIw9A")]
[Description(@"Type of bank check.")]
[DerivedFrom(typeof(CheckTypeCode))]
public enum CheckType1Code
{
    /// <summary>
    /// The check is guaranteed by a bank.
    /// Encoded/decoded by serializers as &quot;BANK&quot;.
    /// </summary>
    [EnumMember(Value = "BANK")]
    [IsoId("_ipUJEdtbEeipuvJHTHIw9A")]
    [Description(@"The check is guaranteed by a bank.")]
    BankCheck = CheckTypeCode.BankCheck, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The check belongs to a Company or a professional entity.
    /// Encoded/decoded by serializers as &quot;BUSI&quot;.
    /// </summary>
    [EnumMember(Value = "BUSI")]
    [IsoId("_itISEdtbEeipuvJHTHIw9A")]
    [Description(@"The check belongs to a Company or a professional entity.")]
    BusinessCheck = CheckTypeCode.BusinessCheck, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Check issued by Government.
    /// Encoded/decoded by serializers as &quot;GOVC&quot;.
    /// </summary>
    [EnumMember(Value = "GOVC")]
    [IsoId("_ixdYcdtbEeipuvJHTHIw9A")]
    [Description(@"Check issued by Government.")]
    GovernmentCheck = CheckTypeCode.GovernmentCheck, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Check issued by a company for the employees.
    /// Encoded/decoded by serializers as &quot;PAYR&quot;.
    /// </summary>
    [EnumMember(Value = "PAYR")]
    [IsoId("_i2vhEdtbEeipuvJHTHIw9A")]
    [Description(@"Check issued by a company for the employees.")]
    PayrollCheck = CheckTypeCode.PayrollCheck, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The check belongs to an individual.
    /// Encoded/decoded by serializers as &quot;PERS&quot;.
    /// </summary>
    [EnumMember(Value = "PERS")]
    [IsoId("_i6bHMdtbEeipuvJHTHIw9A")]
    [Description(@"The check belongs to an individual.")]
    PersonalCheck = CheckTypeCode.PersonalCheck, // same ordinal as derivation source for type conversions
}
