// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
[IsoId("_TZ4q9dp-Ed-ak6NoX_4Aeg_-100992318")]
[DisplayName("Corporate Action Date")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDate1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date/time at which the issuer announced that a corporate action event will occur.
    /// </summary>
    [IsoId("_TZ4q9tp-Ed-ak6NoX_4Aeg_386626685")]
    [DisplayName("Announcement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AnncmntDt")]
    #endif
    [IsoXmlTag("AnncmntDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? AnnouncementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? AnnouncementDate { get; init; } 
    #else
    public DateFormat6Choice_? AnnouncementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Deadline by which the beneficial ownership of securities must be declared.
    /// </summary>
    [IsoId("_TZ4q99p-Ed-ak6NoX_4Aeg_-100992316")]
    [DisplayName("Certification Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnDdln")]
    #endif
    [IsoXmlTag("CertfctnDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? CertificationDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? CertificationDeadline { get; init; } 
    #else
    public DateFormat6Choice_? CertificationDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date upon which the court provided approval.
    /// </summary>
    [IsoId("_TZ4q-Np-Ed-ak6NoX_4Aeg_-100992283")]
    [DisplayName("Court Approval Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrtApprvlDt")]
    #endif
    [IsoXmlTag("CrtApprvlDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? CourtApprovalDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? CourtApprovalDate { get; init; } 
    #else
    public DateFormat6Choice_? CourtApprovalDate { get; set; } 
    #endif
    
    /// <summary>
    /// First possible early closing date of an offer if different from the expiry date.
    /// </summary>
    [IsoId("_TZ4q-dp-Ed-ak6NoX_4Aeg_-100992248")]
    [DisplayName("Early Closing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyClsgDt")]
    #endif
    [IsoXmlTag("EarlyClsgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? EarlyClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? EarlyClosingDate { get; init; } 
    #else
    public DateFormat6Choice_? EarlyClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which an event is officially effective from the issuer&apos;s perspective.
    /// </summary>
    [IsoId("_TZ4q-tp-Ed-ak6NoX_4Aeg_-100992223")]
    [DisplayName("Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvDt")]
    #endif
    [IsoXmlTag("FctvDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? EffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? EffectiveDate { get; init; } 
    #else
    public DateFormat6Choice_? EffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/Time on which all or part of any holding bought in a unit trust is subject to being treated as capital rather than income. This is normally one day after the previous distribution&apos;s ex date.
    /// </summary>
    [IsoId("_TaCb8Np-Ed-ak6NoX_4Aeg_-100992188")]
    [DisplayName("Equalisation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EqulstnDt")]
    #endif
    [IsoXmlTag("EqulstnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? EqualisationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? EqualisationDate { get; init; } 
    #else
    public DateFormat6Choice_? EqualisationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which additional information on the event will be announced, for example, exchange ratio announcement date.
    /// </summary>
    [IsoId("_TaCb8dp-Ed-ak6NoX_4Aeg_742183833")]
    [DisplayName("Further Detailed Announcement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrthrDtldAnncmntDt")]
    #endif
    [IsoXmlTag("FrthrDtldAnncmntDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? FurtherDetailedAnnouncementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? FurtherDetailedAnnouncementDate { get; init; } 
    #else
    public DateFormat6Choice_? FurtherDetailedAnnouncementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which an index rate will be determined.
    /// </summary>
    [IsoId("_TaCb8tp-Ed-ak6NoX_4Aeg_-100992163")]
    [DisplayName("Index Fixing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndxFxgDt")]
    #endif
    [IsoXmlTag("IndxFxgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? IndexFixingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? IndexFixingDate { get; init; } 
    #else
    public DateFormat6Choice_? IndexFixingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time on which the lottery is run and applied to the holder&apos;s positions. This is also applicable to partial calls.
    /// </summary>
    [IsoId("_TaCb89p-Ed-ak6NoX_4Aeg_-100992146")]
    [DisplayName("Lottery Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LtryDt")]
    #endif
    [IsoXmlTag("LtryDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? LotteryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? LotteryDate { get; init; } 
    #else
    public DateFormat6Choice_? LotteryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time upon on which an interest bearing financial instrument becomes due and principal is repaid by the issuer to the investor.
    /// </summary>
    [IsoId("_TaCb9Np-Ed-ak6NoX_4Aeg_-100992128")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? MaturityDate { get; init; } 
    #else
    public DateFormat6Choice_? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time on which the bondholder&apos;s or shareholder&apos;s meeting will take place.
    /// </summary>
    [IsoId("_TaCb9dp-Ed-ak6NoX_4Aeg_845675430")]
    [DisplayName("Meeting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgDt")]
    #endif
    [IsoXmlTag("MtgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? MeetingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? MeetingDate { get; init; } 
    #else
    public DateFormat6Choice_? MeetingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the margin rate will be determined.
    /// </summary>
    [IsoId("_TaCb9tp-Ed-ak6NoX_4Aeg_-100991876")]
    [DisplayName("Margin Fixing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnFxgDt")]
    #endif
    [IsoXmlTag("MrgnFxgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? MarginFixingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? MarginFixingDate { get; init; } 
    #else
    public DateFormat6Choice_? MarginFixingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time (and time) at which an issuer will determine the proration amount/quantity of an offer.
    /// </summary>
    [IsoId("_TaCb99p-Ed-ak6NoX_4Aeg_-100991834")]
    [DisplayName("Proration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrratnDt")]
    #endif
    [IsoXmlTag("PrratnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? ProrationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? ProrationDate { get; init; } 
    #else
    public DateFormat6Choice_? ProrationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which positions are struck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date.
    /// </summary>
    [IsoId("_TaCb-Np-Ed-ak6NoX_4Aeg_-100991816")]
    [DisplayName("Record Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcrdDt")]
    #endif
    [IsoXmlTag("RcrdDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? RecordDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? RecordDate { get; init; } 
    #else
    public DateFormat6Choice_? RecordDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time on which instructions to register or registration details will be accepted.
    /// </summary>
    [IsoId("_TaMM8Np-Ed-ak6NoX_4Aeg_-100991773")]
    [DisplayName("Registration Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnDdln")]
    #endif
    [IsoXmlTag("RegnDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? RegistrationDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? RegistrationDeadline { get; init; } 
    #else
    public DateFormat6Choice_? RegistrationDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time on which results are published, for example, results of an offer.
    /// </summary>
    [IsoId("_TaMM8dp-Ed-ak6NoX_4Aeg_-100991755")]
    [DisplayName("Results Publication Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltsPblctnDt")]
    #endif
    [IsoXmlTag("RsltsPblctnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? ResultsPublicationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? ResultsPublicationDate { get; init; } 
    #else
    public DateFormat6Choice_? ResultsPublicationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Deadline by which instructions must be received to split securities, for example, of physical certificates.
    /// </summary>
    [IsoId("_TaMM8tp-Ed-ak6NoX_4Aeg_1243957378")]
    [DisplayName("Deadline To Split")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DdlnToSplt")]
    #endif
    [IsoXmlTag("DdlnToSplt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? DeadlineToSplit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? DeadlineToSplit { get; init; } 
    #else
    public DateFormat6Choice_? DeadlineToSplit { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time on until which tax breakdown instructions will be accepted.
    /// </summary>
    [IsoId("_TaMM89p-Ed-ak6NoX_4Aeg_-100991730")]
    [DisplayName("Deadline For Tax Breakdown Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DdlnForTaxBrkdwnInstr")]
    #endif
    [IsoXmlTag("DdlnForTaxBrkdwnInstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? DeadlineForTaxBreakdownInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? DeadlineForTaxBreakdownInstruction { get; init; } 
    #else
    public DateFormat6Choice_? DeadlineForTaxBreakdownInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which trading of a security is suspended as the result of an event.
    /// </summary>
    [IsoId("_TaMM9Np-Ed-ak6NoX_4Aeg_-100991447")]
    [DisplayName("Trading Suspended Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSspdDt")]
    #endif
    [IsoXmlTag("TradgSspdDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? TradingSuspendedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? TradingSuspendedDate { get; init; } 
    #else
    public DateFormat6Choice_? TradingSuspendedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time upon which the terms of the take-over become unconditional as to acceptances.
    /// </summary>
    [IsoId("_TaMM9dp-Ed-ak6NoX_4Aeg_-100991430")]
    [DisplayName("Unconditional Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UcondlDt")]
    #endif
    [IsoXmlTag("UcondlDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? UnconditionalDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? UnconditionalDate { get; init; } 
    #else
    public DateFormat6Choice_? UnconditionalDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at on which all conditions, including regulatory, legal etc. pertaining to the take-over, have been met.
    /// </summary>
    [IsoId("_TaMM9tp-Ed-ak6NoX_4Aeg_-100991412")]
    [DisplayName("Wholly Unconditional Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhlyUcondlDt")]
    #endif
    [IsoXmlTag("WhlyUcondlDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? WhollyUnconditionalDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? WhollyUnconditionalDate { get; init; } 
    #else
    public DateFormat6Choice_? WhollyUnconditionalDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time as from which trading (including exchange and OTC trading) occurs on the underlying security without the benefit.
    /// </summary>
    [IsoId("_TaMM99p-Ed-ak6NoX_4Aeg_-100991387")]
    [DisplayName("Ex Dividend Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExDvddDt")]
    #endif
    [IsoXmlTag("ExDvddDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? ExDividendDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? ExDividendDate { get; init; } 
    #else
    public DateFormat6Choice_? ExDividendDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the corporate action is legally announced by an official body, for example, publication by a governmental administration.
    /// </summary>
    [IsoId("_TaMM-Np-Ed-ak6NoX_4Aeg_1372025093")]
    [DisplayName("Official Announcement Publication Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OffclAnncmntPblctnDt")]
    #endif
    [IsoXmlTag("OffclAnncmntPblctnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? OfficialAnnouncementPublicationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? OfficialAnnouncementPublicationDate { get; init; } 
    #else
    public DateFormat6Choice_? OfficialAnnouncementPublicationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time as from which &apos;special processing&apos; can start to be used by participants for that event. Special processing is a means of marking a transaction, that would normally be traded ex or cum, as being traded cum or ex respectively, for example, a transaction dealt &apos;special&apos; after the ex date would result in the buyer being eligible for the entitlement. This is typically used in the UK and Irish markets.
    /// </summary>
    [IsoId("_TaMM-dp-Ed-ak6NoX_4Aeg_1386800034")]
    [DisplayName("Special Ex Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpclExDt")]
    #endif
    [IsoXmlTag("SpclExDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? SpecialExDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? SpecialExDate { get; init; } 
    #else
    public DateFormat6Choice_? SpecialExDate { get; set; } 
    #endif
    
    /// <summary>
    /// Last date/time by which a buying counterparty to a trade can be sure that it will have the right to participate in an event.
    /// </summary>
    [IsoId("_TaMM-tp-Ed-ak6NoX_4Aeg_1632455549")]
    [DisplayName("Guaranteed Participation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrntedPrtcptnDt")]
    #endif
    [IsoXmlTag("GrntedPrtcptnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? GuaranteedParticipationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? GuaranteedParticipationDate { get; init; } 
    #else
    public DateFormat6Choice_? GuaranteedParticipationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Deadline by which an entitled holder needs to advise their counterparty to a transaction of their election for a corporate action event.
    /// </summary>
    [IsoId("_TaVW4Np-Ed-ak6NoX_4Aeg_1659237350")]
    [DisplayName("Election To Counterparty Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctnToCtrPtyDdln")]
    #endif
    [IsoXmlTag("ElctnToCtrPtyDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? ElectionToCounterpartyDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? ElectionToCounterpartyDeadline { get; init; } 
    #else
    public DateFormat6Choice_? ElectionToCounterpartyDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which an event/offer is terminated or lapsed.
    /// </summary>
    [IsoId("_TaVW4dp-Ed-ak6NoX_4Aeg_1687868827")]
    [DisplayName("Lapsed Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LpsdDt")]
    #endif
    [IsoXmlTag("LpsdDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? LapsedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? LapsedDate { get; init; } 
    #else
    public DateFormat6Choice_? LapsedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_TaVW4tp-Ed-ak6NoX_4Aeg_17913197")]
    [DisplayName("Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDt")]
    #endif
    [IsoXmlTag("PmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? PaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? PaymentDate { get; init; } 
    #else
    public DateFormat6Choice_? PaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/Time by which the account owner must instruct directly another party, for example to provide documentation to an issuer agent.
    /// </summary>
    [IsoId("_TaVW49p-Ed-ak6NoX_4Aeg_1380156192")]
    [DisplayName("Third Party Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThrdPtyDdln")]
    #endif
    [IsoXmlTag("ThrdPtyDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? ThirdPartyDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? ThirdPartyDeadline { get; init; } 
    #else
    public DateFormat6Choice_? ThirdPartyDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date/Time set by the issuer agent as a first early deadline by which the account owner must instruct directly another party, possibly giving the holder eligibility to incentives. For example, to provide documentation to an issuer agent.
    /// </summary>
    [IsoId("_TaVW5Np-Ed-ak6NoX_4Aeg_1012190145")]
    [DisplayName("Early Third Party Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyThrdPtyDdln")]
    #endif
    [IsoXmlTag("EarlyThrdPtyDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? EarlyThirdPartyDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? EarlyThirdPartyDeadline { get; init; } 
    #else
    public DateFormat6Choice_? EarlyThirdPartyDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the depository stops monitoring activities of the event, for instance, accounting and tracking activities for due bills end.
    /// </summary>
    [IsoId("_TaVW5dp-Ed-ak6NoX_4Aeg_915544995")]
    [DisplayName("Market Claim Tracking End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktClmTrckgEndDt")]
    #endif
    [IsoXmlTag("MktClmTrckgEndDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat6Choice_? MarketClaimTrackingEndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat6Choice_? MarketClaimTrackingEndDate { get; init; } 
    #else
    public DateFormat6Choice_? MarketClaimTrackingEndDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
