// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying type of product or financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RDYYYGlDEeaLAKoEUNsD9g")]
[Description(@"Specifies the underlying type of product or financial instrument.")]
[DerivedFrom(typeof(ProductTypeV2Code))]
public enum ProductType5Code
{
    /// <summary>
    /// Identifies categories of instruments related to Emission Allowance.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_Ty9kEWlDEeaLAKoEUNsD9g")]
    [Description(@"Identifies categories of instruments related to Emission Allowance.")]
    EmissionAllowance = ProductTypeV2Code.EmissionAllowance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies categories of instruments that are interest rates based.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_VAB0IWlDEeaLAKoEUNsD9g")]
    [Description(@"Identifies categories of instruments that are interest rates based.")]
    InterestRate = ProductTypeV2Code.InterestRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies the nature or type of an equity.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_VdArEWlDEeaLAKoEUNsD9g")]
    [Description(@"Identifies the nature or type of an equity.")]
    Equity = ProductTypeV2Code.Equity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies categories of instruments that are commodities.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_VzUSQWlDEeaLAKoEUNsD9g")]
    [Description(@"Identifies categories of instruments that are commodities.")]
    Commodity = ProductTypeV2Code.Commodity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies categories of instruments that are credits.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_WGPOQWlDEeaLAKoEUNsD9g")]
    [Description(@"Identifies categories of instruments that are credits.")]
    Credit = ProductTypeV2Code.Credit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifies categories of currency instruments.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_WZ5KEWlDEeaLAKoEUNsD9g")]
    [Description(@"Identifies categories of currency instruments.")]
    Currency = ProductTypeV2Code.Currency, // same ordinal as derivation source for type conversions
    
}
