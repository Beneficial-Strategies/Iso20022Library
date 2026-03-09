// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the seniority type of a specific debt instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xteCIM4tEeSc85GUbgBycw")]
[Description(@"Specifies the seniority type of a specific debt instrument.")]
[DerivedFrom(typeof(DebtInstrumentSeniorityTypeCode))]
public enum DebtInstrumentSeniorityType1Code
{
    /// <summary>
    /// Debt owed to an unsecured creditor that can only be paid, in the event of a liquidation, after the claims of secured creditors have been met.
    /// Encoded/decoded by serializers as &quot;SBOD&quot;.
    /// </summary>
    [EnumMember(Value = "SBOD")]
    [IsoId("_PTlIkdDlEeSv_Pll20DdbA")]
    [Description(@"Debt owed to an unsecured creditor that can only be paid, in the event of a liquidation, after the claims of secured creditors have been met.")]
    SubordinatedDebt = DebtInstrumentSeniorityTypeCode.SubordinatedDebt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debt that takes priority over other unsecured or otherwise more junior debt owed by the issuer.
    /// Encoded/decoded by serializers as &quot;SNDB&quot;.
    /// </summary>
    [EnumMember(Value = "SNDB")]
    [IsoId("_PZh_kdDlEeSv_Pll20DdbA")]
    [Description(@"Debt that takes priority over other unsecured or otherwise more junior debt owed by the issuer.")]
    SeniorDebt = DebtInstrumentSeniorityTypeCode.SeniorDebt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Subordinated debt or preferred equity instrument that represents a claim on a company&apos;s assets which is senior only to that of the common shares.
    /// Encoded/decoded by serializers as &quot;MZZD&quot;.
    /// </summary>
    [EnumMember(Value = "MZZD")]
    [IsoId("_PfVsodDlEeSv_Pll20DdbA")]
    [Description(@"Subordinated debt or preferred equity instrument that represents a claim on a company's assets which is senior only to that of the common shares.")]
    MezzanineDebt = DebtInstrumentSeniorityTypeCode.MezzanineDebt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debt that is either unsecured or has a lower priority than of another debt claim on the same asset or property.
    /// Encoded/decoded by serializers as &quot;JUND&quot;.
    /// </summary>
    [EnumMember(Value = "JUND")]
    [IsoId("_PmxxYdDlEeSv_Pll20DdbA")]
    [Description(@"Debt that is either unsecured or has a lower priority than of another debt claim on the same asset or property.")]
    JuniorDebt = DebtInstrumentSeniorityTypeCode.JuniorDebt, // same ordinal as derivation source for type conversions
    
}
