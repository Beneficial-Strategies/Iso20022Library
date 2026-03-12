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
[IsoId("_YXWgaV99Ee262vCSVgjImg")]
[DisplayName("Corporate Action Date")]
public partial record CorporateActionDate96
{
    #nullable enable
    
    /// <summary>
    /// Date/time at which the issuer announced that a corporate action event will occur.
    /// </summary>
    [IsoId("_YXWgb199Ee262vCSVgjImg")]
    [DisplayName("Announcement Date")]
    [IsoXmlTag("AnncmntDt")]
    public DateFormat49Choice_? AnnouncementDate { get; init; } 
    
    /// <summary>
    /// Deadline by which the certification must be sent.
    /// </summary>
    [IsoId("_YXWgd199Ee262vCSVgjImg")]
    [DisplayName("Certification Deadline")]
    [IsoXmlTag("CertfctnDdln")]
    public DateFormat49Choice_? CertificationDeadline { get; init; } 
    
    /// <summary>
    /// Date upon which the court provided approval.
    /// </summary>
    [IsoId("_YXWgf199Ee262vCSVgjImg")]
    [DisplayName("Court Approval Date")]
    [IsoXmlTag("CrtApprvlDt")]
    public DateFormat41Choice_? CourtApprovalDate { get; init; } 
    
    /// <summary>
    /// First possible early closing date of an offer if different from the expiry date.
    /// </summary>
    [IsoId("_YXWgh199Ee262vCSVgjImg")]
    [DisplayName("Early Closing Date")]
    [IsoXmlTag("EarlyClsgDt")]
    public DateFormat49Choice_? EarlyClosingDate { get; init; } 
    
    /// <summary>
    /// Date/time at which an event is officially effective from the issuer&apos;s perspective.
    /// </summary>
    [IsoId("_YXWgj199Ee262vCSVgjImg")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public DateFormat41Choice_? EffectiveDate { get; init; } 
    
    /// <summary>
    /// Date/time on which all or part of any holding bought in a unit trust is subject to being treated as capital rather than income. This is normally one day after the previous distribution&apos;s ex date.
    /// </summary>
    [IsoId("_YXWgl199Ee262vCSVgjImg")]
    [DisplayName("Equalisation Date")]
    [IsoXmlTag("EqulstnDt")]
    public DateFormat41Choice_? EqualisationDate { get; init; } 
    
    /// <summary>
    /// Date/time at which additional information on the event will be announced, for example, exchange ratio announcement date.
    /// </summary>
    [IsoId("_YXWgn199Ee262vCSVgjImg")]
    [DisplayName("Further Detailed Announcement Date")]
    [IsoXmlTag("FrthrDtldAnncmntDt")]
    public DateFormat49Choice_? FurtherDetailedAnnouncementDate { get; init; } 
    
    /// <summary>
    /// Date/time at which an index / rate / price / value will be determined.
    /// </summary>
    [IsoId("_YXWgp199Ee262vCSVgjImg")]
    [DisplayName("Fixing Date")]
    [IsoXmlTag("FxgDt")]
    public DateFormat49Choice_? FixingDate { get; init; } 
    
    /// <summary>
    /// Date/time on which the lottery is run and applied to the holder&apos;s positions. This is also applicable to partial calls.
    /// </summary>
    [IsoId("_YXWgr199Ee262vCSVgjImg")]
    [DisplayName("Lottery Date")]
    [IsoXmlTag("LtryDt")]
    public DateFormat41Choice_? LotteryDate { get; init; } 
    
    /// <summary>
    /// Date/time to which the maturity date of an interest bearing security is extended.
    /// </summary>
    [IsoId("_YXWgt199Ee262vCSVgjImg")]
    [DisplayName("New Maturity Date")]
    [IsoXmlTag("NewMtrtyDt")]
    public DateFormat41Choice_? NewMaturityDate { get; init; } 
    
    /// <summary>
    /// Date/time on which the bondholder&apos;s or shareholder&apos;s meeting will take place.
    /// </summary>
    [IsoId("_YXWguV99Ee262vCSVgjImg")]
    [DisplayName("Meeting Date")]
    [IsoXmlTag("MtgDt")]
    public DateFormat49Choice_? MeetingDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the margin rate will be determined.
    /// </summary>
    [IsoId("_YXWgwV99Ee262vCSVgjImg")]
    [DisplayName("Margin Fixing Date")]
    [IsoXmlTag("MrgnFxgDt")]
    public DateFormat41Choice_? MarginFixingDate { get; init; } 
    
    /// <summary>
    /// Date/time (and time) at which an issuer will determine the proration amount/quantity of an offer.
    /// </summary>
    [IsoId("_YXWgyV99Ee262vCSVgjImg")]
    [DisplayName("Proration Date")]
    [IsoXmlTag("PrratnDt")]
    public DateFormat41Choice_? ProrationDate { get; init; } 
    
    /// <summary>
    /// Date/time at which positions are struck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date.
    /// </summary>
    [IsoId("_YXWg0V99Ee262vCSVgjImg")]
    [DisplayName("Record Date")]
    [IsoXmlTag("RcrdDt")]
    public DateFormat41Choice_? RecordDate { get; init; } 
    
    /// <summary>
    /// Date/time on which instructions to register or registration details will be accepted.
    /// </summary>
    [IsoId("_YXWg2V99Ee262vCSVgjImg")]
    [DisplayName("Registration Deadline")]
    [IsoXmlTag("RegnDdln")]
    public DateFormat49Choice_? RegistrationDeadline { get; init; } 
    
    /// <summary>
    /// Date/time on which results are published, for example, results of an offer.
    /// </summary>
    [IsoId("_YXWg4V99Ee262vCSVgjImg")]
    [DisplayName("Results Publication Date")]
    [IsoXmlTag("RsltsPblctnDt")]
    public DateFormat49Choice_? ResultsPublicationDate { get; init; } 
    
    /// <summary>
    /// Deadline by which instructions must be received to split securities, for example, of physical certificates.
    /// </summary>
    [IsoId("_YXWg6V99Ee262vCSVgjImg")]
    [DisplayName("Deadline To Split")]
    [IsoXmlTag("DdlnToSplt")]
    public DateFormat49Choice_? DeadlineToSplit { get; init; } 
    
    /// <summary>
    /// Date/time on until which tax breakdown instructions will be accepted.
    /// </summary>
    [IsoId("_YXWg8V99Ee262vCSVgjImg")]
    [DisplayName("Deadline For Tax Breakdown Instruction")]
    [IsoXmlTag("DdlnForTaxBrkdwnInstr")]
    public DateFormat49Choice_? DeadlineForTaxBreakdownInstruction { get; init; } 
    
    /// <summary>
    /// Date/time at which trading of a security is suspended as the result of an event.
    /// </summary>
    [IsoId("_YXWg-V99Ee262vCSVgjImg")]
    [DisplayName("Trading Suspended Date")]
    [IsoXmlTag("TradgSspdDt")]
    public DateFormat49Choice_? TradingSuspendedDate { get; init; } 
    
    /// <summary>
    /// Date/time upon which the terms of the take-over become unconditional as to acceptances.
    /// </summary>
    [IsoId("_YXWhAV99Ee262vCSVgjImg")]
    [DisplayName("Unconditional Date")]
    [IsoXmlTag("UcondlDt")]
    public DateFormat41Choice_? UnconditionalDate { get; init; } 
    
    /// <summary>
    /// Date/time at on which all conditions, including regulatory, legal etc. pertaining to the take-over, have been met.
    /// </summary>
    [IsoId("_YXWhCV99Ee262vCSVgjImg")]
    [DisplayName("Wholly Unconditional Date")]
    [IsoXmlTag("WhlyUcondlDt")]
    public DateFormat41Choice_? WhollyUnconditionalDate { get; init; } 
    
    /// <summary>
    /// Date/time as from which trading (including exchange and OTC trading) occurs on the underlying security without the benefit.
    /// </summary>
    [IsoId("_YXWhEV99Ee262vCSVgjImg")]
    [DisplayName("Ex Dividend Date")]
    [IsoXmlTag("ExDvddDt")]
    public DateFormat41Choice_? ExDividendDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the corporate action is legally announced by an official body, for example, publication by a governmental administration.
    /// </summary>
    [IsoId("_YXWhGV99Ee262vCSVgjImg")]
    [DisplayName("Official Announcement Publication Date")]
    [IsoXmlTag("OffclAnncmntPblctnDt")]
    public DateFormat49Choice_? OfficialAnnouncementPublicationDate { get; init; } 
    
    /// <summary>
    /// Date/time from which &apos;special processing&apos; can start to be used by participants for that event. Special processing is a means of marking a transaction, that would normally be traded ex or cum, as being traded cum or ex respectively, for example, a transaction dealt &apos;special&apos; after the ex date would result in the buyer being eligible for the entitlement. This is typically used in the UK and Irish markets.
    /// </summary>
    [IsoId("_YXWhIV99Ee262vCSVgjImg")]
    [DisplayName("Special Ex Date")]
    [IsoXmlTag("SpclExDt")]
    public DateFormat41Choice_? SpecialExDate { get; init; } 
    
    /// <summary>
    /// Last date/time by which a buying counterparty to a trade can be sure that it will have the right to participate in an event.
    /// </summary>
    [IsoId("_YXWhKV99Ee262vCSVgjImg")]
    [DisplayName("Guaranteed Participation Date")]
    [IsoXmlTag("GrntedPrtcptnDt")]
    public DateFormat41Choice_? GuaranteedParticipationDate { get; init; } 
    
    /// <summary>
    /// Deadline by which an entitled holder needs to advise their counterparty to a transaction of their election for a corporate action event, also known as Buyer Protection Deadline.
    /// </summary>
    [IsoId("_YXWhMV99Ee262vCSVgjImg")]
    [DisplayName("Election To Counterparty Market Deadline")]
    [IsoXmlTag("ElctnToCtrPtyMktDdln")]
    public DateFormat49Choice_? ElectionToCounterpartyMarketDeadline { get; init; } 
    
    /// <summary>
    /// Date/time the account servicer has set as the deadline to respond, with instructions, prior to the election to counterparty market deadline.
    /// </summary>
    [IsoId("_YXWhOV99Ee262vCSVgjImg")]
    [DisplayName("Election To Counterparty Response Deadline")]
    [IsoXmlTag("ElctnToCtrPtyRspnDdln")]
    public DateFormat49Choice_? ElectionToCounterpartyResponseDeadline { get; init; } 
    
    /// <summary>
    /// Date/time at which an event/offer is terminated or lapsed.
    /// </summary>
    [IsoId("_YXWhO199Ee262vCSVgjImg")]
    [DisplayName("Lapsed Date")]
    [IsoXmlTag("LpsdDt")]
    public DateFormat41Choice_? LapsedDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_YXWhQ199Ee262vCSVgjImg")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateFormat41Choice_? PaymentDate { get; init; } 
    
    /// <summary>
    /// Date/time by which the account owner must instruct directly another party, for example, to provide documentation to an issuer agent.
    /// </summary>
    [IsoId("_YXWhS199Ee262vCSVgjImg")]
    [DisplayName("Third Party Deadline")]
    [IsoXmlTag("ThrdPtyDdln")]
    public DateFormat49Choice_? ThirdPartyDeadline { get; init; } 
    
    /// <summary>
    /// Date/Time set by the issuer agent as a first early deadline by which the account owner must instruct directly another party, possibly giving the holder eligibility to incentives. For example, to provide documentation to an issuer agent.
    /// </summary>
    [IsoId("_YXWhU199Ee262vCSVgjImg")]
    [DisplayName("Early Third Party Deadline")]
    [IsoXmlTag("EarlyThrdPtyDdln")]
    public DateFormat49Choice_? EarlyThirdPartyDeadline { get; init; } 
    
    /// <summary>
    /// Date by which the depository stops monitoring activities of the event, for instance, accounting and tracking activities for due bills end.
    /// </summary>
    [IsoId("_YXWhW199Ee262vCSVgjImg")]
    [DisplayName("Market Claim Tracking End Date")]
    [IsoXmlTag("MktClmTrckgEndDt")]
    public DateFormat41Choice_? MarketClaimTrackingEndDate { get; init; } 
    
    /// <summary>
    /// Last day an investor can become a lead plaintiff.
    /// </summary>
    [IsoId("_YXWhY199Ee262vCSVgjImg")]
    [DisplayName("Lead Plaintiff Deadline")]
    [IsoXmlTag("LeadPlntffDdln")]
    public DateFormat49Choice_? LeadPlaintiffDeadline { get; init; } 
    
    /// <summary>
    /// Date on which the action was filed at the applicable court.
    /// </summary>
    [IsoId("_YXWhZV99Ee262vCSVgjImg")]
    [DisplayName("Filing Date")]
    [IsoXmlTag("FilgDt")]
    public DateFormat41Choice_? FilingDate { get; init; } 
    
    /// <summary>
    /// Date for the hearing between the plaintiff and defendant, as set by the court.
    /// </summary>
    [IsoId("_YXWhZ199Ee262vCSVgjImg")]
    [DisplayName("Hearing Date")]
    [IsoXmlTag("HrgDt")]
    public DateFormat41Choice_? HearingDate { get; init; } 
    
    
    #nullable disable
    
}
