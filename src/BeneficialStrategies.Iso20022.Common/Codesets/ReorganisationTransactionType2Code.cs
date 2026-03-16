// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of reorganisation transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_al_E4OcZEei5aPS232E3Mw")]
[Description(@"Specifies the type of reorganisation transaction.")]
[DerivedFrom(typeof(ReorganisationTransactionTypeCode))]
public enum ReorganisationTransactionType2Code
{
    /// <summary>
    /// Reorganisation is a cover protect directly to agent transaction type.
    /// Encoded/decoded by serializers as &quot;COVA&quot;.
    /// </summary>
    [EnumMember(Value = "COVA")]
    [IsoId("_uO0ssecZEei5aPS232E3Mw")]
    [Description(@"Reorganisation is a cover protect directly to agent transaction type.")]
    CoverProtectDirectlyToAgentHeaderTransaction =
        ReorganisationTransactionTypeCode.CoverProtectDirectlyToAgentHeaderTransaction, // same ordinal as derivation source for type conversions
}
