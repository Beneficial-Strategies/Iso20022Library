// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of tax.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TRd1mQEcEeCQm6a_G2yO_w_-1182449041")]
[Description(@"Specifies the type of tax.")]
[DerivedFrom(typeof(TaxTypeCode))]
public enum TaxType15Code
{
    /// <summary>
    /// Tax is a provincial tax.
    /// Encoded/decoded by serializers as &quot;PROV&quot;.
    /// </summary>
    [EnumMember(Value = "PROV")]
    [IsoId("_TRd1mgEcEeCQm6a_G2yO_w_462818394")]
    [Description(@"Tax is a provincial tax.")]
    Provincial = TaxTypeCode.Provincial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is a national tax.
    /// Encoded/decoded by serializers as &quot;NATI&quot;.
    /// </summary>
    [EnumMember(Value = "NATI")]
    [IsoId("_TRd1mwEcEeCQm6a_G2yO_w_2115445902")]
    [Description(@"Tax is a national tax.")]
    NationalTax = TaxTypeCode.NationalTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is a state tax.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_TRd1nAEcEeCQm6a_G2yO_w_1823488164")]
    [Description(@"Tax is a state tax.")]
    StateTax = TaxTypeCode.StateTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_TRd1nQEcEeCQm6a_G2yO_w_2001606836")]
    [Description(
        @"Tax is on income deducted at source, which the paying agent is legally obliged to deduct from its payments of interest on deposits and other proceeds of a financial instrument."
    )]
    WithholdingTax = TaxTypeCode.WithholdingTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is on certain documents and transactions.
    /// Encoded/decoded by serializers as &quot;STAM&quot;.
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_TRnmkAEcEeCQm6a_G2yO_w_-534253959")]
    [Description(@"Tax is on certain documents and transactions.")]
    StampDuty = TaxTypeCode.StampDuty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax that is levied on goods and services purchased by customers, and is added to the retail price.
    /// Encoded/decoded by serializers as &quot;COAX&quot;.
    /// </summary>
    [EnumMember(Value = "COAX")]
    [IsoId("_TRnmkQEcEeCQm6a_G2yO_w_1118373549")]
    [Description(
        @"Tax that is levied on goods and services purchased by customers, and is added to the retail price."
    )]
    ConsumptionTax = TaxTypeCode.ConsumptionTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is a value added tax.
    /// Encoded/decoded by serializers as &quot;VATA&quot;.
    /// </summary>
    [EnumMember(Value = "VATA")]
    [IsoId("_TRnmkgEcEeCQm6a_G2yO_w_826415811")]
    [Description(@"Tax is a value added tax.")]
    ValueAddedTax = TaxTypeCode.ValueAddedTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax is customs and excise.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_TRnmkwEcEeCQm6a_G2yO_w_1004534483")]
    [Description(@"Tax is customs and excise.")]
    CustomsTax = TaxTypeCode.CustomsTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax for which a zero rate applies.
    /// Encoded/decoded by serializers as &quot;VATB&quot;.
    /// </summary>
    [EnumMember(Value = "VATB")]
    [IsoId("_TRnmlAEcEeCQm6a_G2yO_w_-31457795")]
    [Description(@"Tax for which a zero rate applies.")]
    ValueAddedTaxOfZeroRate = TaxTypeCode.ValueAddedTaxOfZeroRate, // same ordinal as derivation source for type conversions
}
