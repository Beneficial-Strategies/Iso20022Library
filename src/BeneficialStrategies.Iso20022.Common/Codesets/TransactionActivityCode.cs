// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of activity to which this transaction relates.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YrP25tp-Ed-ak6NoX_4Aeg_-41180042")]
[Description(@"Specifies the type of activity to which this transaction relates.")]
[Derivations(typeof(TransactionActivity1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransactionActivityCode>))]
#endif
public enum TransactionActivityCode
{
    /// <summary>
    /// Transaction relates to lending/borrowing.
    /// Encoded/decoded by serializers as &quot;BOLE&quot;.
    /// </summary>
    [EnumMember(Value = "BOLE")]
    [IsoId("_YrP259p-Ed-ak6NoX_4Aeg_-330582251")]
    [Description(@"Transaction relates to lending/borrowing.")]
    BorrowingLendingActivity,

    /// <summary>
    /// Transaction relates to a market claim following a corporate action.
    /// Encoded/decoded by serializers as &quot;CLAI&quot;.
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_YrP26Np-Ed-ak6NoX_4Aeg_-328734377")]
    [Description(@"Transaction relates to a market claim following a corporate action.")]
    MarketClaim,

    /// <summary>
    /// Transaction relates to collateral.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_YrZn4Np-Ed-ak6NoX_4Aeg_-327810772")]
    [Description(@"Transaction relates to collateral.")]
    CollateralActivity,

    /// <summary>
    /// Transaction relates to corporate action.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_YrZn4dp-Ed-ak6NoX_4Aeg_-320422749")]
    [Description(@"Transaction relates to corporate action.")]
    CorporateActionActivity,

    /// <summary>
    /// Transaction relates to settlement and clearing.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_YrZn4tp-Ed-ak6NoX_4Aeg_-319499022")]
    [Description(@"Transaction relates to settlement and clearing.")]
    SettlementandClearingActivity,
}
