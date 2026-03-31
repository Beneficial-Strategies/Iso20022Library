// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of tax efficient product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Xccy8E4MEeiQHa-q1Uephw")]
[Description(@"Specifies a type of tax efficient product.")]
[DerivedFrom(typeof(TaxEfficientProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TaxEfficientProductType1Code>))]
#endif
public enum TaxEfficientProductType1Code
{
    /// <summary>
    /// Cash individual savings account. In the UK, this is known as a cash ISA.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_YiM6EU4MEeiQHa-q1Uephw")]
    [Description(@"Cash individual savings account. In the UK, this is known as a cash ISA.")]
    Cash = TaxEfficientProductTypeCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Non-stakeholder child trust fund individual savings account. In the UK, this is known as a non-stakeholder CTF ISA.
    /// Encoded/decoded by serializers as &quot;CCTF&quot;.
    /// </summary>
    [EnumMember(Value = "CCTF")]
    [IsoId("_YoWlYU4MEeiQHa-q1Uephw")]
    [Description(
        @"Non-stakeholder child trust fund individual savings account. In the UK, this is known as a non-stakeholder CTF ISA."
    )]
    NonStakeholderChildTrustFund = TaxEfficientProductTypeCode.NonStakeholderChildTrustFund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Flexible individual savings account. In the UK, this is known as a FISA.
    /// Encoded/decoded by serializers as &quot;FISA&quot;.
    /// </summary>
    [EnumMember(Value = "FISA")]
    [IsoId("_YuGoEU4MEeiQHa-q1Uephw")]
    [Description(@"Flexible individual savings account. In the UK, this is known as a FISA.")]
    Flexible = TaxEfficientProductTypeCode.Flexible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Help to buy individual savings account. In the UK, this is known as a HISA.
    /// Encoded/decoded by serializers as &quot;HISA&quot;.
    /// </summary>
    [EnumMember(Value = "HISA")]
    [IsoId("_Y0QTYU4MEeiQHa-q1Uephw")]
    [Description(@"Help to buy individual savings account. In the UK, this is known as a HISA.")]
    HelpToBuy = TaxEfficientProductTypeCode.HelpToBuy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Innovative finance individual savings account. In the UK, this is known as an innovative ISA.
    /// Encoded/decoded by serializers as &quot;INNF&quot;.
    /// </summary>
    [EnumMember(Value = "INNF")]
    [IsoId("_Y41RYU4MEeiQHa-q1Uephw")]
    [Description(
        @"Innovative finance individual savings account. In the UK, this is known as an innovative ISA."
    )]
    InnovativeFinance = TaxEfficientProductTypeCode.InnovativeFinance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Junior cash individual savings account. In the UK, this is known as a cash JISA.
    /// Encoded/decoded by serializers as &quot;JCSH&quot;.
    /// </summary>
    [EnumMember(Value = "JCSH")]
    [IsoId("_ZAO54U4MEeiQHa-q1Uephw")]
    [Description(
        @"Junior cash individual savings account. In the UK, this is known as a cash JISA."
    )]
    JuniorCash = TaxEfficientProductTypeCode.JuniorCash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Junior stocks and shares individual savings account. In the UK, this is known as a stocks and shares  JISA.
    /// Encoded/decoded by serializers as &quot;JISA&quot;.
    /// </summary>
    [EnumMember(Value = "JISA")]
    [IsoId("_ZFB6UU4MEeiQHa-q1Uephw")]
    [Description(
        @"Junior stocks and shares individual savings account. In the UK, this is known as a stocks and shares  JISA."
    )]
    JuniorStocksAndSharesISA = TaxEfficientProductTypeCode.JuniorStocksAndSharesISA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stocks and shares lifetime individual savings account. In the UK, this is known as a stocks and shares LISA.
    /// Encoded/decoded by serializers as &quot;LISA&quot;.
    /// </summary>
    [EnumMember(Value = "LISA")]
    [IsoId("_ZKgQMU4MEeiQHa-q1Uephw")]
    [Description(
        @"Stocks and shares lifetime individual savings account. In the UK, this is known as a stocks and shares LISA."
    )]
    Lifetime = TaxEfficientProductTypeCode.Lifetime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stakeholder child trust fund individual savings account. In the UK, this is known as a stakeholder CTF ISA.
    /// Encoded/decoded by serializers as &quot;SCTF&quot;.
    /// </summary>
    [EnumMember(Value = "SCTF")]
    [IsoId("_ZO5oAU4MEeiQHa-q1Uephw")]
    [Description(
        @"Stakeholder child trust fund individual savings account. In the UK, this is known as a stakeholder CTF ISA."
    )]
    StakeholderChildTrustFund = TaxEfficientProductTypeCode.StakeholderChildTrustFund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stocks and shares individual savings account. In the UK, this is known as a stocks and shares ISA.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_ZU_o8U4MEeiQHa-q1Uephw")]
    [Description(
        @"Stocks and shares individual savings account. In the UK, this is known as a stocks and shares ISA."
    )]
    StocksAndShares = TaxEfficientProductTypeCode.StocksAndShares, // same ordinal as derivation source for type conversions

    /// <summary>
    /// General investment savings account. (Known as Investeringssparkonto (ISK) in some markets.)
    /// Encoded/decoded by serializers as &quot;GISK&quot;.
    /// </summary>
    [EnumMember(Value = "GISK")]
    [IsoId("_EAWtYaFgEei_VZq-6SQkuQ")]
    [Description(
        @"General investment savings account. (Known as Investeringssparkonto (ISK) in some markets.)"
    )]
    GeneralInvestmentSavingsAccount = TaxEfficientProductTypeCode.GeneralInvestmentSavingsAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// General shares or equity savings account. (Known as ASK in some markets.)
    /// Encoded/decoded by serializers as &quot;GASK&quot;.
    /// </summary>
    [EnumMember(Value = "GASK")]
    [IsoId("_0csswaVFEeiYMvosZPzV4g")]
    [Description(@"General shares or equity savings account. (Known as ASK in some markets.)")]
    GeneralShareSavingsAccount = TaxEfficientProductTypeCode.GeneralShareSavingsAccount, // same ordinal as derivation source for type conversions
}
