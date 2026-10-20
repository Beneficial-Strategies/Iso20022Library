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
[IsoId("_Q0TXgaNYEfC9id413JK-Ig")]
[Description(@"Specifies the additional business process linked to a corporate action event.")]
[DerivedFrom(typeof(AdditionalBusinessProcessCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<AdditionalBusinessProcess13Code>))]
public enum AdditionalBusinessProcess13Code
{
    /// <summary>
    /// Will automatically give rise to market claims by the account servicer, for example, a Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as &quot;ACLA&quot;.
    /// </summary>
    [EnumMember(Value = "ACLA")]
    [IsoId("_Q83doaNYEfC9id413JK-Ig")]
    [Description(@"Will automatically give rise to market claims by the account servicer, for example, a Central Securities Depository (CSD).")]
    AutomaticMarketClaim = AdditionalBusinessProcessCode.AutomaticMarketClaim,

    /// <summary>
    /// As a result of the corporate action, all transactions in the underlying security will be cancelled by the system and replaced with transactions in the outturn resource(s).
    /// Encoded/decoded by serializers as &quot;ATXF&quot;.
    /// </summary>
    [EnumMember(Value = "ATXF")]
    [IsoId("_Q83do6NYEfC9id413JK-Ig")]
    [Description(@"As a result of the corporate action, all transactions in the underlying security will be cancelled by the system and replaced with transactions in the outturn resource(s).")]
    SubjectToTransformation = AdditionalBusinessProcessCode.SubjectToTransformation,

    /// <summary>
    /// As a result of the corporate action, all transactions in the underlying security will be cancelled by the system.
    /// Encoded/decoded by serializers as &quot;CNTR&quot;.
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_Q83dpaNYEfC9id413JK-Ig")]
    [Description(@"As a result of the corporate action, all transactions in the underlying security will be cancelled by the system.")]
    CancelUnderlyingTrades = AdditionalBusinessProcessCode.CancelUnderlyingTrades,

    /// <summary>
    /// Relates to a consent within a corporate action event other than a Consent event.
    /// Encoded/decoded by serializers as &quot;CONS&quot;.
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_Q83draNYEfC9id413JK-Ig")]
    [Description(@"Relates to a consent within a corporate action event other than a Consent event.")]
    Consent = AdditionalBusinessProcessCode.Consent,

    /// <summary>
    /// The event is a payment of an incentive premium related to the voting conditions prescribed at a general meeting.
    /// Encoded/decoded by serializers as &quot;INCP&quot;.
    /// </summary>
    [EnumMember(Value = "INCP")]
    [IsoId("_Q83dt6NYEfC9id413JK-Ig")]
    [Description(@"The event is a payment of an incentive premium related to the voting conditions prescribed at a general meeting.")]
    IncentivePremiumPayment = AdditionalBusinessProcessCode.IncentivePremiumPayment,

    /// <summary>
    /// Event will not automatically give rise to market claims and transformations by the account servicer, for example, a Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as &quot;NAMC&quot;.
    /// </summary>
    [EnumMember(Value = "NAMC")]
    [IsoId("_Q83dp6NYEfC9id413JK-Ig")]
    [Description(@"Event will not automatically give rise to market claims and transformations by the account servicer, for example, a Central Securities Depository (CSD).")]
    NoAutomaticMarketClaimsAndTransformations = AdditionalBusinessProcessCode.NoAutomaticMarketClaimsAndTransformations,

    /// <summary>
    /// Issuer only allows a single option to be selected per designated holding.
    /// Encoded/decoded by serializers as &quot;NPLE&quot;.
    /// </summary>
    [EnumMember(Value = "NPLE")]
    [IsoId("_Q83dqaNYEfC9id413JK-Ig")]
    [Description(@"Issuer only allows a single option to be selected per designated holding.")]
    NoSplitElection = AdditionalBusinessProcessCode.NoSplitElection,

    /// <summary>
    /// Partial pre-funding of a debt instrument prior to maturity drawn through a lottery process.
    /// Encoded/decoded by serializers as &quot;PPRE&quot;.
    /// </summary>
    [EnumMember(Value = "PPRE")]
    [IsoId("_Q83ds6NYEfC9id413JK-Ig")]
    [Description(@"Partial pre-funding of a debt instrument prior to maturity drawn through a lottery process.")]
    PartialPreFunding = AdditionalBusinessProcessCode.PartialPreFunding,

    /// <summary>
    /// Partial mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed.
    /// Encoded/decoded by serializers as &quot;PPUT&quot;.
    /// </summary>
    [EnumMember(Value = "PPUT")]
    [IsoId("_Q83dr6NYEfC9id413JK-Ig")]
    [Description(@"Partial mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed.")]
    PartialMandatoryPutRedemption = AdditionalBusinessProcessCode.PartialMandatoryPutRedemption,

    /// <summary>
    /// Proceeds / entitlements of the mandatory event can only be paid if specified action is taken by the account owner.
    /// Encoded/decoded by serializers as &quot;REAC&quot;.
    /// </summary>
    [EnumMember(Value = "REAC")]
    [IsoId("_Q83dtaNYEfC9id413JK-Ig")]
    [Description(@"Proceeds / entitlements of the mandatory event can only be paid if specified action is taken by the account owner.")]
    RequiredAction = AdditionalBusinessProcessCode.RequiredAction,

    /// <summary>
    /// Component event of a scheme/plan of arrangement: a reorganisation of a company or a group of companies, and their capital.
    /// Encoded/decoded by serializers as &quot;SCHM&quot;.
    /// </summary>
    [EnumMember(Value = "SCHM")]
    [IsoId("_Q83dq6NYEfC9id413JK-Ig")]
    [Description(@"Component event of a scheme/plan of arrangement: a reorganisation of a company or a group of companies, and their capital.")]
    SchemeOrPlanOfArrangement = AdditionalBusinessProcessCode.SchemeOrPlanOfArrangement,
}
