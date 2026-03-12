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
[IsoId("_YPvBk0ECEeWVgfuHGaKtRQ")]
[DisplayName("Corporate Action Date")]
public partial record CorporateActionDate44
{
    #nullable enable
    
    /// <summary>
    /// Date/time at which the issuer announced that a corporate action event will occur.
    /// </summary>
    [IsoId("_Yb7qdUECEeWVgfuHGaKtRQ")]
    [DisplayName("Announcement Date")]
    [IsoXmlTag("AnncmntDt")]
    public DateFormat31Choice_? AnnouncementDate { get; init; } 
    
    /// <summary>
    /// Deadline by which the beneficial ownership of securities must be declared.
    /// </summary>
    [IsoId("_Yb7qfUECEeWVgfuHGaKtRQ")]
    [DisplayName("Certification Deadline")]
    [IsoXmlTag("CertfctnDdln")]
    public DateFormat31Choice_? CertificationDeadline { get; init; } 
    
    /// <summary>
    /// Date upon which the court provided approval.
    /// </summary>
    [IsoId("_Yb7qhUECEeWVgfuHGaKtRQ")]
    [DisplayName("Court Approval Date")]
    [IsoXmlTag("CrtApprvlDt")]
    public DateFormat31Choice_? CourtApprovalDate { get; init; } 
    
    /// <summary>
    /// First possible early closing date of an offer if different from the expiry date.
    /// </summary>
    [IsoId("_Yb7qjUECEeWVgfuHGaKtRQ")]
    [DisplayName("Early Closing Date")]
    [IsoXmlTag("EarlyClsgDt")]
    public DateFormat31Choice_? EarlyClosingDate { get; init; } 
    
    /// <summary>
    /// Date/time at which an event is officially effective from the issuer&apos;s perspective.
    /// </summary>
    [IsoId("_Yb7qlUECEeWVgfuHGaKtRQ")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public DateFormat31Choice_? EffectiveDate { get; init; } 
    
    /// <summary>
    /// Date/Time on which all or part of any holding bought in a unit trust is subject to being treated as capital rather than income. This is normally one day after the previous distribution&apos;s ex date.
    /// </summary>
    [IsoId("_Yb7qnUECEeWVgfuHGaKtRQ")]
    [DisplayName("Equalisation Date")]
    [IsoXmlTag("EqulstnDt")]
    public DateFormat31Choice_? EqualisationDate { get; init; } 
    
    /// <summary>
    /// Date/time at which additional information on the event will be announced, for example, exchange ratio announcement date.
    /// </summary>
    [IsoId("_Yb7qpUECEeWVgfuHGaKtRQ")]
    [DisplayName("Further Detailed Announcement Date")]
    [IsoXmlTag("FrthrDtldAnncmntDt")]
    public DateFormat31Choice_? FurtherDetailedAnnouncementDate { get; init; } 
    
    /// <summary>
    /// Date/time at which an index / rate / price / value will be determined.
    /// </summary>
    [IsoId("_Yb7qrUECEeWVgfuHGaKtRQ")]
    [DisplayName("Fixing Date")]
    [IsoXmlTag("FxgDt")]
    public DateFormat31Choice_? FixingDate { get; init; } 
    
    /// <summary>
    /// Date/time on which the lottery is run and applied to the holder&apos;s positions. This is also applicable to partial calls.
    /// </summary>
    [IsoId("_Yb7qtUECEeWVgfuHGaKtRQ")]
    [DisplayName("Lottery Date")]
    [IsoXmlTag("LtryDt")]
    public DateFormat31Choice_? LotteryDate { get; init; } 
    
    /// <summary>
    /// Date/time to which the maturity date of an interest bearing security is extended.
    /// </summary>
    [IsoId("_Yb7qvUECEeWVgfuHGaKtRQ")]
    [DisplayName("New Maturity Date")]
    [IsoXmlTag("NewMtrtyDt")]
    public DateFormat31Choice_? NewMaturityDate { get; init; } 
    
    /// <summary>
    /// Date/time on which the bondholder&apos;s or shareholder&apos;s meeting will take place.
    /// </summary>
    [IsoId("_Yb7qv0ECEeWVgfuHGaKtRQ")]
    [DisplayName("Meeting Date")]
    [IsoXmlTag("MtgDt")]
    public DateFormat31Choice_? MeetingDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the margin rate will be determined.
    /// </summary>
    [IsoId("_Yb7qx0ECEeWVgfuHGaKtRQ")]
    [DisplayName("Margin Fixing Date")]
    [IsoXmlTag("MrgnFxgDt")]
    public DateFormat31Choice_? MarginFixingDate { get; init; } 
    
    /// <summary>
    /// Date/time (and time) at which an issuer will determine the proration amount/quantity of an offer.
    /// </summary>
    [IsoId("_Yb7qz0ECEeWVgfuHGaKtRQ")]
    [DisplayName("Proration Date")]
    [IsoXmlTag("PrratnDt")]
    public DateFormat31Choice_? ProrationDate { get; init; } 
    
    /// <summary>
    /// Date/time at which positions are struck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date.
    /// </summary>
    [IsoId("_Yb7q10ECEeWVgfuHGaKtRQ")]
    [DisplayName("Record Date")]
    [IsoXmlTag("RcrdDt")]
    public DateFormat31Choice_? RecordDate { get; init; } 
    
    /// <summary>
    /// Date/time on which instructions to register or registration details will be accepted.
    /// </summary>
    [IsoId("_Yb7q30ECEeWVgfuHGaKtRQ")]
    [DisplayName("Registration Deadline")]
    [IsoXmlTag("RegnDdln")]
    public DateFormat31Choice_? RegistrationDeadline { get; init; } 
    
    /// <summary>
    /// Date/time on which results are published, for example, results of an offer.
    /// </summary>
    [IsoId("_Yb7q50ECEeWVgfuHGaKtRQ")]
    [DisplayName("Results Publication Date")]
    [IsoXmlTag("RsltsPblctnDt")]
    public DateFormat31Choice_? ResultsPublicationDate { get; init; } 
    
    /// <summary>
    /// Deadline by which instructions must be received to split securities, for example, of physical certificates.
    /// </summary>
    [IsoId("_Yb7q70ECEeWVgfuHGaKtRQ")]
    [DisplayName("Deadline To Split")]
    [IsoXmlTag("DdlnToSplt")]
    public DateFormat31Choice_? DeadlineToSplit { get; init; } 
    
    /// <summary>
    /// Date/time on until which tax breakdown instructions will be accepted.
    /// </summary>
    [IsoId("_Yb7q90ECEeWVgfuHGaKtRQ")]
    [DisplayName("Deadline For Tax Breakdown Instruction")]
    [IsoXmlTag("DdlnForTaxBrkdwnInstr")]
    public DateFormat31Choice_? DeadlineForTaxBreakdownInstruction { get; init; } 
    
    /// <summary>
    /// Date/time at which trading of a security is suspended as the result of an event.
    /// </summary>
    [IsoId("_Yb7q_0ECEeWVgfuHGaKtRQ")]
    [DisplayName("Trading Suspended Date")]
    [IsoXmlTag("TradgSspdDt")]
    public DateFormat31Choice_? TradingSuspendedDate { get; init; } 
    
    /// <summary>
    /// Date/time upon which the terms of the take-over become unconditional as to acceptances.
    /// </summary>
    [IsoId("_Yb7rB0ECEeWVgfuHGaKtRQ")]
    [DisplayName("Unconditional Date")]
    [IsoXmlTag("UcondlDt")]
    public DateFormat31Choice_? UnconditionalDate { get; init; } 
    
    /// <summary>
    /// Date/time at on which all conditions, including regulatory, legal etc. pertaining to the take-over, have been met.
    /// </summary>
    [IsoId("_Yb7rD0ECEeWVgfuHGaKtRQ")]
    [DisplayName("Wholly Unconditional Date")]
    [IsoXmlTag("WhlyUcondlDt")]
    public DateFormat31Choice_? WhollyUnconditionalDate { get; init; } 
    
    /// <summary>
    /// Date/time as from which trading (including exchange and OTC trading) occurs on the underlying security without the benefit.
    /// </summary>
    [IsoId("_Yb7rF0ECEeWVgfuHGaKtRQ")]
    [DisplayName("Ex Dividend Date")]
    [IsoXmlTag("ExDvddDt")]
    public DateFormat31Choice_? ExDividendDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the corporate action is legally announced by an official body, for example, publication by a governmental administration.
    /// </summary>
    [IsoId("_Yb7rH0ECEeWVgfuHGaKtRQ")]
    [DisplayName("Official Announcement Publication Date")]
    [IsoXmlTag("OffclAnncmntPblctnDt")]
    public DateFormat31Choice_? OfficialAnnouncementPublicationDate { get; init; } 
    
    /// <summary>
    /// Date/time as from which &apos;special processing&apos; can start to be used by participants for that event. Special processing is a means of marking a transaction, that would normally be traded ex or cum, as being traded cum or ex respectively, for example, a transaction dealt &apos;special&apos; after the ex date would result in the buyer being eligible for the entitlement. This is typically used in the UK and Irish markets.
    /// </summary>
    [IsoId("_Yb7rJ0ECEeWVgfuHGaKtRQ")]
    [DisplayName("Special Ex Date")]
    [IsoXmlTag("SpclExDt")]
    public DateFormat31Choice_? SpecialExDate { get; init; } 
    
    /// <summary>
    /// Last date/time by which a buying counterparty to a trade can be sure that it will have the right to participate in an event.
    /// </summary>
    [IsoId("_Yb7rL0ECEeWVgfuHGaKtRQ")]
    [DisplayName("Guaranteed Participation Date")]
    [IsoXmlTag("GrntedPrtcptnDt")]
    public DateFormat31Choice_? GuaranteedParticipationDate { get; init; } 
    
    /// <summary>
    /// Deadline by which an entitled holder needs to advise their counterparty to a transaction of their election for a corporate action event, also known as Buyer Protection Deadline.
    /// </summary>
    [IsoId("_Yb7rN0ECEeWVgfuHGaKtRQ")]
    [DisplayName("Election To Counterparty Market Deadline")]
    [IsoXmlTag("ElctnToCtrPtyMktDdln")]
    public DateFormat31Choice_? ElectionToCounterpartyMarketDeadline { get; init; } 
    
    /// <summary>
    /// Date/time the account servicer has set as the deadline to respond, with instructions, prior to the election to counterparty market deadline.
    /// </summary>
    [IsoId("_zc9csGLAEeWR9ZSfjmHwUA")]
    [DisplayName("Election To Counterparty Response Deadline")]
    [IsoXmlTag("ElctnToCtrPtyRspnDdln")]
    public DateFormat31Choice_? ElectionToCounterpartyResponseDeadline { get; init; } 
    
    /// <summary>
    /// Date/time at which an event/offer is terminated or lapsed.
    /// </summary>
    [IsoId("_Yb7rP0ECEeWVgfuHGaKtRQ")]
    [DisplayName("Lapsed Date")]
    [IsoXmlTag("LpsdDt")]
    public DateFormat31Choice_? LapsedDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_Yb7rR0ECEeWVgfuHGaKtRQ")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateFormat31Choice_? PaymentDate { get; init; } 
    
    /// <summary>
    /// Date/Time by which the account owner must instruct directly another party, for example to provide documentation to an issuer agent.
    /// </summary>
    [IsoId("_Yb7rT0ECEeWVgfuHGaKtRQ")]
    [DisplayName("Third Party Deadline")]
    [IsoXmlTag("ThrdPtyDdln")]
    public DateFormat31Choice_? ThirdPartyDeadline { get; init; } 
    
    /// <summary>
    /// Date/Time set by the issuer agent as a first early deadline by which the account owner must instruct directly another party, possibly giving the holder eligibility to incentives. For example, to provide documentation to an issuer agent.
    /// </summary>
    [IsoId("_Yb7rV0ECEeWVgfuHGaKtRQ")]
    [DisplayName("Early Third Party Deadline")]
    [IsoXmlTag("EarlyThrdPtyDdln")]
    public DateFormat31Choice_? EarlyThirdPartyDeadline { get; init; } 
    
    /// <summary>
    /// Date by which the depository stops monitoring activities of the event, for instance, accounting and tracking activities for due bills end.
    /// </summary>
    [IsoId("_Yb7rX0ECEeWVgfuHGaKtRQ")]
    [DisplayName("Market Claim Tracking End Date")]
    [IsoXmlTag("MktClmTrckgEndDt")]
    public DateFormat31Choice_? MarketClaimTrackingEndDate { get; init; } 
    
    /// <summary>
    /// Last day an investor can become a lead plaintiff.
    /// </summary>
    [IsoId("_Yb7rZ0ECEeWVgfuHGaKtRQ")]
    [DisplayName("Lead Plaintiff Deadline")]
    [IsoXmlTag("LeadPlntffDdln")]
    public DateFormat31Choice_? LeadPlaintiffDeadline { get; init; } 
    
    /// <summary>
    /// Date on which the action was filed at the applicable court.
    /// </summary>
    [IsoId("_Yb7raUECEeWVgfuHGaKtRQ")]
    [DisplayName("Filing Date")]
    [IsoXmlTag("FilgDt")]
    public DateFormat30Choice_? FilingDate { get; init; } 
    
    /// <summary>
    /// Date for the hearing between the plaintiff and defendant, as set by the court.
    /// </summary>
    [IsoId("_Yb7ra0ECEeWVgfuHGaKtRQ")]
    [DisplayName("Hearing Date")]
    [IsoXmlTag("HrgDt")]
    public DateFormat30Choice_? HearingDate { get; init; } 
    
    
    #nullable disable
    
}
