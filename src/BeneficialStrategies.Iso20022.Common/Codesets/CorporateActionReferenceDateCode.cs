// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reference date of corporate action, in coded form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bR_2stp-Ed-ak6NoX_4Aeg_-280874700")]
[Description(@"Specifies the reference date of corporate action, in coded form.")]
[Derivations(typeof(CorporateActionDeadline1Code))]
public enum CorporateActionReferenceDateCode
{
    /// <summary>
    /// Date on which the issuer announced that a corporate action event will occur.
    /// Encoded/decoded by serializers as &quot;ANOU&quot;.
    /// </summary>
    [EnumMember(Value = "ANOU")]
    [IsoId("_bR_2s9p-Ed-ak6NoX_4Aeg_545674128")]
    [Description(@"Date on which the issuer announced that a corporate action event will occur.")]
    AnnouncementDate,
    
    /// <summary>
    /// Date on which securities become available for trading, for example first dealing date.
    /// Encoded/decoded by serializers as &quot;AVAL&quot;.
    /// </summary>
    [EnumMember(Value = "AVAL")]
    [IsoId("_bR_2tNp-Ed-ak6NoX_4Aeg_1504289547")]
    [Description(@"Date on which securities become available for trading, for example first dealing date.")]
    AvailableDate,
    
    /// <summary>
    /// Deadline by which the beneficial ownership of securities must be declared.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_bR_2tdp-Ed-ak6NoX_4Aeg_545674206")]
    [Description(@"Deadline by which the beneficial ownership of securities must be declared.")]
    CertificationDeadline,
    
    /// <summary>
    /// Last date on which a holder can consent to the changes sought by the corporation.
    /// Encoded/decoded by serializers as &quot;CEXD&quot;.
    /// </summary>
    [EnumMember(Value = "CEXD")]
    [IsoId("_bR_2ttp-Ed-ak6NoX_4Aeg_1578173148")]
    [Description(@"Last date on which a holder can consent to the changes sought by the corporation.")]
    ConsentExpirationDate,
    
    /// <summary>
    /// Date upon which the court provided approval.
    /// Encoded/decoded by serializers as &quot;COAP&quot;.
    /// </summary>
    [EnumMember(Value = "COAP")]
    [IsoId("_bR_2t9p-Ed-ak6NoX_4Aeg_545674613")]
    [Description(@"Date upon which the court provided approval.")]
    CourtApprovalDate,
    
    /// <summary>
    /// Date used by the offeror to determine the beneficiary eligible to participate in a consent based on the registered owner of the securities, for example, beneficial owner of consent record. Consent record date qualifier is used to indicate that a record date only applies to a certain part of the offer, not the entire offer.
    /// Encoded/decoded by serializers as &quot;CORD&quot;.
    /// </summary>
    [EnumMember(Value = "CORD")]
    [IsoId("_bR_2uNp-Ed-ak6NoX_4Aeg_2006686254")]
    [Description(@"Date used by the offeror to determine the beneficiary eligible to participate in a consent based on the registered owner of the securities, for example, beneficial owner of consent record. Consent record date qualifier is used to indicate that a record date only applies to a certain part of the offer, not the entire offer.")]
    ConsentRecordDate,
    
    /// <summary>
    /// Last day a holder can deliver the securities that it had elected on and/or previously protected.
    /// Encoded/decoded by serializers as &quot;CVPR&quot;.
    /// </summary>
    [EnumMember(Value = "CVPR")]
    [IsoId("_bSJAoNp-Ed-ak6NoX_4Aeg_545675041")]
    [Description(@"Last day a holder can deliver the securities that it had elected on and/or previously protected.")]
    CoverExpirationDate,
    
    /// <summary>
    /// Date on which a security will be entitled to a dividend.
    /// Encoded/decoded by serializers as &quot;DIVR&quot;.
    /// </summary>
    [EnumMember(Value = "DIVR")]
    [IsoId("_bSJAodp-Ed-ak6NoX_4Aeg_-1977054321")]
    [Description(@"Date on which a security will be entitled to a dividend.")]
    DividendRankingDate,
    
    /// <summary>
    /// Date on which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// Encoded/decoded by serializers as &quot;EARL&quot;.
    /// </summary>
    [EnumMember(Value = "EARL")]
    [IsoId("_bSJAotp-Ed-ak6NoX_4Aeg_-1943809478")]
    [Description(@"Date on which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.")]
    EarliestPaymentDate,
    
    /// <summary>
    /// Deadline by which an entitled holder needs to advise their counterparty to a transaction of their election for a corporate action event.
    /// Encoded/decoded by serializers as &quot;ECPD&quot;.
    /// </summary>
    [EnumMember(Value = "ECPD")]
    [IsoId("_bSJAo9p-Ed-ak6NoX_4Aeg_546597805")]
    [Description(@"Deadline by which an entitled holder needs to advise their counterparty to a transaction of their election for a corporate action event.")]
    ElectionToCounterpartyDeadline,
    
    /// <summary>
    /// Date on which a process is to be completed or becomes effective.
    /// Encoded/decoded by serializers as &quot;EFFD&quot;.
    /// </summary>
    [EnumMember(Value = "EFFD")]
    [IsoId("_bSJApNp-Ed-ak6NoX_4Aeg_545675136")]
    [Description(@"Date on which a process is to be completed or becomes effective.")]
    EffectiveDate,
    
    /// <summary>
    /// Date on which all or part of any holding bought in a unit trust is subject to being treated as capital rather than income. This is normally one day after the previous distribution&apos;s ex date.
    /// Encoded/decoded by serializers as &quot;EQUL&quot;.
    /// </summary>
    [EnumMember(Value = "EQUL")]
    [IsoId("_bSJApdp-Ed-ak6NoX_4Aeg_545675231")]
    [Description(@"Date on which all or part of any holding bought in a unit trust is subject to being treated as capital rather than income. This is normally one day after the previous distribution's ex date.")]
    EqualisationDate,
    
    /// <summary>
    /// Date on which an order expires or on which a privilege or offer terminates.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_bSJAptp-Ed-ak6NoX_4Aeg_458600807")]
    [Description(@"Date on which an order expires or on which a privilege or offer terminates.")]
    ExpiryDate,
    
    /// <summary>
    /// First day of the month that is a working day.
    /// Encoded/decoded by serializers as &quot;FBDM&quot;.
    /// </summary>
    [EnumMember(Value = "FBDM")]
    [IsoId("_bSJAp9p-Ed-ak6NoX_4Aeg_484457833")]
    [Description(@"First day of the month that is a working day.")]
    FirstBusinessDayOfMonth,
    
    /// <summary>
    /// First calendar day of the month.
    /// Encoded/decoded by serializers as &quot;FCDM&quot;.
    /// </summary>
    [EnumMember(Value = "FCDM")]
    [IsoId("_bSJAqNp-Ed-ak6NoX_4Aeg_531558457")]
    [Description(@"First calendar day of the month.")]
    FirstCalendarDayOfMonth,
    
    /// <summary>
    /// Date on which additional information on the event will be announced, for example, exchange ratio announcement date.
    /// Encoded/decoded by serializers as &quot;FDAT&quot;.
    /// </summary>
    [EnumMember(Value = "FDAT")]
    [IsoId("_bSJAqdp-Ed-ak6NoX_4Aeg_545675273")]
    [Description(@"Date on which additional information on the event will be announced, for example, exchange ratio announcement date.")]
    FurtherDetailedAnnouncementDate,
    
    /// <summary>
    /// Date on which a foreign exchange rate will be determined.
    /// Encoded/decoded by serializers as &quot;FXDT&quot;.
    /// </summary>
    [EnumMember(Value = "FXDT")]
    [IsoId("_bSSxoNp-Ed-ak6NoX_4Aeg_834473884")]
    [Description(@"Date on which a foreign exchange rate will be determined.")]
    CurrencyExchangeDate,
    
    /// <summary>
    /// Last date/time by which a buying counterparty to a trade can be sure that it will have the right to participate in an event.
    /// Encoded/decoded by serializers as &quot;GUPA&quot;.
    /// </summary>
    [EnumMember(Value = "GUPA")]
    [IsoId("_bSSxodp-Ed-ak6NoX_4Aeg_546597788")]
    [Description(@"Last date/time by which a buying counterparty to a trade can be sure that it will have the right to participate in an event.")]
    GuaranteedParticipationDate,
    
    /// <summary>
    /// Date/time at which an index rate will be determined.
    /// Encoded/decoded by serializers as &quot;IFIX&quot;.
    /// </summary>
    [EnumMember(Value = "IFIX")]
    [IsoId("_bSSxotp-Ed-ak6NoX_4Aeg_545675308")]
    [Description(@"Date/time at which an index rate will be determined.")]
    IndexFixingDate,
    
    /// <summary>
    /// Date on which instruction was sent.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_bSSxo9p-Ed-ak6NoX_4Aeg_887114495")]
    [Description(@"Date on which instruction was sent.")]
    InstructedDate,
    
    /// <summary>
    /// Last day of the month that is a working day.
    /// Encoded/decoded by serializers as &quot;LBDM&quot;.
    /// </summary>
    [EnumMember(Value = "LBDM")]
    [IsoId("_bSSxpNp-Ed-ak6NoX_4Aeg_913894181")]
    [Description(@"Last day of the month that is a working day.")]
    LastBusinessDayOfMonth,
    
    /// <summary>
    /// Last calendar day of the month.
    /// Encoded/decoded by serializers as &quot;LCDM&quot;.
    /// </summary>
    [EnumMember(Value = "LCDM")]
    [IsoId("_bSSxpdp-Ed-ak6NoX_4Aeg_933290258")]
    [Description(@"Last calendar day of the month.")]
    LastCalendarDayOfMonth,
    
    /// <summary>
    /// Date on which the lottery is run and applied to the holder&apos;s positions. This is also applicable to partial calls.
    /// Encoded/decoded by serializers as &quot;LOTO&quot;.
    /// </summary>
    [EnumMember(Value = "LOTO")]
    [IsoId("_bSSxptp-Ed-ak6NoX_4Aeg_545675568")]
    [Description(@"Date on which the lottery is run and applied to the holder's positions. This is also applicable to partial calls.")]
    LotteryDate,
    
    /// <summary>
    /// Date upon which interest bearing security becomes due and principal is paid.
    /// Encoded/decoded by serializers as &quot;MATU&quot;.
    /// </summary>
    [EnumMember(Value = "MATU")]
    [IsoId("_bSSxp9p-Ed-ak6NoX_4Aeg_545675603")]
    [Description(@"Date upon which interest bearing security becomes due and principal is paid.")]
    MaturityDate,
    
    /// <summary>
    /// Date on which the bondholders&apos; or shareholders&apos; meeting will take place.
    /// Encoded/decoded by serializers as &quot;MEET&quot;.
    /// </summary>
    [EnumMember(Value = "MEET")]
    [IsoId("_bScioNp-Ed-ak6NoX_4Aeg_545675988")]
    [Description(@"Date on which the bondholders' or shareholders' meeting will take place.")]
    MeetingDate,
    
    /// <summary>
    /// Date on which the company&apos;s general meeting is scheduled, second session if applicable, for example, Italy.
    /// Encoded/decoded by serializers as &quot;MET2&quot;.
    /// </summary>
    [EnumMember(Value = "MET2")]
    [IsoId("_bSciodp-Ed-ak6NoX_4Aeg_545676049")]
    [Description(@"Date on which the company's general meeting is scheduled, second session if applicable, for example, Italy.")]
    SecondMeetingDate,
    
    /// <summary>
    /// Date on which the company&apos;s general meeting is scheduled, third session if applicable, for example, Italy.
    /// Encoded/decoded by serializers as &quot;MET3&quot;.
    /// </summary>
    [EnumMember(Value = "MET3")]
    [IsoId("_bSciotp-Ed-ak6NoX_4Aeg_545676144")]
    [Description(@"Date on which the company's general meeting is scheduled, third session if applicable, for example, Italy.")]
    ThirdMeetingDate,
    
    /// <summary>
    /// Date/time at which the margin rate will be determined.
    /// Encoded/decoded by serializers as &quot;MFIX&quot;.
    /// </summary>
    [EnumMember(Value = "MFIX")]
    [IsoId("_bScio9p-Ed-ak6NoX_4Aeg_545676162")]
    [Description(@"Date/time at which the margin rate will be determined.")]
    MarginFixingDate,
    
    /// <summary>
    /// Issuer or issuer&apos;s agent deadline to respond, with an election instruction, to an outstanding offer or privilege.
    /// Encoded/decoded by serializers as &quot;MKDT&quot;.
    /// </summary>
    [EnumMember(Value = "MKDT")]
    [IsoId("_bScipNp-Ed-ak6NoX_4Aeg_1230664300")]
    [Description(@"Issuer or issuer's agent deadline to respond, with an election instruction, to an outstanding offer or privilege.")]
    MarketDeadline,
    
    /// <summary>
    /// Date on which the movement is due to take place (cash and/or securities).
    /// Encoded/decoded by serializers as &quot;PAYD&quot;.
    /// </summary>
    [EnumMember(Value = "PAYD")]
    [IsoId("_bScipdp-Ed-ak6NoX_4Aeg_1274067482")]
    [Description(@"Date on which the movement is due to take place (cash and/or securities).")]
    PaymentDate,
    
    /// <summary>
    /// Last date a holder can request to defer delivery of securities pursuant to a notice of guaranteed delivery or other required documentation.
    /// Encoded/decoded by serializers as &quot;PODT&quot;.
    /// </summary>
    [EnumMember(Value = "PODT")]
    [IsoId("_bSciptp-Ed-ak6NoX_4Aeg_545676222")]
    [Description(@"Last date a holder can request to defer delivery of securities pursuant to a notice of guaranteed delivery or other required documentation.")]
    ProtectDate,
    
    /// <summary>
    /// Date on which security will assimilate, become fungible, or have the same rights to dividends as the parent issue.
    /// Encoded/decoded by serializers as &quot;PPDT&quot;.
    /// </summary>
    [EnumMember(Value = "PPDT")]
    [IsoId("_bScip9p-Ed-ak6NoX_4Aeg_857601260")]
    [Description(@"Date on which security will assimilate, become fungible, or have the same rights to dividends as the parent issue.")]
    PariPassuDate,
    
    /// <summary>
    /// Date at which an issuer will determine the proration amount/quantity of an offer.
    /// Encoded/decoded by serializers as &quot;PROD&quot;.
    /// </summary>
    [EnumMember(Value = "PROD")]
    [IsoId("_bSciqNp-Ed-ak6NoX_4Aeg_545676499")]
    [Description(@"Date at which an issuer will determine the proration amount/quantity of an offer.")]
    ProrationDate,
    
    /// <summary>
    /// Date on which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// Encoded/decoded by serializers as &quot;RDDT&quot;.
    /// </summary>
    [EnumMember(Value = "RDDT")]
    [IsoId("_bSciqdp-Ed-ak6NoX_4Aeg_1347026649")]
    [Description(@"Date on which the account servicer has set as the deadline to respond, with instructions, to an outstanding event. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).")]
    ResponseDeadline,
    
    /// <summary>
    /// Date on which positions are struck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date.
    /// Encoded/decoded by serializers as &quot;RDTE&quot;.
    /// </summary>
    [EnumMember(Value = "RDTE")]
    [IsoId("_bSlskNp-Ed-ak6NoX_4Aeg_545676559")]
    [Description(@"Date on which positions are struck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date.")]
    RecordDate,
    
    /// <summary>
    /// Date on which instructions to register or registration details will be accepted.
    /// Encoded/decoded by serializers as &quot;REGI&quot;.
    /// </summary>
    [EnumMember(Value = "REGI")]
    [IsoId("_bSlskdp-Ed-ak6NoX_4Aeg_545676654")]
    [Description(@"Date on which instructions to register or registration details will be accepted.")]
    RegistrationDeadline,
    
    /// <summary>
    /// Date on which results are published, for example, results of an offer.
    /// Encoded/decoded by serializers as &quot;RESU&quot;.
    /// </summary>
    [EnumMember(Value = "RESU")]
    [IsoId("_bSlsktp-Ed-ak6NoX_4Aeg_545677039")]
    [Description(@"Date on which results are published, for example, results of an offer.")]
    ResultsPublicationDate,
    
    /// <summary>
    /// Deadline by which instructions must be received to split securities, for example, of physical certificates.
    /// Encoded/decoded by serializers as &quot;SPLT&quot;.
    /// </summary>
    [EnumMember(Value = "SPLT")]
    [IsoId("_bSlsk9p-Ed-ak6NoX_4Aeg_1417214216")]
    [Description(@"Deadline by which instructions must be received to split securities, for example, of physical certificates.")]
    SplitDeadline,
    
    /// <summary>
    /// Date by which cash must be in place in order to take part in the event.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_bSlslNp-Ed-ak6NoX_4Aeg_1476318053")]
    [Description(@"Date by which cash must be in place in order to take part in the event.")]
    SubscriptionCostDebitDate,
    
    /// <summary>
    /// Date/time as from which &apos;special processing&apos; can start to be used by participants for that event. Special processing is a means of marking a transaction, that would normally be traded ex or cum, as being traded cum or ex respectively, for example, a transaction dealt &apos;special&apos; after the ex date would result in the buyer&apos;s being eligible for the entitlement. This is typically used in the UK and Irish markets.
    /// Encoded/decoded by serializers as &quot;SXDT&quot;.
    /// </summary>
    [EnumMember(Value = "SXDT")]
    [IsoId("_bSlsldp-Ed-ak6NoX_4Aeg_546597728")]
    [Description(@"Date/time as from which 'special processing' can start to be used by participants for that event. Special processing is a means of marking a transaction, that would normally be traded ex or cum, as being traded cum or ex respectively, for example, a transaction dealt 'special' after the ex date would result in the buyer's being eligible for the entitlement. This is typically used in the UK and Irish markets.")]
    SpecialExDate,
    
    /// <summary>
    /// Date on until which tax breakdown instructions will be accepted.
    /// Encoded/decoded by serializers as &quot;TAXB&quot;.
    /// </summary>
    [EnumMember(Value = "TAXB")]
    [IsoId("_bSlsltp-Ed-ak6NoX_4Aeg_545677117")]
    [Description(@"Date on until which tax breakdown instructions will be accepted.")]
    DeadlineForTaxBreakdownInstructions,
    
    /// <summary>
    /// Date on which the trade was executed.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_bSlsl9p-Ed-ak6NoX_4Aeg_1939257507")]
    [Description(@"Date on which the trade was executed.")]
    TradeDateTime,
    
    /// <summary>
    /// Date on which trading of a security is suspended as the result of an event.
    /// Encoded/decoded by serializers as &quot;TSDT&quot;.
    /// </summary>
    [EnumMember(Value = "TSDT")]
    [IsoId("_bSlsmNp-Ed-ak6NoX_4Aeg_545677152")]
    [Description(@"Date on which trading of a security is suspended as the result of an event.")]
    TradingSuspendedDate,
    
    /// <summary>
    /// Date upon which the terms of the take-over become unconditional.
    /// Encoded/decoded by serializers as &quot;UNCO&quot;.
    /// </summary>
    [EnumMember(Value = "UNCO")]
    [IsoId("_bSlsmdp-Ed-ak6NoX_4Aeg_545677489")]
    [Description(@"Date upon which the terms of the take-over become unconditional.")]
    UnconditionalDate,
    
    /// <summary>
    /// Date on which assets become available to the account owner (in a credit entry), or cease to be available to the account owner (in a debit entry).
    /// Encoded/decoded by serializers as &quot;VALU&quot;.
    /// </summary>
    [EnumMember(Value = "VALU")]
    [IsoId("_bSlsmtp-Ed-ak6NoX_4Aeg_1874357883")]
    [Description(@"Date on which assets become available to the account owner (in a credit entry), or cease to be available to the account owner (in a debit entry).")]
    ValueDate,
    
    /// <summary>
    /// Date on which all conditions, including regulatory, legal etc. pertaining to the take-over, have been met.
    /// Encoded/decoded by serializers as &quot;WUCO&quot;.
    /// </summary>
    [EnumMember(Value = "WUCO")]
    [IsoId("_bSvdkNp-Ed-ak6NoX_4Aeg_545677549")]
    [Description(@"Date on which all conditions, including regulatory, legal etc. pertaining to the take-over, have been met.")]
    WhollyUnconditionalDate,
    
    /// <summary>
    /// Date as from which trading (including exchange and Over The Counter (OTC) trading) occurs on the underlying security without the benefit.
    /// Encoded/decoded by serializers as &quot;XDTE&quot;.
    /// </summary>
    [EnumMember(Value = "XDTE")]
    [IsoId("_bSvdkdp-Ed-ak6NoX_4Aeg_546597615")]
    [Description(@"Date as from which trading (including exchange and Over The Counter (OTC) trading) occurs on the underlying security without the benefit.")]
    ExDividendDate,
    
    /// <summary>
    /// Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event, giving the holder eligibility to incentives. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).
    /// Encoded/decoded by serializers as &quot;EARD&quot;.
    /// </summary>
    [EnumMember(Value = "EARD")]
    [IsoId("_bSvdktp-Ed-ak6NoX_4Aeg_333827875")]
    [Description(@"Date/time at which the account servicer has set as the deadline to respond, with instructions, to an outstanding event, giving the holder eligibility to incentives. This time is dependent on the reference time zone of the account servicer as specified in a Service Level Agreement (SLA).")]
    EarlyResponseDeadline,
    
}
