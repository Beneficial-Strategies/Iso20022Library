// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of tax details.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YiBCZ9p-Ed-ak6NoX_4Aeg_278106710")]
[Description(@"Specifies the type of tax details.")]
[DerivedFrom(typeof(TaxRecordCode))]
public enum TaxRecord1Code
{
    /// <summary>
    /// Tax record is related to the withholding tax.
    /// Encoded/decoded by serializers as &quot;WHTX&quot;.
    /// </summary>
    [EnumMember(Value = "WHTX")]
    [IsoId("_YiBCaNp-Ed-ak6NoX_4Aeg_278106712")]
    [Description(@"Tax record is related to the withholding tax.")]
    WithholdingTax = TaxRecordCode.WithholdingTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax record is related to the value added tax.
    /// Encoded/decoded by serializers as &quot;VATX&quot;.
    /// </summary>
    [EnumMember(Value = "VATX")]
    [IsoId("_YiKMUNp-Ed-ak6NoX_4Aeg_278106740")]
    [Description(@"Tax record is related to the value added tax.")]
    ValueAddedTax = TaxRecordCode.ValueAddedTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax record is related to the income payment details.
    /// Encoded/decoded by serializers as &quot;INCP&quot;.
    /// </summary>
    [EnumMember(Value = "INCP")]
    [IsoId("_YiKMUdp-Ed-ak6NoX_4Aeg_278106771")]
    [Description(@"Tax record is related to the income payment details.")]
    IncomePaymentDetails = TaxRecordCode.IncomePaymentDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax record is related to the total amount for income payments.
    /// Encoded/decoded by serializers as &quot;TLAI&quot;.
    /// </summary>
    [EnumMember(Value = "TLAI")]
    [IsoId("_YiKMUtp-Ed-ak6NoX_4Aeg_278106772")]
    [Description(@"Tax record is related to the total amount for income payments.")]
    TotalAmountForIncomePayments = TaxRecordCode.TotalAmountForIncomePayments, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax record is related to the money payments details.
    /// Encoded/decoded by serializers as &quot;MONP&quot;.
    /// </summary>
    [EnumMember(Value = "MONP")]
    [IsoId("_YiKMU9p-Ed-ak6NoX_4Aeg_278106802")]
    [Description(@"Tax record is related to the money payments details.")]
    MoneyPaymentDetails = TaxRecordCode.MoneyPaymentDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax record is related to the total amount for money payments.
    /// Encoded/decoded by serializers as &quot;TLAM&quot;.
    /// </summary>
    [EnumMember(Value = "TLAM")]
    [IsoId("_YiKMVNp-Ed-ak6NoX_4Aeg_278107073")]
    [Description(@"Tax record is related to the total amount for money payments.")]
    TotalAmountForMoneyPayments = TaxRecordCode.TotalAmountForMoneyPayments, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other tax record type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_YiKMVdp-Ed-ak6NoX_4Aeg_278107081")]
    [Description(@"Other tax record type.")]
    Other = TaxRecordCode.Other, // same ordinal as derivation source for type conversions
    
}
