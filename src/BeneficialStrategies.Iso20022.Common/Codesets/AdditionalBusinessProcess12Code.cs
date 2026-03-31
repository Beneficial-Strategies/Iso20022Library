// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the additional business process linked to a corporate action event such as an automatic market claim.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AdditionalBusinessProcess12Code")]
[Description(
    @"Specifies the additional business process linked to a corporate action event such as an automatic market claim."
)]
[DerivedFrom(typeof(AdditionalBusinessProcessCode))]
public enum AdditionalBusinessProcess12Code
{
    /// <summary>
    /// Relates to a claim on the associated corporate action event.
    /// Encoded/decoded by serializers as &quot;CLAI&quot;.
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_AdditionalBusinessProcess12Code_ClaimOrCompensation")]
    [Description(@"Relates to a claim on the associated corporate action event.")]
    ClaimOrCompensation = AdditionalBusinessProcessCode.ClaimOrCompensation,

    /// <summary>
    /// Market Claim is to transfer proceeds received from the issuer to the entitled party.
    /// Encoded/decoded by serializers as &quot;CLFT&quot;.
    /// </summary>
    [EnumMember(Value = "CLFT")]
    [IsoId("_AdditionalBusinessProcess12Code_FullTransferOfReceivedProceeds")]
    [Description(
        @"Market Claim is to transfer proceeds received from the issuer to the entitled party."
    )]
    FullTransferOfReceivedProceeds,

    /// <summary>
    /// Market Claim is to transfer proceeds partially received from the issuer to the entitled party. Part is compensated in cash by the party that failed to fulfil its obligation.
    /// Encoded/decoded by serializers as &quot;CLNT&quot;.
    /// </summary>
    [EnumMember(Value = "CLNT")]
    [IsoId("_AdditionalBusinessProcess12Code_PartialTransferOfReceivedProceeds")]
    [Description(
        @"Market Claim is to transfer proceeds partially received from the issuer to the entitled party. Part is compensated in cash by the party that failed to fulfil its obligation."
    )]
    PartialTransferOfReceivedProceeds,

    /// <summary>
    /// Market Claim is to compensate the entitled party in cash by the party that failed to fulfil its obligation. No proceeds have been received from the issuer.
    /// Encoded/decoded by serializers as &quot;CLPT&quot;.
    /// </summary>
    [EnumMember(Value = "CLPT")]
    [IsoId("_AdditionalBusinessProcess12Code_NoTransferOfReceivedProceeds")]
    [Description(
        @"Market Claim is to compensate the entitled party in cash by the party that failed to fulfil its obligation. No proceeds have been received from the issuer."
    )]
    NoTransferOfReceivedProceeds,

    /// <summary>
    /// Relates to a consent within a corporate action event other than a Consent event (: 22F:: CAEV//CONS).
    /// Encoded/decoded by serializers as &quot;CONS&quot;.
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_AdditionalBusinessProcess12Code_Consent")]
    [Description(
        @"Relates to a consent within a corporate action event other than a Consent event (: 22F:: CAEV//CONS)."
    )]
    Consent = AdditionalBusinessProcessCode.Consent,

    /// <summary>
    /// Full pre-funding of a debt instrument by the issuer prior to original maturity when the issuer deposits assets in trust. Applicable only in the frame of a partial defeasance corporate action event.
    /// Encoded/decoded by serializers as &quot;FPRE&quot;.
    /// </summary>
    [EnumMember(Value = "FPRE")]
    [IsoId("_AdditionalBusinessProcess12Code_FullPrefunding")]
    [Description(
        @"Full pre-funding of a debt instrument by the issuer prior to original maturity when the issuer deposits assets in trust. Applicable only in the frame of a partial defeasance corporate action event."
    )]
    FullPrefunding = AdditionalBusinessProcessCode.FullPrefunding,

    /// <summary>
    /// The event is a payment of an incentive premium related to the voting conditions prescribed at a general meeting.
    /// Encoded/decoded by serializers as &quot;INCP&quot;.
    /// </summary>
    [EnumMember(Value = "INCP")]
    [IsoId("_AdditionalBusinessProcess12Code_IncentivePremiumPayment")]
    [Description(
        @"The event is a payment of an incentive premium related to the voting conditions prescribed at a general meeting."
    )]
    IncentivePremiumPayment = AdditionalBusinessProcessCode.IncentivePremiumPayment,

    /// <summary>
    /// Issuer only allows a single option to be selected per designated holding.
    /// Encoded/decoded by serializers as &quot;NPLE&quot;.
    /// </summary>
    [EnumMember(Value = "NPLE")]
    [IsoId("_AdditionalBusinessProcess12Code_NoSplitElection")]
    [Description(@"Issuer only allows a single option to be selected per designated holding.")]
    NoSplitElection = AdditionalBusinessProcessCode.NoSplitElection,

    /// <summary>
    /// Partial pre-funding of a debt instrument prior to maturity drawn through a lottery process. One new security is issued with an earlier maturity date for the refunded (called portion) and the other new security is issued with the original maturity date for the non refunded (remaining) portion. Applicable only in the frame of a partial defeasance corporate action event.
    /// Encoded/decoded by serializers as &quot;PPRE&quot;.
    /// </summary>
    [EnumMember(Value = "PPRE")]
    [IsoId("_AdditionalBusinessProcess12Code_PartialPreFunding")]
    [Description(
        @"Partial pre-funding of a debt instrument prior to maturity drawn through a lottery process. One new security is issued with an earlier maturity date for the refunded (called portion) and the other new security is issued with the original maturity date for the non refunded (remaining) portion. Applicable only in the frame of a partial defeasance corporate action event."
    )]
    PartialPreFunding = AdditionalBusinessProcessCode.PartialPreFunding,

    /// <summary>
    /// Partial mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities. A lottery will be used to determine eligibility for the event.
    /// Encoded/decoded by serializers as &quot;PPUT&quot;.
    /// </summary>
    [EnumMember(Value = "PPUT")]
    [IsoId("_AdditionalBusinessProcess12Code_PartialMandatoryPutRedemption")]
    [Description(
        @"Partial mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities. A lottery will be used to determine eligibility for the event."
    )]
    PartialMandatoryPutRedemption = AdditionalBusinessProcessCode.PartialMandatoryPutRedemption,

    /// <summary>
    /// Component event of a scheme/plan of arrangement: a reorganisation of a company or a group of companies, and their capital.
    /// Encoded/decoded by serializers as &quot;SCHM&quot;.
    /// </summary>
    [EnumMember(Value = "SCHM")]
    [IsoId("_AdditionalBusinessProcess12Code_SchemeOrPlanOfArrangement")]
    [Description(
        @"Component event of a scheme/plan of arrangement: a reorganisation of a company or a group of companies, and their capital."
    )]
    SchemeOrPlanOfArrangement = AdditionalBusinessProcessCode.SchemeOrPlanOfArrangement,

    /// <summary>
    /// Relates to a tax refund from the authorities on the associated corporate action event.
    /// Encoded/decoded by serializers as &quot;TAXR&quot;.
    /// </summary>
    [EnumMember(Value = "TAXR")]
    [IsoId("_AdditionalBusinessProcess12Code_TaxRefund")]
    [Description(
        @"Relates to a tax refund from the authorities on the associated corporate action event."
    )]
    TaxRefund = AdditionalBusinessProcessCode.TaxRefund,
}
