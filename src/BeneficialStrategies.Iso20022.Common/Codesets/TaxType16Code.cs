// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of tax.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kiNHQBuGEeOqSdXzJ0oydA")]
[Description(@"Specifies the type of tax.")]
[DerivedFrom(typeof(TaxTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TaxType16Code>))]
#endif
public enum TaxType16Code
{
    /// <summary>
    /// Tax that is levied on goods and services purchased by customers, and is added to the retail price.
    /// Encoded/decoded by serializers as &quot;COAX&quot;.
    /// </summary>
    [EnumMember(Value = "COAX")]
    [IsoId("_tcKxkRuGEeOqSdXzJ0oydA")]
    [Description(
        @"Tax that is levied on goods and services purchased by customers, and is added to the retail price."
    )]
    ConsumptionTax = TaxTypeCode.ConsumptionTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direct reduction of an individual&apos;s tax liability.
    /// Encoded/decoded by serializers as &quot;CTAX&quot;.
    /// </summary>
    [EnumMember(Value = "CTAX")]
    [IsoId("_u4j3ERuGEeOqSdXzJ0oydA")]
    [Description(@"Direct reduction of an individual's tax liability.")]
    TaxCredit = TaxTypeCode.TaxCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.
    /// Encoded/decoded by serializers as &quot;EUTR&quot;.
    /// </summary>
    [EnumMember(Value = "EUTR")]
    [IsoId("_vqGowRuGEeOqSdXzJ0oydA")]
    [Description(
        @"Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments."
    )]
    EUTaxRetention = TaxTypeCode.EUTaxRetention, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied on a payment.
    /// Encoded/decoded by serializers as &quot;LEVY&quot;.
    /// </summary>
    [EnumMember(Value = "LEVY")]
    [IsoId("_w-KRoRuGEeOqSdXzJ0oydA")]
    [Description(@"Tax levied on a payment.")]
    PaymentLevyTax = TaxTypeCode.PaymentLevyTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax that is charged by a local settlement system or local jurisdiction.
    /// Encoded/decoded by serializers as &quot;LOCL&quot;.
    /// </summary>
    [EnumMember(Value = "LOCL")]
    [IsoId("_y1CTsRuGEeOqSdXzJ0oydA")]
    [Description(@"Tax that is charged by a local settlement system or local jurisdiction.")]
    LocalTax = TaxTypeCode.LocalTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is a national tax.
    /// Encoded/decoded by serializers as &quot;NATI&quot;.
    /// </summary>
    [EnumMember(Value = "NATI")]
    [IsoId("_0ZTi0RuGEeOqSdXzJ0oydA")]
    [Description(@"Tax is a national tax.")]
    NationalTax = TaxTypeCode.NationalTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is a provincial tax.
    /// Encoded/decoded by serializers as &quot;PROV&quot;.
    /// </summary>
    [EnumMember(Value = "PROV")]
    [IsoId("_3Ia0cRuGEeOqSdXzJ0oydA")]
    [Description(@"Tax is a provincial tax.")]
    Provincial = TaxTypeCode.Provincial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is on certain documents and transactions.
    /// Encoded/decoded by serializers as &quot;STAM&quot;.
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_359mIRuGEeOqSdXzJ0oydA")]
    [Description(@"Tax is on certain documents and transactions.")]
    StampDuty = TaxTypeCode.StampDuty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is a state tax.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_4Ts70RuGEeOqSdXzJ0oydA")]
    [Description(@"Tax is a state tax.")]
    StateTax = TaxTypeCode.StateTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax collected by a stock exchange.
    /// Encoded/decoded by serializers as &quot;STEX&quot;.
    /// </summary>
    [EnumMember(Value = "STEX")]
    [IsoId("_6NsjURuGEeOqSdXzJ0oydA")]
    [Description(@"Tax collected by a stock exchange.")]
    StockExchangeTax = TaxTypeCode.StockExchangeTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied on a transfer.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_7EclIRuGEeOqSdXzJ0oydA")]
    [Description(@"Tax levied on a transfer.")]
    TransferTax = TaxTypeCode.TransferTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax levied on a transaction.
    /// Encoded/decoded by serializers as &quot;TRAX&quot;.
    /// </summary>
    [EnumMember(Value = "TRAX")]
    [IsoId("_7j_A0RuGEeOqSdXzJ0oydA")]
    [Description(@"Tax levied on a transaction.")]
    TransactionTax = TaxTypeCode.TransactionTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is a value added tax.
    /// Encoded/decoded by serializers as &quot;VATA&quot;.
    /// </summary>
    [EnumMember(Value = "VATA")]
    [IsoId("_8KOhcRuGEeOqSdXzJ0oydA")]
    [Description(@"Tax is a value added tax.")]
    ValueAddedTax = TaxTypeCode.ValueAddedTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_9CUAARuGEeOqSdXzJ0oydA")]
    [Description(
        @"Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument."
    )]
    WithholdingTax = TaxTypeCode.WithholdingTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax recovery is due to capital loss.
    /// Encoded/decoded by serializers as &quot;NKAP&quot;.
    /// </summary>
    [EnumMember(Value = "NKAP")]
    [IsoId("_-E9v0RuGEeOqSdXzJ0oydA")]
    [Description(@"Tax recovery is due to capital loss.")]
    CapitalLossCredit = TaxTypeCode.CapitalLossCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is on a capital gain (realised and unrealised), that is, the profit that is gained from the sale of a financial instrument.
    /// Encoded/decoded by serializers as &quot;KAPA&quot;.
    /// </summary>
    [EnumMember(Value = "KAPA")]
    [IsoId("___j0QRuGEeOqSdXzJ0oydA")]
    [Description(
        @"Tax is on a capital gain (realised and unrealised), that is, the profit that is gained from the sale of a financial instrument."
    )]
    CapitalGainTax = TaxTypeCode.CapitalGainTax, // same ordinal as derivation source for type conversions
}
