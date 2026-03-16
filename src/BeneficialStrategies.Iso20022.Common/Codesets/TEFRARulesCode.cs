// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the Tax Equity and Fiscal Responsibility Act (TEFRA) rule levied by the Internal Revenue Service under which the security is issued.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yg95htp-Ed-ak6NoX_4Aeg_-1987299415")]
[Description(
    @"Indicates the Tax Equity and Fiscal Responsibility Act (TEFRA) rule levied by the Internal Revenue Service under which the security is issued."
)]
[Derivations(typeof(TEFRARules1Code))]
public enum TEFRARulesCode
{
    /// <summary>
    /// Indicates that the security is issued under the TEFRA rule C.
    /// Encoded/decoded by serializers as &quot;RULC&quot;.
    /// </summary>
    [EnumMember(Value = "RULC")]
    [IsoId("_Yg95h9p-Ed-ak6NoX_4Aeg_-698951025")]
    [Description(@"Indicates that the security is issued under the TEFRA rule C.")]
    C,

    /// <summary>
    /// Indicates that the security is issued under the TEFRA rule D.
    /// Encoded/decoded by serializers as &quot;RULD&quot;.
    /// </summary>
    [EnumMember(Value = "RULD")]
    [IsoId("_Yg95iNp-Ed-ak6NoX_4Aeg_1946839088")]
    [Description(@"Indicates that the security is issued under the TEFRA rule D.")]
    D,
}
