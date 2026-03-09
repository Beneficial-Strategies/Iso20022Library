// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of tax.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yk2T89p-Ed-ak6NoX_4Aeg_1366299042")]
[Description(@"Specifies the type of tax.")]
[Derivations(typeof(TaxType16Code),typeof(TaxType13Code),typeof(TaxType14Code),typeof(TaxType6Code),typeof(TaxType2Code),typeof(TaxType7Code),typeof(TaxType15Code),typeof(TaxType11Code),typeof(TaxType3Code),typeof(TaxType4Code),typeof(TaxType17Code),typeof(TaxType12Code),typeof(TaxType9Code),typeof(TaxType10Code),typeof(TaxType5Code))]
public enum TaxTypeCode
{
    /// <summary>
    /// Tax for which a zero rate applies.
    /// Encoded/decoded by serializers as &quot;VATB&quot;.
    /// </summary>
    [EnumMember(Value = "VATB")]
    [IsoId("_TW-nsAEcEeCQm6a_G2yO_w_-1666564998")]
    [Description(@"Tax for which a zero rate applies.")]
    ValueAddedTaxOfZeroRate,
    
    /// <summary>
    /// Tax is a provincial tax.
    /// Encoded/decoded by serializers as &quot;PROV&quot;.
    /// </summary>
    [EnumMember(Value = "PROV")]
    [IsoId("_Yk2T9Np-Ed-ak6NoX_4Aeg_101436698")]
    [Description(@"Tax is a provincial tax.")]
    Provincial,
    
    /// <summary>
    /// Tax is a national tax.
    /// Encoded/decoded by serializers as &quot;NATI&quot;.
    /// </summary>
    [EnumMember(Value = "NATI")]
    [IsoId("_Yk2T9dp-Ed-ak6NoX_4Aeg_101436699")]
    [Description(@"Tax is a national tax.")]
    NationalTax,
    
    /// <summary>
    /// Tax is a state tax.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_Yk2T9tp-Ed-ak6NoX_4Aeg_101436700")]
    [Description(@"Tax is a state tax.")]
    StateTax,
    
    /// <summary>
    /// Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_Yk2T99p-Ed-ak6NoX_4Aeg_101436701")]
    [Description(@"Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument.")]
    WithholdingTax,
    
    /// <summary>
    /// Tax is on a capital gain (realised and unrealised), that is, the profit that is gained from the sale of a financial instrument.
    /// Encoded/decoded by serializers as &quot;KAPA&quot;.
    /// </summary>
    [EnumMember(Value = "KAPA")]
    [IsoId("_Yk2T-Np-Ed-ak6NoX_4Aeg_101436710")]
    [Description(@"Tax is on a capital gain (realised and unrealised), that is, the profit that is gained from the sale of a financial instrument.")]
    CapitalGainTax,
    
    /// <summary>
    /// Tax is on the sum of all earnings/revenues accrued since the last dividend distribution.
    /// Encoded/decoded by serializers as &quot;INPO&quot;.
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("_Yk_d4Np-Ed-ak6NoX_4Aeg_101436711")]
    [Description(@"Tax is on the sum of all earnings/revenues accrued since the last dividend distribution.")]
    InterimProfitTax,
    
    /// <summary>
    /// Tax is on certain documents and transactions.
    /// Encoded/decoded by serializers as &quot;STAM&quot;.
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_Yk_d4dp-Ed-ak6NoX_4Aeg_101436712")]
    [Description(@"Tax is on certain documents and transactions.")]
    StampDuty,
    
    /// <summary>
    /// Tax is a special tax imposed, applicable only when the value of assets or categories of assets owned by an entity are above a given ceiling defined by the tax authority. Wealth tax is not linked to income.
    /// Encoded/decoded by serializers as &quot;WTAX&quot;.
    /// </summary>
    [EnumMember(Value = "WTAX")]
    [IsoId("_Yk_d4tp-Ed-ak6NoX_4Aeg_101436713")]
    [Description(@"Tax is a special tax imposed, applicable only when the value of assets or categories of assets owned by an entity are above a given ceiling defined by the tax authority. Wealth tax is not linked to income.")]
    WealthTax,
    
    /// <summary>
    /// Tax that is payable at the time of death on any items (money or otherwise), where ownership changes either upon death or within a legally specified number of years before death.
    /// Encoded/decoded by serializers as &quot;INHT&quot;.
    /// </summary>
    [EnumMember(Value = "INHT")]
    [IsoId("_Yk_d49p-Ed-ak6NoX_4Aeg_101436714")]
    [Description(@"Tax that is payable at the time of death on any items (money or otherwise), where ownership changes either upon death or within a legally specified number of years before death.")]
    InheritanceTax,
    
    /// <summary>
    /// Tax that is levied by legal authorities for solidarity purposes.
    /// Encoded/decoded by serializers as &quot;SOSU&quot;.
    /// </summary>
    [EnumMember(Value = "SOSU")]
    [IsoId("_Yk_d5Np-Ed-ak6NoX_4Aeg_101436715")]
    [Description(@"Tax that is levied by legal authorities for solidarity purposes.")]
    SolidaritySurcharge,
    
    /// <summary>
    /// Direct reduction of an individual&apos;s tax liability.
    /// Encoded/decoded by serializers as &quot;CTAX&quot;.
    /// </summary>
    [EnumMember(Value = "CTAX")]
    [IsoId("_Yk_d5dp-Ed-ak6NoX_4Aeg_101436716")]
    [Description(@"Direct reduction of an individual's tax liability.")]
    TaxCredit,
    
    /// <summary>
    /// The part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// Encoded/decoded by serializers as &quot;EQUL&quot;.
    /// </summary>
    [EnumMember(Value = "EQUL")]
    [IsoId("_Yk_d5tp-Ed-ak6NoX_4Aeg_1366299069")]
    [Description(@"The part of an investor's subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.")]
    Equalisation,
    
    /// <summary>
    /// Tax that is levied on assets given to individuals prior to the death of the donor. Gift tax is designed to ensure the integrity of the inheritance tax, preventing the pre-death transfer of wealth.
    /// Encoded/decoded by serializers as &quot;GIFT&quot;.
    /// </summary>
    [EnumMember(Value = "GIFT")]
    [IsoId("_Yk_d59p-Ed-ak6NoX_4Aeg_1366299070")]
    [Description(@"Tax that is levied on assets given to individuals prior to the death of the donor. Gift tax is designed to ensure the integrity of the inheritance tax, preventing the pre-death transfer of wealth.")]
    GiftTax,
    
    /// <summary>
    /// Tax that is levied on goods and services purchased by customers, and is added to the retail price.
    /// Encoded/decoded by serializers as &quot;COAX&quot;.
    /// </summary>
    [EnumMember(Value = "COAX")]
    [IsoId("_Yk_d6Np-Ed-ak6NoX_4Aeg_1366299071")]
    [Description(@"Tax that is levied on goods and services purchased by customers, and is added to the retail price.")]
    ConsumptionTax,
    
    /// <summary>
    /// Tax is an alternative minimum tax.
    /// Encoded/decoded by serializers as &quot;ALMI&quot;.
    /// </summary>
    [EnumMember(Value = "ALMI")]
    [IsoId("_Yk_d6dp-Ed-ak6NoX_4Aeg_-235891984")]
    [Description(@"Tax is an alternative minimum tax.")]
    AlternativeMinimumTax,
    
    /// <summary>
    /// Tax that is charged by a local settlement system or local jurisdiction.
    /// Encoded/decoded by serializers as &quot;LOCL&quot;.
    /// </summary>
    [EnumMember(Value = "LOCL")]
    [IsoId("_Yk_d6tp-Ed-ak6NoX_4Aeg_1995661841")]
    [Description(@"Tax that is charged by a local settlement system or local jurisdiction.")]
    LocalTax,
    
    /// <summary>
    /// Tax is a country, national, or federal tax that is usually charged by the custodian.
    /// Encoded/decoded by serializers as &quot;COUN&quot;.
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_YlJO4Np-Ed-ak6NoX_4Aeg_1995661901")]
    [Description(@"Tax is a country, national, or federal tax that is usually charged by the custodian.")]
    NationalFederalTax,
    
    /// <summary>
    /// Tax levied on a payment.
    /// Encoded/decoded by serializers as &quot;LEVY&quot;.
    /// </summary>
    [EnumMember(Value = "LEVY")]
    [IsoId("_YlJO4dp-Ed-ak6NoX_4Aeg_1995661936")]
    [Description(@"Tax levied on a payment.")]
    PaymentLevyTax,
    
    /// <summary>
    /// Tax collected by a stock exchange.
    /// Encoded/decoded by serializers as &quot;STEX&quot;.
    /// </summary>
    [EnumMember(Value = "STEX")]
    [IsoId("_YlJO4tp-Ed-ak6NoX_4Aeg_1995662231")]
    [Description(@"Tax collected by a stock exchange.")]
    StockExchangeTax,
    
    /// <summary>
    /// Tax levied on a transaction.
    /// Encoded/decoded by serializers as &quot;TRAX&quot;.
    /// </summary>
    [EnumMember(Value = "TRAX")]
    [IsoId("_YlJO49p-Ed-ak6NoX_4Aeg_1995662291")]
    [Description(@"Tax levied on a transaction.")]
    TransactionTax,
    
    /// <summary>
    /// Tax levied on a transfer.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_YlJO5Np-Ed-ak6NoX_4Aeg_1995662599")]
    [Description(@"Tax levied on a transfer.")]
    TransferTax,
    
    /// <summary>
    /// Tax is a value added tax.
    /// Encoded/decoded by serializers as &quot;VATA&quot;.
    /// </summary>
    [EnumMember(Value = "VATA")]
    [IsoId("_YlJO5dp-Ed-ak6NoX_4Aeg_1995662659")]
    [Description(@"Tax is a value added tax.")]
    ValueAddedTax,
    
    /// <summary>
    /// Local broker&apos;s commission amount.
    /// Encoded/decoded by serializers as &quot;LOCO&quot;.
    /// </summary>
    [EnumMember(Value = "LOCO")]
    [IsoId("_YlJO5tp-Ed-ak6NoX_4Aeg_1995662729")]
    [Description(@"Local broker's commission amount.")]
    LocalBrokerCommission,
    
    /// <summary>
    /// Executing broker&apos;s commission amount.
    /// Encoded/decoded by serializers as &quot;EXEC&quot;.
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_YlJO59p-Ed-ak6NoX_4Aeg_1995662789")]
    [Description(@"Executing broker's commission amount.")]
    ExecutingBrokerCommission,
    
    /// <summary>
    /// Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.
    /// Encoded/decoded by serializers as &quot;EUTR&quot;.
    /// </summary>
    [EnumMember(Value = "EUTR")]
    [IsoId("_YlJO6Np-Ed-ak6NoX_4Aeg_2062905332")]
    [Description(@"Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.")]
    EUTaxRetention,
    
    /// <summary>
    /// Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the old Investment Tax Act (Investmentsteuergesetz).
    /// Encoded/decoded by serializers as &quot;AKT1&quot;.
    /// </summary>
    [EnumMember(Value = "AKT1")]
    [IsoId("_YlJO6dp-Ed-ak6NoX_4Aeg_-1098061737")]
    [Description(@"Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the old Investment Tax Act (Investmentsteuergesetz).")]
    Aktiengewinn1,
    
    /// <summary>
    /// Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the new Investment Tax Act (Investmentsteuergesetz).
    /// Encoded/decoded by serializers as &quot;AKT2&quot;.
    /// </summary>
    [EnumMember(Value = "AKT2")]
    [IsoId("_YlSY0Np-Ed-ak6NoX_4Aeg_-1098061719")]
    [Description(@"Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the new Investment Tax Act (Investmentsteuergesetz).")]
    Aktiengewinn2,
    
    /// <summary>
    /// Zwischengewinn.
    /// Encoded/decoded by serializers as &quot;ZWIS&quot;.
    /// </summary>
    [EnumMember(Value = "ZWIS")]
    [IsoId("_YlSY0dp-Ed-ak6NoX_4Aeg_-1098061694")]
    [Description(@"Zwischengewinn.")]
    Zwischengewinn,
    
    /// <summary>
    /// Tax is customs and excise.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_YlSY0tp-Ed-ak6NoX_4Aeg_2120170335")]
    [Description(@"Tax is customs and excise.")]
    CustomsTax,
    
    /// <summary>
    /// Another type of tax.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_YlSY09p-Ed-ak6NoX_4Aeg_-1199915118")]
    [Description(@"Another type of tax.")]
    Other,
    
    /// <summary>
    /// Earnings from renting.
    /// Encoded/decoded by serializers as &quot;MIET&quot;.
    /// </summary>
    [EnumMember(Value = "MIET")]
    [IsoId("_YlSY1Np-Ed-ak6NoX_4Aeg_-195327179")]
    [Description(@"Earnings from renting.")]
    Mietgewinn,
    
    /// <summary>
    /// Local tax (Zinstopf) offset interest per unit against tax exempt amount (variation to offset interest per unit in relation to tax exempt amount).
    /// Encoded/decoded by serializers as &quot;LOTE&quot;.
    /// </summary>
    [EnumMember(Value = "LOTE")]
    [IsoId("_YlSY1dp-Ed-ak6NoX_4Aeg_1814391584")]
    [Description(@"Local tax (Zinstopf) offset interest per unit against tax exempt amount (variation to offset interest per unit in relation to tax exempt amount).")]
    GermanLocalTax3,
    
    /// <summary>
    /// Local tax (Ertrag Besitzanteilig) yield liable for interest down payment tax.
    /// Encoded/decoded by serializers as &quot;LYDT&quot;.
    /// </summary>
    [EnumMember(Value = "LYDT")]
    [IsoId("_YlSY1tp-Ed-ak6NoX_4Aeg_1814391646")]
    [Description(@"Local tax (Ertrag Besitzanteilig) yield liable for interest down payment tax.")]
    GermanLocalTax4,
    
    /// <summary>
    /// Local tax (ZAS pflichtige Zinsen) - interest liable for interest down payment tax (proportion of gross interest per unit/interim profits that is not covered by the credit in the interest pool).
    /// Encoded/decoded by serializers as &quot;LIDT&quot;.
    /// </summary>
    [EnumMember(Value = "LIDT")]
    [IsoId("_YlSY19p-Ed-ak6NoX_4Aeg_165827201")]
    [Description(@"Local tax (ZAS pflichtige Zinsen) - interest liable for interest down payment tax (proportion of gross interest per unit/interim profits that is not covered by the credit in the interest pool).")]
    GermanLocalTax2,
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as &quot;WITF&quot;.
    /// </summary>
    [EnumMember(Value = "WITF")]
    [IsoId("_YlSY2Np-Ed-ak6NoX_4Aeg_165827262")]
    [Description(@"Rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.")]
    WithholdingOfForeignTax,
    
    /// <summary>
    /// Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// Encoded/decoded by serializers as &quot;WITL&quot;.
    /// </summary>
    [EnumMember(Value = "WITL")]
    [IsoId("_YlSY2dp-Ed-ak6NoX_4Aeg_165827602")]
    [Description(@"Rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.")]
    WithholdingOfLocalTax,
    
    /// <summary>
    /// Tax recovery is due to capital loss.
    /// Encoded/decoded by serializers as &quot;NKAP&quot;.
    /// </summary>
    [EnumMember(Value = "NKAP")]
    [IsoId("_HiqOwBuGEeOqSdXzJ0oydA")]
    [Description(@"Tax recovery is due to capital loss.")]
    CapitalLossCredit,
    
}
