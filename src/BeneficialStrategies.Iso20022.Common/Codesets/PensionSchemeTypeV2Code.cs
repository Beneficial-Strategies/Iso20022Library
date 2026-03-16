// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of pension scheme.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BGikxDOSEeqKY_RYlDm6Pw")]
[Description(@"Specifies a type of pension scheme.")]
[Derivations(typeof(PensionSchemeType2Code), typeof(PensionSchemeType3Code))]
public enum PensionSchemeTypeV2Code
{
    /// <summary>
    /// Pension is a group personal pension.
    /// Encoded/decoded by serializers as &quot;GPPS&quot;.
    /// </summary>
    [EnumMember(Value = "GPPS")]
    [IsoId("_BGikxzOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is a group personal pension.")]
    GroupPersonalPension,

    /// <summary>
    /// Pension is a personal pension plan.
    /// Encoded/decoded by serializers as &quot;PPNS&quot;.
    /// </summary>
    [EnumMember(Value = "PPNS")]
    [IsoId("_BGikxjOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is a personal pension plan.")]
    PersonalPension,

    /// <summary>
    /// Pension is a self-invested personal pension plan.
    /// Encoded/decoded by serializers as &quot;SIPP&quot;.
    /// </summary>
    [EnumMember(Value = "SIPP")]
    [IsoId("_BGik0TOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is a self-invested personal pension plan.")]
    SelfInvestedPersonalPension,

    /// <summary>
    /// Pension plan is a group self-invested pension plan.
    /// Encoded/decoded by serializers as &quot;SIPG&quot;.
    /// </summary>
    [EnumMember(Value = "SIPG")]
    [IsoId("_BGikxTOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is a group self-invested pension plan.")]
    GroupSelfInvestedPension,

    /// <summary>
    /// Pension is a small self-administered pension scheme.
    /// Encoded/decoded by serializers as &quot;SSAS&quot;.
    /// </summary>
    [EnumMember(Value = "SSAS")]
    [IsoId("_BGikyjOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension is a small self-administered pension scheme.")]
    SmallSelfAdministeredScheme,

    /// <summary>
    /// Pension plan is an individual stakeholder pension.
    /// Encoded/decoded by serializers as &quot;STKI&quot;.
    /// </summary>
    [EnumMember(Value = "STKI")]
    [IsoId("_BGikzDOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is an individual stakeholder pension.")]
    IndividualStakeholder,

    /// <summary>
    /// Pension plan is a group stakeholder pension plan.
    /// Encoded/decoded by serializers as &quot;STKG&quot;.
    /// </summary>
    [EnumMember(Value = "STKG")]
    [IsoId("_BGikzjOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is a group stakeholder pension plan.")]
    GroupStakeholder,

    /// <summary>
    /// Pension type covered by section 32.
    /// Encoded/decoded by serializers as &quot;SC32&quot;.
    /// </summary>
    [EnumMember(Value = "SC32")]
    [IsoId("_BGik1zOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension type covered by section 32.")]
    Section32,

    /// <summary>
    /// Pension type covered by section 32A.
    /// Encoded/decoded by serializers as &quot;S32A&quot;.
    /// </summary>
    [EnumMember(Value = "S32A")]
    [IsoId("_BGikzzOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension type covered by section 32A.")]
    Section32A,

    /// <summary>
    /// Pension plan is a retirement annuity.
    /// Encoded/decoded by serializers as &quot;REAN&quot;.
    /// </summary>
    [EnumMember(Value = "REAN")]
    [IsoId("_BGikyzOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is a retirement annuity.")]
    RetirementAnnuity,

    /// <summary>
    /// Pension plan is an occupational defined contribution plan.
    /// Encoded/decoded by serializers as &quot;OCDC&quot;.
    /// </summary>
    [EnumMember(Value = "OCDC")]
    [IsoId("_BGik0jOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is an occupational defined contribution plan.")]
    OccupationalDefinedContribution,

    /// <summary>
    /// Pension plan is an executive pension plan.
    /// Encoded/decoded by serializers as &quot;EXPP&quot;.
    /// </summary>
    [EnumMember(Value = "EXPP")]
    [IsoId("_BGikyDOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is an executive pension plan.")]
    ExecutivePensionPlan,

    /// <summary>
    /// Pension plan is an additional voluntary contribution plan.
    /// Encoded/decoded by serializers as &quot;AAVC&quot;.
    /// </summary>
    [EnumMember(Value = "AAVC")]
    [IsoId("_BGik0DOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is an additional voluntary contribution plan.")]
    AdditionalVoluntaryContribution,

    /// <summary>
    /// Pension plan is a free standing additional voluntary contribution plan.
    /// Encoded/decoded by serializers as &quot;FAVC&quot;.
    /// </summary>
    [EnumMember(Value = "FAVC")]
    [IsoId("_BGik1jOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is a free standing additional voluntary contribution plan.")]
    FreeStandingAdditionalVoluntaryContribution,

    /// <summary>
    /// Pension plan is a defined benefit plan.
    /// Encoded/decoded by serializers as &quot;DBEN&quot;.
    /// </summary>
    [EnumMember(Value = "DBEN")]
    [IsoId("_BGik1DOSEeqKY_RYlDm6Pw")]
    [Description(@"Pension plan is a defined benefit plan.")]
    DefinedBenefit,

    /// <summary>
    /// Pension is an individual pension savings plan with a tax benefit. This is known as an Individual Pension Schema (IPS) in some markets.
    /// Encoded/decoded by serializers as &quot;IPST&quot;.
    /// </summary>
    [EnumMember(Value = "IPST")]
    [IsoId("_BGik0zOSEeqKY_RYlDm6Pw")]
    [Description(
        @"Pension is an individual pension savings plan with a tax benefit. This is known as an Individual Pension Schema (IPS) in some markets."
    )]
    IndividualPensionWithTaxBenefit,

    /// <summary>
    /// Pension is a mandatory occupational pension. This is known as an Obligatory Occupation Pension (OTP) in some markets.
    /// Encoded/decoded by serializers as &quot;OTPM&quot;.
    /// </summary>
    [EnumMember(Value = "OTPM")]
    [IsoId("_BGik1TOSEeqKY_RYlDm6Pw")]
    [Description(
        @"Pension is a mandatory occupational pension. This is known as an Obligatory Occupation Pension (OTP) in some markets."
    )]
    MandatoryOccupationalPension,

    /// <summary>
    /// Pension is a personal pension account. This is known as Employee Pension Kapital (EPK) in some markets.
    /// Encoded/decoded by serializers as &quot;EPKA&quot;.
    /// </summary>
    [EnumMember(Value = "EPKA")]
    [IsoId("_BGikzTOSEeqKY_RYlDm6Pw")]
    [Description(
        @"Pension is a personal pension account. This is known as Employee Pension Kapital (EPK) in some markets."
    )]
    PersonalPensionAccount,

    /// <summary>
    /// Pension is a private occupational pension. This is known as an industrial and trade supplementary pension (ITP) in some markets.
    /// Encoded/decoded by serializers as &quot;ITPO&quot;.
    /// </summary>
    [EnumMember(Value = "ITPO")]
    [IsoId("_BGikyTOSEeqKY_RYlDm6Pw")]
    [Description(
        @"Pension is a private occupational pension. This is known as an industrial and trade supplementary pension (ITP) in some markets."
    )]
    PrivateOccupationalPension,

    /// <summary>
    /// Indicates that the party does not operate the pension wrapper.
    /// Encoded/decoded by serializers as &quot;NWRP&quot;.
    /// </summary>
    [EnumMember(Value = "NWRP")]
    [IsoId("_LnCUoOlpEeuvhrZwLF0fDg")]
    [Description(@"Indicates that the party does not operate the pension wrapper.")]
    NonWrapperPension,
}
