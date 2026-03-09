// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of activity to which this transaction relates.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YrP24Np-Ed-ak6NoX_4Aeg_166271008")]
[Description(@"Specifies the type of activity to which this transaction relates.")]
[DerivedFrom(typeof(TransactionActivityCode))]
public enum TransactionActivity1Code
{
    /// <summary>
    /// Transaction relates to lending/borrowing.
    /// Encoded/decoded by serializers as &quot;BOLE&quot;.
    /// </summary>
    [EnumMember(Value = "BOLE")]
    [IsoId("_YrP24dp-Ed-ak6NoX_4Aeg_166271038")]
    [Description(@"Transaction relates to lending/borrowing.")]
    BorrowingLendingActivity = TransactionActivityCode.BorrowingLendingActivity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction relates to a market claim following a corporate action.
    /// Encoded/decoded by serializers as &quot;CLAI&quot;.
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_YrP24tp-Ed-ak6NoX_4Aeg_166271039")]
    [Description(@"Transaction relates to a market claim following a corporate action.")]
    MarketClaim = TransactionActivityCode.MarketClaim, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction relates to collateral.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_YrP249p-Ed-ak6NoX_4Aeg_166271040")]
    [Description(@"Transaction relates to collateral.")]
    CollateralActivity = TransactionActivityCode.CollateralActivity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction relates to corporate action.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_YrP25Np-Ed-ak6NoX_4Aeg_166271069")]
    [Description(@"Transaction relates to corporate action.")]
    CorporateActionActivity = TransactionActivityCode.CorporateActionActivity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction relates to settlement and clearing.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_YrP25dp-Ed-ak6NoX_4Aeg_166271070")]
    [Description(@"Transaction relates to settlement and clearing.")]
    SettlementandClearingActivity = TransactionActivityCode.SettlementandClearingActivity, // same ordinal as derivation source for type conversions
    
}
