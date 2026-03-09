// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the options for distribution of dividend income.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pt6LwCFJEeWgV9SQSyaAog")]
[Description(@"Specifies the options for distribution of dividend income.")]
[DerivedFrom(typeof(IncomePreferenceCode))]
public enum IncomePreference2Code
{
    /// <summary>
    /// Distribution in cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_ril1cSFJEeWgV9SQSyaAog")]
    [Description(@"Distribution in cash.")]
    Cash = IncomePreferenceCode.Cash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution in securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_ryQpISFJEeWgV9SQSyaAog")]
    [Description(@"Distribution in securities.")]
    Securities = IncomePreferenceCode.Securities, // same ordinal as derivation source for type conversions
    
}
