// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Domain of an identifier.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GvWnULh1Eea3PLWeF1tJsQ")]
[Description(@"Domain of an identifier.")]
[DerivedFrom(typeof(SchemeIdentificationTypeCode))]
public enum SchemeIdentificationType1Code
{
    /// <summary>
    /// Operational construct used to record the set of positions whose margin requirements is calculated on a gross basis.
    /// Encoded/decoded by serializers as &quot;MARG&quot;.
    /// </summary>
    [EnumMember(Value = "MARG")]
    [IsoId("_Gz2FkXa-Eee2GNSe_4BSzQ")]
    [Description(
        @"Operational construct used to record the set of positions whose margin requirements is calculated on a gross basis."
    )]
    MarginAccount = SchemeIdentificationTypeCode.MarginAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Operational construct used by a central counterparty to record ownership of assets posted as collateral by clearing members to meet their obligations at the central counterparty.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_G6lmwXa-Eee2GNSe_4BSzQ")]
    [Description(
        @"Operational construct used by a central counterparty to record ownership of assets posted as collateral by clearing members to meet their obligations at the central counterparty."
    )]
    CollateralAccount = SchemeIdentificationTypeCode.CollateralAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Operational construct used to record a position in a set of financial instruments, often linked by a common set of characteristics, ownership or trading strategy.
    /// Encoded/decoded by serializers as &quot;POSI&quot;.
    /// </summary>
    [EnumMember(Value = "POSI")]
    [IsoId("_HFG0sXa-Eee2GNSe_4BSzQ")]
    [Description(
        @"Operational construct used to record a position in a set of financial instruments, often linked by a common set of characteristics, ownership or trading strategy."
    )]
    PositionAccount = SchemeIdentificationTypeCode.PositionAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal entity that is a participant in a clearing service of a central counterparty, that is the legal counterparty to all novated trades for all the accounts associated with such counterparty.
    /// Encoded/decoded by serializers as &quot;CLIM&quot;.
    /// </summary>
    [EnumMember(Value = "CLIM")]
    [IsoId("_YWoVkXtNEee8tZ67_DQBAw")]
    [Description(
        @"Legal entity that is a participant in a clearing service of a central counterparty, that is the legal counterparty to all novated trades for all the accounts associated with such counterparty."
    )]
    ClearingMemberAccount = SchemeIdentificationTypeCode.ClearingMemberAccount, // same ordinal as derivation source for type conversions
}
