// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
[IsoId("_TZ4q9dp-Ed-ak6NoX_4Aeg_-100992318")]
[DisplayName("Corporate Action Date")]
public record CorporateActionDate1
{
    /// <summary>
    /// Date/time at which the issuer announced that a corporate action event will occur.
    /// </summary>
    [IsoId("_TZ4q9tp-Ed-ak6NoX_4Aeg_386626685")]
    [DisplayName("Announcement Date")]
    [IsoXmlTag("AnncmntDt")]
    public DateFormat6Choice_? AnnouncementDate { get; init; }

    /// <summary>
    /// Deadline by which the beneficial ownership of securities must be declared.
    /// </summary>
    [IsoId("_TZ4q99p-Ed-ak6NoX_4Aeg_-100992316")]
    [DisplayName("Certification Deadline")]
    [IsoXmlTag("CertfctnDdln")]
    public DateFormat6Choice_? CertificationDeadline { get; init; }

    /// <summary>
    /// Date upon which the court provided approval.
    /// </summary>
    [IsoId("_TZ4q-Np-Ed-ak6NoX_4Aeg_-100992283")]
    [DisplayName("Court Approval Date")]
    [IsoXmlTag("CrtApprvlDt")]
    public DateFormat6Choice_? CourtApprovalDate { get; init; }

    /// <summary>
    /// First possible early closing date of an offer if different from the expiry date.
    /// </summary>
    [IsoId("_TZ4q-dp-Ed-ak6NoX_4Aeg_-100992248")]
    [DisplayName("Early Closing Date")]
    [IsoXmlTag("EarlyClsgDt")]
    public DateFormat6Choice_? EarlyClosingDate { get; init; }

    /// <summary>
    /// Date/time at which an event is officially effective from the issuer&apos;s perspective.
    /// </summary>
    [IsoId("_TZ4q-tp-Ed-ak6NoX_4Aeg_-100992223")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public DateFormat6Choice_? EffectiveDate { get; init; }

    /// <summary>
    /// Date/Time on which all or part of any holding bought in a unit trust is subject to being treated as capital rather than income. This is normally one day after the previous distribution&apos;s ex date.
    /// </summary>
    [IsoId("_TaCb8Np-Ed-ak6NoX_4Aeg_-100992188")]
    [DisplayName("Equalisation Date")]
    [IsoXmlTag("EqulstnDt")]
    public DateFormat6Choice_? EqualisationDate { get; init; }

    /// <summary>
    /// Date/time at which additional information on the event will be announced, for example, exchange ratio announcement date.
    /// </summary>
    [IsoId("_TaCb8dp-Ed-ak6NoX_4Aeg_742183833")]
    [DisplayName("Further Detailed Announcement Date")]
    [IsoXmlTag("FrthrDtldAnncmntDt")]
    public DateFormat6Choice_? FurtherDetailedAnnouncementDate { get; init; }

    /// <summary>
    /// Date/time at which an index rate will be determined.
    /// </summary>
    [IsoId("_TaCb8tp-Ed-ak6NoX_4Aeg_-100992163")]
    [DisplayName("Index Fixing Date")]
    [IsoXmlTag("IndxFxgDt")]
    public DateFormat6Choice_? IndexFixingDate { get; init; }

    /// <summary>
    /// Date/time on which the lottery is run and applied to the holder&apos;s positions. This is also applicable to partial calls.
    /// </summary>
    [IsoId("_TaCb89p-Ed-ak6NoX_4Aeg_-100992146")]
    [DisplayName("Lottery Date")]
    [IsoXmlTag("LtryDt")]
    public DateFormat6Choice_? LotteryDate { get; init; }

    /// <summary>
    /// Date/time upon on which an interest bearing financial instrument becomes due and principal is repaid by the issuer to the investor.
    /// </summary>
    [IsoId("_TaCb9Np-Ed-ak6NoX_4Aeg_-100992128")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    public DateFormat6Choice_? MaturityDate { get; init; }

    /// <summary>
    /// Date/time on which the bondholder&apos;s or shareholder&apos;s meeting will take place.
    /// </summary>
    [IsoId("_TaCb9dp-Ed-ak6NoX_4Aeg_845675430")]
    [DisplayName("Meeting Date")]
    [IsoXmlTag("MtgDt")]
    public DateFormat6Choice_? MeetingDate { get; init; }

    /// <summary>
    /// Date/time at which the margin rate will be determined.
    /// </summary>
    [IsoId("_TaCb9tp-Ed-ak6NoX_4Aeg_-100991876")]
    [DisplayName("Margin Fixing Date")]
    [IsoXmlTag("MrgnFxgDt")]
    public DateFormat6Choice_? MarginFixingDate { get; init; }

    /// <summary>
    /// Date/time (and time) at which an issuer will determine the proration amount/quantity of an offer.
    /// </summary>
    [IsoId("_TaCb99p-Ed-ak6NoX_4Aeg_-100991834")]
    [DisplayName("Proration Date")]
    [IsoXmlTag("PrratnDt")]
    public DateFormat6Choice_? ProrationDate { get; init; }

    /// <summary>
    /// Date/time at which positions are struck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date.
    /// </summary>
    [IsoId("_TaCb-Np-Ed-ak6NoX_4Aeg_-100991816")]
    [DisplayName("Record Date")]
    [IsoXmlTag("RcrdDt")]
    public DateFormat6Choice_? RecordDate { get; init; }

    /// <summary>
    /// Date/time on which instructions to register or registration details will be accepted.
    /// </summary>
    [IsoId("_TaMM8Np-Ed-ak6NoX_4Aeg_-100991773")]
    [DisplayName("Registration Deadline")]
    [IsoXmlTag("RegnDdln")]
    public DateFormat6Choice_? RegistrationDeadline { get; init; }

    /// <summary>
    /// Date/time on which results are published, for example, results of an offer.
    /// </summary>
    [IsoId("_TaMM8dp-Ed-ak6NoX_4Aeg_-100991755")]
    [DisplayName("Results Publication Date")]
    [IsoXmlTag("RsltsPblctnDt")]
    public DateFormat6Choice_? ResultsPublicationDate { get; init; }

    /// <summary>
    /// Deadline by which instructions must be received to split securities, for example, of physical certificates.
    /// </summary>
    [IsoId("_TaMM8tp-Ed-ak6NoX_4Aeg_1243957378")]
    [DisplayName("Deadline To Split")]
    [IsoXmlTag("DdlnToSplt")]
    public DateFormat6Choice_? DeadlineToSplit { get; init; }

    /// <summary>
    /// Date/time on until which tax breakdown instructions will be accepted.
    /// </summary>
    [IsoId("_TaMM89p-Ed-ak6NoX_4Aeg_-100991730")]
    [DisplayName("Deadline For Tax Breakdown Instruction")]
    [IsoXmlTag("DdlnForTaxBrkdwnInstr")]
    public DateFormat6Choice_? DeadlineForTaxBreakdownInstruction { get; init; }

    /// <summary>
    /// Date/time at which trading of a security is suspended as the result of an event.
    /// </summary>
    [IsoId("_TaMM9Np-Ed-ak6NoX_4Aeg_-100991447")]
    [DisplayName("Trading Suspended Date")]
    [IsoXmlTag("TradgSspdDt")]
    public DateFormat6Choice_? TradingSuspendedDate { get; init; }

    /// <summary>
    /// Date/time upon which the terms of the take-over become unconditional as to acceptances.
    /// </summary>
    [IsoId("_TaMM9dp-Ed-ak6NoX_4Aeg_-100991430")]
    [DisplayName("Unconditional Date")]
    [IsoXmlTag("UcondlDt")]
    public DateFormat6Choice_? UnconditionalDate { get; init; }

    /// <summary>
    /// Date/time at on which all conditions, including regulatory, legal etc. pertaining to the take-over, have been met.
    /// </summary>
    [IsoId("_TaMM9tp-Ed-ak6NoX_4Aeg_-100991412")]
    [DisplayName("Wholly Unconditional Date")]
    [IsoXmlTag("WhlyUcondlDt")]
    public DateFormat6Choice_? WhollyUnconditionalDate { get; init; }

    /// <summary>
    /// Date/time as from which trading (including exchange and OTC trading) occurs on the underlying security without the benefit.
    /// </summary>
    [IsoId("_TaMM99p-Ed-ak6NoX_4Aeg_-100991387")]
    [DisplayName("Ex Dividend Date")]
    [IsoXmlTag("ExDvddDt")]
    public DateFormat6Choice_? ExDividendDate { get; init; }

    /// <summary>
    /// Date/time at which the corporate action is legally announced by an official body, for example, publication by a governmental administration.
    /// </summary>
    [IsoId("_TaMM-Np-Ed-ak6NoX_4Aeg_1372025093")]
    [DisplayName("Official Announcement Publication Date")]
    [IsoXmlTag("OffclAnncmntPblctnDt")]
    public DateFormat6Choice_? OfficialAnnouncementPublicationDate { get; init; }

    /// <summary>
    /// Date/time as from which &apos;special processing&apos; can start to be used by participants for that event. Special processing is a means of marking a transaction, that would normally be traded ex or cum, as being traded cum or ex respectively, for example, a transaction dealt &apos;special&apos; after the ex date would result in the buyer being eligible for the entitlement. This is typically used in the UK and Irish markets.
    /// </summary>
    [IsoId("_TaMM-dp-Ed-ak6NoX_4Aeg_1386800034")]
    [DisplayName("Special Ex Date")]
    [IsoXmlTag("SpclExDt")]
    public DateFormat6Choice_? SpecialExDate { get; init; }

    /// <summary>
    /// Last date/time by which a buying counterparty to a trade can be sure that it will have the right to participate in an event.
    /// </summary>
    [IsoId("_TaMM-tp-Ed-ak6NoX_4Aeg_1632455549")]
    [DisplayName("Guaranteed Participation Date")]
    [IsoXmlTag("GrntedPrtcptnDt")]
    public DateFormat6Choice_? GuaranteedParticipationDate { get; init; }

    /// <summary>
    /// Deadline by which an entitled holder needs to advise their counterparty to a transaction of their election for a corporate action event.
    /// </summary>
    [IsoId("_TaVW4Np-Ed-ak6NoX_4Aeg_1659237350")]
    [DisplayName("Election To Counterparty Deadline")]
    [IsoXmlTag("ElctnToCtrPtyDdln")]
    public DateFormat6Choice_? ElectionToCounterpartyDeadline { get; init; }

    /// <summary>
    /// Date/time at which an event/offer is terminated or lapsed.
    /// </summary>
    [IsoId("_TaVW4dp-Ed-ak6NoX_4Aeg_1687868827")]
    [DisplayName("Lapsed Date")]
    [IsoXmlTag("LpsdDt")]
    public DateFormat6Choice_? LapsedDate { get; init; }

    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_TaVW4tp-Ed-ak6NoX_4Aeg_17913197")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateFormat6Choice_? PaymentDate { get; init; }

    /// <summary>
    /// Date/Time by which the account owner must instruct directly another party, for example to provide documentation to an issuer agent.
    /// </summary>
    [IsoId("_TaVW49p-Ed-ak6NoX_4Aeg_1380156192")]
    [DisplayName("Third Party Deadline")]
    [IsoXmlTag("ThrdPtyDdln")]
    public DateFormat6Choice_? ThirdPartyDeadline { get; init; }

    /// <summary>
    /// Date/Time set by the issuer agent as a first early deadline by which the account owner must instruct directly another party, possibly giving the holder eligibility to incentives. For example, to provide documentation to an issuer agent.
    /// </summary>
    [IsoId("_TaVW5Np-Ed-ak6NoX_4Aeg_1012190145")]
    [DisplayName("Early Third Party Deadline")]
    [IsoXmlTag("EarlyThrdPtyDdln")]
    public DateFormat6Choice_? EarlyThirdPartyDeadline { get; init; }

    /// <summary>
    /// Date by which the depository stops monitoring activities of the event, for instance, accounting and tracking activities for due bills end.
    /// </summary>
    [IsoId("_TaVW5dp-Ed-ak6NoX_4Aeg_915544995")]
    [DisplayName("Market Claim Tracking End Date")]
    [IsoXmlTag("MktClmTrckgEndDt")]
    public DateFormat6Choice_? MarketClaimTrackingEndDate { get; init; }
}
