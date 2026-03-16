// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of corporate action options.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DnUSwe33Eeqc-LCjwLsUVg")]
[Description(@"Specifies the type of corporate action options.")]
[DerivedFrom(typeof(CorporateActionOptionCode))]
public enum CorporateActionOption15Code
{
    /// <summary>
    /// Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting.|If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used.
    /// Encoded/decoded by serializers as &quot;ABST&quot;.
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_D6zPce33Eeqc-LCjwLsUVg")]
    [Description(
        @"Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting.|If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used."
    )]
    Abstain = CorporateActionOptionCode.Abstain, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receive equities from the share premium reserve of the company and considered as a capital distribution rather than a disbursement of income with different tax implications (typically found in Australia).
    /// Encoded/decoded by serializers as &quot;BSPL&quot;.
    /// </summary>
    [EnumMember(Value = "BSPL")]
    [IsoId("_D6zPc-33Eeqc-LCjwLsUVg")]
    [Description(
        @"Receive equities from the share premium reserve of the company and considered as a capital distribution rather than a disbursement of income with different tax implications (typically found in Australia)."
    )]
    BonusSharePlan = CorporateActionOptionCode.BonusSharePlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Buy additional securities to round up position.
    /// Encoded/decoded by serializers as &quot;BUYA&quot;.
    /// </summary>
    [EnumMember(Value = "BUYA")]
    [IsoId("_D6zPde33Eeqc-LCjwLsUVg")]
    [Description(@"Buy additional securities to round up position.")]
    BuyUp = CorporateActionOptionCode.BuyUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option to choose between different security and cash options.
    /// Encoded/decoded by serializers as &quot;CASE&quot;.
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_D6zPd-33Eeqc-LCjwLsUVg")]
    [Description(@"Option to choose between different security and cash options.")]
    CashAndSecurity = CorporateActionOptionCode.CashAndSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option to choose cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_D6zPee33Eeqc-LCjwLsUVg")]
    [Description(@"Option to choose cash.")]
    Cash = CorporateActionOptionCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to exchange securities.
    /// Encoded/decoded by serializers as &quot;CEXC&quot;.
    /// </summary>
    [EnumMember(Value = "CEXC")]
    [IsoId("_D6zPe-33Eeqc-LCjwLsUVg")]
    [Description(
        @"Vote to consent to change the terms of the securities agreement and to exchange securities."
    )]
    ConsentAndExchange = CorporateActionOptionCode.ConsentAndExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote not to approve the event or proposal.
    /// Encoded/decoded by serializers as &quot;CONN&quot;.
    /// </summary>
    [EnumMember(Value = "CONN")]
    [IsoId("_D6zPfe33Eeqc-LCjwLsUVg")]
    [Description(@"Vote not to approve the event or proposal.")]
    ConsentDenied = CorporateActionOptionCode.ConsentDenied, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote to approve the event or proposal.
    /// Encoded/decoded by serializers as &quot;CONY&quot;.
    /// </summary>
    [EnumMember(Value = "CONY")]
    [IsoId("_D6zPf-33Eeqc-LCjwLsUVg")]
    [Description(@"Vote to approve the event or proposal.")]
    ConsentGranted = CorporateActionOptionCode.ConsentGranted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to tender securities for cash.
    /// Encoded/decoded by serializers as &quot;CTEN&quot;.
    /// </summary>
    [EnumMember(Value = "CTEN")]
    [IsoId("_D6zPge33Eeqc-LCjwLsUVg")]
    [Description(
        @"Vote to consent to change the terms of the securities agreement and to tender securities for cash."
    )]
    ConsentAndTender = CorporateActionOptionCode.ConsentAndTender, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exercise intermediate securities or warrants.
    /// Encoded/decoded by serializers as &quot;EXER&quot;.
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_D6zPg-33Eeqc-LCjwLsUVg")]
    [Description(@"Exercise intermediate securities or warrants.")]
    Exercise = CorporateActionOptionCode.Exercise, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Allow event or entitled security to expire.
    /// Encoded/decoded by serializers as &quot;LAPS&quot;.
    /// </summary>
    [EnumMember(Value = "LAPS")]
    [IsoId("_D6zPhe33Eeqc-LCjwLsUVg")]
    [Description(@"Allow event or entitled security to expire.")]
    Lapse = CorporateActionOptionCode.Lapse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option that allows a holder to elect to retain their holding, for example, a putable bond.
    /// Encoded/decoded by serializers as &quot;MPUT&quot;.
    /// </summary>
    [EnumMember(Value = "MPUT")]
    [IsoId("_D6zPh-33Eeqc-LCjwLsUVg")]
    [Description(
        @"Option that allows a holder to elect to retain their holding, for example, a putable bond."
    )]
    Retain = CorporateActionOptionCode.Retain, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option for the account owner not to take part in the event. This would include opt-out for class actions and lodging of dissenters&apos; rights.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_D6zPie33Eeqc-LCjwLsUVg")]
    [Description(
        @"Option for the account owner not to take part in the event. This would include opt-out for class actions and lodging of dissenters' rights."
    )]
    NoAction = CorporateActionOptionCode.NoAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account owner is a non-qualified investor.
    /// Encoded/decoded by serializers as &quot;NOQU&quot;.
    /// </summary>
    [EnumMember(Value = "NOQU")]
    [IsoId("_D6zPi-33Eeqc-LCjwLsUVg")]
    [Description(@"Account owner is a non-qualified investor.")]
    NonQualifiedInvestor = CorporateActionOptionCode.NonQualifiedInvestor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period.
    /// Encoded/decoded by serializers as &quot;OFFR&quot;.
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_D6zPje33Eeqc-LCjwLsUVg")]
    [Description(
        @"In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period."
    )]
    ProposedRate = CorporateActionOptionCode.ProposedRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Generic corporate action option to be used in case that no other specific code is appropriate.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_D6zPj-33Eeqc-LCjwLsUVg")]
    [Description(
        @"Generic corporate action option to be used in case that no other specific code is appropriate."
    )]
    Other = CorporateActionOptionCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Subscribe to more equities than underlying securities position allows.
    /// Encoded/decoded by serializers as &quot;OVER&quot;.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_D6zPke33Eeqc-LCjwLsUVg")]
    [Description(@"Subscribe to more equities than underlying securities position allows.")]
    Oversubscribe = CorporateActionOptionCode.Oversubscribe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account owner is a qualified investor.
    /// Encoded/decoded by serializers as &quot;QINV&quot;.
    /// </summary>
    [EnumMember(Value = "QINV")]
    [IsoId("_D6zPk-33Eeqc-LCjwLsUVg")]
    [Description(@"Account owner is a qualified investor.")]
    QualifiedInvestor = CorporateActionOptionCode.QualifiedInvestor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of securities to holders.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_D6zPle33Eeqc-LCjwLsUVg")]
    [Description(@"Distribution of securities to holders.")]
    Security = CorporateActionOptionCode.Security, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sell the intermediate securities.
    /// Encoded/decoded by serializers as &quot;SLLE&quot;.
    /// </summary>
    [EnumMember(Value = "SLLE")]
    [IsoId("_D6zPl-33Eeqc-LCjwLsUVg")]
    [Description(@"Sell the intermediate securities.")]
    SellEntitlement = CorporateActionOptionCode.SellEntitlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Proceeds not known during election period. The option can result in cash and/or securities.
    /// Encoded/decoded by serializers as &quot;PRUN&quot;.
    /// </summary>
    [EnumMember(Value = "PRUN")]
    [IsoId("_D6zPme33Eeqc-LCjwLsUVg")]
    [Description(
        @"Proceeds not known during election period. The option can result in cash and/or securities."
    )]
    UnknownProceeds = CorporateActionOptionCode.UnknownProceeds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Breakdown of beneficial ownership required for withholding tax reclaim event.
    /// Encoded/decoded by serializers as &quot;BOBD&quot;.
    /// </summary>
    [EnumMember(Value = "BOBD")]
    [IsoId("_dhiZEe33Eeqc-LCjwLsUVg")]
    [Description(@"Breakdown of beneficial ownership required for withholding tax reclaim event.")]
    BeneficialOwnerBreakdownRequest = CorporateActionOptionCode.BeneficialOwnerBreakdownRequest, // same ordinal as derivation source for type conversions
}
