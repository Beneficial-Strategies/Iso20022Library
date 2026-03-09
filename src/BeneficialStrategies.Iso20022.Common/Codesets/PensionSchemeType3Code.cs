// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of pension scheme.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ufPCkelpEeuvhrZwLF0fDg")]
[Description(@"Specifies a type of pension scheme.")]
[DerivedFrom(typeof(PensionSchemeTypeV2Code))]
public enum PensionSchemeType3Code
{
    /// <summary>
    /// Pension plan is an additional voluntary contribution plan.
    /// Encoded/decoded by serializers as &quot;AAVC&quot;.
    /// </summary>
    [EnumMember(Value = "AAVC")]
    [IsoId("_u01fIelpEeuvhrZwLF0fDg")]
    [Description(@"Pension plan is an additional voluntary contribution plan.")]
    AdditionalVoluntaryContribution = PensionSchemeTypeV2Code.AdditionalVoluntaryContribution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pension plan is a defined benefit plan.
    /// Encoded/decoded by serializers as &quot;DBEN&quot;.
    /// </summary>
    [EnumMember(Value = "DBEN")]
    [IsoId("_u01fI-lpEeuvhrZwLF0fDg")]
    [Description(@"Pension plan is a defined benefit plan.")]
    DefinedBenefit = PensionSchemeTypeV2Code.DefinedBenefit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pension plan is an executive pension plan.
    /// Encoded/decoded by serializers as &quot;EXPP&quot;.
    /// </summary>
    [EnumMember(Value = "EXPP")]
    [IsoId("_u01fJelpEeuvhrZwLF0fDg")]
    [Description(@"Pension plan is an executive pension plan.")]
    ExecutivePensionPlan = PensionSchemeTypeV2Code.ExecutivePensionPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pension plan is a free standing additional voluntary contribution plan.
    /// Encoded/decoded by serializers as &quot;FAVC&quot;.
    /// </summary>
    [EnumMember(Value = "FAVC")]
    [IsoId("_u01fJ-lpEeuvhrZwLF0fDg")]
    [Description(@"Pension plan is a free standing additional voluntary contribution plan.")]
    FreeStandingAdditionalVoluntaryContribution = PensionSchemeTypeV2Code.FreeStandingAdditionalVoluntaryContribution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pension is a group personal pension.
    /// Encoded/decoded by serializers as &quot;GPPS&quot;.
    /// </summary>
    [EnumMember(Value = "GPPS")]
    [IsoId("_u01fKelpEeuvhrZwLF0fDg")]
    [Description(@"Pension is a group personal pension.")]
    GroupPersonalPension = PensionSchemeTypeV2Code.GroupPersonalPension, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pension plan is a group self-invested pension plan.
    /// Encoded/decoded by serializers as &quot;SIPG&quot;.
    /// </summary>
    [EnumMember(Value = "SIPG")]
    [IsoId("_u01fK-lpEeuvhrZwLF0fDg")]
    [Description(@"Pension plan is a group self-invested pension plan.")]
    GroupSelfInvestedPension = PensionSchemeTypeV2Code.GroupSelfInvestedPension, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pension plan is a group stakeholder pension plan.
    /// Encoded/decoded by serializers as &quot;STKG&quot;.
    /// </summary>
    [EnumMember(Value = "STKG")]
    [IsoId("_u01fLelpEeuvhrZwLF0fDg")]
    [Description(@"Pension plan is a group stakeholder pension plan.")]
    GroupStakeholder = PensionSchemeTypeV2Code.GroupStakeholder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pension is an individual pension savings plan with a tax benefit. This is known as an Individual Pension Schema (IPS) in some markets.
    /// Encoded/decoded by serializers as &quot;IPST&quot;.
    /// </summary>
    [EnumMember(Value = "IPST")]
    [IsoId("_u01fL-lpEeuvhrZwLF0fDg")]
    [Description(@"Pension is an individual pension savings plan with a tax benefit. This is known as an Individual Pension Schema (IPS) in some markets.")]
    IndividualPensionWithTaxBenefit = PensionSchemeTypeV2Code.IndividualPensionWithTaxBenefit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pension plan is an individual stakeholder pension.
    /// Encoded/decoded by serializers as &quot;STKI&quot;.
    /// </summary>
    [EnumMember(Value = "STKI")]
    [IsoId("_u01fMelpEeuvhrZwLF0fDg")]
    [Description(@"Pension plan is an individual stakeholder pension.")]
    IndividualStakeholder = PensionSchemeTypeV2Code.IndividualStakeholder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pension is a mandatory occupational pension. This is known as an Obligatory Occupation Pension (OTP) in some markets.
    /// Encoded/decoded by serializers as &quot;OTPM&quot;.
    /// </summary>
    [EnumMember(Value = "OTPM")]
    [IsoId("_u01fM-lpEeuvhrZwLF0fDg")]
    [Description(@"Pension is a mandatory occupational pension. This is known as an Obligatory Occupation Pension (OTP) in some markets.")]
    MandatoryOccupationalPension = PensionSchemeTypeV2Code.MandatoryOccupationalPension, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pension plan is an occupational defined contribution plan.
    /// Encoded/decoded by serializers as &quot;OCDC&quot;.
    /// </summary>
    [EnumMember(Value = "OCDC")]
    [IsoId("_u01fNelpEeuvhrZwLF0fDg")]
    [Description(@"Pension plan is an occupational defined contribution plan.")]
    OccupationalDefinedContribution = PensionSchemeTypeV2Code.OccupationalDefinedContribution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pension is a personal pension plan.
    /// Encoded/decoded by serializers as &quot;PPNS&quot;.
    /// </summary>
    [EnumMember(Value = "PPNS")]
    [IsoId("_u01fN-lpEeuvhrZwLF0fDg")]
    [Description(@"Pension is a personal pension plan.")]
    PersonalPension = PensionSchemeTypeV2Code.PersonalPension, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pension is a personal pension account. This is known as Employee Pension Kapital (EPK) in some markets.
    /// Encoded/decoded by serializers as &quot;EPKA&quot;.
    /// </summary>
    [EnumMember(Value = "EPKA")]
    [IsoId("_u01fOelpEeuvhrZwLF0fDg")]
    [Description(@"Pension is a personal pension account. This is known as Employee Pension Kapital (EPK) in some markets.")]
    PersonalPensionAccount = PensionSchemeTypeV2Code.PersonalPensionAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pension is a private occupational pension. This is known as an industrial and trade supplementary pension (ITP) in some markets.
    /// Encoded/decoded by serializers as &quot;ITPO&quot;.
    /// </summary>
    [EnumMember(Value = "ITPO")]
    [IsoId("_u01fO-lpEeuvhrZwLF0fDg")]
    [Description(@"Pension is a private occupational pension. This is known as an industrial and trade supplementary pension (ITP) in some markets.")]
    PrivateOccupationalPension = PensionSchemeTypeV2Code.PrivateOccupationalPension, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pension plan is a retirement annuity.
    /// Encoded/decoded by serializers as &quot;REAN&quot;.
    /// </summary>
    [EnumMember(Value = "REAN")]
    [IsoId("_u01fPelpEeuvhrZwLF0fDg")]
    [Description(@"Pension plan is a retirement annuity.")]
    RetirementAnnuity = PensionSchemeTypeV2Code.RetirementAnnuity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pension type covered by section 32.
    /// Encoded/decoded by serializers as &quot;SC32&quot;.
    /// </summary>
    [EnumMember(Value = "SC32")]
    [IsoId("_u01fP-lpEeuvhrZwLF0fDg")]
    [Description(@"Pension type covered by section 32.")]
    Section32 = PensionSchemeTypeV2Code.Section32, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pension type covered by section 32A.
    /// Encoded/decoded by serializers as &quot;S32A&quot;.
    /// </summary>
    [EnumMember(Value = "S32A")]
    [IsoId("_u01fQelpEeuvhrZwLF0fDg")]
    [Description(@"Pension type covered by section 32A.")]
    Section32A = PensionSchemeTypeV2Code.Section32A, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pension is a self-invested personal pension plan.
    /// Encoded/decoded by serializers as &quot;SIPP&quot;.
    /// </summary>
    [EnumMember(Value = "SIPP")]
    [IsoId("_u01fQ-lpEeuvhrZwLF0fDg")]
    [Description(@"Pension is a self-invested personal pension plan.")]
    SelfInvestedPersonalPension = PensionSchemeTypeV2Code.SelfInvestedPersonalPension, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pension is a small self-administered pension scheme.
    /// Encoded/decoded by serializers as &quot;SSAS&quot;.
    /// </summary>
    [EnumMember(Value = "SSAS")]
    [IsoId("_u01fRelpEeuvhrZwLF0fDg")]
    [Description(@"Pension is a small self-administered pension scheme.")]
    SmallSelfAdministeredScheme = PensionSchemeTypeV2Code.SmallSelfAdministeredScheme, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the party does not operate the pension wrapper.
    /// Encoded/decoded by serializers as &quot;NWRP&quot;.
    /// </summary>
    [EnumMember(Value = "NWRP")]
    [IsoId("_xgf0IelpEeuvhrZwLF0fDg")]
    [Description(@"Indicates that the party does not operate the pension wrapper.")]
    NonWrapperPension = PensionSchemeTypeV2Code.NonWrapperPension, // same ordinal as derivation source for type conversions
    
}
