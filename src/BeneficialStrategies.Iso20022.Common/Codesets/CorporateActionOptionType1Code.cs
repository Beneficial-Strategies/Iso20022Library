// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of CA options.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bQ8t09p-Ed-ak6NoX_4Aeg_1430508802")]
[Description(@"Specifies the type of CA options.")]
[DerivedFrom(typeof(CorporateActionOptionTypeCode))]
public enum CorporateActionOptionType1Code
{
    /// <summary>
    /// Receive shares issued from the Share Premium Reserve of the company and considered as a capital distribution rather than a disbursement of income, with different tax implications (typically found in Australia).
    /// Encoded/decoded by serializers as &quot;BSPL&quot;.
    /// </summary>
    [EnumMember(Value = "BSPL")]
    [IsoId("_bQ8t1Np-Ed-ak6NoX_4Aeg_-1588151471")]
    [Description(
        @"Receive shares issued from the Share Premium Reserve of the company and considered as a capital distribution rather than a disbursement of income, with different tax implications (typically found in Australia)."
    )]
    BonusSharePlan = CorporateActionOptionTypeCode.BonusSharePlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Buy additional securities to round up position.
    /// Encoded/decoded by serializers as &quot;BUYA&quot;.
    /// </summary>
    [EnumMember(Value = "BUYA")]
    [IsoId("_bQ8t1dp-Ed-ak6NoX_4Aeg_-1501341678")]
    [Description(@"Buy additional securities to round up position.")]
    BuyUp = CorporateActionOptionTypeCode.BuyUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Election choice includes a combination of both cash and securities.
    /// Encoded/decoded by serializers as &quot;CASE&quot;.
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_bQ8t1tp-Ed-ak6NoX_4Aeg_-1444084217")]
    [Description(@"Election choice includes a combination of both cash and securities.")]
    CashAndSecurities = CorporateActionOptionTypeCode.CashAndSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_bQ8t19p-Ed-ak6NoX_4Aeg_-1187346341")]
    [Description(@"Distribution of cash.")]
    Cash = CorporateActionOptionTypeCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to exchange securities.
    /// Encoded/decoded by serializers as &quot;CEXC&quot;.
    /// </summary>
    [EnumMember(Value = "CEXC")]
    [IsoId("_bQ8t2Np-Ed-ak6NoX_4Aeg_-1062668196")]
    [Description(
        @"Vote to consent to change the terms of the securities agreement and to exchange securities."
    )]
    ConsentAndExchange = CorporateActionOptionTypeCode.ConsentAndExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to tender securities for cash.
    /// Encoded/decoded by serializers as &quot;CTEN&quot;.
    /// </summary>
    [EnumMember(Value = "CTEN")]
    [IsoId("_bRGe0Np-Ed-ak6NoX_4Aeg_1158726763")]
    [Description(
        @"Vote to consent to change the terms of the securities agreement and to tender securities for cash."
    )]
    ConsentAndTender = CorporateActionOptionTypeCode.ConsentAndTender, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote not to approve the event or proposal.
    /// Encoded/decoded by serializers as &quot;CONN&quot;.
    /// </summary>
    [EnumMember(Value = "CONN")]
    [IsoId("_bRGe0dp-Ed-ak6NoX_4Aeg_1287097128")]
    [Description(@"Vote not to approve the event or proposal.")]
    ConsentDenied = CorporateActionOptionTypeCode.ConsentDenied, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote to approve the event or proposal.
    /// Encoded/decoded by serializers as &quot;CONY&quot;.
    /// </summary>
    [EnumMember(Value = "CONY")]
    [IsoId("_bRGe0tp-Ed-ak6NoX_4Aeg_1726692670")]
    [Description(@"Vote to approve the event or proposal.")]
    ConsentGranted = CorporateActionOptionTypeCode.ConsentGranted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exercise intermediate securities or warrants.
    /// Encoded/decoded by serializers as &quot;EXER&quot;.
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_bRGe09p-Ed-ak6NoX_4Aeg_2115496056")]
    [Description(@"Exercise intermediate securities or warrants.")]
    Exercise = CorporateActionOptionTypeCode.Exercise, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Allow event or entitled security to expire.
    /// Encoded/decoded by serializers as &quot;LAPS&quot;.
    /// </summary>
    [EnumMember(Value = "LAPS")]
    [IsoId("_bRGe1Np-Ed-ak6NoX_4Aeg_-2094508846")]
    [Description(@"Allow event or entitled security to expire.")]
    Lapse = CorporateActionOptionTypeCode.Lapse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An option that allows a holder to elect to retain their holding, eg, a putable bond.
    /// Encoded/decoded by serializers as &quot;MPUT&quot;.
    /// </summary>
    [EnumMember(Value = "MPUT")]
    [IsoId("_bRGe1dp-Ed-ak6NoX_4Aeg_-1733412944")]
    [Description(
        @"An option that allows a holder to elect to retain their holding, eg, a putable bond."
    )]
    Retain = CorporateActionOptionTypeCode.Retain, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option for the account owner not to take part in the event.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_bRGe1tp-Ed-ak6NoX_4Aeg_-1409257022")]
    [Description(@"Option for the account owner not to take part in the event.")]
    NoAction = CorporateActionOptionTypeCode.NoAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period.
    /// Encoded/decoded by serializers as &quot;OFFR&quot;.
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_bRGe19p-Ed-ak6NoX_4Aeg_-1337221986")]
    [Description(
        @"In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period."
    )]
    ProposedRate = CorporateActionOptionTypeCode.ProposedRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Subscribe to more equities than underlying securities position allows.
    /// Encoded/decoded by serializers as &quot;OVER&quot;.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_bRGe2Np-Ed-ak6NoX_4Aeg_-1176529861")]
    [Description(@"Subscribe to more equities than underlying securities position allows.")]
    Oversubscribe = CorporateActionOptionTypeCode.Oversubscribe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of securities to holders.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_bRGe2dp-Ed-ak6NoX_4Aeg_-388763501")]
    [Description(@"Distribution of securities to holders.")]
    SecuritiesOption = CorporateActionOptionTypeCode.SecuritiesOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sell the intermediate securities.
    /// Encoded/decoded by serializers as &quot;SLLE&quot;.
    /// </summary>
    [EnumMember(Value = "SLLE")]
    [IsoId("_bRGe2tp-Ed-ak6NoX_4Aeg_-292719284")]
    [Description(@"Sell the intermediate securities.")]
    SellEntitlement = CorporateActionOptionTypeCode.SellEntitlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option to give a split instruction, eg, a split voting instruction on a meeting.
    /// Encoded/decoded by serializers as &quot;SPLI&quot;.
    /// </summary>
    [EnumMember(Value = "SPLI")]
    [IsoId("_bRQP0Np-Ed-ak6NoX_4Aeg_1811467816")]
    [Description(
        @"Option to give a split instruction, eg, a split voting instruction on a meeting."
    )]
    SplitInstruction = CorporateActionOptionTypeCode.SplitInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The account owner is a Non-Qualified Investor.
    /// Encoded/decoded by serializers as &quot;NOQU&quot;.
    /// </summary>
    [EnumMember(Value = "NOQU")]
    [IsoId("_bRQP0dp-Ed-ak6NoX_4Aeg_-1261679474")]
    [Description(@"The account owner is a Non-Qualified Investor.")]
    NonQualifiedInvestor = CorporateActionOptionTypeCode.NonQualifiedInvestor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Generic corporate action option to be used in case that no other specific code is appropriate.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bRQP0tp-Ed-ak6NoX_4Aeg_-953225262")]
    [Description(
        @"Generic corporate action option to be used in case that no other specific code is appropriate."
    )]
    Other = CorporateActionOptionTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The account owner is a Qualified Investor.
    /// Encoded/decoded by serializers as &quot;QINV&quot;.
    /// </summary>
    [EnumMember(Value = "QINV")]
    [IsoId("_bRQP09p-Ed-ak6NoX_4Aeg_-806383466")]
    [Description(@"The account owner is a Qualified Investor.")]
    QualifiedInvestor = CorporateActionOptionTypeCode.QualifiedInvestor, // same ordinal as derivation source for type conversions
}
