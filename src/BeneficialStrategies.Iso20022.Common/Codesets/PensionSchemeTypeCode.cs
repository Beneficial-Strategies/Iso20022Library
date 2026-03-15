// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of pension scheme.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OIg3gE4OEeiQHa-q1Uephw")]
[Description(@"Specifies a type of pension scheme.")]
[Derivations(typeof(PensionSchemeType1Code))]
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
public enum PensionSchemeTypeCode
{
    /// <summary>
    /// Pension is a group personal pension scheme.
    /// Encoded/decoded by serializers as &quot;GPPS&quot;.
    /// </summary>
    [EnumMember(Value = "GPPS")]
    [IsoId("_ZKAPAE4OEeiQHa-q1Uephw")]
    [Description(@"Pension is a group personal pension scheme.")]
    GroupPersonalPensionScheme,
    
    /// <summary>
    /// Pension is a personal pension plan.
    /// Encoded/decoded by serializers as &quot;PPNS&quot;.
    /// </summary>
    [EnumMember(Value = "PPNS")]
    [IsoId("_eUuncE4OEeiQHa-q1Uephw")]
    [Description(@"Pension is a personal pension plan.")]
    PersonalPension,
    
    /// <summary>
    /// Pension is a self-invested pension plan.
    /// Encoded/decoded by serializers as &quot;SIPP&quot;.
    /// </summary>
    [EnumMember(Value = "SIPP")]
    [IsoId("_g-680E4OEeiQHa-q1Uephw")]
    [Description(@"Pension is a self-invested pension plan.")]
    SelfInvestedPension,
    
    /// <summary>
    /// Pension plan is a group-invested pension plan.
    /// Encoded/decoded by serializers as &quot;SIPG&quot;.
    /// </summary>
    [EnumMember(Value = "SIPG")]
    [IsoId("_nqDYEE4OEeiQHa-q1Uephw")]
    [Description(@"Pension plan is a group-invested pension plan.")]
    GroupInvestedPension,
    
    /// <summary>
    /// Pension is a small self-administered pension schema.
    /// Encoded/decoded by serializers as &quot;SSAS&quot;.
    /// </summary>
    [EnumMember(Value = "SSAS")]
    [IsoId("_sB5iEE4OEeiQHa-q1Uephw")]
    [Description(@"Pension is a small self-administered pension schema.")]
    SmallSelfAdministeredSchema,
    
    /// <summary>
    /// Pension plan is an individual stakeholder pension.
    /// Encoded/decoded by serializers as &quot;STKI&quot;.
    /// </summary>
    [EnumMember(Value = "STKI")]
    [IsoId("_yEQtIE4OEeiQHa-q1Uephw")]
    [Description(@"Pension plan is an individual stakeholder pension.")]
    IndividualStakeholder,
    
    /// <summary>
    /// Pension plan is a group stakeholder pension plan.
    /// Encoded/decoded by serializers as &quot;STKG&quot;.
    /// </summary>
    [EnumMember(Value = "STKG")]
    [IsoId("_1eEhkE4OEeiQHa-q1Uephw")]
    [Description(@"Pension plan is a group stakeholder pension plan.")]
    GroupStakeholder,
    
    /// <summary>
    /// Pension type covered by section 32.
    /// Encoded/decoded by serializers as &quot;SC32&quot;.
    /// </summary>
    [EnumMember(Value = "SC32")]
    [IsoId("_36IUUE4OEeiQHa-q1Uephw")]
    [Description(@"Pension type covered by section 32.")]
    Section32,
    
    /// <summary>
    /// Pension type covered by section 32A.
    /// Encoded/decoded by serializers as &quot;S32A&quot;.
    /// </summary>
    [EnumMember(Value = "S32A")]
    [IsoId("_9qyrYE4OEeiQHa-q1Uephw")]
    [Description(@"Pension type covered by section 32A.")]
    Section32A,
    
    /// <summary>
    /// Pension plan is a retirement annuity.
    /// Encoded/decoded by serializers as &quot;REAN&quot;.
    /// </summary>
    [EnumMember(Value = "REAN")]
    [IsoId("_AaWB4E4PEeiQHa-q1Uephw")]
    [Description(@"Pension plan is a retirement annuity.")]
    RetirementAnnuity,
    
    /// <summary>
    /// Pension plan is an occupational direct contribution plan.
    /// Encoded/decoded by serializers as &quot;OCDC&quot;.
    /// </summary>
    [EnumMember(Value = "OCDC")]
    [IsoId("_Dm6rkE4PEeiQHa-q1Uephw")]
    [Description(@"Pension plan is an occupational direct contribution plan.")]
    OccupationalDirectContribution,
    
    /// <summary>
    /// Pension plan is an executive pension plan.
    /// Encoded/decoded by serializers as &quot;EXPP&quot;.
    /// </summary>
    [EnumMember(Value = "EXPP")]
    [IsoId("_JAXcgE4PEeiQHa-q1Uephw")]
    [Description(@"Pension plan is an executive pension plan.")]
    ExecutivePension,
    
    /// <summary>
    /// Pension plan is an additional voluntary contribution plan.
    /// Encoded/decoded by serializers as &quot;AAVC&quot;.
    /// </summary>
    [EnumMember(Value = "AAVC")]
    [IsoId("_PnLYcE4PEeiQHa-q1Uephw")]
    [Description(@"Pension plan is an additional voluntary contribution plan.")]
    AdditionalVoluntaryContribution,
    
    /// <summary>
    /// Pension plan is a free standing additional voluntary contribution plan.
    /// Encoded/decoded by serializers as &quot;FAVC&quot;.
    /// </summary>
    [EnumMember(Value = "FAVC")]
    [IsoId("_UODc8E4PEeiQHa-q1Uephw")]
    [Description(@"Pension plan is a free standing additional voluntary contribution plan.")]
    FreeStandingAdditionalVoluntaryContribution,
    
    /// <summary>
    /// Pension plan is a defined benefit plan.
    /// Encoded/decoded by serializers as &quot;DBEN&quot;.
    /// </summary>
    [EnumMember(Value = "DBEN")]
    [IsoId("_aGvuoE4PEeiQHa-q1Uephw")]
    [Description(@"Pension plan is a defined benefit plan.")]
    DefinedBenefit,
    
    /// <summary>
    /// Pension is an individual pension savings plan with a tax benefit. This is known as an Individual Pension Schema (IPS) in some markets.
    /// Encoded/decoded by serializers as &quot;IPST&quot;.
    /// </summary>
    [EnumMember(Value = "IPST")]
    [IsoId("_j_udsF2sEeiFXdiLi_Nf4A")]
    [Description(@"Pension is an individual pension savings plan with a tax benefit. This is known as an Individual Pension Schema (IPS) in some markets.")]
    IndividualPensionWithTaxBenefit,
    
    /// <summary>
    /// Pension is a mandatory occupational pension. This is known as an Obligatory Occupation Pension (OTP) in some markets.
    /// Encoded/decoded by serializers as &quot;OTPM&quot;.
    /// </summary>
    [EnumMember(Value = "OTPM")]
    [IsoId("_pEy6EF2sEeiFXdiLi_Nf4A")]
    [Description(@"Pension is a mandatory occupational pension. This is known as an Obligatory Occupation Pension (OTP) in some markets.")]
    MandatoryOccupationalPension,
    
    /// <summary>
    /// Pension is a personal pension account. This is known as Employee Pension Kapital (EPK) in some markets.
    /// Encoded/decoded by serializers as &quot;EPKA&quot;.
    /// </summary>
    [EnumMember(Value = "EPKA")]
    [IsoId("_szk48F2sEeiFXdiLi_Nf4A")]
    [Description(@"Pension is a personal pension account. This is known as Employee Pension Kapital (EPK) in some markets.")]
    PersonalPensionAccount,
    
    /// <summary>
    /// Pension is a private occupational pension. This is known as an industrial and trade supplementary pension (ITP) in some markets.
    /// Encoded/decoded by serializers as &quot;ITPO&quot;.
    /// </summary>
    [EnumMember(Value = "ITPO")]
    [IsoId("_veXrQF2sEeiFXdiLi_Nf4A")]
    [Description(@"Pension is a private occupational pension. This is known as an industrial and trade supplementary pension (ITP) in some markets.")]
    PrivateOccupationalPension,
    
}
