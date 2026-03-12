// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
[IsoId("_SFR2Wd24Ed-KAqAOGQOnnw")]
[DisplayName("Corporate Action Date")]
public partial record CorporateActionDate14
{
    #nullable enable
    
    /// <summary>
    /// Date/time at which the issuer announced that a corporate action event will occur.
    /// </summary>
    [IsoId("_SFR2W924Ed-KAqAOGQOnnw")]
    [DisplayName("Announcement Date")]
    [IsoXmlTag("AnncmntDt")]
    public DateFormat19Choice_? AnnouncementDate { get; init; } 
    
    /// <summary>
    /// Deadline by which the beneficial ownership of securities must be declared.
    /// </summary>
    [IsoId("_SFR2Xd24Ed-KAqAOGQOnnw")]
    [DisplayName("Certification Deadline")]
    [IsoXmlTag("CertfctnDdln")]
    public DateFormat19Choice_? CertificationDeadline { get; init; } 
    
    /// <summary>
    /// Date upon which the court provided approval.
    /// </summary>
    [IsoId("_SFR2X924Ed-KAqAOGQOnnw")]
    [DisplayName("Court Approval Date")]
    [IsoXmlTag("CrtApprvlDt")]
    public DateFormat19Choice_? CourtApprovalDate { get; init; } 
    
    /// <summary>
    /// First possible early closing date of an offer if different from the expiry date.
    /// </summary>
    [IsoId("_SFR2Yd24Ed-KAqAOGQOnnw")]
    [DisplayName("Early Closing Date")]
    [IsoXmlTag("EarlyClsgDt")]
    public DateFormat19Choice_? EarlyClosingDate { get; init; } 
    
    /// <summary>
    /// Date/time at which an event is officially effective from the issuer&apos;s perspective.
    /// </summary>
    [IsoId("_SFR2Y924Ed-KAqAOGQOnnw")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public DateFormat19Choice_? EffectiveDate { get; init; } 
    
    /// <summary>
    /// Date/Time on which all or part of any holding bought in a unit trust is subject to being treated as capital rather than income. This is normally one day after the previous distribution&apos;s ex date.
    /// </summary>
    [IsoId("_SFR2Zd24Ed-KAqAOGQOnnw")]
    [DisplayName("Equalisation Date")]
    [IsoXmlTag("EqulstnDt")]
    public DateFormat19Choice_? EqualisationDate { get; init; } 
    
    /// <summary>
    /// Date/time at which additional information on the event will be announced, for example, exchange ratio announcement date.
    /// </summary>
    [IsoId("_SFR2Z924Ed-KAqAOGQOnnw")]
    [DisplayName("Further Detailed Announcement Date")]
    [IsoXmlTag("FrthrDtldAnncmntDt")]
    public DateFormat19Choice_? FurtherDetailedAnnouncementDate { get; init; } 
    
    /// <summary>
    /// Date/time at which an index rate will be determined.
    /// </summary>
    [IsoId("_SFR2ad24Ed-KAqAOGQOnnw")]
    [DisplayName("Index Fixing Date")]
    [IsoXmlTag("IndxFxgDt")]
    public DateFormat19Choice_? IndexFixingDate { get; init; } 
    
    /// <summary>
    /// Date/time on which the lottery is run and applied to the holder&apos;s positions. This is also applicable to partial calls.
    /// </summary>
    [IsoId("_SFR2a924Ed-KAqAOGQOnnw")]
    [DisplayName("Lottery Date")]
    [IsoXmlTag("LtryDt")]
    public DateFormat19Choice_? LotteryDate { get; init; } 
    
    /// <summary>
    /// Date/time to which the maturity date of an interest bearing security is extended.
    /// </summary>
    [IsoId("_SFR2bd24Ed-KAqAOGQOnnw")]
    [DisplayName("New Maturity Date")]
    [IsoXmlTag("NewMtrtyDt")]
    public DateFormat19Choice_? NewMaturityDate { get; init; } 
    
    /// <summary>
    /// Date/time on which the bondholder&apos;s or shareholder&apos;s meeting will take place.
    /// </summary>
    [IsoId("_SFR2b924Ed-KAqAOGQOnnw")]
    [DisplayName("Meeting Date")]
    [IsoXmlTag("MtgDt")]
    public DateFormat19Choice_? MeetingDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the margin rate will be determined.
    /// </summary>
    [IsoId("_SFR2cd24Ed-KAqAOGQOnnw")]
    [DisplayName("Margin Fixing Date")]
    [IsoXmlTag("MrgnFxgDt")]
    public DateFormat19Choice_? MarginFixingDate { get; init; } 
    
    /// <summary>
    /// Date/time (and time) at which an issuer will determine the proration amount/quantity of an offer.
    /// </summary>
    [IsoId("_SFR2c924Ed-KAqAOGQOnnw")]
    [DisplayName("Proration Date")]
    [IsoXmlTag("PrratnDt")]
    public DateFormat19Choice_? ProrationDate { get; init; } 
    
    /// <summary>
    /// Date/time at which positions are struck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date.
    /// </summary>
    [IsoId("_SFR2dd24Ed-KAqAOGQOnnw")]
    [DisplayName("Record Date")]
    [IsoXmlTag("RcrdDt")]
    public DateFormat19Choice_? RecordDate { get; init; } 
    
    /// <summary>
    /// Date/time on which instructions to register or registration details will be accepted.
    /// </summary>
    [IsoId("_SFR2d924Ed-KAqAOGQOnnw")]
    [DisplayName("Registration Deadline")]
    [IsoXmlTag("RegnDdln")]
    public DateFormat19Choice_? RegistrationDeadline { get; init; } 
    
    /// <summary>
    /// Date/time on which results are published, for example, results of an offer.
    /// </summary>
    [IsoId("_SFR2ed24Ed-KAqAOGQOnnw")]
    [DisplayName("Results Publication Date")]
    [IsoXmlTag("RsltsPblctnDt")]
    public DateFormat19Choice_? ResultsPublicationDate { get; init; } 
    
    /// <summary>
    /// Deadline by which instructions must be received to split securities, for example, of physical certificates.
    /// </summary>
    [IsoId("_SFR2e924Ed-KAqAOGQOnnw")]
    [DisplayName("Deadline To Split")]
    [IsoXmlTag("DdlnToSplt")]
    public DateFormat19Choice_? DeadlineToSplit { get; init; } 
    
    /// <summary>
    /// Date/time on until which tax breakdown instructions will be accepted.
    /// </summary>
    [IsoId("_SFR2fd24Ed-KAqAOGQOnnw")]
    [DisplayName("Deadline For Tax Breakdown Instruction")]
    [IsoXmlTag("DdlnForTaxBrkdwnInstr")]
    public DateFormat19Choice_? DeadlineForTaxBreakdownInstruction { get; init; } 
    
    /// <summary>
    /// Date/time at which trading of a security is suspended as the result of an event.
    /// </summary>
    [IsoId("_SFR2f924Ed-KAqAOGQOnnw")]
    [DisplayName("Trading Suspended Date")]
    [IsoXmlTag("TradgSspdDt")]
    public DateFormat19Choice_? TradingSuspendedDate { get; init; } 
    
    /// <summary>
    /// Date/time upon which the terms of the take-over become unconditional as to acceptances.
    /// </summary>
    [IsoId("_SFR2gd24Ed-KAqAOGQOnnw")]
    [DisplayName("Unconditional Date")]
    [IsoXmlTag("UcondlDt")]
    public DateFormat19Choice_? UnconditionalDate { get; init; } 
    
    /// <summary>
    /// Date/time at on which all conditions, including regulatory, legal etc. pertaining to the take-over, have been met.
    /// </summary>
    [IsoId("_SFR2g924Ed-KAqAOGQOnnw")]
    [DisplayName("Wholly Unconditional Date")]
    [IsoXmlTag("WhlyUcondlDt")]
    public DateFormat19Choice_? WhollyUnconditionalDate { get; init; } 
    
    /// <summary>
    /// Date/time as from which trading (including exchange and OTC trading) occurs on the underlying security without the benefit.
    /// </summary>
    [IsoId("_SFR2hd24Ed-KAqAOGQOnnw")]
    [DisplayName("Ex Dividend Date")]
    [IsoXmlTag("ExDvddDt")]
    public DateFormat19Choice_? ExDividendDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the corporate action is legally announced by an official body, for example, publication by a governmental administration.
    /// </summary>
    [IsoId("_SFR2h924Ed-KAqAOGQOnnw")]
    [DisplayName("Official Announcement Publication Date")]
    [IsoXmlTag("OffclAnncmntPblctnDt")]
    public DateFormat19Choice_? OfficialAnnouncementPublicationDate { get; init; } 
    
    /// <summary>
    /// Date/time as from which &apos;special processing&apos; can start to be used by participants for that event. Special processing is a means of marking a transaction, that would normally be traded ex or cum, as being traded cum or ex respectively, for example, a transaction dealt &apos;special&apos; after the ex date would result in the buyer being eligible for the entitlement. This is typically used in the UK and Irish markets.
    /// </summary>
    [IsoId("_SFR2id24Ed-KAqAOGQOnnw")]
    [DisplayName("Special Ex Date")]
    [IsoXmlTag("SpclExDt")]
    public DateFormat19Choice_? SpecialExDate { get; init; } 
    
    /// <summary>
    /// Last date/time by which a buying counterparty to a trade can be sure that it will have the right to participate in an event.
    /// </summary>
    [IsoId("_SFR2i924Ed-KAqAOGQOnnw")]
    [DisplayName("Guaranteed Participation Date")]
    [IsoXmlTag("GrntedPrtcptnDt")]
    public DateFormat19Choice_? GuaranteedParticipationDate { get; init; } 
    
    /// <summary>
    /// Deadline by which an entitled holder needs to advise their counterparty to a transaction of their election for a corporate action event.
    /// </summary>
    [IsoId("_SFR2jd24Ed-KAqAOGQOnnw")]
    [DisplayName("Election To Counterparty Deadline")]
    [IsoXmlTag("ElctnToCtrPtyDdln")]
    public DateFormat19Choice_? ElectionToCounterpartyDeadline { get; init; } 
    
    /// <summary>
    /// Date/time at which an event/offer is terminated or lapsed.
    /// </summary>
    [IsoId("_SFR2j924Ed-KAqAOGQOnnw")]
    [DisplayName("Lapsed Date")]
    [IsoXmlTag("LpsdDt")]
    public DateFormat19Choice_? LapsedDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_SFR2kd24Ed-KAqAOGQOnnw")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateFormat19Choice_? PaymentDate { get; init; } 
    
    /// <summary>
    /// Date/Time by which the account owner must instruct directly another party, for example to provide documentation to an issuer agent.
    /// </summary>
    [IsoId("_SFR2k924Ed-KAqAOGQOnnw")]
    [DisplayName("Third Party Deadline")]
    [IsoXmlTag("ThrdPtyDdln")]
    public DateFormat19Choice_? ThirdPartyDeadline { get; init; } 
    
    /// <summary>
    /// Date/Time set by the issuer agent as a first early deadline by which the account owner must instruct directly another party, possibly giving the holder eligibility to incentives. For example, to provide documentation to an issuer agent.
    /// </summary>
    [IsoId("_SFR2ld24Ed-KAqAOGQOnnw")]
    [DisplayName("Early Third Party Deadline")]
    [IsoXmlTag("EarlyThrdPtyDdln")]
    public DateFormat19Choice_? EarlyThirdPartyDeadline { get; init; } 
    
    /// <summary>
    /// Date by which the depository stops monitoring activities of the event, for instance, accounting and tracking activities for due bills end.
    /// </summary>
    [IsoId("_SFR2l924Ed-KAqAOGQOnnw")]
    [DisplayName("Market Claim Tracking End Date")]
    [IsoXmlTag("MktClmTrckgEndDt")]
    public DateFormat19Choice_? MarketClaimTrackingEndDate { get; init; } 
    
    /// <summary>
    /// Last day an investor can become a lead plaintiff.
    /// </summary>
    [IsoId("_khITke5lEd-w9cnVeeY-JA")]
    [DisplayName("Lead Plaintiff Deadline")]
    [IsoXmlTag("LeadPlntffDdln")]
    public DateFormat19Choice_? LeadPlaintiffDeadline { get; init; } 
    
    
    #nullable disable
    
}
