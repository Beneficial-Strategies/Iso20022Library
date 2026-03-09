// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the additional business process linked to a corporate action event such as an automatic market claim.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bmaAc9p-Ed-ak6NoX_4Aeg_356428670")]
[Description(@"Specifies the additional business process linked to a corporate action event such as an automatic market claim.")]
[Derivations(typeof(AdditionalBusinessProcess1Code),typeof(AdditionalBusinessProcess6Code),typeof(AdditionalBusinessProcess4Code),typeof(AdditionalBusinessProcess11Code),typeof(AdditionalBusinessProcess5Code),typeof(AdditionalBusinessProcess7Code),typeof(AdditionalBusinessProcess10Code),typeof(AdditionalBusinessProcess3Code),typeof(AdditionalBusinessProcess2Code),typeof(AdditionalBusinessProcess9Code),typeof(AdditionalBusinessProcess8Code))]
public enum AdditionalBusinessProcessCode
{
    /// <summary>
    /// Will automatically give rise to market claims by the account servicer, for example, a Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as &quot;ACLA&quot;.
    /// </summary>
    [EnumMember(Value = "ACLA")]
    [IsoId("_bmaAdNp-Ed-ak6NoX_4Aeg_680586071")]
    [Description(@"Will automatically give rise to market claims by the account servicer, for example, a Central Securities Depository (CSD).")]
    AutomaticMarketClaim,
    
    /// <summary>
    /// As a result of the corporate action, all transactions in the underlying security will be cancelled by the system and replaced with transactions in the outturn resource(s).
    /// Encoded/decoded by serializers as &quot;ATXF&quot;.
    /// </summary>
    [EnumMember(Value = "ATXF")]
    [IsoId("_bmaAddp-Ed-ak6NoX_4Aeg_1125721829")]
    [Description(@"As a result of the corporate action, all transactions in the underlying security will be cancelled by the system and replaced with transactions in the outturn resource(s).")]
    SubjectToTransformation,
    
    /// <summary>
    /// As a result of the corporate action, all transactions in the underlying security will be cancelled by the system.
    /// Encoded/decoded by serializers as &quot;CNTR&quot;.
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_bmaAdtp-Ed-ak6NoX_4Aeg_1154351853")]
    [Description(@"As a result of the corporate action, all transactions in the underlying security will be cancelled by the system.")]
    CancelUnderlyingTrades,
    
    /// <summary>
    /// Event will not automatically give rise to market claims and transformations by the account servicer, for example, a Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as &quot;NAMC&quot;.
    /// </summary>
    [EnumMember(Value = "NAMC")]
    [IsoId("_bmaAd9p-Ed-ak6NoX_4Aeg_1195909241")]
    [Description(@"Event will not automatically give rise to market claims and transformations by the account servicer, for example, a Central Securities Depository (CSD).")]
    NoAutomaticMarketClaimsAndTransformations,
    
    /// <summary>
    /// Issuer only allows a single option to be selected per designated holding.
    /// Encoded/decoded by serializers as &quot;NPLE&quot;.
    /// </summary>
    [EnumMember(Value = "NPLE")]
    [IsoId("_bmjxcNp-Ed-ak6NoX_4Aeg_1242085325")]
    [Description(@"Issuer only allows a single option to be selected per designated holding.")]
    NoSplitElection,
    
    /// <summary>
    /// Component event of a scheme/plan of arrangement: a reorganisation of a company or a group of companies, and their capital.
    /// Encoded/decoded by serializers as &quot;SCHM&quot;.
    /// </summary>
    [EnumMember(Value = "SCHM")]
    [IsoId("_bmjxcdp-Ed-ak6NoX_4Aeg_1522835843")]
    [Description(@"Component event of a scheme/plan of arrangement: a reorganisation of a company or a group of companies, and their capital.")]
    SchemeOrPlanOfArrangement,
    
    /// <summary>
    /// Relates to a claim on the associated corporate action event.
    /// Encoded/decoded by serializers as &quot;CLAI&quot;.
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_bmjxctp-Ed-ak6NoX_4Aeg_1302432019")]
    [Description(@"Relates to a claim on the associated corporate action event.")]
    ClaimOrCompensation,
    
    /// <summary>
    /// Relates to a tax refund from the authorities on the associated corporate action event.
    /// Encoded/decoded by serializers as &quot;TAXR&quot;.
    /// </summary>
    [EnumMember(Value = "TAXR")]
    [IsoId("_bmjxc9p-Ed-ak6NoX_4Aeg_1331059271")]
    [Description(@"Relates to a tax refund from the authorities on the associated corporate action event.")]
    TaxRefund,
    
    /// <summary>
    /// Indicates a preadvice of movement reversal.
    /// Encoded/decoded by serializers as &quot;REVR&quot;.
    /// </summary>
    [EnumMember(Value = "REVR")]
    [IsoId("_bmjxdNp-Ed-ak6NoX_4Aeg_-1970967591")]
    [Description(@"Indicates a preadvice of movement reversal.")]
    NotificationOfReversal,
    
    /// <summary>
    /// Relates to a consent within a corporate action event other than a Consent event (: 22F:: CAEV//CONS).
    /// Encoded/decoded by serializers as &quot;CONS&quot;.
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_bmjxddp-Ed-ak6NoX_4Aeg_164070844")]
    [Description(@"Relates to a consent within a corporate action event other than a Consent event (: 22F:: CAEV//CONS).")]
    Consent,
    
    /// <summary>
    /// Partial mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities. A lottery will be used to determine eligibility for the event.
    /// Encoded/decoded by serializers as &quot;PPUT&quot;.
    /// </summary>
    [EnumMember(Value = "PPUT")]
    [IsoId("_mr8y8GH9EeWNUe-5HV3A_g")]
    [Description(@"Partial mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities. A lottery will be used to determine eligibility for the event.")]
    PartialMandatoryPutRedemption,
    
    /// <summary>
    /// Full pre-funding of a debt instrument by the issuer prior to original maturity when the issuer deposits assets in trust. Applicable only in the frame of a partial defeasance corporate action event.
    /// Encoded/decoded by serializers as &quot;FPRE&quot;.
    /// </summary>
    [EnumMember(Value = "FPRE")]
    [IsoId("_PnyMYGIAEeWNUe-5HV3A_g")]
    [Description(@"Full pre-funding of a debt instrument by the issuer prior to original maturity when the issuer deposits assets in trust. Applicable only in the frame of a partial defeasance corporate action event.")]
    FullPrefunding,
    
    /// <summary>
    /// Partial pre-funding of a debt instrument prior to maturity drawn through a lottery process. One new security is issued with an earlier maturity date for the refunded (called portion) and the other new security is issued with the original maturity date for the non refunded (remaining) portion. Applicable only in the frame of a partial defeasance corporate action event.
    /// Encoded/decoded by serializers as &quot;PPRE&quot;.
    /// </summary>
    [EnumMember(Value = "PPRE")]
    [IsoId("_Xynf0GIAEeWNUe-5HV3A_g")]
    [Description(@"Partial pre-funding of a debt instrument prior to maturity drawn through a lottery process. One new security is issued with an earlier maturity date for the refunded (called portion) and the other new security is issued with the original maturity date for the non refunded (remaining) portion. Applicable only in the frame of a partial defeasance corporate action event.")]
    PartialPreFunding,
    
    /// <summary>
    /// Proceeds / entitlements of the mandatory event can only be paid if specified action is taken by the account owner.
    /// Encoded/decoded by serializers as &quot;REAC&quot;.
    /// </summary>
    [EnumMember(Value = "REAC")]
    [IsoId("_Ao5yAGKfEeWR9ZSfjmHwUA")]
    [Description(@"Proceeds / entitlements of the mandatory event can only be paid if specified action is taken by the account owner.")]
    RequiredAction,
    
    /// <summary>
    /// The event is a payment of an incentive premium related to the voting conditions prescribed at a general meeting.
    /// Encoded/decoded by serializers as &quot;INCP&quot;.
    /// </summary>
    [EnumMember(Value = "INCP")]
    [IsoId("_Du5eEBeoEeyroI8qKgB7Mg")]
    [Description(@"The event is a payment of an incentive premium related to the voting conditions prescribed at a general meeting.")]
    IncentivePremiumPayment,
    
}
