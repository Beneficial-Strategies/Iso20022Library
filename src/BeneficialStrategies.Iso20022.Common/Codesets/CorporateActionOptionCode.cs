// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of corporate action options offered to the account holder for a corporate action.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bM7wg9p-Ed-ak6NoX_4Aeg_962956293")]
[Description(@"Specifies the type of corporate action options offered to the account holder for a corporate action.")]
[Derivations(typeof(CorporateActionOption16Code),typeof(CorporateActionOption2Code),typeof(CorporateActionOption9Code),typeof(CorporateActionOption6Code),typeof(CorporateActionOption17Code),typeof(CorporateActionOption10Code),typeof(CorporateActionOption11Code),typeof(CorporateActionOption4Code),typeof(CorporateActionOption14Code),typeof(CorporateActionOption7Code),typeof(CorporateActionOption5Code),typeof(CorporateActionOption12Code),typeof(CorporateActionOption15Code),typeof(CorporateActionOption8Code),typeof(CorporateActionOption13Code),typeof(CorporateActionOption3Code))]
public enum CorporateActionOptionCode
{
    /// <summary>
    /// Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting.|If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used.
    /// Encoded/decoded by serializers as &quot;ABST&quot;.
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_bM7whNp-Ed-ak6NoX_4Aeg_-366634623")]
    [Description(@"Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting.|If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used.")]
    Abstain,
    
    /// <summary>
    /// Receive equities from the share premium reserve of the company and considered as a capital distribution rather than a disbursement of income with different tax implications (typically found in Australia).
    /// Encoded/decoded by serializers as &quot;BSPL&quot;.
    /// </summary>
    [EnumMember(Value = "BSPL")]
    [IsoId("_bM7whdp-Ed-ak6NoX_4Aeg_-366634588")]
    [Description(@"Receive equities from the share premium reserve of the company and considered as a capital distribution rather than a disbursement of income with different tax implications (typically found in Australia).")]
    BonusSharePlan,
    
    /// <summary>
    /// Buy additional securities to round up position.
    /// Encoded/decoded by serializers as &quot;BUYA&quot;.
    /// </summary>
    [EnumMember(Value = "BUYA")]
    [IsoId("_bM7whtp-Ed-ak6NoX_4Aeg_-366634587")]
    [Description(@"Buy additional securities to round up position.")]
    BuyUp,
    
    /// <summary>
    /// Certification is provided.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_bM7wh9p-Ed-ak6NoX_4Aeg_-1437285432")]
    [Description(@"Certification is provided.")]
    Certification,
    
    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to exchange securities.
    /// Encoded/decoded by serializers as &quot;CEXC&quot;.
    /// </summary>
    [EnumMember(Value = "CEXC")]
    [IsoId("_bM7wiNp-Ed-ak6NoX_4Aeg_-366634215")]
    [Description(@"Vote to consent to change the terms of the securities agreement and to exchange securities.")]
    ConsentAndExchange,
    
    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to tender securities for cash.
    /// Encoded/decoded by serializers as &quot;CTEN&quot;.
    /// </summary>
    [EnumMember(Value = "CTEN")]
    [IsoId("_bNE6cNp-Ed-ak6NoX_4Aeg_-366634190")]
    [Description(@"Vote to consent to change the terms of the securities agreement and to tender securities for cash.")]
    ConsentAndTender,
    
    /// <summary>
    /// Vote not to approve the event or proposal.
    /// Encoded/decoded by serializers as &quot;CONN&quot;.
    /// </summary>
    [EnumMember(Value = "CONN")]
    [IsoId("_bQpy4Np-Ed-ak6NoX_4Aeg_-366634120")]
    [Description(@"Vote not to approve the event or proposal.")]
    ConsentDenied,
    
    /// <summary>
    /// Vote to approve the event or proposal.
    /// Encoded/decoded by serializers as &quot;CONY&quot;.
    /// </summary>
    [EnumMember(Value = "CONY")]
    [IsoId("_bQpy4dp-Ed-ak6NoX_4Aeg_-366633830")]
    [Description(@"Vote to approve the event or proposal.")]
    ConsentGranted,
    
    /// <summary>
    /// Exercise intermediate securities or warrants.
    /// Encoded/decoded by serializers as &quot;EXER&quot;.
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_bQpy4tp-Ed-ak6NoX_4Aeg_-366633787")]
    [Description(@"Exercise intermediate securities or warrants.")]
    Exercise,
    
    /// <summary>
    /// Allow event or entitled security to expire.
    /// Encoded/decoded by serializers as &quot;LAPS&quot;.
    /// </summary>
    [EnumMember(Value = "LAPS")]
    [IsoId("_bQpy49p-Ed-ak6NoX_4Aeg_-366633717")]
    [Description(@"Allow event or entitled security to expire.")]
    Lapse,
    
    /// <summary>
    /// Mark down the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).
    /// Encoded/decoded by serializers as &quot;MKDW&quot;.
    /// </summary>
    [EnumMember(Value = "MKDW")]
    [IsoId("_bQpy5Np-Ed-ak6NoX_4Aeg_28619625")]
    [Description(@"Mark down the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).")]
    MarkDown,
    
    /// <summary>
    /// Mark up the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).
    /// Encoded/decoded by serializers as &quot;MKUP&quot;.
    /// </summary>
    [EnumMember(Value = "MKUP")]
    [IsoId("_bQpy5dp-Ed-ak6NoX_4Aeg_112661384")]
    [Description(@"Mark up the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).")]
    MarkUp,
    
    /// <summary>
    /// Account owner is a non-qualified investor.
    /// Encoded/decoded by serializers as &quot;NOQU&quot;.
    /// </summary>
    [EnumMember(Value = "NOQU")]
    [IsoId("_bQpy5tp-Ed-ak6NoX_4Aeg_1880634298")]
    [Description(@"Account owner is a non-qualified investor.")]
    NonQualifiedInvestor,
    
    /// <summary>
    /// Generic corporate action option to be used in case that no other specific code is appropriate.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bQpy59p-Ed-ak6NoX_4Aeg_1964672759")]
    [Description(@"Generic corporate action option to be used in case that no other specific code is appropriate.")]
    Other,
    
    /// <summary>
    /// Subscribe to more equities than underlying securities position allows.
    /// Encoded/decoded by serializers as &quot;OVER&quot;.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_bQpy6Np-Ed-ak6NoX_4Aeg_-359245951")]
    [Description(@"Subscribe to more equities than underlying securities position allows.")]
    Oversubscribe,
    
    /// <summary>
    /// In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period.
    /// Encoded/decoded by serializers as &quot;OFFR&quot;.
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_bQzj4Np-Ed-ak6NoX_4Aeg_-359246478")]
    [Description(@"In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period.")]
    ProposedRate,
    
    /// <summary>
    /// Issue a proxy card in case of voting.
    /// Encoded/decoded by serializers as &quot;PROX&quot;.
    /// </summary>
    [EnumMember(Value = "PROX")]
    [IsoId("_bQzj4dp-Ed-ak6NoX_4Aeg_-359245943")]
    [Description(@"Issue a proxy card in case of voting.")]
    ProxyCard,
    
    /// <summary>
    /// Account owner is a qualified investor.
    /// Encoded/decoded by serializers as &quot;QINV&quot;.
    /// </summary>
    [EnumMember(Value = "QINV")]
    [IsoId("_bQzj4tp-Ed-ak6NoX_4Aeg_-1934104529")]
    [Description(@"Account owner is a qualified investor.")]
    QualifiedInvestor,
    
    /// <summary>
    /// Option that allows a holder to elect to retain their holding, for example, a putable bond.
    /// Encoded/decoded by serializers as &quot;MPUT&quot;.
    /// </summary>
    [EnumMember(Value = "MPUT")]
    [IsoId("_bQzj49p-Ed-ak6NoX_4Aeg_-366633597")]
    [Description(@"Option that allows a holder to elect to retain their holding, for example, a putable bond.")]
    Retain,
    
    /// <summary>
    /// Sell the intermediate securities.
    /// Encoded/decoded by serializers as &quot;SLLE&quot;.
    /// </summary>
    [EnumMember(Value = "SLLE")]
    [IsoId("_bQzj5Np-Ed-ak6NoX_4Aeg_-359245601")]
    [Description(@"Sell the intermediate securities.")]
    SellEntitlement,
    
    /// <summary>
    /// Option to give a split instruction, for example, a split voting instruction on a meeting.
    /// Encoded/decoded by serializers as &quot;SPLI&quot;.
    /// </summary>
    [EnumMember(Value = "SPLI")]
    [IsoId("_bQzj5dp-Ed-ak6NoX_4Aeg_-359245600")]
    [Description(@"Option to give a split instruction, for example, a split voting instruction on a meeting.")]
    SplitInstruction,
    
    /// <summary>
    /// Tax instruction.
    /// Encoded/decoded by serializers as &quot;TAXI&quot;.
    /// </summary>
    [EnumMember(Value = "TAXI")]
    [IsoId("_bQzj5tp-Ed-ak6NoX_4Aeg_1746924196")]
    [Description(@"Tax instruction.")]
    TaxInstruction,
    
    /// <summary>
    /// Vote against management.
    /// Encoded/decoded by serializers as &quot;AMGT&quot;.
    /// </summary>
    [EnumMember(Value = "AMGT")]
    [IsoId("_bQzj59p-Ed-ak6NoX_4Aeg_-366634606")]
    [Description(@"Vote against management.")]
    VoteAgainstManagement,
    
    /// <summary>
    /// Vote with management.
    /// Encoded/decoded by serializers as &quot;MNGT&quot;.
    /// </summary>
    [EnumMember(Value = "MNGT")]
    [IsoId("_bQzj6Np-Ed-ak6NoX_4Aeg_-366633632")]
    [Description(@"Vote with management.")]
    VoteWithManagement,
    
    /// <summary>
    /// Distribution of securities to holders.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_bQzj6dp-Ed-ak6NoX_4Aeg_-1049990588")]
    [Description(@"Distribution of securities to holders.")]
    Security,
    
    /// <summary>
    /// Option to choose cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_bQ8t0Np-Ed-ak6NoX_4Aeg_-1005660786")]
    [Description(@"Option to choose cash.")]
    Cash,
    
    /// <summary>
    /// Option to choose between different security and cash options.
    /// Encoded/decoded by serializers as &quot;CASE&quot;.
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_bQ8t0dp-Ed-ak6NoX_4Aeg_-989038385")]
    [Description(@"Option to choose between different security and cash options.")]
    CashAndSecurity,
    
    /// <summary>
    /// Option for the account owner not to take part in the event. This would include opt-out for class actions and lodging of dissenters&apos; rights.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_bQ8t0tp-Ed-ak6NoX_4Aeg_-948402361")]
    [Description(@"Option for the account owner not to take part in the event. This would include opt-out for class actions and lodging of dissenters' rights.")]
    NoAction,
    
    /// <summary>
    /// Proceeds not known during election period. The option can result in cash and/or securities.
    /// Encoded/decoded by serializers as &quot;PRUN&quot;.
    /// </summary>
    [EnumMember(Value = "PRUN")]
    [IsoId("_no4M5_odEeC7qvRLUh5UBA")]
    [Description(@"Proceeds not known during election period. The option can result in cash and/or securities.")]
    UnknownProceeds,
    
    /// <summary>
    /// Breakdown of beneficial ownership required for withholding tax reclaim event.
    /// Encoded/decoded by serializers as &quot;BOBD&quot;.
    /// </summary>
    [EnumMember(Value = "BOBD")]
    [IsoId("_ScCrUO33Eeqc-LCjwLsUVg")]
    [Description(@"Breakdown of beneficial ownership required for withholding tax reclaim event.")]
    BeneficialOwnerBreakdownRequest,
    
}
