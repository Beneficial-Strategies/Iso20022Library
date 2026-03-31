// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Collateral  transaction type expressed as an ISO 20022 code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cBwMgLwdEeivTd4NUfCi2g")]
[Description(@"Collateral  transaction type expressed as an ISO 20022 code.")]
[Derivations(typeof(CollateralTransactionType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CollateralTransactionTypeCode>))]
#endif
public enum CollateralTransactionTypeCode
{
    /// <summary>
    /// Automatic/manual settlement adjustment to change the allocation mode from manual to automatic or vice  versa.
    /// Encoded/decoded by serializers as &quot;AADJ&quot;.
    /// </summary>
    [EnumMember(Value = "AADJ")]
    [IsoId("_9-h0ALwdEeivTd4NUfCi2g")]
    [Description(
        @"Automatic/manual settlement adjustment to change the allocation mode from manual to automatic or vice  versa."
    )]
    AllocationModeAdjustment,

    /// <summary>
    /// Change to collateral. Used  when collateral giver manually allocates the securities to the transaction.
    /// Encoded/decoded by serializers as &quot;CADJ&quot;.
    /// </summary>
    [EnumMember(Value = "CADJ")]
    [IsoId("_Hj6Z4LweEeivTd4NUfCi2g")]
    [Description(
        @"Change to collateral. Used  when collateral giver manually allocates the securities to the transaction."
    )]
    CollateralAdjustment,

    /// <summary>
    /// Change of the closing date.
    /// Encoded/decoded by serializers as &quot;CDTA&quot;.
    /// </summary>
    [EnumMember(Value = "CDTA")]
    [IsoId("_jDmpMLweEeivTd4NUfCi2g")]
    [Description(@"Change of the closing date.")]
    ClosingDateAdjustment,

    /// <summary>
    /// Change of other data.
    /// Encoded/decoded by serializers as &quot;DADJ&quot;.
    /// </summary>
    [EnumMember(Value = "DADJ")]
    [IsoId("_b6ADoLyqEeivTd4NUfCi2g")]
    [Description(@"Change of other data.")]
    DataAdjustment,

    /// <summary>
    /// Delivery by value (DBV) transaction.
    /// Encoded/decoded by serializers as &quot;DBVT&quot;.
    /// </summary>
    [EnumMember(Value = "DBVT")]
    [IsoId("_hUpHYLyqEeivTd4NUfCi2g")]
    [Description(@"Delivery by value (DBV) transaction. |")]
    DeliveredByValue,

    /// <summary>
    /// Creation of a Collateral Management Transaction.
    /// Encoded/decoded by serializers as &quot;INIT&quot;.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_lhwoELyqEeivTd4NUfCi2g")]
    [Description(@"Creation of a Collateral Management Transaction.")]
    Initiation,

    /// <summary>
    /// Change to margin.
    /// Encoded/decoded by serializers as &quot;MADJ&quot;.
    /// </summary>
    [EnumMember(Value = "MADJ")]
    [IsoId("_oC_OsLyqEeivTd4NUfCi2g")]
    [Description(@"Change to margin. |")]
    MarginAdjustment,

    /// <summary>
    /// Change of principal/exposure adjustment
    /// Encoded/decoded by serializers as &quot;PADJ&quot;.
    /// </summary>
    [EnumMember(Value = "PADJ")]
    [IsoId("_5YQRYLyqEeivTd4NUfCi2g")]
    [Description(@"Change of principal/exposure adjustment")]
    PrincipalExposureAdjustment,

    /// <summary>
    /// Change of rate.
    /// Encoded/decoded by serializers as &quot;RATA&quot;.
    /// </summary>
    [EnumMember(Value = "RATA")]
    [IsoId("_BlfYkLyrEeivTd4NUfCi2g")]
    [Description(@"Change of rate.")]
    RateAdjustment,

    /// <summary>
    /// Closing of the Collateral Management Transaction.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_GMeKwLyrEeivTd4NUfCi2g")]
    [Description(@"Closing of the Collateral Management Transaction.")]
    Termination,
}
