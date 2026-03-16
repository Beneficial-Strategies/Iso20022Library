// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of tax.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VfQcANp-Ed-ak6NoX_4Aeg_-282594827")]
[Description(@"Specifies the type of tax.")]
[DerivedFrom(typeof(TaxTypeCode))]
public enum TaxType5Code
{
    /// <summary>
    /// Tax is a provincial tax.
    /// Encoded/decoded by serializers as &quot;PROV&quot;.
    /// </summary>
    [EnumMember(Value = "PROV")]
    [IsoId("_VfQcAdp-Ed-ak6NoX_4Aeg_7390246")]
    [Description(@"Tax is a provincial tax.")]
    Provincial = TaxTypeCode.Provincial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is a national tax.
    /// Encoded/decoded by serializers as &quot;NATI&quot;.
    /// </summary>
    [EnumMember(Value = "NATI")]
    [IsoId("_VfQcAtp-Ed-ak6NoX_4Aeg_7390271")]
    [Description(@"Tax is a national tax.")]
    NationalTax = TaxTypeCode.NationalTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is a state tax.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_VfQcA9p-Ed-ak6NoX_4Aeg_7390272")]
    [Description(@"Tax is a state tax.")]
    StateTax = TaxTypeCode.StateTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_VfQcBNp-Ed-ak6NoX_4Aeg_7390288")]
    [Description(
        @"Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument."
    )]
    WithholdingTax = TaxTypeCode.WithholdingTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is on a capital gain (realised and unrealised), that is, the profit that is gained from the sale of a financial instrument.
    /// Encoded/decoded by serializers as &quot;KAPA&quot;.
    /// </summary>
    [EnumMember(Value = "KAPA")]
    [IsoId("_VfQcBdp-Ed-ak6NoX_4Aeg_7390306")]
    [Description(
        @"Tax is on a capital gain (realised and unrealised), that is, the profit that is gained from the sale of a financial instrument."
    )]
    CapitalGainTax = TaxTypeCode.CapitalGainTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is on the sum of all earnings/revenues accrued since the last dividend distribution.
    /// Encoded/decoded by serializers as &quot;INPO&quot;.
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("_VfQcBtp-Ed-ak6NoX_4Aeg_7390307")]
    [Description(
        @"Tax is on the sum of all earnings/revenues accrued since the last dividend distribution."
    )]
    InterimProfitTax = TaxTypeCode.InterimProfitTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is on certain documents and transactions.
    /// Encoded/decoded by serializers as &quot;STAM&quot;.
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_VfQcB9p-Ed-ak6NoX_4Aeg_7390331")]
    [Description(@"Tax is on certain documents and transactions.")]
    StampDuty = TaxTypeCode.StampDuty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is a special tax imposed, applicable only when the value of assets or categories of assets owned by an entity are above a given ceiling defined by the tax authority. Wealth tax is not linked to income.
    /// Encoded/decoded by serializers as &quot;WTAX&quot;.
    /// </summary>
    [EnumMember(Value = "WTAX")]
    [IsoId("_VfQcCNp-Ed-ak6NoX_4Aeg_7390348")]
    [Description(
        @"Tax is a special tax imposed, applicable only when the value of assets or categories of assets owned by an entity are above a given ceiling defined by the tax authority. Wealth tax is not linked to income."
    )]
    WealthTax = TaxTypeCode.WealthTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax that is payable at the time of death on any items (money or otherwise), where ownership changes either upon death or within a legally specified number of years before death.
    /// Encoded/decoded by serializers as &quot;INHT&quot;.
    /// </summary>
    [EnumMember(Value = "INHT")]
    [IsoId("_VfQcCdp-Ed-ak6NoX_4Aeg_7390349")]
    [Description(
        @"Tax that is payable at the time of death on any items (money or otherwise), where ownership changes either upon death or within a legally specified number of years before death."
    )]
    InheritanceTax = TaxTypeCode.InheritanceTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax that is levied by legal authorities for solidarity purposes.
    /// Encoded/decoded by serializers as &quot;SOSU&quot;.
    /// </summary>
    [EnumMember(Value = "SOSU")]
    [IsoId("_Vgcu0Np-Ed-ak6NoX_4Aeg_7390366")]
    [Description(@"Tax that is levied by legal authorities for solidarity purposes.")]
    SolidaritySurcharge = TaxTypeCode.SolidaritySurcharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direct reduction of an individual&apos;s tax liability.
    /// Encoded/decoded by serializers as &quot;CTAX&quot;.
    /// </summary>
    [EnumMember(Value = "CTAX")]
    [IsoId("_Vgcu0dp-Ed-ak6NoX_4Aeg_7390383")]
    [Description(@"Direct reduction of an individual's tax liability.")]
    TaxCredit = TaxTypeCode.TaxCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax that is levied on assets given to individuals prior to the death of the donor. Gift tax is designed to ensure the integrity of the inheritance tax, preventing the pre-death transfer of wealth.
    /// Encoded/decoded by serializers as &quot;GIFT&quot;.
    /// </summary>
    [EnumMember(Value = "GIFT")]
    [IsoId("_Vgcu0tp-Ed-ak6NoX_4Aeg_7390618")]
    [Description(
        @"Tax that is levied on assets given to individuals prior to the death of the donor. Gift tax is designed to ensure the integrity of the inheritance tax, preventing the pre-death transfer of wealth."
    )]
    GiftTax = TaxTypeCode.GiftTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax that is levied on goods and services purchased by customers, and is added to the retail price.
    /// Encoded/decoded by serializers as &quot;COAX&quot;.
    /// </summary>
    [EnumMember(Value = "COAX")]
    [IsoId("_Vgcu09p-Ed-ak6NoX_4Aeg_7390643")]
    [Description(
        @"Tax that is levied on goods and services purchased by customers, and is added to the retail price."
    )]
    ConsumptionTax = TaxTypeCode.ConsumptionTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.
    /// Encoded/decoded by serializers as &quot;EUTR&quot;.
    /// </summary>
    [EnumMember(Value = "EUTR")]
    [IsoId("_Vgcu1Np-Ed-ak6NoX_4Aeg_7390660")]
    [Description(
        @"Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments."
    )]
    EUTaxRetention = TaxTypeCode.EUTaxRetention, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the old Investment Tax Act (Investmentsteuergesetz).
    /// Encoded/decoded by serializers as &quot;AKT1&quot;.
    /// </summary>
    [EnumMember(Value = "AKT1")]
    [IsoId("_Vgl4wNp-Ed-ak6NoX_4Aeg_7390661")]
    [Description(
        @"Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the old Investment Tax Act (Investmentsteuergesetz)."
    )]
    Aktiengewinn1 = TaxTypeCode.Aktiengewinn1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the new Investment Tax Act (Investmentsteuergesetz).
    /// Encoded/decoded by serializers as &quot;AKT2&quot;.
    /// </summary>
    [EnumMember(Value = "AKT2")]
    [IsoId("_Vgl4wdp-Ed-ak6NoX_4Aeg_7390678")]
    [Description(
        @"Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the new Investment Tax Act (Investmentsteuergesetz)."
    )]
    Aktiengewinn2 = TaxTypeCode.Aktiengewinn2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Zwischengewinn.
    /// Encoded/decoded by serializers as &quot;ZWIS&quot;.
    /// </summary>
    [EnumMember(Value = "ZWIS")]
    [IsoId("_Vgl4wtp-Ed-ak6NoX_4Aeg_7390703")]
    [Description(@"Zwischengewinn.")]
    Zwischengewinn = TaxTypeCode.Zwischengewinn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Another type of tax.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Vgl4w9p-Ed-ak6NoX_4Aeg_7390720")]
    [Description(@"Another type of tax.")]
    Other = TaxTypeCode.Other, // same ordinal as derivation source for type conversions
}
