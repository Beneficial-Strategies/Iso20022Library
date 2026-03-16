// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of reorganisation transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QcVdoMU9EeeWeZMpNX1JUQ")]
[Description(@"Specifies the type of reorganisation transaction.")]
[Derivations(
    typeof(ReorganisationTransactionType1Code),
    typeof(ProtectTransactionType2Code),
    typeof(ProtectTransactionType3Code),
    typeof(ReorganisationTransactionType2Code)
)]
public enum ReorganisationTransactionTypeCode
{
    /// <summary>
    /// Reorganisation is a protect transaction type.
    /// Encoded/decoded by serializers as &quot;PROT&quot;.
    /// </summary>
    [EnumMember(Value = "PROT")]
    [IsoId("_iUhnMMU9EeeWeZMpNX1JUQ")]
    [Description(@"Reorganisation is a protect transaction type.")]
    ProtectTransaction,

    /// <summary>
    /// Reorganisation is a cover protect transaction type.
    /// Encoded/decoded by serializers as &quot;COVR&quot;.
    /// </summary>
    [EnumMember(Value = "COVR")]
    [IsoId("_nAV2EMU9EeeWeZMpNX1JUQ")]
    [Description(@"Reorganisation is a cover protect transaction type.")]
    CoverProtectTransaction,

    /// <summary>
    /// Reorganisation is a cover protect directly to agent transaction type.
    /// Encoded/decoded by serializers as &quot;COVA&quot;.
    /// </summary>
    [EnumMember(Value = "COVA")]
    [IsoId("_6pVO4MU9EeeWeZMpNX1JUQ")]
    [Description(@"Reorganisation is a cover protect directly to agent transaction type.")]
    CoverProtectDirectlyToAgentHeaderTransaction,

    /// <summary>
    /// Reorganisation is a protect on behalf of another participant transaction type.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_D2Ui4MU-EeeWeZMpNX1JUQ")]
    [Description(@"Reorganisation is a protect on behalf of another participant transaction type.")]
    ProtectOnBehalfOfAnotherParticipantTransaction,

    /// <summary>
    /// Reorganisation is a voluntary offer instruction transaction type.
    /// Encoded/decoded by serializers as &quot;VOIT&quot;.
    /// </summary>
    [EnumMember(Value = "VOIT")]
    [IsoId("_MsG30MU-EeeWeZMpNX1JUQ")]
    [Description(@"Reorganisation is a voluntary offer instruction transaction type.")]
    VoluntaryOfferInstructionTransaction,

    /// <summary>
    /// Reorganisation is a cover on behalf of another participant transaction type.
    /// Encoded/decoded by serializers as &quot;COVP&quot;.
    /// </summary>
    [EnumMember(Value = "COVP")]
    [IsoId("_WluoUMU-EeeWeZMpNX1JUQ")]
    [Description(@"Reorganisation is a cover on behalf of another participant transaction type.")]
    CoverOnBehalfOfAnotherParticipantTransaction,
}
