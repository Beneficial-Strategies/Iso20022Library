// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of corporate action options.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bLlst9p-Ed-ak6NoX_4Aeg_986310809")]
[Description(@"Specifies the type of corporate action options.")]
[DerivedFrom(typeof(CorporateActionOptionCode))]
public enum CorporateActionOption3Code
{
    /// <summary>
    /// Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting.|If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used.
    /// Encoded/decoded by serializers as &quot;ABST&quot;.
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_bLlsuNp-Ed-ak6NoX_4Aeg_986310839")]
    [Description(
        @"Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting.|If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used."
    )]
    Abstain = CorporateActionOptionCode.Abstain, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote against management.
    /// Encoded/decoded by serializers as &quot;AMGT&quot;.
    /// </summary>
    [EnumMember(Value = "AMGT")]
    [IsoId("_bLlsudp-Ed-ak6NoX_4Aeg_986310870")]
    [Description(@"Vote against management.")]
    VoteAgainstManagement = CorporateActionOptionCode.VoteAgainstManagement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receive equities from the share premium reserve of the company and considered as a capital distribution rather than a disbursement of income with different tax implications (typically found in Australia).
    /// Encoded/decoded by serializers as &quot;BSPL&quot;.
    /// </summary>
    [EnumMember(Value = "BSPL")]
    [IsoId("_bLvdsNp-Ed-ak6NoX_4Aeg_986310871")]
    [Description(
        @"Receive equities from the share premium reserve of the company and considered as a capital distribution rather than a disbursement of income with different tax implications (typically found in Australia)."
    )]
    BonusSharePlan = CorporateActionOptionCode.BonusSharePlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Buy additional securities to round up position.
    /// Encoded/decoded by serializers as &quot;BUYA&quot;.
    /// </summary>
    [EnumMember(Value = "BUYA")]
    [IsoId("_bLvdsdp-Ed-ak6NoX_4Aeg_986310900")]
    [Description(@"Buy additional securities to round up position.")]
    BuyUp = CorporateActionOptionCode.BuyUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option to choose between different security and cash options.
    /// Encoded/decoded by serializers as &quot;CASE&quot;.
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_bLvdstp-Ed-ak6NoX_4Aeg_986310901")]
    [Description(@"Option to choose between different security and cash options.")]
    CashAndSecurity = CorporateActionOptionCode.CashAndSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option to choose cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_bLvds9p-Ed-ak6NoX_4Aeg_986310931")]
    [Description(@"Option to choose cash.")]
    Cash = CorporateActionOptionCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to exchange securities.
    /// Encoded/decoded by serializers as &quot;CEXC&quot;.
    /// </summary>
    [EnumMember(Value = "CEXC")]
    [IsoId("_bLvdtNp-Ed-ak6NoX_4Aeg_986310962")]
    [Description(
        @"Vote to consent to change the terms of the securities agreement and to exchange securities."
    )]
    ConsentAndExchange = CorporateActionOptionCode.ConsentAndExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote not to approve the event or proposal.
    /// Encoded/decoded by serializers as &quot;CONN&quot;.
    /// </summary>
    [EnumMember(Value = "CONN")]
    [IsoId("_bLvdtdp-Ed-ak6NoX_4Aeg_986310963")]
    [Description(@"Vote not to approve the event or proposal.")]
    ConsentDenied = CorporateActionOptionCode.ConsentDenied, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote to approve the event or proposal.
    /// Encoded/decoded by serializers as &quot;CONY&quot;.
    /// </summary>
    [EnumMember(Value = "CONY")]
    [IsoId("_bLvdttp-Ed-ak6NoX_4Aeg_986310984")]
    [Description(@"Vote to approve the event or proposal.")]
    ConsentGranted = CorporateActionOptionCode.ConsentGranted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to tender securities for cash.
    /// Encoded/decoded by serializers as &quot;CTEN&quot;.
    /// </summary>
    [EnumMember(Value = "CTEN")]
    [IsoId("_bLvdt9p-Ed-ak6NoX_4Aeg_986310993")]
    [Description(
        @"Vote to consent to change the terms of the securities agreement and to tender securities for cash."
    )]
    ConsentAndTender = CorporateActionOptionCode.ConsentAndTender, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exercise intermediate securities or warrants.
    /// Encoded/decoded by serializers as &quot;EXER&quot;.
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_bLvduNp-Ed-ak6NoX_4Aeg_986311015")]
    [Description(@"Exercise intermediate securities or warrants.")]
    Exercise = CorporateActionOptionCode.Exercise, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Allow event or entitled security to expire.
    /// Encoded/decoded by serializers as &quot;LAPS&quot;.
    /// </summary>
    [EnumMember(Value = "LAPS")]
    [IsoId("_bLvdudp-Ed-ak6NoX_4Aeg_986311046")]
    [Description(@"Allow event or entitled security to expire.")]
    Lapse = CorporateActionOptionCode.Lapse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mark down the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).
    /// Encoded/decoded by serializers as &quot;MKDW&quot;.
    /// </summary>
    [EnumMember(Value = "MKDW")]
    [IsoId("_bL4noNp-Ed-ak6NoX_4Aeg_-2036969768")]
    [Description(
        @"Mark down the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs))."
    )]
    MarkDown = CorporateActionOptionCode.MarkDown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mark up the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).
    /// Encoded/decoded by serializers as &quot;MKUP&quot;.
    /// </summary>
    [EnumMember(Value = "MKUP")]
    [IsoId("_bL4nodp-Ed-ak6NoX_4Aeg_-1861497589")]
    [Description(
        @"Mark up the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs))."
    )]
    MarkUp = CorporateActionOptionCode.MarkUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote with management.
    /// Encoded/decoded by serializers as &quot;MNGT&quot;.
    /// </summary>
    [EnumMember(Value = "MNGT")]
    [IsoId("_bL4notp-Ed-ak6NoX_4Aeg_986311293")]
    [Description(@"Vote with management.")]
    VoteWithManagement = CorporateActionOptionCode.VoteWithManagement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option that allows a holder to elect to retain their holding, for example, a putable bond.
    /// Encoded/decoded by serializers as &quot;MPUT&quot;.
    /// </summary>
    [EnumMember(Value = "MPUT")]
    [IsoId("_bL4no9p-Ed-ak6NoX_4Aeg_986311294")]
    [Description(
        @"Option that allows a holder to elect to retain their holding, for example, a putable bond."
    )]
    Retain = CorporateActionOptionCode.Retain, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option for the account owner not to take part in the event. This would include opt-out for class actions and lodging of dissenters&apos; rights.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_bL4npNp-Ed-ak6NoX_4Aeg_986311303")]
    [Description(
        @"Option for the account owner not to take part in the event. This would include opt-out for class actions and lodging of dissenters' rights."
    )]
    NoAction = CorporateActionOptionCode.NoAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account owner is a non-qualified investor.
    /// Encoded/decoded by serializers as &quot;NOQU&quot;.
    /// </summary>
    [EnumMember(Value = "NOQU")]
    [IsoId("_bL4npdp-Ed-ak6NoX_4Aeg_986311324")]
    [Description(@"Account owner is a non-qualified investor.")]
    NonQualifiedInvestor = CorporateActionOptionCode.NonQualifiedInvestor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period.
    /// Encoded/decoded by serializers as &quot;OFFR&quot;.
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_bL4nptp-Ed-ak6NoX_4Aeg_986311325")]
    [Description(
        @"In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period."
    )]
    ProposedRate = CorporateActionOptionCode.ProposedRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Generic corporate action option to be used in case that no other specific code is appropriate.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bL4np9p-Ed-ak6NoX_4Aeg_986311334")]
    [Description(
        @"Generic corporate action option to be used in case that no other specific code is appropriate."
    )]
    Other = CorporateActionOptionCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Subscribe to more equities than underlying securities position allows.
    /// Encoded/decoded by serializers as &quot;OVER&quot;.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_bL4nqNp-Ed-ak6NoX_4Aeg_986311354")]
    [Description(@"Subscribe to more equities than underlying securities position allows.")]
    Oversubscribe = CorporateActionOptionCode.Oversubscribe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issue a proxy card in case of voting.
    /// Encoded/decoded by serializers as &quot;PROX&quot;.
    /// </summary>
    [EnumMember(Value = "PROX")]
    [IsoId("_bL4nqdp-Ed-ak6NoX_4Aeg_986311355")]
    [Description(@"Issue a proxy card in case of voting.")]
    ProxyCard = CorporateActionOptionCode.ProxyCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account owner is a qualified investor.
    /// Encoded/decoded by serializers as &quot;QINV&quot;.
    /// </summary>
    [EnumMember(Value = "QINV")]
    [IsoId("_bL4nqtp-Ed-ak6NoX_4Aeg_986311356")]
    [Description(@"Account owner is a qualified investor.")]
    QualifiedInvestor = CorporateActionOptionCode.QualifiedInvestor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of securities to holders.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_bMCYoNp-Ed-ak6NoX_4Aeg_986311385")]
    [Description(@"Distribution of securities to holders.")]
    Security = CorporateActionOptionCode.Security, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sell the intermediate securities.
    /// Encoded/decoded by serializers as &quot;SLLE&quot;.
    /// </summary>
    [EnumMember(Value = "SLLE")]
    [IsoId("_bMCYodp-Ed-ak6NoX_4Aeg_986311386")]
    [Description(@"Sell the intermediate securities.")]
    SellEntitlement = CorporateActionOptionCode.SellEntitlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option to give a split instruction, for example, a split voting instruction on a meeting.
    /// Encoded/decoded by serializers as &quot;SPLI&quot;.
    /// </summary>
    [EnumMember(Value = "SPLI")]
    [IsoId("_bMCYotp-Ed-ak6NoX_4Aeg_986311387")]
    [Description(
        @"Option to give a split instruction, for example, a split voting instruction on a meeting."
    )]
    SplitInstruction = CorporateActionOptionCode.SplitInstruction, // same ordinal as derivation source for type conversions
}
