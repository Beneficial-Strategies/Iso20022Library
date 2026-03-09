// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the options for distribution of dividend income.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aWGPIdp-Ed-ak6NoX_4Aeg_-1985616336")]
[Description(@"Specifies the options for distribution of dividend income.")]
[Derivations(typeof(IncomePreference1Code),typeof(IncomePreference2Code))]
public enum IncomePreferenceCode
{
    /// <summary>
    /// Distribution in cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_aWGPItp-Ed-ak6NoX_4Aeg_-238756116")]
    [Description(@"Distribution in cash.")]
    Cash,
    
    /// <summary>
    /// Reinvestment of proceeds into securities.
    /// Encoded/decoded by serializers as &quot;DRIP&quot;.
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("_aWGPI9p-Ed-ak6NoX_4Aeg_-226750448")]
    [Description(@"Reinvestment of proceeds into securities.")]
    DividendReinvestment,
    
    /// <summary>
    /// Distribution in securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_fJyswCFJEeWgV9SQSyaAog")]
    [Description(@"Distribution in securities.")]
    Securities,
    
}
