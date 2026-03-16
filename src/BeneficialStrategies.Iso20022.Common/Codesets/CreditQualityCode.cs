// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Credit quality rating of an issuer or financial obligation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VUiw4KcjEeaGcf8_qtd8Yw")]
[Description(@"Credit quality rating of an issuer or financial obligation.")]
[Derivations(typeof(CreditQuality1Code))]
public enum CreditQualityCode
{
    /// <summary>
    /// Credit rating that indicates a default or default-like process has begun, or the issuer is in standstill, or for a closed funding vehicle, payment capacity is irrevocably impaired.
    /// Encoded/decoded by serializers as &quot;DFIM&quot;.
    /// </summary>
    [EnumMember(Value = "DFIM")]
    [IsoId("_x_DNgKcjEeaGcf8_qtd8Yw")]
    [Description(
        @"Credit rating that indicates a default or default-like process has begun, or the issuer is in standstill, or for a closed funding vehicle, payment capacity is irrevocably impaired."
    )]
    DefaultImminent,

    /// <summary>
    /// Default of some kind appears probable.
    /// Encoded/decoded by serializers as &quot;EXSP&quot;.
    /// </summary>
    [EnumMember(Value = "EXSP")]
    [IsoId("_28FvQKcjEeaGcf8_qtd8Yw")]
    [Description(@"Default of some kind appears probable.")]
    ExtremelySpeculative,

    /// <summary>
    /// Credit rating that denotes expectations of very low default risk. It indicates a very strong capacity for payment of financial commitments which is not significantly vulnerable to foreseeable events.
    /// Encoded/decoded by serializers as &quot;HIGR&quot;.
    /// </summary>
    [EnumMember(Value = "HIGR")]
    [IsoId("_6azR0KcjEeaGcf8_qtd8Yw")]
    [Description(
        @"Credit rating that denotes expectations of very low default risk. It indicates a very strong capacity for payment of financial commitments which is not significantly vulnerable to foreseeable events."
    )]
    HighGrade,

    /// <summary>
    /// Credit rating that indicates that material default risk is present, but a limited margin of safety remains. Financial commitments are currently being met; however, capacity for continued payment is vulnerable to deterioration in the business and economic environment.
    /// Encoded/decoded by serializers as &quot;HISP&quot;.
    /// </summary>
    [EnumMember(Value = "HISP")]
    [IsoId("_83J_gKcjEeaGcf8_qtd8Yw")]
    [Description(
        @"Credit rating that indicates that material default risk is present, but a limited margin of safety remains. Financial commitments are currently being met; however, capacity for continued payment is vulnerable to deterioration in the business and economic environment."
    )]
    HighlySpeculative,

    /// <summary>
    /// Credit rating that indicates an issuer has entered into bankruptcy filings, administration, receivership, liquidation or other formal winding-up procedure or that has otherwise ceased business.
    /// Encoded/decoded by serializers as &quot;INDF&quot;.
    /// </summary>
    [EnumMember(Value = "INDF")]
    [IsoId("__kLmcKcjEeaGcf8_qtd8Yw")]
    [Description(
        @"Credit rating that indicates an issuer has entered into bankruptcy filings, administration, receivership, liquidation or other formal winding-up procedure or that has otherwise ceased business."
    )]
    InDefault,

    /// <summary>
    /// Credit rating that indicates that expectations of default risk are currently low. The capacity for payment of financial commitments is considered adequate, but adverse business or economic conditions are more likely to impair this capacity.
    /// Encoded/decoded by serializers as &quot;LMGR&quot;.
    /// </summary>
    [EnumMember(Value = "LMGR")]
    [IsoId("_B6ldIKckEeaGcf8_qtd8Yw")]
    [Description(
        @"Credit rating that indicates that expectations of default risk are currently low. The capacity for payment of financial commitments is considered adequate, but adverse business or economic conditions are more likely to impair this capacity."
    )]
    LowerMediumGrade,

    /// <summary>
    /// Credit rating that indicates an elevated vulnerability to default risk, particularly in the event of adverse changes in business or economic conditions over time; however, business or financial flexibility exists that supports the servicing of financial commitments.
    /// Encoded/decoded by serializers as &quot;NIGS&quot;.
    /// </summary>
    [EnumMember(Value = "NIGS")]
    [IsoId("_EAojoKckEeaGcf8_qtd8Yw")]
    [Description(
        @"Credit rating that indicates an elevated vulnerability to default risk, particularly in the event of adverse changes in business or economic conditions over time; however, business or financial flexibility exists that supports the servicing of financial commitments."
    )]
    NonInvestmentGradeSpeculative,

    /// <summary>
    /// Credit rating that denotes the lowest expectation of default risk. Assigned only in cases of exceptionally strong capacity for payment of financial commitments. Where the capacity to meet financial commitments is highly unlikely to be adversely affected by foreseeable events.
    /// Encoded/decoded by serializers as &quot;PRIM&quot;.
    /// </summary>
    [EnumMember(Value = "PRIM")]
    [IsoId("_IoYx4KckEeaGcf8_qtd8Yw")]
    [Description(
        @"Credit rating that denotes the lowest expectation of default risk. Assigned only in cases of exceptionally strong capacity for payment of financial commitments. Where the capacity to meet financial commitments is highly unlikely to be adversely affected by foreseeable events."
    )]
    Prime,

    /// <summary>
    /// Default is a real possibility.
    /// Encoded/decoded by serializers as &quot;SURI&quot;.
    /// </summary>
    [EnumMember(Value = "SURI")]
    [IsoId("_LodQoKckEeaGcf8_qtd8Yw")]
    [Description(@"Default is a real possibility.")]
    SubstantialRisk,

    /// <summary>
    /// Credit rating that denotes expectations of low default risk. The capacity for payment of financial commitments is considered strong. This capacity may, nevertheless, be more vulnerable to adverse business or economic conditions than is the case for higher ratings.
    /// Encoded/decoded by serializers as &quot;UMGR&quot;.
    /// </summary>
    [EnumMember(Value = "UMGR")]
    [IsoId("_QpzqoKckEeaGcf8_qtd8Yw")]
    [Description(
        @"Credit rating that denotes expectations of low default risk. The capacity for payment of financial commitments is considered strong. This capacity may, nevertheless, be more vulnerable to adverse business or economic conditions than is the case for higher ratings."
    )]
    UpperMediumGrade,
}
