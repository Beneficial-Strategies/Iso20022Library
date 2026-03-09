// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of reorganisation transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y3QJkMU_EeeWeZMpNX1JUQ")]
[Description(@"Specifies the type of reorganisation transaction.")]
[DerivedFrom(typeof(ReorganisationTransactionTypeCode))]
public enum ReorganisationTransactionType1Code
{
    /// <summary>
    /// Reorganisation is a cover on behalf of another participant transaction type.
    /// Encoded/decoded by serializers as &quot;COVP&quot;.
    /// </summary>
    [EnumMember(Value = "COVP")]
    [IsoId("_am1Q0cU_EeeWeZMpNX1JUQ")]
    [Description(@"Reorganisation is a cover on behalf of another participant transaction type.")]
    CoverOnBehalfOfAnotherParticipantTransaction = ReorganisationTransactionTypeCode.CoverOnBehalfOfAnotherParticipantTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reorganisation is a cover protect directly to agent transaction type.
    /// Encoded/decoded by serializers as &quot;COVA&quot;.
    /// </summary>
    [EnumMember(Value = "COVA")]
    [IsoId("_arcrEcU_EeeWeZMpNX1JUQ")]
    [Description(@"Reorganisation is a cover protect directly to agent transaction type.")]
    CoverProtectDirectlyToAgentHeaderTransaction = ReorganisationTransactionTypeCode.CoverProtectDirectlyToAgentHeaderTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reorganisation is a cover protect transaction type.
    /// Encoded/decoded by serializers as &quot;COVR&quot;.
    /// </summary>
    [EnumMember(Value = "COVR")]
    [IsoId("_avnZYcU_EeeWeZMpNX1JUQ")]
    [Description(@"Reorganisation is a cover protect transaction type.")]
    CoverProtectTransaction = ReorganisationTransactionTypeCode.CoverProtectTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reorganisation is a protect on behalf of another participant transaction type.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_azyHscU_EeeWeZMpNX1JUQ")]
    [Description(@"Reorganisation is a protect on behalf of another participant transaction type.")]
    ProtectOnBehalfOfAnotherParticipantTransaction = ReorganisationTransactionTypeCode.ProtectOnBehalfOfAnotherParticipantTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reorganisation is a protect transaction type.
    /// Encoded/decoded by serializers as &quot;PROT&quot;.
    /// </summary>
    [EnumMember(Value = "PROT")]
    [IsoId("_a3zFAcU_EeeWeZMpNX1JUQ")]
    [Description(@"Reorganisation is a protect transaction type.")]
    ProtectTransaction = ReorganisationTransactionTypeCode.ProtectTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reorganisation is a voluntary offer instruction transaction type.
    /// Encoded/decoded by serializers as &quot;VOIT&quot;.
    /// </summary>
    [EnumMember(Value = "VOIT")]
    [IsoId("_a8taMcU_EeeWeZMpNX1JUQ")]
    [Description(@"Reorganisation is a voluntary offer instruction transaction type.")]
    VoluntaryOfferInstructionTransaction = ReorganisationTransactionTypeCode.VoluntaryOfferInstructionTransaction, // same ordinal as derivation source for type conversions
    
}
