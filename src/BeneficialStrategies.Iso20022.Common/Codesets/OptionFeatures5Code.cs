// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the features that may apply to a corporate action option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_R2efACdaEeOXAt_43VmZGw")]
[Description(@"Specifies the features that may apply to a corporate action option.")]
[DerivedFrom(typeof(OptionFeaturesCode))]
public enum OptionFeatures5Code
{
    /// <summary>
    /// Option is offered by the account servicer only.
    /// Encoded/decoded by serializers as &quot;ASVO&quot;.
    /// </summary>
    [EnumMember(Value = "ASVO")]
    [IsoId("_zjcv8SdaEeOXAt_43VmZGw")]
    [Description(@"Option is offered by the account servicer only.")]
    AccountServicerOption = OptionFeaturesCode.AccountServicerOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the holder needs to instruct at beneficiary owner level only.
    /// Encoded/decoded by serializers as &quot;BOIS&quot;.
    /// </summary>
    [EnumMember(Value = "BOIS")]
    [IsoId("_zp_c0SdaEeOXAt_43VmZGw")]
    [Description(@"Indicates that the holder needs to instruct at beneficiary owner level only.")]
    BeneficiaryOwnerInstruction = OptionFeaturesCode.BeneficiaryOwnerInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Feature whereby the holder can elect to place a condition on the acceptance of the option.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_zvMs8SdaEeOXAt_43VmZGw")]
    [Description(@"Feature whereby the holder can elect to place a condition on the acceptance of the option.")]
    Conditional = OptionFeaturesCode.Conditional, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn.
    /// Encoded/decoded by serializers as &quot;MAXC&quot;.
    /// </summary>
    [EnumMember(Value = "MAXC")]
    [IsoId("_z1mP4SdaEeOXAt_43VmZGw")]
    [Description(@"Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn.")]
    MaximumCash = OptionFeaturesCode.MaximumCash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn.
    /// Encoded/decoded by serializers as &quot;MAXS&quot;.
    /// </summary>
    [EnumMember(Value = "MAXS")]
    [IsoId("_z6NqISdaEeOXAt_43VmZGw")]
    [Description(@"Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn.")]
    MaximumSecurities = OptionFeaturesCode.MaximumSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Feature whereby the holder must elect directly to the issuer&apos;s agent (issuer only supported option).
    /// Encoded/decoded by serializers as &quot;NOSE&quot;.
    /// </summary>
    [EnumMember(Value = "NOSE")]
    [IsoId("_z-hiYSdaEeOXAt_43VmZGw")]
    [Description(@"Feature whereby the holder must elect directly to the issuer's agent (issuer only supported option).")]
    NoServiceOffered = OptionFeaturesCode.NoServiceOffered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tender or exchange with the odd lot preference.
    /// Encoded/decoded by serializers as &quot;OPLF&quot;.
    /// </summary>
    [EnumMember(Value = "OPLF")]
    [IsoId("_0DSGkSdaEeOXAt_43VmZGw")]
    [Description(@"Tender or exchange with the odd lot preference.")]
    OddLotPreference = OptionFeaturesCode.OddLotPreference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants.
    /// Encoded/decoded by serializers as &quot;CAOS&quot;.
    /// </summary>
    [EnumMember(Value = "CAOS")]
    [IsoId("_0Jh4gSdaEeOXAt_43VmZGw")]
    [Description(@"Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants.")]
    OptionApplicability = OptionFeaturesCode.OptionApplicability, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Feature whereby the holder can elect a quantity to receive over and above normal ensured entitlement.
    /// Encoded/decoded by serializers as &quot;QOVE&quot;.
    /// </summary>
    [EnumMember(Value = "QOVE")]
    [IsoId("_0QYHYSdaEeOXAt_43VmZGw")]
    [Description(@"Feature whereby the holder can elect a quantity to receive over and above normal ensured entitlement.")]
    OverAndAbove = OptionFeaturesCode.OverAndAbove, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates the previously sent instructions becomes invalid. This is only applicable after a market deadline extension.
    /// Encoded/decoded by serializers as &quot;PINS&quot;.
    /// </summary>
    [EnumMember(Value = "PINS")]
    [IsoId("_0WCDcSdaEeOXAt_43VmZGw")]
    [Description(@"Indicates the previously sent instructions becomes invalid. This is only applicable after a market deadline extension.")]
    PreviousInstructionInvalidity = OptionFeaturesCode.PreviousInstructionInvalidity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Feature whereby the holder can elect a quantity to receive.
    /// Encoded/decoded by serializers as &quot;QREC&quot;.
    /// </summary>
    [EnumMember(Value = "QREC")]
    [IsoId("_0aV7sSdaEeOXAt_43VmZGw")]
    [Description(@"Feature whereby the holder can elect a quantity to receive.")]
    QuantityToReceive = OptionFeaturesCode.QuantityToReceive, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Feature whereby the option can be subject to pro ration in case, for example, of over-subscription.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_0iE7YSdaEeOXAt_43VmZGw")]
    [Description(@"Feature whereby the option can be subject to pro ration in case, for example, of over-subscription.")]
    Proration = OptionFeaturesCode.Proration, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reduced withholding tax rate applies to the option.
    /// Encoded/decoded by serializers as &quot;VVPR&quot;.
    /// </summary>
    [EnumMember(Value = "VVPR")]
    [IsoId("_0oeeUSdaEeOXAt_43VmZGw")]
    [Description(@"Reduced withholding tax rate applies to the option.")]
    ReducedWithholdingTax = OptionFeaturesCode.ReducedWithholdingTax, // same ordinal as derivation source for type conversions
    
}
