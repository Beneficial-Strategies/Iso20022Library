// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a contract balance type code, as published in the external ISO 20022 external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cjg1wQtKEeWkxvNyFrBT8Q")]
[Description(@"Specifies a contract balance type code, as published in the external ISO 20022 external code set.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalContractBalanceTypeCode))]
public enum ExternalContractBalanceType1Code
{
    /// <summary>
    /// Revolver loan current utilisation (applicable on loan contracts types)
    /// Encoded/decoded by serializers as &quot;EXPC&quot;.
    /// </summary>
    [EnumMember(Value = "EXPC")]
    [IsoId("_uUDndfRYEeuLhpyIdtJzwg")]
    [Description(@"Revolver loan current utilisation (applicable on loan contracts types)")]
    CurrentUtilisation = ExternalContractBalanceTypeCode.CurrentUtilisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Total loan utilisation for loans with total loan limit  (applicable on loan contracts types)
    /// Encoded/decoded by serializers as &quot;EXPT&quot;.
    /// </summary>
    [EnumMember(Value = "EXPT")]
    [IsoId("_uUDnePRYEeuLhpyIdtJzwg")]
    [Description(@"Total loan utilisation for loans with total loan limit  (applicable on loan contracts types)")]
    TotalUtilisation = ExternalContractBalanceTypeCode.TotalUtilisation, // same ordinal as derivation source for type conversions
    
}
