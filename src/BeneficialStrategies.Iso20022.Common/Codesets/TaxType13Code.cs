// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of tax.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YkZoANp-Ed-ak6NoX_4Aeg_1588972374")]
[Description(@"Specifies the type of tax.")]
[DerivedFrom(typeof(TaxTypeCode))]
public enum TaxType13Code
{
    /// <summary>
    /// Tax that is levied on goods and services purchased by customers, and is added to the retail price.
    /// Encoded/decoded by serializers as &quot;COAX&quot;.
    /// </summary>
    [EnumMember(Value = "COAX")]
    [IsoId("_YkZoAdp-Ed-ak6NoX_4Aeg_2016560306")]
    [Description(@"Tax that is levied on goods and services purchased by customers, and is added to the retail price.")]
    ConsumptionTax = TaxTypeCode.ConsumptionTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.
    /// Encoded/decoded by serializers as &quot;EUTR&quot;.
    /// </summary>
    [EnumMember(Value = "EUTR")]
    [IsoId("_YkZoAtp-Ed-ak6NoX_4Aeg_2016560703")]
    [Description(@"Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.")]
    EUTaxRetention = TaxTypeCode.EUTaxRetention, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax that is charged by a local settlement system or local jurisdiction.
    /// Encoded/decoded by serializers as &quot;LOCL&quot;.
    /// </summary>
    [EnumMember(Value = "LOCL")]
    [IsoId("_YkZoA9p-Ed-ak6NoX_4Aeg_2016560720")]
    [Description(@"Tax that is charged by a local settlement system or local jurisdiction.")]
    LocalTax = TaxTypeCode.LocalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is a national tax.
    /// Encoded/decoded by serializers as &quot;NATI&quot;.
    /// </summary>
    [EnumMember(Value = "NATI")]
    [IsoId("_YkZoBNp-Ed-ak6NoX_4Aeg_2016560721")]
    [Description(@"Tax is a national tax.")]
    NationalTax = TaxTypeCode.NationalTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied on a payment.
    /// Encoded/decoded by serializers as &quot;LEVY&quot;.
    /// </summary>
    [EnumMember(Value = "LEVY")]
    [IsoId("_YkZoBdp-Ed-ak6NoX_4Aeg_2016560738")]
    [Description(@"Tax levied on a payment.")]
    PaymentLevyTax = TaxTypeCode.PaymentLevyTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is a provincial tax.
    /// Encoded/decoded by serializers as &quot;PROV&quot;.
    /// </summary>
    [EnumMember(Value = "PROV")]
    [IsoId("_YkZoBtp-Ed-ak6NoX_4Aeg_2016560763")]
    [Description(@"Tax is a provincial tax.")]
    Provincial = TaxTypeCode.Provincial, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is on certain documents and transactions.
    /// Encoded/decoded by serializers as &quot;STAM&quot;.
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_YkZoB9p-Ed-ak6NoX_4Aeg_2016560780")]
    [Description(@"Tax is on certain documents and transactions.")]
    StampDuty = TaxTypeCode.StampDuty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is a state tax.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_YkZoCNp-Ed-ak6NoX_4Aeg_2016560798")]
    [Description(@"Tax is a state tax.")]
    StateTax = TaxTypeCode.StateTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax collected by a stock exchange.
    /// Encoded/decoded by serializers as &quot;STEX&quot;.
    /// </summary>
    [EnumMember(Value = "STEX")]
    [IsoId("_YkZoCdp-Ed-ak6NoX_4Aeg_2016560815")]
    [Description(@"Tax collected by a stock exchange.")]
    StockExchangeTax = TaxTypeCode.StockExchangeTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Direct reduction of an individual&apos;s tax liability.
    /// Encoded/decoded by serializers as &quot;CTAX&quot;.
    /// </summary>
    [EnumMember(Value = "CTAX")]
    [IsoId("_Ykix8Np-Ed-ak6NoX_4Aeg_2016561081")]
    [Description(@"Direct reduction of an individual's tax liability.")]
    TaxCredit = TaxTypeCode.TaxCredit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied on a transaction.
    /// Encoded/decoded by serializers as &quot;TRAX&quot;.
    /// </summary>
    [EnumMember(Value = "TRAX")]
    [IsoId("_Ykix8dp-Ed-ak6NoX_4Aeg_2016561106")]
    [Description(@"Tax levied on a transaction.")]
    TransactionTax = TaxTypeCode.TransactionTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax levied on a transfer.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_Ykix8tp-Ed-ak6NoX_4Aeg_2016561123")]
    [Description(@"Tax levied on a transfer.")]
    TransferTax = TaxTypeCode.TransferTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is a value added tax.
    /// Encoded/decoded by serializers as &quot;VATA&quot;.
    /// </summary>
    [EnumMember(Value = "VATA")]
    [IsoId("_Ykix89p-Ed-ak6NoX_4Aeg_2016561141")]
    [Description(@"Tax is a value added tax.")]
    ValueAddedTax = TaxTypeCode.ValueAddedTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_Ykix9Np-Ed-ak6NoX_4Aeg_2016561166")]
    [Description(@"Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument.")]
    WithholdingTax = TaxTypeCode.WithholdingTax, // same ordinal as derivation source for type conversions
    
}
