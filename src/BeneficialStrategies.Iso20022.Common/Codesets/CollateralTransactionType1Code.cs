// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of collateral instruction as a code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zKAQULyzEeivTd4NUfCi2g")]
[Description(@"Specifies the type of collateral instruction as a code.")]
[DerivedFrom(typeof(CollateralTransactionTypeCode))]
public enum CollateralTransactionType1Code
{
    /// <summary>
    /// Automatic/manual settlement adjustment to change the allocation mode from manual to automatic or vice  versa.
    /// Encoded/decoded by serializers as &quot;AADJ&quot;.
    /// </summary>
    [EnumMember(Value = "AADJ")]
    [IsoId("_4oc2AbyzEeivTd4NUfCi2g")]
    [Description(
        @"Automatic/manual settlement adjustment to change the allocation mode from manual to automatic or vice  versa."
    )]
    AllocationModeAdjustment = CollateralTransactionTypeCode.AllocationModeAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Change of the closing date.
    /// Encoded/decoded by serializers as &quot;CDTA&quot;.
    /// </summary>
    [EnumMember(Value = "CDTA")]
    [IsoId("_43ILMryzEeivTd4NUfCi2g")]
    [Description(@"Change of the closing date.")]
    ClosingDateAdjustment = CollateralTransactionTypeCode.ClosingDateAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Change to collateral. Used  when collateral giver manually allocates the securities to the transaction.
    /// Encoded/decoded by serializers as &quot;CADJ&quot;.
    /// </summary>
    [EnumMember(Value = "CADJ")]
    [IsoId("_45Er8byzEeivTd4NUfCi2g")]
    [Description(
        @"Change to collateral. Used  when collateral giver manually allocates the securities to the transaction."
    )]
    CollateralAdjustment = CollateralTransactionTypeCode.CollateralAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Change of other data.
    /// Encoded/decoded by serializers as &quot;DADJ&quot;.
    /// </summary>
    [EnumMember(Value = "DADJ")]
    [IsoId("_4_4ekbyzEeivTd4NUfCi2g")]
    [Description(@"Change of other data.")]
    DataAdjustment = CollateralTransactionTypeCode.DataAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivery by value (DBV) transaction.
    /// Encoded/decoded by serializers as &quot;DBVT&quot;.
    /// </summary>
    [EnumMember(Value = "DBVT")]
    [IsoId("_5F4Y4byzEeivTd4NUfCi2g")]
    [Description(@"Delivery by value (DBV) transaction. |")]
    DeliveredByValue = CollateralTransactionTypeCode.DeliveredByValue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Creation of a Collateral Management Transaction.
    /// Encoded/decoded by serializers as &quot;INIT&quot;.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_5PiEIryzEeivTd4NUfCi2g")]
    [Description(@"Creation of a Collateral Management Transaction.")]
    Initiation = CollateralTransactionTypeCode.Initiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Change to margin.
    /// Encoded/decoded by serializers as &quot;MADJ&quot;.
    /// </summary>
    [EnumMember(Value = "MADJ")]
    [IsoId("_5V-qYbyzEeivTd4NUfCi2g")]
    [Description(@"Change to margin. |")]
    MarginAdjustment = CollateralTransactionTypeCode.MarginAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Change of principal/exposure adjustment
    /// Encoded/decoded by serializers as &quot;PADJ&quot;.
    /// </summary>
    [EnumMember(Value = "PADJ")]
    [IsoId("_5g6vEryzEeivTd4NUfCi2g")]
    [Description(@"Change of principal/exposure adjustment")]
    PrincipalExposureAdjustment = CollateralTransactionTypeCode.PrincipalExposureAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Change of rate.
    /// Encoded/decoded by serializers as &quot;RATA&quot;.
    /// </summary>
    [EnumMember(Value = "RATA")]
    [IsoId("_5o_tAbyzEeivTd4NUfCi2g")]
    [Description(@"Change of rate.")]
    RateAdjustment = CollateralTransactionTypeCode.RateAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Closing of the Collateral Management Transaction.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_51DMAryzEeivTd4NUfCi2g")]
    [Description(@"Closing of the Collateral Management Transaction.")]
    Termination = CollateralTransactionTypeCode.Termination, // same ordinal as derivation source for type conversions
}
