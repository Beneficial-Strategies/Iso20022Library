// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of pension scheme.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FWsKoE4QEeiQHa-q1Uephw")]
[Description(@"Specifies a type of pension scheme.")]
[DerivedFrom(typeof(PensionSchemeTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PensionSchemeType1Code>))]
#endif
public enum PensionSchemeType1Code
{
    /// <summary>
    /// Pension plan is an additional voluntary contribution plan.
    /// Encoded/decoded by serializers as &quot;AAVC&quot;.
    /// </summary>
    [EnumMember(Value = "AAVC")]
    [IsoId("_Gc6L0U4QEeiQHa-q1Uephw")]
    [Description(@"Pension plan is an additional voluntary contribution plan.")]
    AdditionalVoluntaryContribution = PensionSchemeTypeCode.AdditionalVoluntaryContribution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension plan is a defined benefit plan.
    /// Encoded/decoded by serializers as &quot;DBEN&quot;.
    /// </summary>
    [EnumMember(Value = "DBEN")]
    [IsoId("_GhE6IU4QEeiQHa-q1Uephw")]
    [Description(@"Pension plan is a defined benefit plan.")]
    DefinedBenefit = PensionSchemeTypeCode.DefinedBenefit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension plan is an executive pension plan.
    /// Encoded/decoded by serializers as &quot;EXPP&quot;.
    /// </summary>
    [EnumMember(Value = "EXPP")]
    [IsoId("_GoES8U4QEeiQHa-q1Uephw")]
    [Description(@"Pension plan is an executive pension plan.")]
    ExecutivePension = PensionSchemeTypeCode.ExecutivePension, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension plan is a free standing additional voluntary contribution plan.
    /// Encoded/decoded by serializers as &quot;FAVC&quot;.
    /// </summary>
    [EnumMember(Value = "FAVC")]
    [IsoId("_GtlFEU4QEeiQHa-q1Uephw")]
    [Description(@"Pension plan is a free standing additional voluntary contribution plan.")]
    FreeStandingAdditionalVoluntaryContribution =
        PensionSchemeTypeCode.FreeStandingAdditionalVoluntaryContribution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension plan is a group-invested pension plan.
    /// Encoded/decoded by serializers as &quot;SIPG&quot;.
    /// </summary>
    [EnumMember(Value = "SIPG")]
    [IsoId("_Gx49UU4QEeiQHa-q1Uephw")]
    [Description(@"Pension plan is a group-invested pension plan.")]
    GroupInvestedPension = PensionSchemeTypeCode.GroupInvestedPension, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension is a group personal pension scheme.
    /// Encoded/decoded by serializers as &quot;GPPS&quot;.
    /// </summary>
    [EnumMember(Value = "GPPS")]
    [IsoId("_G3_lUU4QEeiQHa-q1Uephw")]
    [Description(@"Pension is a group personal pension scheme.")]
    GroupPersonalPensionScheme = PensionSchemeTypeCode.GroupPersonalPensionScheme, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension plan is a group stakeholder pension plan.
    /// Encoded/decoded by serializers as &quot;STKG&quot;.
    /// </summary>
    [EnumMember(Value = "STKG")]
    [IsoId("_G9M1cU4QEeiQHa-q1Uephw")]
    [Description(@"Pension plan is a group stakeholder pension plan.")]
    GroupStakeholder = PensionSchemeTypeCode.GroupStakeholder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension plan is an individual stakeholder pension.
    /// Encoded/decoded by serializers as &quot;STKI&quot;.
    /// </summary>
    [EnumMember(Value = "STKI")]
    [IsoId("_HBW8sU4QEeiQHa-q1Uephw")]
    [Description(@"Pension plan is an individual stakeholder pension.")]
    IndividualStakeholder = PensionSchemeTypeCode.IndividualStakeholder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension plan is an occupational direct contribution plan.
    /// Encoded/decoded by serializers as &quot;OCDC&quot;.
    /// </summary>
    [EnumMember(Value = "OCDC")]
    [IsoId("_HGIH8U4QEeiQHa-q1Uephw")]
    [Description(@"Pension plan is an occupational direct contribution plan.")]
    OccupationalDirectContribution = PensionSchemeTypeCode.OccupationalDirectContribution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension is a personal pension plan.
    /// Encoded/decoded by serializers as &quot;PPNS&quot;.
    /// </summary>
    [EnumMember(Value = "PPNS")]
    [IsoId("_HMhD0U4QEeiQHa-q1Uephw")]
    [Description(@"Pension is a personal pension plan.")]
    PersonalPension = PensionSchemeTypeCode.PersonalPension, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension plan is a retirement annuity.
    /// Encoded/decoded by serializers as &quot;REAN&quot;.
    /// </summary>
    [EnumMember(Value = "REAN")]
    [IsoId("_HQ-tEU4QEeiQHa-q1Uephw")]
    [Description(@"Pension plan is a retirement annuity.")]
    RetirementAnnuity = PensionSchemeTypeCode.RetirementAnnuity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension type covered by section 32.
    /// Encoded/decoded by serializers as &quot;SC32&quot;.
    /// </summary>
    [EnumMember(Value = "SC32")]
    [IsoId("_HVv4UU4QEeiQHa-q1Uephw")]
    [Description(@"Pension type covered by section 32.")]
    Section32 = PensionSchemeTypeCode.Section32, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension type covered by section 32A.
    /// Encoded/decoded by serializers as &quot;S32A&quot;.
    /// </summary>
    [EnumMember(Value = "S32A")]
    [IsoId("_HbZNUU4QEeiQHa-q1Uephw")]
    [Description(@"Pension type covered by section 32A.")]
    Section32A = PensionSchemeTypeCode.Section32A, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension is a self-invested pension plan.
    /// Encoded/decoded by serializers as &quot;SIPP&quot;.
    /// </summary>
    [EnumMember(Value = "SIPP")]
    [IsoId("_HhM6YU4QEeiQHa-q1Uephw")]
    [Description(@"Pension is a self-invested pension plan.")]
    SelfInvestedPension = PensionSchemeTypeCode.SelfInvestedPension, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension is a small self-administered pension schema.
    /// Encoded/decoded by serializers as &quot;SSAS&quot;.
    /// </summary>
    [EnumMember(Value = "SSAS")]
    [IsoId("_HnS7UU4QEeiQHa-q1Uephw")]
    [Description(@"Pension is a small self-administered pension schema.")]
    SmallSelfAdministeredSchema = PensionSchemeTypeCode.SmallSelfAdministeredSchema, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension is an individual pension savings plan with a tax benefit. This is known as an Individual Pension Schema (IPS) in some markets.
    /// Encoded/decoded by serializers as &quot;IPST&quot;.
    /// </summary>
    [EnumMember(Value = "IPST")]
    [IsoId("_wz7H8V23EeiFXdiLi_Nf4A")]
    [Description(
        @"Pension is an individual pension savings plan with a tax benefit. This is known as an Individual Pension Schema (IPS) in some markets."
    )]
    IndividualPensionWithTaxBenefit = PensionSchemeTypeCode.IndividualPensionWithTaxBenefit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension is a personal pension account. This is known as Employee Pension Kapital (EPK) in some markets.
    /// Encoded/decoded by serializers as &quot;EPKA&quot;.
    /// </summary>
    [EnumMember(Value = "EPKA")]
    [IsoId("_w79CkV23EeiFXdiLi_Nf4A")]
    [Description(
        @"Pension is a personal pension account. This is known as Employee Pension Kapital (EPK) in some markets."
    )]
    PersonalPensionAccount = PensionSchemeTypeCode.PersonalPensionAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension is a private occupational pension. This is known as an industrial and trade supplementary pension (ITP) in some markets.
    /// Encoded/decoded by serializers as &quot;ITPO&quot;.
    /// </summary>
    [EnumMember(Value = "ITPO")]
    [IsoId("_xCfvcV23EeiFXdiLi_Nf4A")]
    [Description(
        @"Pension is a private occupational pension. This is known as an industrial and trade supplementary pension (ITP) in some markets."
    )]
    PrivateOccupationalPension = PensionSchemeTypeCode.PrivateOccupationalPension, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension is a mandatory occupational pension. This is known as an Obligatory Occupation Pension (OTP) in some markets.
    /// Encoded/decoded by serializers as &quot;OTPM&quot;.
    /// </summary>
    [EnumMember(Value = "OTPM")]
    [IsoId("_xVinQV23EeiFXdiLi_Nf4A")]
    [Description(
        @"Pension is a mandatory occupational pension. This is known as an Obligatory Occupation Pension (OTP) in some markets."
    )]
    MandatoryOccupationalPension = PensionSchemeTypeCode.MandatoryOccupationalPension, // same ordinal as derivation source for type conversions
}
