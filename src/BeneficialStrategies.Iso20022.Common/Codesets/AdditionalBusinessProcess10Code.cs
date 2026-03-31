// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the additional business process linked to a corporate action event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DyGCYRewEeyroI8qKgB7Mg")]
[Description(@"Specifies the additional business process linked to a corporate action event.")]
[DerivedFrom(typeof(AdditionalBusinessProcessCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AdditionalBusinessProcess10Code>))]
#endif
public enum AdditionalBusinessProcess10Code
{
    /// <summary>
    /// Relates to a claim on the associated corporate action event.
    /// Encoded/decoded by serializers as &quot;CLAI&quot;.
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_EIJx8RewEeyroI8qKgB7Mg")]
    [Description(@"Relates to a claim on the associated corporate action event.")]
    ClaimOrCompensation = AdditionalBusinessProcessCode.ClaimOrCompensation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates a preadvice of movement reversal.
    /// Encoded/decoded by serializers as &quot;REVR&quot;.
    /// </summary>
    [EnumMember(Value = "REVR")]
    [IsoId("_EIJx8xewEeyroI8qKgB7Mg")]
    [Description(@"Indicates a preadvice of movement reversal.")]
    NotificationOfReversal = AdditionalBusinessProcessCode.NotificationOfReversal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a tax refund from the authorities on the associated corporate action event.
    /// Encoded/decoded by serializers as &quot;TAXR&quot;.
    /// </summary>
    [EnumMember(Value = "TAXR")]
    [IsoId("_EIJx9RewEeyroI8qKgB7Mg")]
    [Description(
        @"Relates to a tax refund from the authorities on the associated corporate action event."
    )]
    TaxRefund = AdditionalBusinessProcessCode.TaxRefund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Partial mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities. A lottery will be used to determine eligibility for the event.
    /// Encoded/decoded by serializers as &quot;PPUT&quot;.
    /// </summary>
    [EnumMember(Value = "PPUT")]
    [IsoId("_EIJx9xewEeyroI8qKgB7Mg")]
    [Description(
        @"Partial mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities. A lottery will be used to determine eligibility for the event."
    )]
    PartialMandatoryPutRedemption = AdditionalBusinessProcessCode.PartialMandatoryPutRedemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Partial pre-funding of a debt instrument prior to maturity drawn through a lottery process. One new security is issued with an earlier maturity date for the refunded (called portion) and the other new security is issued with the original maturity date for the non refunded (remaining) portion. Applicable only in the frame of a partial defeasance corporate action event.
    /// Encoded/decoded by serializers as &quot;PPRE&quot;.
    /// </summary>
    [EnumMember(Value = "PPRE")]
    [IsoId("_EIJx-RewEeyroI8qKgB7Mg")]
    [Description(
        @"Partial pre-funding of a debt instrument prior to maturity drawn through a lottery process. One new security is issued with an earlier maturity date for the refunded (called portion) and the other new security is issued with the original maturity date for the non refunded (remaining) portion. Applicable only in the frame of a partial defeasance corporate action event."
    )]
    PartialPreFunding = AdditionalBusinessProcessCode.PartialPreFunding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Full pre-funding of a debt instrument by the issuer prior to original maturity when the issuer deposits assets in trust. Applicable only in the frame of a partial defeasance corporate action event.
    /// Encoded/decoded by serializers as &quot;FPRE&quot;.
    /// </summary>
    [EnumMember(Value = "FPRE")]
    [IsoId("_EIJx-xewEeyroI8qKgB7Mg")]
    [Description(
        @"Full pre-funding of a debt instrument by the issuer prior to original maturity when the issuer deposits assets in trust. Applicable only in the frame of a partial defeasance corporate action event."
    )]
    FullPrefunding = AdditionalBusinessProcessCode.FullPrefunding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Proceeds / entitlements of the mandatory event can only be paid if specified action is taken by the account owner.
    /// Encoded/decoded by serializers as &quot;REAC&quot;.
    /// </summary>
    [EnumMember(Value = "REAC")]
    [IsoId("_EIJx_RewEeyroI8qKgB7Mg")]
    [Description(
        @"Proceeds / entitlements of the mandatory event can only be paid if specified action is taken by the account owner."
    )]
    RequiredAction = AdditionalBusinessProcessCode.RequiredAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The event is a payment of an incentive premium related to the voting conditions prescribed at a general meeting.
    /// Encoded/decoded by serializers as &quot;INCP&quot;.
    /// </summary>
    [EnumMember(Value = "INCP")]
    [IsoId("_GyU5MRewEeyroI8qKgB7Mg")]
    [Description(
        @"The event is a payment of an incentive premium related to the voting conditions prescribed at a general meeting."
    )]
    IncentivePremiumPayment = AdditionalBusinessProcessCode.IncentivePremiumPayment, // same ordinal as derivation source for type conversions
}
