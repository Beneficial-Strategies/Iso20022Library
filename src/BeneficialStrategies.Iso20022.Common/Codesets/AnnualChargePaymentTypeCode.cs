// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how the charge is to be deducted.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_be0Kt9p-Ed-ak6NoX_4Aeg_1016563740")]
[Description(@"Specifies how the charge is to be deducted.")]
[Derivations(typeof(AnnualChargePaymentType1Code))]
public enum AnnualChargePaymentTypeCode
{
    /// <summary>
    /// Annual charge is deducted from the fund capital.
    /// Encoded/decoded by serializers as &quot;CAPL&quot;.
    /// </summary>
    [EnumMember(Value = "CAPL")]
    [IsoId("_be9UoNp-Ed-ak6NoX_4Aeg_1016563741")]
    [Description(@"Annual charge is deducted from the fund capital.")]
    Capital,
    
    /// <summary>
    /// Annual charge is deducted from the fund income.
    /// Encoded/decoded by serializers as &quot;INCO&quot;.
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_be9Uodp-Ed-ak6NoX_4Aeg_1016563742")]
    [Description(@"Annual charge is deducted from the fund income.")]
    Income,
    
}
