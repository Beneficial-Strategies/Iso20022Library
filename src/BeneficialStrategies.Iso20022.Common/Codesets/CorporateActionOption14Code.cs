// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of corporate action options.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IbMafeasEemtTOaHuc_63w")]
[Description(@"Specifies the type of corporate action options.")]
[DerivedFrom(typeof(CorporateActionOptionCode))]
public enum CorporateActionOption14Code
{
    /// <summary>
    /// Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting.|If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used.
    /// Encoded/decoded by serializers as &quot;ABST&quot;.
    /// </summary>
    [EnumMember(Value = "ABST")]
    [IsoId("_IbMaheasEemtTOaHuc_63w")]
    [Description(@"Vote expressed as abstain. In this case, the issuing company will add the number of shares to the quorum of the meeting.|If the voting right is not executed, it will not be added to the quorum. In this case, code NOAC should be used.")]
    Abstain = CorporateActionOptionCode.Abstain, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Receive equities from the share premium reserve of the company and considered as a capital distribution rather than a disbursement of income with different tax implications (typically found in Australia).
    /// Encoded/decoded by serializers as &quot;BSPL&quot;.
    /// </summary>
    [EnumMember(Value = "BSPL")]
    [IsoId("_IbMagOasEemtTOaHuc_63w")]
    [Description(@"Receive equities from the share premium reserve of the company and considered as a capital distribution rather than a disbursement of income with different tax implications (typically found in Australia).")]
    BonusSharePlan = CorporateActionOptionCode.BonusSharePlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Buy additional securities to round up position.
    /// Encoded/decoded by serializers as &quot;BUYA&quot;.
    /// </summary>
    [EnumMember(Value = "BUYA")]
    [IsoId("_IbMaj-asEemtTOaHuc_63w")]
    [Description(@"Buy additional securities to round up position.")]
    BuyUp = CorporateActionOptionCode.BuyUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option to choose between different security and cash options.
    /// Encoded/decoded by serializers as &quot;CASE&quot;.
    /// </summary>
    [EnumMember(Value = "CASE")]
    [IsoId("_IbMak-asEemtTOaHuc_63w")]
    [Description(@"Option to choose between different security and cash options.")]
    CashAndSecurity = CorporateActionOptionCode.CashAndSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option to choose cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_IbMaleasEemtTOaHuc_63w")]
    [Description(@"Option to choose cash.")]
    Cash = CorporateActionOptionCode.Cash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to exchange securities.
    /// Encoded/decoded by serializers as &quot;CEXC&quot;.
    /// </summary>
    [EnumMember(Value = "CEXC")]
    [IsoId("_IbMakeasEemtTOaHuc_63w")]
    [Description(@"Vote to consent to change the terms of the securities agreement and to exchange securities.")]
    ConsentAndExchange = CorporateActionOptionCode.ConsentAndExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote not to approve the event or proposal.
    /// Encoded/decoded by serializers as &quot;CONN&quot;.
    /// </summary>
    [EnumMember(Value = "CONN")]
    [IsoId("_IbMaiOasEemtTOaHuc_63w")]
    [Description(@"Vote not to approve the event or proposal.")]
    ConsentDenied = CorporateActionOptionCode.ConsentDenied, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote to approve the event or proposal.
    /// Encoded/decoded by serializers as &quot;CONY&quot;.
    /// </summary>
    [EnumMember(Value = "CONY")]
    [IsoId("_IbMaieasEemtTOaHuc_63w")]
    [Description(@"Vote to approve the event or proposal.")]
    ConsentGranted = CorporateActionOptionCode.ConsentGranted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote to consent to change the terms of the securities agreement and to tender securities for cash.
    /// Encoded/decoded by serializers as &quot;CTEN&quot;.
    /// </summary>
    [EnumMember(Value = "CTEN")]
    [IsoId("_IbMaguasEemtTOaHuc_63w")]
    [Description(@"Vote to consent to change the terms of the securities agreement and to tender securities for cash.")]
    ConsentAndTender = CorporateActionOptionCode.ConsentAndTender, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exercise intermediate securities or warrants.
    /// Encoded/decoded by serializers as &quot;EXER&quot;.
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("_IbMajuasEemtTOaHuc_63w")]
    [Description(@"Exercise intermediate securities or warrants.")]
    Exercise = CorporateActionOptionCode.Exercise, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Allow event or entitled security to expire.
    /// Encoded/decoded by serializers as &quot;LAPS&quot;.
    /// </summary>
    [EnumMember(Value = "LAPS")]
    [IsoId("_IbMahuasEemtTOaHuc_63w")]
    [Description(@"Allow event or entitled security to expire.")]
    Lapse = CorporateActionOptionCode.Lapse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mark down the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).
    /// Encoded/decoded by serializers as &quot;MKDW&quot;.
    /// </summary>
    [EnumMember(Value = "MKDW")]
    [IsoId("_IbMai-asEemtTOaHuc_63w")]
    [Description(@"Mark down the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).")]
    MarkDown = CorporateActionOptionCode.MarkDown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mark up the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).
    /// Encoded/decoded by serializers as &quot;MKUP&quot;.
    /// </summary>
    [EnumMember(Value = "MKUP")]
    [IsoId("_IbMaf-asEemtTOaHuc_63w")]
    [Description(@"Mark up the global certificate as a result of a corporate action (instruction from International Central Securities Depositories (ICSDs) to common depositories who are holding the global certificate on behalf of the International Central Securities Depositories (ICSDs)).")]
    MarkUp = CorporateActionOptionCode.MarkUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option that allows a holder to elect to retain their holding, for example, a putable bond.
    /// Encoded/decoded by serializers as &quot;MPUT&quot;.
    /// </summary>
    [EnumMember(Value = "MPUT")]
    [IsoId("_IbMaiuasEemtTOaHuc_63w")]
    [Description(@"Option that allows a holder to elect to retain their holding, for example, a putable bond.")]
    Retain = CorporateActionOptionCode.Retain, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option for the account owner not to take part in the event. This would include opt-out for class actions and lodging of dissenters&apos; rights.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_IbMal-asEemtTOaHuc_63w")]
    [Description(@"Option for the account owner not to take part in the event. This would include opt-out for class actions and lodging of dissenters' rights.")]
    NoAction = CorporateActionOptionCode.NoAction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is a non-qualified investor.
    /// Encoded/decoded by serializers as &quot;NOQU&quot;.
    /// </summary>
    [EnumMember(Value = "NOQU")]
    [IsoId("_IbMahOasEemtTOaHuc_63w")]
    [Description(@"Account owner is a non-qualified investor.")]
    NonQualifiedInvestor = CorporateActionOptionCode.NonQualifiedInvestor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period.
    /// Encoded/decoded by serializers as &quot;OFFR&quot;.
    /// </summary>
    [EnumMember(Value = "OFFR")]
    [IsoId("_IbMakuasEemtTOaHuc_63w")]
    [Description(@"In a remarketing of variable notes, the margin that shareholders can propose in respect of the next interest period.")]
    ProposedRate = CorporateActionOptionCode.ProposedRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Generic corporate action option to be used in case that no other specific code is appropriate.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_IbMageasEemtTOaHuc_63w")]
    [Description(@"Generic corporate action option to be used in case that no other specific code is appropriate.")]
    Other = CorporateActionOptionCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Subscribe to more equities than underlying securities position allows.
    /// Encoded/decoded by serializers as &quot;OVER&quot;.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_IbMafuasEemtTOaHuc_63w")]
    [Description(@"Subscribe to more equities than underlying securities position allows.")]
    Oversubscribe = CorporateActionOptionCode.Oversubscribe, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account owner is a qualified investor.
    /// Encoded/decoded by serializers as &quot;QINV&quot;.
    /// </summary>
    [EnumMember(Value = "QINV")]
    [IsoId("_IbMajOasEemtTOaHuc_63w")]
    [Description(@"Account owner is a qualified investor.")]
    QualifiedInvestor = CorporateActionOptionCode.QualifiedInvestor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of securities to holders.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_IbMameasEemtTOaHuc_63w")]
    [Description(@"Distribution of securities to holders.")]
    Security = CorporateActionOptionCode.Security, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sell the intermediate securities.
    /// Encoded/decoded by serializers as &quot;SLLE&quot;.
    /// </summary>
    [EnumMember(Value = "SLLE")]
    [IsoId("_IbMakOasEemtTOaHuc_63w")]
    [Description(@"Sell the intermediate securities.")]
    SellEntitlement = CorporateActionOptionCode.SellEntitlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax instruction.
    /// Encoded/decoded by serializers as &quot;TAXI&quot;.
    /// </summary>
    [EnumMember(Value = "TAXI")]
    [IsoId("_IbMaluasEemtTOaHuc_63w")]
    [Description(@"Tax instruction.")]
    TaxInstruction = CorporateActionOptionCode.TaxInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Proceeds not known during election period. The option can result in cash and/or securities.
    /// Encoded/decoded by serializers as &quot;PRUN&quot;.
    /// </summary>
    [EnumMember(Value = "PRUN")]
    [IsoId("_IbMag-asEemtTOaHuc_63w")]
    [Description(@"Proceeds not known during election period. The option can result in cash and/or securities.")]
    UnknownProceeds = CorporateActionOptionCode.UnknownProceeds, // same ordinal as derivation source for type conversions
    
}
