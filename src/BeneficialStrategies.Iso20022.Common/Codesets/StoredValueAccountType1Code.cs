// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of stored value account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qZrKMNtfEeipuvJHTHIw9A")]
[Description(@"Type of stored value account.")]
[DerivedFrom(typeof(StoredValueAccountTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<StoredValueAccountType1Code>))]
#endif
public enum StoredValueAccountType1Code
{
    /// <summary>
    /// Prepaid account managed by a financial institution for low income customers.
    /// Encoded/decoded by serializers as &quot;BNKA&quot;.
    /// </summary>
    [EnumMember(Value = "BNKA")]
    [IsoId("_swkJEdtfEeipuvJHTHIw9A")]
    [Description(@"Prepaid account managed by a financial institution for low income customers.")]
    BankPrepaidAccount = StoredValueAccountTypeCode.BankPrepaidAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Car wash specific account.
    /// Encoded/decoded by serializers as &quot;CWVC&quot;.
    /// </summary>
    [EnumMember(Value = "CWVC")]
    [IsoId("_sz7mIdtfEeipuvJHTHIw9A")]
    [Description(@"Car wash specific account.")]
    CarwashVoucher = StoredValueAccountTypeCode.CarwashVoucher, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specific prepaid account for companies or professionals expenses.
    /// Encoded/decoded by serializers as &quot;CPYA&quot;.
    /// </summary>
    [EnumMember(Value = "CPYA")]
    [IsoId("_s4Kl4dtfEeipuvJHTHIw9A")]
    [Description(@"Specific prepaid account for companies or professionals expenses.")]
    CompanyPrepaidAccount = StoredValueAccountTypeCode.CompanyPrepaidAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account supporting e-money issued by an electronic money issuer.
    /// Encoded/decoded by serializers as &quot;ELMY&quot;.
    /// </summary>
    [EnumMember(Value = "ELMY")]
    [IsoId("_s8hhcdtfEeipuvJHTHIw9A")]
    [Description(@"Account supporting e-money issued by an electronic money issuer.")]
    ElectronicMoneyAccount = StoredValueAccountTypeCode.ElectronicMoneyAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment mean issued by retailers or banks as a substitute to a non-monetary gift. Usually, this Stored Value item is used only once.
    /// Encoded/decoded by serializers as &quot;GIFT&quot;.
    /// </summary>
    [EnumMember(Value = "GIFT")]
    [IsoId("_tBb2odtfEeipuvJHTHIw9A")]
    [Description(
        @"Payment mean issued by retailers or banks as a substitute to a non-monetary gift. Usually, this Stored Value item is used only once."
    )]
    GiftCard = StoredValueAccountTypeCode.GiftCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate to be given to a customer. Usually one shot voucher.
    /// Encoded/decoded by serializers as &quot;GCER&quot;.
    /// </summary>
    [EnumMember(Value = "GCER")]
    [IsoId("_tGYBAdtfEeipuvJHTHIw9A")]
    [Description(@"Certificate to be given to a customer. Usually one shot voucher.")]
    GiftCertificate = StoredValueAccountTypeCode.GiftCertificate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Meal and check voucher for restaurants.
    /// Encoded/decoded by serializers as &quot;MLVC&quot;.
    /// </summary>
    [EnumMember(Value = "MLVC")]
    [IsoId("_tKV7AdtfEeipuvJHTHIw9A")]
    [Description(@"Meal and check voucher for restaurants.")]
    MealVoucher = StoredValueAccountTypeCode.MealVoucher, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Voucher that can be used online once or in several times.
    /// Encoded/decoded by serializers as &quot;OLVC&quot;.
    /// </summary>
    [EnumMember(Value = "OLVC")]
    [IsoId("_tPUhodtfEeipuvJHTHIw9A")]
    [Description(@"Voucher that can be used online once or in several times.")]
    OnlineVoucher = StoredValueAccountTypeCode.OnlineVoucher, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Prepaid account open with a merchant or big retailers.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_tVqaMdtfEeipuvJHTHIw9A")]
    [Description(@"Prepaid account open with a merchant or big retailers.")]
    MerchantAccount = StoredValueAccountTypeCode.MerchantAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other non listed stored value instrument.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_tdEpwdtfEeipuvJHTHIw9A")]
    [Description(@"Other non listed stored value instrument.")]
    OtherPrepaidAccount = StoredValueAccountTypeCode.OtherPrepaidAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stored value instrument used to pay telephone services (e.g. card or identifier).
    /// Encoded/decoded by serializers as &quot;PHON&quot;.
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_thugQdtfEeipuvJHTHIw9A")]
    [Description(
        @"Stored value instrument used to pay telephone services (e.g. card or identifier)."
    )]
    PhoneCard = StoredValueAccountTypeCode.PhoneCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stored value account hold on the chip of a smart card.
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_tmPz4dtfEeipuvJHTHIw9A")]
    [Description(@"Stored value account hold on the chip of a smart card. ")]
    SmartCardTag = StoredValueAccountTypeCode.SmartCardTag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Travel prepaid account.
    /// Encoded/decoded by serializers as &quot;TRVL&quot;.
    /// </summary>
    [EnumMember(Value = "TRVL")]
    [IsoId("_tquEMdtfEeipuvJHTHIw9A")]
    [Description(@"Travel prepaid account.")]
    Travel = StoredValueAccountTypeCode.Travel, // same ordinal as derivation source for type conversions
}
