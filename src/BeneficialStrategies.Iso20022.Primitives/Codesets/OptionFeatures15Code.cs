// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the features that may apply to a corporate action option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("dd2c5fe5-ddea-445e-a717-756b5d1257b6")]
[Description(@"Specifies the features that may apply to a corporate action option.")]
[DerivedFrom(typeof(OptionFeaturesCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<OptionFeatures15Code>))]
public enum OptionFeatures15Code
{
    /// <summary>
    /// Option is offered by the account servicer only.
    /// Encoded/decoded by serializers as &quot;ASVO&quot;.
    /// </summary>
    [EnumMember(Value = "ASVO")]
    [IsoId("6a9d9f31-2362-4815-a626-b68f2f9960f0")]
    [Description(@"Option is offered by the account servicer only.")]
    AccountServicerOption = OptionFeaturesCode.AccountServicerOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the holder needs to instruct at beneficiary owner level only.
    /// Encoded/decoded by serializers as &quot;BOIS&quot;.
    /// </summary>
    [EnumMember(Value = "BOIS")]
    [IsoId("91ed66eb-30d1-482b-8c0e-2d499d455b6f")]
    [Description(@"Indicates that the holder needs to instruct at beneficiary owner level only.")]
    BeneficiaryOwnerInstruction = OptionFeaturesCode.BeneficiaryOwnerInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants.
    /// Encoded/decoded by serializers as &quot;CAOS&quot;.
    /// </summary>
    [EnumMember(Value = "CAOS")]
    [IsoId("94b9c260-cf03-43a2-b54d-ab1fcf701c31")]
    [Description(
        @"Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants."
    )]
    OptionApplicability = OptionFeaturesCode.OptionApplicability, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the holder can elect to place a condition on the acceptance of the option.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("070d2fa1-47d7-4274-a7dd-ff1380d2c667")]
    [Description(
        @"Feature whereby the holder can elect to place a condition on the acceptance of the option."
    )]
    Conditional = OptionFeaturesCode.Conditional, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities will be accepted in the order they have been submitted until the target number of quantity sought is reached.
    /// Encoded/decoded by serializers as &quot;FCFS&quot;.
    /// </summary>
    [EnumMember(Value = "FCFS")]
    [IsoId("57b6b0f8-9276-4083-a887-810f6fdcbc63")]
    [Description(
        @"Securities will be accepted in the order they have been submitted until the target number of quantity sought is reached."
    )]
    FirstComeFirstServed = OptionFeaturesCode.FirstComeFirstServed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn.
    /// Encoded/decoded by serializers as &quot;MAXC&quot;.
    /// </summary>
    [EnumMember(Value = "MAXC")]
    [IsoId("b39ac9a4-0ba8-472f-9b18-c9f4d7d1a698")]
    [Description(
        @"Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn."
    )]
    MaximumCash = OptionFeaturesCode.MaximumCash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn.
    /// Encoded/decoded by serializers as &quot;MAXS&quot;.
    /// </summary>
    [EnumMember(Value = "MAXS")]
    [IsoId("a19fa64b-4361-46e2-a060-721f83b3338b")]
    [Description(
        @"Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn."
    )]
    MaximumSecurities = OptionFeaturesCode.MaximumSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the holder must elect directly to the issuer's agent (issuer only supported option).
    /// Encoded/decoded by serializers as &quot;NOSE&quot;.
    /// </summary>
    [EnumMember(Value = "NOSE")]
    [IsoId("c82b1662-7025-4e3c-a580-4fc8038a2a18")]
    [Description(
        @"Feature whereby the holder must elect directly to the issuer's agent (issuer only supported option)."
    )]
    NoServiceOffered = OptionFeaturesCode.NoServiceOffered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tender or exchange with the odd lot preference.
    /// Encoded/decoded by serializers as &quot;OPLF&quot;.
    /// </summary>
    [EnumMember(Value = "OPLF")]
    [IsoId("740632a5-9367-4a51-b165-37ce12cca401")]
    [Description(@"Tender or exchange with the odd lot preference.")]
    OddLotPreference = OptionFeaturesCode.OddLotPreference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates the previously sent instructions becomes invalid. This is only applicable after a market deadline extension.
    /// Encoded/decoded by serializers as &quot;PINS&quot;.
    /// </summary>
    [EnumMember(Value = "PINS")]
    [IsoId("81b1cf4d-25fd-4ad4-93b3-97bc784af920")]
    [Description(
        @"Indicates the previously sent instructions becomes invalid. This is only applicable after a market deadline extension."
    )]
    PreviousInstructionInvalidity = OptionFeaturesCode.PreviousInstructionInvalidity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the option can be subject to pro ration in case, for example, of over-subscription.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("d77aba1a-131e-4608-9999-f07a4ca50ec6")]
    [Description(
        @"Feature whereby the option can be subject to pro ration in case, for example, of over-subscription."
    )]
    Proration = OptionFeaturesCode.Proration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the holder should only instruct a cash amount.
    /// Encoded/decoded by serializers as &quot;QCAS&quot;.
    /// </summary>
    [EnumMember(Value = "QCAS")]
    [IsoId("dcba59e6-8a32-4bc6-a219-412bc21620b1")]
    [Description(@"Feature whereby the holder should only instruct a cash amount.")]
    InstructCashAmount = OptionFeaturesCode.InstructCashAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Gross dividend is reinvested.
    /// Encoded/decoded by serializers as &quot;RGRS&quot;.
    /// </summary>
    [EnumMember(Value = "RGRS")]
    [IsoId("37e248f6-b508-4f80-b2fe-4ab3840887c3")]
    [Description(@"Gross dividend is reinvested.")]
    GrossDividendReinvestment = OptionFeaturesCode.GrossDividendReinvestment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend reinvestment is processed net of withholding tax.
    /// Encoded/decoded by serializers as &quot;RNET&quot;.
    /// </summary>
    [EnumMember(Value = "RNET")]
    [IsoId("e2f53ac6-db3b-4ac9-a377-224f416ddc6f")]
    [Description(@"Dividend reinvestment is processed net of withholding tax.")]
    NetDividendReinvestment = OptionFeaturesCode.NetDividendReinvestment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates usage of a reference number to identify an investor or a shareholder with the issuer or the registration provider (for instance allocation code).
    /// Encoded/decoded by serializers as &quot;SHAR&quot;.
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("164f86ff-3420-4015-8011-8cbd1810f5b9")]
    [Description(
        @"Indicates usage of a reference number to identify an investor or a shareholder with the issuer or the registration provider (for instance allocation code)."
    )]
    ShareholderNumber = OptionFeaturesCode.ShareholderNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reduced withholding tax rate applies to the option.
    /// Encoded/decoded by serializers as &quot;VVPR&quot;.
    /// </summary>
    [EnumMember(Value = "VVPR")]
    [IsoId("93370390-e3f6-4824-b676-841ebc3cb63d")]
    [Description(@"Reduced withholding tax rate applies to the option.")]
    ReducedWithholdingTax = OptionFeaturesCode.ReducedWithholdingTax, // same ordinal as derivation source for type conversions
}
