// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Instalment amount detail type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_998BcZqBEe6bZt44gtg6XQ")]
[Description(@"Instalment amount detail type.")]
[DerivedFrom(typeof(InstalmentAmountDetailsTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<InstalmentAmountDetailsType3Code>))]
public enum InstalmentAmountDetailsType3Code
{
    /// <summary>
    /// Insurance amount
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_-D-_GZqBEe6bZt44gtg6XQ")]
    [Description(@"Insurance amount")]
    Insurance = InstalmentAmountDetailsTypeCode.Insurance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Requested amount
    /// Encoded/decoded by serializers as &quot;RQST&quot;.
    /// </summary>
    [EnumMember(Value = "RQST")]
    [IsoId("_-D-_JZqBEe6bZt44gtg6XQ")]
    [Description(@"Requested amount")]
    Requested = InstalmentAmountDetailsTypeCode.Requested, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instalment amount tax
    /// Encoded/decoded by serializers as &quot;TAXX&quot;.
    /// </summary>
    [EnumMember(Value = "TAXX")]
    [IsoId("_-D-_J5qBEe6bZt44gtg6XQ")]
    [Description(@"Instalment amount tax")]
    Tax = InstalmentAmountDetailsTypeCode.Tax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Expense Amount
    /// Encoded/decoded by serializers as &quot;EXPN&quot;.
    /// </summary>
    [EnumMember(Value = "EXPN")]
    [IsoId("_-D-_E5qBEe6bZt44gtg6XQ")]
    [Description(@"Expense Amount")]
    Expense = InstalmentAmountDetailsTypeCode.Expense, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Grace period unit type
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_-D-_H5qBEe6bZt44gtg6XQ")]
    [Description(@"Grace period unit type")]
    OtherNational = InstalmentAmountDetailsTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Grace period unit type
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_-D-_IZqBEe6bZt44gtg6XQ")]
    [Description(@"Grace period unit type")]
    OtherPrivate = InstalmentAmountDetailsTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other amounts
    /// Encoded/decoded by serializers as &quot;OTHC&quot;.
    /// </summary>
    [EnumMember(Value = "OTHC")]
    [IsoId("_-D-_HZqBEe6bZt44gtg6XQ")]
    [Description(@"Other amounts")]
    OtherCharges = InstalmentAmountDetailsTypeCode.OtherCharges, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Funded amount
    /// Encoded/decoded by serializers as &quot;FUNA&quot;.
    /// </summary>
    [EnumMember(Value = "FUNA")]
    [IsoId("_-D-_F5qBEe6bZt44gtg6XQ")]
    [Description(@"Funded amount")]
    Funded = InstalmentAmountDetailsTypeCode.Funded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fees amount
    /// Encoded/decoded by serializers as &quot;FEES&quot;.
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_-D-_FZqBEe6bZt44gtg6XQ")]
    [Description(@"Fees amount")]
    Fees = InstalmentAmountDetailsTypeCode.Fees, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total financing cost per annum.
    /// Encoded/decoded by serializers as &quot;AFCO&quot;.
    /// </summary>
    [EnumMember(Value = "AFCO")]
    [IsoId("_-D-_EZqBEe6bZt44gtg6XQ")]
    [Description(@"Total financing cost per annum.")]
    AnnualFinancingCost = InstalmentAmountDetailsTypeCode.AnnualFinancingCost, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interest amount.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_-D-_G5qBEe6bZt44gtg6XQ")]
    [Description(@"Interest amount.")]
    Interest = InstalmentAmountDetailsTypeCode.Interest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Principal amount.
    /// Encoded/decoded by serializers as &quot;PRNC&quot;.
    /// </summary>
    [EnumMember(Value = "PRNC")]
    [IsoId("_-D-_I5qBEe6bZt44gtg6XQ")]
    [Description(@"Principal amount.")]
    Principal = InstalmentAmountDetailsTypeCode.Principal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Discount.
    /// Encoded/decoded by serializers as &quot;DCNT&quot;.
    /// </summary>
    [EnumMember(Value = "DCNT")]
    [IsoId("_BS2u0ZqCEe6bZt44gtg6XQ")]
    [Description(@"Discount.")]
    Discount = InstalmentAmountDetailsTypeCode.Discount, // same ordinal as derivation source for type conversions
}
