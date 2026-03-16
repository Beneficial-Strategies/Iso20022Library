// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of corporate action options.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_i7YxkQFFEeGHSK1dK4hfWA")]
[Description(@"Specifies the type of corporate action options.")]
[DerivedFrom(typeof(CorporateActionOptionCode))]
public enum CorporateActionOption7Code
{
    /// <summary>
    /// Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting.|If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used.
    /// Encoded/decoded by serializers as &quot;ABST&quot;.
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_i7iilQFFEeGHSK1dK4hfWA")]
    [Description(
        @"Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting.|If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used."
    )]
    Abstain = CorporateActionOptionCode.Abstain, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote against management.
    /// Encoded/decoded by serializers as &quot;AMGT&quot;.
    /// </summary>
    [EnumMember(Value = "AMGT")]
    [IsoId("_i7iimQFFEeGHSK1dK4hfWA")]
    [Description(@"Vote against management.")]
    VoteAgainstManagement = CorporateActionOptionCode.VoteAgainstManagement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receive equities from the share premium reserve of the company and considered as a capital distribution rather than a disbursement of income with different tax implications (typically found in Australia).
    /// Encoded/decoded by serializers as &quot;BSPL&quot;.
    /// </summary>
    [EnumMember(Value = "BSPL")]
    [IsoId("_i7iinQFFEeGHSK1dK4hfWA")]
    [Description(
        @"Receive equities from the share premium reserve of the company and considered as a capital distribution rather than a disbursement of income with different tax implications (typically found in Australia)."
    )]
    BonusSharePlan = CorporateActionOptionCode.BonusSharePlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Buy additional securities to round up position.
    /// Encoded/decoded by serializers as &quot;BUYA&quot;.
    /// </summary>
    [EnumMember(Value = "BUYA")]
    [IsoId("_i7iioQFFEeGHSK1dK4hfWA")]
    [Description(@"Buy additional securities to round up position.")]
    BuyUp = CorporateActionOptionCode.BuyUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option to choose between different security and cash options.
    /// Encoded/decoded by serializers as &quot;CASE&quot;.
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_i7iipQFFEeGHSK1dK4hfWA")]
    [Description(@"Option to choose between different security and cash options.")]
    CashAndSecurity = CorporateActionOptionCode.CashAndSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option to choose cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_i7iiqQFFEeGHSK1dK4hfWA")]
    [Description(@"Option to choose cash.")]
    Cash = CorporateActionOptionCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to exchange securities.
    /// Encoded/decoded by serializers as &quot;CEXC&quot;.
    /// </summary>
    [EnumMember(Value = "CEXC")]
    [IsoId("_i7iirQFFEeGHSK1dK4hfWA")]
    [Description(
        @"Vote to consent to change the terms of the securities agreement and to exchange securities."
    )]
    ConsentAndExchange = CorporateActionOptionCode.ConsentAndExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote not to approve the event or proposal.
    /// Encoded/decoded by serializers as &quot;CONN&quot;.
    /// </summary>
    [EnumMember(Value = "CONN")]
    [IsoId("_i7iisQFFEeGHSK1dK4hfWA")]
    [Description(@"Vote not to approve the event or proposal.")]
    ConsentDenied = CorporateActionOptionCode.ConsentDenied, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote to approve the event or proposal.
    /// Encoded/decoded by serializers as &quot;CONY&quot;.
    /// </summary>
    [EnumMember(Value = "CONY")]
    [IsoId("_i7iitQFFEeGHSK1dK4hfWA")]
    [Description(@"Vote to approve the event or proposal.")]
    ConsentGranted = CorporateActionOptionCode.ConsentGranted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to tender securities for cash.
    /// Encoded/decoded by serializers as &quot;CTEN&quot;.
    /// </summary>
    [EnumMember(Value = "CTEN")]
    [IsoId("_i7iiuQFFEeGHSK1dK4hfWA")]
    [Description(
        @"Vote to consent to change the terms of the securities agreement and to tender securities for cash."
    )]
    ConsentAndTender = CorporateActionOptionCode.ConsentAndTender, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exercise intermediate securities or warrants.
    /// Encoded/decoded by serializers as &quot;EXER&quot;.
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_i7iivQFFEeGHSK1dK4hfWA")]
    [Description(@"Exercise intermediate securities or warrants.")]
    Exercise = CorporateActionOptionCode.Exercise, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Allow event or entitled security to expire.
    /// Encoded/decoded by serializers as &quot;LAPS&quot;.
    /// </summary>
    [EnumMember(Value = "LAPS")]
    [IsoId("_i7iiwQFFEeGHSK1dK4hfWA")]
    [Description(@"Allow event or entitled security to expire.")]
    Lapse = CorporateActionOptionCode.Lapse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote with management.
    /// Encoded/decoded by serializers as &quot;MNGT&quot;.
    /// </summary>
    [EnumMember(Value = "MNGT")]
    [IsoId("_i7iixQFFEeGHSK1dK4hfWA")]
    [Description(@"Vote with management.")]
    VoteWithManagement = CorporateActionOptionCode.VoteWithManagement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option that allows a holder to elect to retain their holding, for example, a putable bond.
    /// Encoded/decoded by serializers as &quot;MPUT&quot;.
    /// </summary>
    [EnumMember(Value = "MPUT")]
    [IsoId("_i7iiyQFFEeGHSK1dK4hfWA")]
    [Description(
        @"Option that allows a holder to elect to retain their holding, for example, a putable bond."
    )]
    Retain = CorporateActionOptionCode.Retain, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option for the account owner not to take part in the event. This would include opt-out for class actions and lodging of dissenters&apos; rights.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_i7iizQFFEeGHSK1dK4hfWA")]
    [Description(
        @"Option for the account owner not to take part in the event. This would include opt-out for class actions and lodging of dissenters' rights."
    )]
    NoAction = CorporateActionOptionCode.NoAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account owner is a non-qualified investor.
    /// Encoded/decoded by serializers as &quot;NOQU&quot;.
    /// </summary>
    [EnumMember(Value = "NOQU")]
    [IsoId("_i7ii0QFFEeGHSK1dK4hfWA")]
    [Description(@"Account owner is a non-qualified investor.")]
    NonQualifiedInvestor = CorporateActionOptionCode.NonQualifiedInvestor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period.
    /// Encoded/decoded by serializers as &quot;OFFR&quot;.
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_i7ii1QFFEeGHSK1dK4hfWA")]
    [Description(
        @"In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period."
    )]
    ProposedRate = CorporateActionOptionCode.ProposedRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Generic corporate action option to be used in case that no other specific code is appropriate.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_i7ii2QFFEeGHSK1dK4hfWA")]
    [Description(
        @"Generic corporate action option to be used in case that no other specific code is appropriate."
    )]
    Other = CorporateActionOptionCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Subscribe to more equities than underlying securities position allows.
    /// Encoded/decoded by serializers as &quot;OVER&quot;.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_i7ii3QFFEeGHSK1dK4hfWA")]
    [Description(@"Subscribe to more equities than underlying securities position allows.")]
    Oversubscribe = CorporateActionOptionCode.Oversubscribe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issue a proxy card in case of voting.
    /// Encoded/decoded by serializers as &quot;PROX&quot;.
    /// </summary>
    [EnumMember(Value = "PROX")]
    [IsoId("_i7ii4QFFEeGHSK1dK4hfWA")]
    [Description(@"Issue a proxy card in case of voting.")]
    ProxyCard = CorporateActionOptionCode.ProxyCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account owner is a qualified investor.
    /// Encoded/decoded by serializers as &quot;QINV&quot;.
    /// </summary>
    [EnumMember(Value = "QINV")]
    [IsoId("_i7ii5QFFEeGHSK1dK4hfWA")]
    [Description(@"Account owner is a qualified investor.")]
    QualifiedInvestor = CorporateActionOptionCode.QualifiedInvestor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of securities to holders.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_i7ii6QFFEeGHSK1dK4hfWA")]
    [Description(@"Distribution of securities to holders.")]
    Security = CorporateActionOptionCode.Security, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sell the intermediate securities.
    /// Encoded/decoded by serializers as &quot;SLLE&quot;.
    /// </summary>
    [EnumMember(Value = "SLLE")]
    [IsoId("_i7ii7QFFEeGHSK1dK4hfWA")]
    [Description(@"Sell the intermediate securities.")]
    SellEntitlement = CorporateActionOptionCode.SellEntitlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option to give a split instruction, for example, a split voting instruction on a meeting.
    /// Encoded/decoded by serializers as &quot;SPLI&quot;.
    /// </summary>
    [EnumMember(Value = "SPLI")]
    [IsoId("_i7ii8QFFEeGHSK1dK4hfWA")]
    [Description(
        @"Option to give a split instruction, for example, a split voting instruction on a meeting."
    )]
    SplitInstruction = CorporateActionOptionCode.SplitInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Proceeds not known during election period. The option can result in cash and/or securities.
    /// Encoded/decoded by serializers as &quot;PRUN&quot;.
    /// </summary>
    [EnumMember(Value = "PRUN")]
    [IsoId("_kEtKHgFFEeGHSK1dK4hfWA")]
    [Description(
        @"Proceeds not known during election period. The option can result in cash and/or securities."
    )]
    UnknownProceeds = CorporateActionOptionCode.UnknownProceeds, // same ordinal as derivation source for type conversions
}
