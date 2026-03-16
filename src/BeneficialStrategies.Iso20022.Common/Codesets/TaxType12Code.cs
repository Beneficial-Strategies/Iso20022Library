// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of tax.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YkP3Atp-Ed-ak6NoX_4Aeg_-1091962237")]
[Description(@"Specifies the type of tax.")]
[DerivedFrom(typeof(TaxTypeCode))]
public enum TaxType12Code
{
    /// <summary>
    /// Tax is on the sum of all earnings/revenues accrued since the last dividend distribution.
    /// Encoded/decoded by serializers as &quot;INPO&quot;.
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("_YkP3A9p-Ed-ak6NoX_4Aeg_-582177215")]
    [Description(
        @"Tax is on the sum of all earnings/revenues accrued since the last dividend distribution."
    )]
    InterimProfitTax = TaxTypeCode.InterimProfitTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments.
    /// Encoded/decoded by serializers as &quot;EUTR&quot;.
    /// </summary>
    [EnumMember(Value = "EUTR")]
    [IsoId("_YkP3BNp-Ed-ak6NoX_4Aeg_-581256561")]
    [Description(
        @"Tax withheld at source in the framework of the European Directive on taxation of savings in the form of interest payments."
    )]
    EUTaxRetention = TaxTypeCode.EUTaxRetention, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the old Investment Tax Act (Investmentsteuergesetz).
    /// Encoded/decoded by serializers as &quot;AKT1&quot;.
    /// </summary>
    [EnumMember(Value = "AKT1")]
    [IsoId("_YkP3Bdp-Ed-ak6NoX_4Aeg_-581256518")]
    [Description(
        @"Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the old Investment Tax Act (Investmentsteuergesetz)."
    )]
    Aktiengewinn1 = TaxTypeCode.Aktiengewinn1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the new Investment Tax Act (Investmentsteuergesetz).
    /// Encoded/decoded by serializers as &quot;AKT2&quot;.
    /// </summary>
    [EnumMember(Value = "AKT2")]
    [IsoId("_YkP3Btp-Ed-ak6NoX_4Aeg_-581256501")]
    [Description(
        @"Share-related profit. This is a tax specific to the German market. The share-related-profit gives the fund the opportunity to pass on to the institutional investor redeeming fund units certain tax-free income from equity. The calculation method is based on the new Investment Tax Act (Investmentsteuergesetz)."
    )]
    Aktiengewinn2 = TaxTypeCode.Aktiengewinn2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Zwischengewinn.
    /// Encoded/decoded by serializers as &quot;ZWIS&quot;.
    /// </summary>
    [EnumMember(Value = "ZWIS")]
    [IsoId("_YkP3B9p-Ed-ak6NoX_4Aeg_-581256483")]
    [Description(@"Zwischengewinn.")]
    Zwischengewinn = TaxTypeCode.Zwischengewinn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Earnings from renting.
    /// Encoded/decoded by serializers as &quot;MIET&quot;.
    /// </summary>
    [EnumMember(Value = "MIET")]
    [IsoId("_YkP3CNp-Ed-ak6NoX_4Aeg_-523997623")]
    [Description(@"Earnings from renting.")]
    Mietgewinn = TaxTypeCode.Mietgewinn, // same ordinal as derivation source for type conversions
}
