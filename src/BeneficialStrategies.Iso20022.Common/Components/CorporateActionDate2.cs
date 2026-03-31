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
[IsoId("_TeznNNp-Ed-ak6NoX_4Aeg_722709396")]
[DisplayName("Corporate Action Date")]
public record CorporateActionDate2
{
    /// <summary>
    /// Date on which positions are struck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date.
    /// </summary>
    [IsoId("_TeznNdp-Ed-ak6NoX_4Aeg_726402957")]
    [DisplayName("Record Date")]
    [IsoXmlTag("RcrdDt")]
    public DateFormat4Choice_? RecordDate { get; init; }

    /// <summary>
    /// Date on which a process is to be completed or becomes effective.
    /// </summary>
    [IsoId("_TeznNtp-Ed-ak6NoX_4Aeg_725482439")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public DateFormat4Choice_? EffectiveDate { get; init; }

    /// <summary>
    /// Last day a holder can deliver the securities that it had previously protected.
    /// </summary>
    [IsoId("_Te9YMNp-Ed-ak6NoX_4Aeg_725482379")]
    [DisplayName("Cover Expiration Date")]
    [IsoXmlTag("CoverXprtnDt")]
    public DateFormat4Choice_? CoverExpirationDate { get; init; }

    /// <summary>
    /// Date on which all or part of any holding bought in a unit trust is subject to being treated as capital rather than income. This is normally one day after the previous distribution&apos;s ex date.
    /// </summary>
    [IsoId("_Te9YMdp-Ed-ak6NoX_4Aeg_725482470")]
    [DisplayName("Equalisation Date")]
    [IsoXmlTag("EqulstnDt")]
    public DateFormat4Choice_? EqualisationDate { get; init; }

    /// <summary>
    /// Date/time at which the margin rate will be determined.
    /// </summary>
    [IsoId("_Te9YMtp-Ed-ak6NoX_4Aeg_726404088")]
    [DisplayName("Margin Fixing Date")]
    [IsoXmlTag("MrgnFxgDt")]
    public DateFormat4Choice_? MarginFixingDate { get; init; }

    /// <summary>
    /// Date on which the lottery is run and applied to the holder&apos;s positions. This is also applicable to partial calls.
    /// </summary>
    [IsoId("_Te9YM9p-Ed-ak6NoX_4Aeg_725482553")]
    [DisplayName("Lottery Date")]
    [IsoXmlTag("LtryDt")]
    public DateFormat4Choice_? LotteryDate { get; init; }

    /// <summary>
    /// Last date a holder can request to defer delivery of securities pursuant to a notice of guaranteed delivery or other required documentation.
    /// </summary>
    [IsoId("_Te9YNNp-Ed-ak6NoX_4Aeg_725482862")]
    [DisplayName("Protect Date")]
    [IsoXmlTag("PrtctDt")]
    public DateFormat4Choice_? ProtectDate { get; init; }

    /// <summary>
    /// Date upon which the terms of the take-over become unconditional as to acceptances.
    /// </summary>
    [IsoId("_Te9YNdp-Ed-ak6NoX_4Aeg_726403511")]
    [DisplayName("Unconditional Date")]
    [IsoXmlTag("UcondlDt")]
    public DateFormat4Choice_? UnconditionalDate { get; init; }

    /// <summary>
    /// Date on which all conditions, including regulatory, legal etc. pertaining to the take-over, have been met.
    /// </summary>
    [IsoId("_Te9YNtp-Ed-ak6NoX_4Aeg_726403564")]
    [DisplayName("Wholly Unconditional Date")]
    [IsoXmlTag("WhlyUcondlDt")]
    public DateFormat4Choice_? WhollyUnconditionalDate { get; init; }

    /// <summary>
    /// Date on which results are published, eg, results of an offer.
    /// </summary>
    [IsoId("_Te9YN9p-Ed-ak6NoX_4Aeg_726403110")]
    [DisplayName("Results Publication Date")]
    [IsoXmlTag("RsltsPblctnDt")]
    public DateFormat4Choice_? ResultsPublicationDate { get; init; }

    /// <summary>
    /// Date/time upon which the High Court provided approval.
    /// </summary>
    [IsoId("_Te9YONp-Ed-ak6NoX_4Aeg_726403965")]
    [DisplayName("Court Approval Date")]
    [IsoXmlTag("CrtApprvlDt")]
    public DateFormat4Choice_? CourtApprovalDate { get; init; }

    /// <summary>
    /// First possible early closing date of an offer if different from the expiry date.
    /// </summary>
    [IsoId("_Te9YOdp-Ed-ak6NoX_4Aeg_-1186197882")]
    [DisplayName("Early Closing Date")]
    [IsoXmlTag("EarlyClsgDt")]
    public DateFormat4Choice_? EarlyClosingDate { get; init; }

    /// <summary>
    /// Date/time as from which trading (including exchange and OTC trading) occurs on the underlying security without the benefit.
    /// </summary>
    [IsoId("_TfGiINp-Ed-ak6NoX_4Aeg_-1580550968")]
    [DisplayName("Ex Dividend Date")]
    [IsoXmlTag("ExDvddDt")]
    public DateFormat4Choice_? ExDividendDate { get; init; }

    /// <summary>
    /// Date/time at which an index rate will be determined.
    /// </summary>
    [IsoId("_TfGiIdp-Ed-ak6NoX_4Aeg_726404026")]
    [DisplayName("Index Fixing Date")]
    [IsoXmlTag("IndxFxgDt")]
    public DateFormat4Choice_? IndexFixingDate { get; init; }

    /// <summary>
    /// Date on which an interest bearing financial instrument becomes due and principal is repaid by the issuer to the investor.
    /// </summary>
    [IsoId("_TfGiItp-Ed-ak6NoX_4Aeg_726404149")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    public DateFormat4Choice_? MaturityDate { get; init; }

    /// <summary>
    /// Date on which trading of a security is suspended as the result of an event.
    /// </summary>
    [IsoId("_TfGiI9p-Ed-ak6NoX_4Aeg_2015311581")]
    [DisplayName("Trading Suspended Date")]
    [IsoXmlTag("TradgSspdDt")]
    public DateFormat4Choice_? TradingSuspendedDate { get; init; }

    /// <summary>
    /// Deadline by which the beneficial ownership of securities must be declared.
    /// </summary>
    [IsoId("_TfGiJNp-Ed-ak6NoX_4Aeg_2015311428")]
    [DisplayName("Certification Deadline")]
    [IsoXmlTag("CertfctnDdln")]
    public DateFormat4Choice_? CertificationDeadline { get; init; }

    /// <summary>
    /// Date/time at which the securities will be redeemed (early) for payment of principal.
    /// </summary>
    [IsoId("_TfGiJdp-Ed-ak6NoX_4Aeg_726402987")]
    [DisplayName("Redemption Date")]
    [IsoXmlTag("RedDt")]
    public DateFormat4Choice_? RedemptionDate { get; init; }

    /// <summary>
    /// Date on which instructions to register or registration details will be accepted.
    /// </summary>
    [IsoId("_TfGiJtp-Ed-ak6NoX_4Aeg_726403079")]
    [DisplayName("Registration Deadline")]
    [IsoXmlTag("RegnDdln")]
    public DateFormat4Choice_? RegistrationDeadline { get; init; }

    /// <summary>
    /// Date (and time) at which an issuer will determine the proration amount/quantity of an offer.
    /// </summary>
    [IsoId("_TfGiJ9p-Ed-ak6NoX_4Aeg_725482893")]
    [DisplayName("Proration Date")]
    [IsoXmlTag("PrratnDt")]
    public DateFormat4Choice_? ProrationDate { get; init; }

    /// <summary>
    /// Date on until which tax breakdown instructions will be accepted.
    /// </summary>
    [IsoId("_TfGiKNp-Ed-ak6NoX_4Aeg_-869263799")]
    [DisplayName("Deadline For Tax Breakdown Instruction")]
    [IsoXmlTag("DdlnForTaxBrkdwnInstr")]
    public DateFormat4Choice_? DeadlineForTaxBreakdownInstruction { get; init; }

    /// <summary>
    /// Date/time at which an event/offer is terminated or lapsed.
    /// </summary>
    [IsoId("_TfQTINp-Ed-ak6NoX_4Aeg_253438133")]
    [DisplayName("Lapsed Date")]
    [IsoXmlTag("LpsdDt")]
    public DateFormat4Choice_? LapsedDate { get; init; }

    /// <summary>
    /// Last date/time by which a buying counterparty to a trade can be sure that it will have the right to participate in an event.
    /// </summary>
    [IsoId("_TfQTIdp-Ed-ak6NoX_4Aeg_-1782267860")]
    [DisplayName("Guaranteed Participation Date")]
    [IsoXmlTag("GrntedPrtcptnDt")]
    public DateFormat4Choice_? GuaranteedParticipationDate { get; init; }

    /// <summary>
    /// Deadline by which an entitled holder needs to advise their counterparty to a transaction of their election for a corporate action event.
    /// </summary>
    [IsoId("_TfQTItp-Ed-ak6NoX_4Aeg_-1705614252")]
    [DisplayName("Election To Counterparty Deadline")]
    [IsoXmlTag("ElctnToCtrPtyDdln")]
    public DateFormat4Choice_? ElectionToCounterpartyDeadline { get; init; }

    /// <summary>
    /// Date/time as from which &apos;special processing&apos; can start to be used by participants for that event. Special processing is a means of marking a transaction, that would normally be traded ex or cum, as being traded cum or ex respectively, eg, a transaction dealt &apos;special&apos; after the ex date would result in the buyer being eligible for the entitlement. This is typically used in the UK and Irish markets.
    /// </summary>
    [IsoId("_TfQTI9p-Ed-ak6NoX_4Aeg_-560039148")]
    [DisplayName("Special Ex Date")]
    [IsoXmlTag("SpclExDt")]
    public DateFormat4Choice_? SpecialExDate { get; init; }
}
