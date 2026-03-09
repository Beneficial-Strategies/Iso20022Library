// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the possible types of voting instructions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QoCAzq4IEemG7MmivSuE5g")]
[Description(@"Specifies the possible types of voting instructions.")]
[Derivations(typeof(VoteInstruction5Code),typeof(VoteInstruction6Code),typeof(VoteInstruction7Code))]
public enum VoteInstructionV2Code
{
    /// <summary>
    /// Vote in favour of a meeting resolution.
    /// Encoded/decoded by serializers as &quot;CFOR&quot;.
    /// </summary>
    [EnumMember(Value = "CFOR")]
    [IsoId("_QoCA264IEemG7MmivSuE5g")]
    [Description(@"Vote in favour of a meeting resolution.")]
    For,
    
    /// <summary>
    /// Vote against a meeting resolution.
    /// Encoded/decoded by serializers as &quot;CAGS&quot;.
    /// </summary>
    [EnumMember(Value = "CAGS")]
    [IsoId("_QoCA1a4IEemG7MmivSuE5g")]
    [Description(@"Vote against a meeting resolution.")]
    Against,
    
    /// <summary>
    /// Active vote expressed as abstain (no opinion).
    /// Encoded/decoded by serializers as &quot;ABST&quot;.
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_QoCA1q4IEemG7MmivSuE5g")]
    [Description(@"Active vote expressed as abstain (no opinion).")]
    Abstain,
    
    /// <summary>
    /// Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market).
    /// Encoded/decoded by serializers as &quot;WTHH&quot;.
    /// </summary>
    [EnumMember(Value = "WTHH")]
    [IsoId("_QoCA1K4IEemG7MmivSuE5g")]
    [Description(@"Participant to a meeting withholds its vote for a meeting resolution. This action is usually taken in order to indicate a strong disagreement with a resolution (US market).")]
    Withhold,
    
    /// <summary>
    /// Vote instruction is in line with the voting recommendations of the management.
    /// Encoded/decoded by serializers as &quot;WMGT&quot;.
    /// </summary>
    [EnumMember(Value = "WMGT")]
    [IsoId("_QoCA164IEemG7MmivSuE5g")]
    [Description(@"Vote instruction is in line with the voting recommendations of the management.")]
    WithManagement,
    
    /// <summary>
    /// Vote instruction is in against the voting recommendations of the management.
    /// Encoded/decoded by serializers as &quot;AMGT&quot;.
    /// </summary>
    [EnumMember(Value = "AMGT")]
    [IsoId("_QoCA2q4IEemG7MmivSuE5g")]
    [Description(@"Vote instruction is in against the voting recommendations of the management.")]
    AgainstManagement,
    
    /// <summary>
    /// Voting party is assigned discretionary right to vote for one resolution.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_QoCA0K4IEemG7MmivSuE5g")]
    [Description(@"Voting party is assigned discretionary right to vote for one resolution.")]
    Discretionary,
    
    /// <summary>
    /// Do not vote.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_QoCA0a4IEemG7MmivSuE5g")]
    [Description(@"Do not vote.")]
    NoAction,
    
    /// <summary>
    /// Rights holder gives authority to the chairman to vote on his behalf.
    /// Encoded/decoded by serializers as &quot;CHRM&quot;.
    /// </summary>
    [EnumMember(Value = "CHRM")]
    [IsoId("_QoCA064IEemG7MmivSuE5g")]
    [Description(@"Rights holder gives authority to the chairman to vote on his behalf.")]
    Chairman,
    
    /// <summary>
    /// Vote in favour for one year for &quot;say on pay&quot; type of resolution.
    /// Encoded/decoded by serializers as &quot;ONEY&quot;.
    /// </summary>
    [EnumMember(Value = "ONEY")]
    [IsoId("_QoCA0q4IEemG7MmivSuE5g")]
    [Description(@"Vote in favour for one year for ""say on pay"" type of resolution.")]
    OneYear,
    
    /// <summary>
    /// Vote in favour for two years for &quot;say on pay&quot; type of resolution.
    /// Encoded/decoded by serializers as &quot;TWOY&quot;.
    /// </summary>
    [EnumMember(Value = "TWOY")]
    [IsoId("_QoCA2K4IEemG7MmivSuE5g")]
    [Description(@"Vote in favour for two years for ""say on pay"" type of resolution.")]
    TwoYears,
    
    /// <summary>
    /// Vote in favour for three years for &quot;say on pay&quot; type of resolution.
    /// Encoded/decoded by serializers as &quot;THRY&quot;.
    /// </summary>
    [EnumMember(Value = "THRY")]
    [IsoId("_QoCA2a4IEemG7MmivSuE5g")]
    [Description(@"Vote in favour for three years for ""say on pay"" type of resolution.")]
    ThreeYears,
    
    /// <summary>
    /// Vote is cast as empty but the vote is counted.
    /// Encoded/decoded by serializers as &quot;BLNK&quot;.
    /// </summary>
    [EnumMember(Value = "BLNK")]
    [IsoId("_QoCAz64IEemG7MmivSuE5g")]
    [Description(@"Vote is cast as empty but the vote is counted.")]
    Blank,
    
    /// <summary>
    /// No recommendation provided for the vote instruction type.
    /// Encoded/decoded by serializers as &quot;NREC&quot;.
    /// </summary>
    [EnumMember(Value = "NREC")]
    [IsoId("_ie7EoK4aEemG7MmivSuE5g")]
    [Description(@"No recommendation provided for the vote instruction type.")]
    NoRecommendation,
    
}
