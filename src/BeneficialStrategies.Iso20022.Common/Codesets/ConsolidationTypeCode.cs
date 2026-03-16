// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the consolidation type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zjlq8CDVEeWCLu74WLgP4w")]
[Description(@"Specifies the consolidation type.")]
[Derivations(typeof(ConsolidationType1Code))]
public enum ConsolidationTypeCode
{
    /// <summary>
    /// Consolidation is general.
    /// Encoded/decoded by serializers as &quot;GENL&quot;.
    /// </summary>
    [EnumMember(Value = "GENL")]
    [IsoId("_mJEkwCDVEeWCLu74WLgP4w")]
    [Description(@"Consolidation is general.")]
    General,

    /// <summary>
    /// Consolidation is at the level of the participant.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_pNTx0CDVEeWCLu74WLgP4w")]
    [Description(@"Consolidation is at the level of the participant.")]
    Participation,
}
