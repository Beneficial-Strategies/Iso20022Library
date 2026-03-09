// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the possible types of voting instructions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y9bzEdp-Ed-ak6NoX_4Aeg_2072155739")]
[Description(@"Specifies the possible types of voting instructions.")]
[Derivations(typeof(VoteInstruction1Code),typeof(VoteInstruction4Code),typeof(VoteInstruction3Code),typeof(VoteInstruction2Code),typeof(VoteInstructionAtMeeting1Code))]
public enum VoteInstructionCode
{
    /// <summary>
    /// Vote in favour of a meeting resolution.
    /// Encoded/decoded by serializers as &quot;CFOR&quot;.
    /// </summary>
    [EnumMember(Value = "CFOR")]
    [IsoId("_Y9bzEtp-Ed-ak6NoX_4Aeg_1363718364")]
    [Description(@"Vote in favour of a meeting resolution.")]
    For,
    
    /// <summary>
    /// Vote against a meeting resolution.
    /// Encoded/decoded by serializers as &quot;CAGS&quot;.
    /// </summary>
    [EnumMember(Value = "CAGS")]
    [IsoId("_Y9bzE9p-Ed-ak6NoX_4Aeg_1366490757")]
    [Description(@"Vote against a meeting resolution.")]
    Against,
    
    /// <summary>
    /// Active vote expressed as abstain (no opinion).
    /// Encoded/decoded by serializers as &quot;ABST&quot;.
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_Y9bzFNp-Ed-ak6NoX_4Aeg_1606604412")]
    [Description(@"Active vote expressed as abstain (no opinion).")]
    Abstain,
    
    /// <summary>
    /// Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market).
    /// Encoded/decoded by serializers as &quot;WTHH&quot;.
    /// </summary>
    [EnumMember(Value = "WTHH")]
    [IsoId("_Y9bzFdp-Ed-ak6NoX_4Aeg_1610301180")]
    [Description(@"Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market).")]
    Withhold,
    
    /// <summary>
    /// Vote instruction is in line with the voting recommendations of the management.
    /// Encoded/decoded by serializers as &quot;WMGT&quot;.
    /// </summary>
    [EnumMember(Value = "WMGT")]
    [IsoId("_Y9bzFtp-Ed-ak6NoX_4Aeg_1613993530")]
    [Description(@"Vote instruction is in line with the voting recommendations of the management.")]
    WithManagement,
    
    /// <summary>
    /// Vote instruction is in against the voting recommendations of the management.
    /// Encoded/decoded by serializers as &quot;AMGT&quot;.
    /// </summary>
    [EnumMember(Value = "AMGT")]
    [IsoId("_Y9bzF9p-Ed-ak6NoX_4Aeg_1623229081")]
    [Description(@"Vote instruction is in against the voting recommendations of the management.")]
    AgainstManagement,
    
    /// <summary>
    /// Voting party is assigned discretionary right to vote for one resolution.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_Y9bzGNp-Ed-ak6NoX_4Aeg_985657770")]
    [Description(@"Voting party is assigned discretionary right to vote for one resolution.")]
    Discretionary,
    
    /// <summary>
    /// Indicates a recommendation to take no action.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_Y9k9ANp-Ed-ak6NoX_4Aeg_580576107")]
    [Description(@"Indicates a recommendation to take no action.")]
    NoAction,
    
    /// <summary>
    /// Specifies that the rights holder gives authority to the chairman to vote on his behalf.
    /// Encoded/decoded by serializers as &quot;CHRM&quot;.
    /// </summary>
    [EnumMember(Value = "CHRM")]
    [IsoId("_Y9k9Adp-Ed-ak6NoX_4Aeg_1528124890")]
    [Description(@"Specifies that the rights holder gives authority to the chairman to vote on his behalf.")]
    Chairman,
    
    /// <summary>
    /// Vote in favour for one year for &quot;say on pay&quot; type of resolution.
    /// Encoded/decoded by serializers as &quot;ONEY&quot;.
    /// </summary>
    [EnumMember(Value = "ONEY")]
    [IsoId("_PAnpsF69EeSjaerr_EM7AQ")]
    [Description(@"Vote in favour for one year for ""say on pay"" type of resolution.")]
    OneYear,
    
    /// <summary>
    /// Vote in favour for two years for &quot;say on pay&quot; type of resolution.
    /// Encoded/decoded by serializers as &quot;TWOY&quot;.
    /// </summary>
    [EnumMember(Value = "TWOY")]
    [IsoId("_fxC58F69EeSjaerr_EM7AQ")]
    [Description(@"Vote in favour for two years for ""say on pay"" type of resolution.")]
    TwoYears,
    
    /// <summary>
    /// Vote in favour for three years for &quot;say on pay&quot; type of resolution.
    /// Encoded/decoded by serializers as &quot;THRY&quot;.
    /// </summary>
    [EnumMember(Value = "THRY")]
    [IsoId("_kovosF69EeSjaerr_EM7AQ")]
    [Description(@"Vote in favour for three years for ""say on pay"" type of resolution.")]
    ThreeYears,
    
}
