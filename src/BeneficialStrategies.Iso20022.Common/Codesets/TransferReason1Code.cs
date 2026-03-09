// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the assets transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SGnRUPr5EeCu2Z1WwxJVWA")]
[Description(@"Specifies the reason for the assets transfer.")]
[DerivedFrom(typeof(TransferReasonCode))]
public enum TransferReason1Code
{
    /// <summary>
    /// Transfer is an undivided possession.
    /// Encoded/decoded by serializers as &quot;TRAU&quot;.
    /// </summary>
    [EnumMember(Value = "TRAU")]
    [IsoId("_jmXjef8wEeCuNd2SpsBr7g")]
    [Description(@"Transfer is an undivided possession.")]
    UndividedPossession = TransferReasonCode.UndividedPossession, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer is between spouses.
    /// Encoded/decoded by serializers as &quot;TRAC&quot;.
    /// </summary>
    [EnumMember(Value = "TRAC")]
    [IsoId("_jpfv_v8wEeCuNd2SpsBr7g")]
    [Description(@"Transfer is between spouses.")]
    TransferBetweenSpouses = TransferReasonCode.TransferBetweenSpouses, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer is a trade.
    /// Encoded/decoded by serializers as &quot;TRAT&quot;.
    /// </summary>
    [EnumMember(Value = "TRAT")]
    [IsoId("_jt-ATv8wEeCuNd2SpsBr7g")]
    [Description(@"Transfer is a trade.")]
    Trade = TransferReasonCode.Trade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer is ordinary.
    /// Encoded/decoded by serializers as &quot;TRAO&quot;.
    /// </summary>
    [EnumMember(Value = "TRAO")]
    [IsoId("_jyIunv8wEeCuNd2SpsBr7g")]
    [Description(@"Transfer is ordinary.")]
    OrdinaryTransfer = TransferReasonCode.OrdinaryTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer is a heritage.
    /// Encoded/decoded by serializers as &quot;TRAI&quot;.
    /// </summary>
    [EnumMember(Value = "TRAI")]
    [IsoId("_j1kdHv8wEeCuNd2SpsBr7g")]
    [Description(@"Transfer is a heritage.")]
    Heritage = TransferReasonCode.Heritage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer is a gift.
    /// Encoded/decoded by serializers as &quot;TRAG&quot;.
    /// </summary>
    [EnumMember(Value = "TRAG")]
    [IsoId("_j5cQfv8wEeCuNd2SpsBr7g")]
    [Description(@"Transfer is a gift.")]
    Gift = TransferReasonCode.Gift, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer to pledged account (in certain circumstances distributors have to freeze and transfer total or partial holding to separate omnibus account e.g. investigation required by fiscal authority or police).
    /// Encoded/decoded by serializers as &quot;TPLD&quot;.
    /// </summary>
    [EnumMember(Value = "TPLD")]
    [IsoId("_-i0zjv_YEeCq5NtzDTui4w")]
    [Description(@"Transfer to pledged account (in certain circumstances distributors have to freeze and transfer total or partial holding to separate omnibus account e.g. investigation required by fiscal authority or police).")]
    PledgedAccountTransfer = TransferReasonCode.PledgedAccountTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer instruction executed within TDT framework (TDT framework is the operation model promoted by the Italian Banking Association for transfer and most of transfers, but not all, will be executed in accordance with that process).
    /// Encoded/decoded by serializers as &quot;TTDT&quot;.
    /// </summary>
    [EnumMember(Value = "TTDT")]
    [IsoId("_-mZr9v_YEeCq5NtzDTui4w")]
    [Description(@"Transfer instruction executed within TDT framework (TDT framework is the operation model promoted by the Italian Banking Association for transfer and most of transfers, but not all, will be executed in accordance with that process).")]
    TDTFrameworkTransfer = TransferReasonCode.TDTFrameworkTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer between different beneficiaries with taxation to be applied (accounts with different owner).
    /// Encoded/decoded by serializers as &quot;TRPE&quot;.
    /// </summary>
    [EnumMember(Value = "TRPE")]
    [IsoId("_-q38Tv_YEeCq5NtzDTui4w")]
    [Description(@"Transfer between different beneficiaries with taxation to be applied (accounts with different owner).")]
    TransferBetweenDifferentBeneficiaries = TransferReasonCode.TransferBetweenDifferentBeneficiaries, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer is the result of a demerger or division.
    /// Encoded/decoded by serializers as &quot;TRAF&quot;.
    /// </summary>
    [EnumMember(Value = "TRAF")]
    [IsoId("_E7sZBgCoEeG3Ye2sV3fsog")]
    [Description(@"Transfer is the result of a demerger or division.")]
    Demerger = TransferReasonCode.Demerger, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer is between own accounts.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_-h3G4ENHEeGHJ_bHJRPaIQ_318694537")]
    [Description(@"Transfer is between own accounts.")]
    BetweenOwnAccounts = TransferReasonCode.BetweenOwnAccounts, // same ordinal as derivation source for type conversions
    
}
