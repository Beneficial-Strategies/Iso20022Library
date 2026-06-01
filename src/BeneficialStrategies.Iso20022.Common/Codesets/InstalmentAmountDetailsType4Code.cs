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
[IsoId("_j0abET2BEfCQAqQ9lolFUg")]
[Description(@"Instalment amount detail type.")]
[DerivedFrom(typeof(InstalmentAmountDetailsTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<InstalmentAmountDetailsType4Code>))]
public enum InstalmentAmountDetailsType4Code
{
    /// <summary>
    /// Total financing cost per annum.
    /// Encoded/decoded by serializers as &quot;AFCO&quot;.
    /// </summary>
    [EnumMember(Value = "AFCO")]
    [IsoId("_j2thIT2BEfCQAqQ9lolFUg")]
    [Description(@"Total financing cost per annum.")]
    AnnualFinancingCost = InstalmentAmountDetailsTypeCode.AnnualFinancingCost, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Discount.
    /// Encoded/decoded by serializers as &quot;DCNT&quot;.
    /// </summary>
    [EnumMember(Value = "DCNT")]
    [IsoId("_j2thOT2BEfCQAqQ9lolFUg")]
    [Description(@"Discount.")]
    Discount = InstalmentAmountDetailsTypeCode.Discount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Expense Amount
    /// Encoded/decoded by serializers as &quot;EXPN&quot;.
    /// </summary>
    [EnumMember(Value = "EXPN")]
    [IsoId("_j2thIz2BEfCQAqQ9lolFUg")]
    [Description(@"Expense Amount")]
    Expense = InstalmentAmountDetailsTypeCode.Expense, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fees amount
    /// Encoded/decoded by serializers as &quot;FEES&quot;.
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_j2thJT2BEfCQAqQ9lolFUg")]
    [Description(@"Fees amount")]
    Fees = InstalmentAmountDetailsTypeCode.Fees, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Funded amount
    /// Encoded/decoded by serializers as &quot;FUNA&quot;.
    /// </summary>
    [EnumMember(Value = "FUNA")]
    [IsoId("_j2thJz2BEfCQAqQ9lolFUg")]
    [Description(@"Funded amount")]
    Funded = InstalmentAmountDetailsTypeCode.Funded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insurance amount
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_j2thKT2BEfCQAqQ9lolFUg")]
    [Description(@"Insurance amount")]
    Insurance = InstalmentAmountDetailsTypeCode.Insurance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interest amount.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_j2thKz2BEfCQAqQ9lolFUg")]
    [Description(@"Interest amount.")]
    Interest = InstalmentAmountDetailsTypeCode.Interest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other amounts
    /// Encoded/decoded by serializers as &quot;OTHC&quot;.
    /// </summary>
    [EnumMember(Value = "OTHC")]
    [IsoId("_j2thLT2BEfCQAqQ9lolFUg")]
    [Description(@"Other amounts")]
    OtherCharges = InstalmentAmountDetailsTypeCode.OtherCharges, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Principal amount.
    /// Encoded/decoded by serializers as &quot;PRNC&quot;.
    /// </summary>
    [EnumMember(Value = "PRNC")]
    [IsoId("_j2thMz2BEfCQAqQ9lolFUg")]
    [Description(@"Principal amount.")]
    Principal = InstalmentAmountDetailsTypeCode.Principal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Requested amount
    /// Encoded/decoded by serializers as &quot;RQST&quot;.
    /// </summary>
    [EnumMember(Value = "RQST")]
    [IsoId("_j2thNT2BEfCQAqQ9lolFUg")]
    [Description(@"Requested amount")]
    Requested = InstalmentAmountDetailsTypeCode.Requested, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instalment amount tax
    /// Encoded/decoded by serializers as &quot;TAXX&quot;.
    /// </summary>
    [EnumMember(Value = "TAXX")]
    [IsoId("_j2thNz2BEfCQAqQ9lolFUg")]
    [Description(@"Instalment amount tax")]
    Tax = InstalmentAmountDetailsTypeCode.Tax, // same ordinal as derivation source for type conversions
}
