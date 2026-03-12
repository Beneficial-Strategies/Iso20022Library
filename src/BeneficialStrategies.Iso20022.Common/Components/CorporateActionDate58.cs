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
[IsoId("_c5MxD5KQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Date")]
public partial record CorporateActionDate58
{
    #nullable enable
    
    /// <summary>
    /// Date/time at which the issuer announced that a corporate action event will occur.
    /// </summary>
    [IsoId("_c5MxE5KQEeWHWpTQn1FFVg")]
    [DisplayName("Announcement Date")]
    [IsoXmlTag("AnncmntDt")]
    public DateFormat34Choice_? AnnouncementDate { get; init; } 
    
    /// <summary>
    /// Deadline by which the beneficial ownership of securities must be declared.
    /// </summary>
    [IsoId("_c5MxG5KQEeWHWpTQn1FFVg")]
    [DisplayName("Certification Deadline")]
    [IsoXmlTag("CertfctnDdln")]
    public DateFormat34Choice_? CertificationDeadline { get; init; } 
    
    /// <summary>
    /// Date upon which the court provided approval.
    /// </summary>
    [IsoId("_c5MxI5KQEeWHWpTQn1FFVg")]
    [DisplayName("Court Approval Date")]
    [IsoXmlTag("CrtApprvlDt")]
    public DateFormat34Choice_? CourtApprovalDate { get; init; } 
    
    /// <summary>
    /// First possible early closing date of an offer if different from the expiry date.
    /// </summary>
    [IsoId("_c5MxK5KQEeWHWpTQn1FFVg")]
    [DisplayName("Early Closing Date")]
    [IsoXmlTag("EarlyClsgDt")]
    public DateFormat34Choice_? EarlyClosingDate { get; init; } 
    
    /// <summary>
    /// Date/time at which an event is officially effective from the issuer&apos;s perspective.
    /// </summary>
    [IsoId("_c5MxM5KQEeWHWpTQn1FFVg")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public DateFormat34Choice_? EffectiveDate { get; init; } 
    
    /// <summary>
    /// Date/Time on which all or part of any holding bought in a unit trust is subject to being treated as capital rather than income. This is normally one day after the previous distribution&apos;s ex date.
    /// </summary>
    [IsoId("_c5MxO5KQEeWHWpTQn1FFVg")]
    [DisplayName("Equalisation Date")]
    [IsoXmlTag("EqulstnDt")]
    public DateFormat34Choice_? EqualisationDate { get; init; } 
    
    /// <summary>
    /// Date/time at which additional information on the event will be announced, for example, exchange ratio announcement date.
    /// </summary>
    [IsoId("_c5MxQ5KQEeWHWpTQn1FFVg")]
    [DisplayName("Further Detailed Announcement Date")]
    [IsoXmlTag("FrthrDtldAnncmntDt")]
    public DateFormat34Choice_? FurtherDetailedAnnouncementDate { get; init; } 
    
    /// <summary>
    /// Date/time at which an index / rate / price / value will be determined.
    /// </summary>
    [IsoId("_c5MxS5KQEeWHWpTQn1FFVg")]
    [DisplayName("Fixing Date")]
    [IsoXmlTag("FxgDt")]
    public DateFormat34Choice_? FixingDate { get; init; } 
    
    /// <summary>
    /// Date/time on which the lottery is run and applied to the holder&apos;s positions. This is also applicable to partial calls.
    /// </summary>
    [IsoId("_c5MxU5KQEeWHWpTQn1FFVg")]
    [DisplayName("Lottery Date")]
    [IsoXmlTag("LtryDt")]
    public DateFormat34Choice_? LotteryDate { get; init; } 
    
    /// <summary>
    /// Date/time to which the maturity date of an interest bearing security is extended.
    /// </summary>
    [IsoId("_c5MxW5KQEeWHWpTQn1FFVg")]
    [DisplayName("New Maturity Date")]
    [IsoXmlTag("NewMtrtyDt")]
    public DateFormat34Choice_? NewMaturityDate { get; init; } 
    
    /// <summary>
    /// Date/time on which the bondholder&apos;s or shareholder&apos;s meeting will take place.
    /// </summary>
    [IsoId("_c5MxXZKQEeWHWpTQn1FFVg")]
    [DisplayName("Meeting Date")]
    [IsoXmlTag("MtgDt")]
    public DateFormat34Choice_? MeetingDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the margin rate will be determined.
    /// </summary>
    [IsoId("_c5MxZZKQEeWHWpTQn1FFVg")]
    [DisplayName("Margin Fixing Date")]
    [IsoXmlTag("MrgnFxgDt")]
    public DateFormat34Choice_? MarginFixingDate { get; init; } 
    
    /// <summary>
    /// Date/time (and time) at which an issuer will determine the proration amount/quantity of an offer.
    /// </summary>
    [IsoId("_c5MxbZKQEeWHWpTQn1FFVg")]
    [DisplayName("Proration Date")]
    [IsoXmlTag("PrratnDt")]
    public DateFormat34Choice_? ProrationDate { get; init; } 
    
    /// <summary>
    /// Date/time at which positions are struck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date.
    /// </summary>
    [IsoId("_c5MxdZKQEeWHWpTQn1FFVg")]
    [DisplayName("Record Date")]
    [IsoXmlTag("RcrdDt")]
    public DateFormat34Choice_? RecordDate { get; init; } 
    
    /// <summary>
    /// Date/time on which instructions to register or registration details will be accepted.
    /// </summary>
    [IsoId("_c5MxfZKQEeWHWpTQn1FFVg")]
    [DisplayName("Registration Deadline")]
    [IsoXmlTag("RegnDdln")]
    public DateFormat34Choice_? RegistrationDeadline { get; init; } 
    
    /// <summary>
    /// Date/time on which results are published, for example, results of an offer.
    /// </summary>
    [IsoId("_c5MxhZKQEeWHWpTQn1FFVg")]
    [DisplayName("Results Publication Date")]
    [IsoXmlTag("RsltsPblctnDt")]
    public DateFormat34Choice_? ResultsPublicationDate { get; init; } 
    
    /// <summary>
    /// Deadline by which instructions must be received to split securities, for example, of physical certificates.
    /// </summary>
    [IsoId("_c5MxjZKQEeWHWpTQn1FFVg")]
    [DisplayName("Deadline To Split")]
    [IsoXmlTag("DdlnToSplt")]
    public DateFormat34Choice_? DeadlineToSplit { get; init; } 
    
    /// <summary>
    /// Date/time on until which tax breakdown instructions will be accepted.
    /// </summary>
    [IsoId("_c5MxlZKQEeWHWpTQn1FFVg")]
    [DisplayName("Deadline For Tax Breakdown Instruction")]
    [IsoXmlTag("DdlnForTaxBrkdwnInstr")]
    public DateFormat34Choice_? DeadlineForTaxBreakdownInstruction { get; init; } 
    
    /// <summary>
    /// Date/time at which trading of a security is suspended as the result of an event.
    /// </summary>
    [IsoId("_c5MxnZKQEeWHWpTQn1FFVg")]
    [DisplayName("Trading Suspended Date")]
    [IsoXmlTag("TradgSspdDt")]
    public DateFormat34Choice_? TradingSuspendedDate { get; init; } 
    
    /// <summary>
    /// Date/time upon which the terms of the take-over become unconditional as to acceptances.
    /// </summary>
    [IsoId("_c5MxpZKQEeWHWpTQn1FFVg")]
    [DisplayName("Unconditional Date")]
    [IsoXmlTag("UcondlDt")]
    public DateFormat34Choice_? UnconditionalDate { get; init; } 
    
    /// <summary>
    /// Date/time at on which all conditions, including regulatory, legal etc. pertaining to the take-over, have been met.
    /// </summary>
    [IsoId("_c5MxrZKQEeWHWpTQn1FFVg")]
    [DisplayName("Wholly Unconditional Date")]
    [IsoXmlTag("WhlyUcondlDt")]
    public DateFormat34Choice_? WhollyUnconditionalDate { get; init; } 
    
    /// <summary>
    /// Date/time as from which trading (including exchange and OTC trading) occurs on the underlying security without the benefit.
    /// </summary>
    [IsoId("_c5MxtZKQEeWHWpTQn1FFVg")]
    [DisplayName("Ex Dividend Date")]
    [IsoXmlTag("ExDvddDt")]
    public DateFormat34Choice_? ExDividendDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the corporate action is legally announced by an official body, for example, publication by a governmental administration.
    /// </summary>
    [IsoId("_c5MxvZKQEeWHWpTQn1FFVg")]
    [DisplayName("Official Announcement Publication Date")]
    [IsoXmlTag("OffclAnncmntPblctnDt")]
    public DateFormat34Choice_? OfficialAnnouncementPublicationDate { get; init; } 
    
    /// <summary>
    /// Date/time as from which &apos;special processing&apos; can start to be used by participants for that event. Special processing is a means of marking a transaction, that would normally be traded ex or cum, as being traded cum or ex respectively, for example, a transaction dealt &apos;special&apos; after the ex date would result in the buyer being eligible for the entitlement. This is typically used in the UK and Irish markets.
    /// </summary>
    [IsoId("_c5MxxZKQEeWHWpTQn1FFVg")]
    [DisplayName("Special Ex Date")]
    [IsoXmlTag("SpclExDt")]
    public DateFormat34Choice_? SpecialExDate { get; init; } 
    
    /// <summary>
    /// Last date/time by which a buying counterparty to a trade can be sure that it will have the right to participate in an event.
    /// </summary>
    [IsoId("_c5MxzZKQEeWHWpTQn1FFVg")]
    [DisplayName("Guaranteed Participation Date")]
    [IsoXmlTag("GrntedPrtcptnDt")]
    public DateFormat34Choice_? GuaranteedParticipationDate { get; init; } 
    
    /// <summary>
    /// Deadline by which an entitled holder needs to advise their counterparty to a transaction of their election for a corporate action event, also known as Buyer Protection Deadline.
    /// </summary>
    [IsoId("_c5Mx1ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Election To Counterparty Market Deadline")]
    [IsoXmlTag("ElctnToCtrPtyMktDdln")]
    public DateFormat34Choice_? ElectionToCounterpartyMarketDeadline { get; init; } 
    
    /// <summary>
    /// Date/time the account servicer has set as the deadline to respond, with instructions, prior to the election to counterparty market deadline.
    /// </summary>
    [IsoId("_c5Mx3ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Election To Counterparty Response Deadline")]
    [IsoXmlTag("ElctnToCtrPtyRspnDdln")]
    public DateFormat34Choice_? ElectionToCounterpartyResponseDeadline { get; init; } 
    
    /// <summary>
    /// Date/time at which an event/offer is terminated or lapsed.
    /// </summary>
    [IsoId("_c5Mx35KQEeWHWpTQn1FFVg")]
    [DisplayName("Lapsed Date")]
    [IsoXmlTag("LpsdDt")]
    public DateFormat34Choice_? LapsedDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_c5NXEZKQEeWHWpTQn1FFVg")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateFormat34Choice_? PaymentDate { get; init; } 
    
    /// <summary>
    /// Date/Time by which the account owner must instruct directly another party, for example to provide documentation to an issuer agent.
    /// </summary>
    [IsoId("_c5NXGZKQEeWHWpTQn1FFVg")]
    [DisplayName("Third Party Deadline")]
    [IsoXmlTag("ThrdPtyDdln")]
    public DateFormat34Choice_? ThirdPartyDeadline { get; init; } 
    
    /// <summary>
    /// Date/Time set by the issuer agent as a first early deadline by which the account owner must instruct directly another party, possibly giving the holder eligibility to incentives. For example, to provide documentation to an issuer agent.
    /// </summary>
    [IsoId("_c5NXIZKQEeWHWpTQn1FFVg")]
    [DisplayName("Early Third Party Deadline")]
    [IsoXmlTag("EarlyThrdPtyDdln")]
    public DateFormat34Choice_? EarlyThirdPartyDeadline { get; init; } 
    
    /// <summary>
    /// Date by which the depository stops monitoring activities of the event, for instance, accounting and tracking activities for due bills end.
    /// </summary>
    [IsoId("_c5NXKZKQEeWHWpTQn1FFVg")]
    [DisplayName("Market Claim Tracking End Date")]
    [IsoXmlTag("MktClmTrckgEndDt")]
    public DateFormat34Choice_? MarketClaimTrackingEndDate { get; init; } 
    
    /// <summary>
    /// Last day an investor can become a lead plaintiff.
    /// </summary>
    [IsoId("_c5NXMZKQEeWHWpTQn1FFVg")]
    [DisplayName("Lead Plaintiff Deadline")]
    [IsoXmlTag("LeadPlntffDdln")]
    public DateFormat34Choice_? LeadPlaintiffDeadline { get; init; } 
    
    /// <summary>
    /// Date on which the action was filed at the applicable court.
    /// </summary>
    [IsoId("_c5NXM5KQEeWHWpTQn1FFVg")]
    [DisplayName("Filing Date")]
    [IsoXmlTag("FilgDt")]
    public DateFormat41Choice_? FilingDate { get; init; } 
    
    /// <summary>
    /// Date for the hearing between the plaintiff and defendant, as set by the court.
    /// </summary>
    [IsoId("_c5NXNZKQEeWHWpTQn1FFVg")]
    [DisplayName("Hearing Date")]
    [IsoXmlTag("HrgDt")]
    public DateFormat41Choice_? HearingDate { get; init; } 
    
    
    #nullable disable
    
}
