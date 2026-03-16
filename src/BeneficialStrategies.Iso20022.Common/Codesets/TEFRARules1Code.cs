// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the Tax Equity and Fiscal Responsibility Act (TEFRA) rule levied by the IRS under which the security is issued.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yg95g9p-Ed-ak6NoX_4Aeg_126958885")]
[Description(
    @"Indicates the Tax Equity and Fiscal Responsibility Act (TEFRA) rule levied by the IRS under which the security is issued."
)]
[DerivedFrom(typeof(TEFRARulesCode))]
public enum TEFRARules1Code
{
    /// <summary>
    /// Indicates that the security is issued under the TEFRA rule C.
    /// Encoded/decoded by serializers as &quot;RULC&quot;.
    /// </summary>
    [EnumMember(Value = "RULC")]
    [IsoId("_Yg95hNp-Ed-ak6NoX_4Aeg_-1859434425")]
    [Description(@"Indicates that the security is issued under the TEFRA rule C.")]
    C = TEFRARulesCode.C, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the security is issued under the TEFRA rule D.
    /// Encoded/decoded by serializers as &quot;RULD&quot;.
    /// </summary>
    [EnumMember(Value = "RULD")]
    [IsoId("_Yg95hdp-Ed-ak6NoX_4Aeg_1396824143")]
    [Description(@"Indicates that the security is issued under the TEFRA rule D.")]
    D = TEFRARulesCode.D, // same ordinal as derivation source for type conversions
}
