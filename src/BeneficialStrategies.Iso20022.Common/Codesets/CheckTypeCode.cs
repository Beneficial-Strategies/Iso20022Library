// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of bank check.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_I5k0cNtbEeipuvJHTHIw9A")]
[Description(@"Type of bank check.")]
[Derivations(typeof(CheckType1Code))]
public enum CheckTypeCode
{
    /// <summary>
    /// The check belongs to an individual.
    /// Encoded/decoded by serializers as &quot;PERS&quot;.
    /// </summary>
    [EnumMember(Value = "PERS")]
    [IsoId("_OZCGwNtbEeipuvJHTHIw9A")]
    [Description(@"The check belongs to an individual.")]
    PersonalCheck,
    
    /// <summary>
    /// The check belongs to a Company or a professional entity.
    /// Encoded/decoded by serializers as &quot;BUSI&quot;.
    /// </summary>
    [EnumMember(Value = "BUSI")]
    [IsoId("_RSSy4NtbEeipuvJHTHIw9A")]
    [Description(@"The check belongs to a Company or a professional entity.")]
    BusinessCheck,
    
    /// <summary>
    /// The check is guaranteed by a bank.
    /// Encoded/decoded by serializers as &quot;BANK&quot;.
    /// </summary>
    [EnumMember(Value = "BANK")]
    [IsoId("_UmnDUNtbEeipuvJHTHIw9A")]
    [Description(@"The check is guaranteed by a bank.")]
    BankCheck,
    
    /// <summary>
    /// Check issued by a company for the employees.
    /// Encoded/decoded by serializers as &quot;PAYR&quot;.
    /// </summary>
    [EnumMember(Value = "PAYR")]
    [IsoId("_YQXYQNtbEeipuvJHTHIw9A")]
    [Description(@"Check issued by a company for the employees.")]
    PayrollCheck,
    
    /// <summary>
    /// Check issued by Government.
    /// Encoded/decoded by serializers as &quot;GOVC&quot;.
    /// </summary>
    [EnumMember(Value = "GOVC")]
    [IsoId("_bkxIQNtbEeipuvJHTHIw9A")]
    [Description(@"Check issued by Government.")]
    GovernmentCheck,
    
}
