// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of party involved in the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZyB4yNp-Ed-ak6NoX_4Aeg_83898339")]
[Description(@"Specifies the type of party involved in the transaction.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType1Code
{
    /// <summary>
    /// Party that identifies an executing / give-up broker.
    /// Encoded/decoded by serializers as &quot;EXEC&quot;.
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_ZyLpwNp-Ed-ak6NoX_4Aeg_227965693")]
    [Description(@"Party that identifies an executing / give-up broker.")]
    ExecutingFirm = PartyTypeCode.ExecutingFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that receives the trade credit.
    /// Encoded/decoded by serializers as &quot;BROK&quot;.
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_ZyLpwdp-Ed-ak6NoX_4Aeg_253825751")]
    [Description(@"Party that receives the trade credit.")]
    BrokerOfCredit = PartyTypeCode.BrokerOfCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that is going to carry the position on their books at another clearinghouse (exchanges).
    /// Encoded/decoded by serializers as &quot;CORR&quot;.
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_ZyLpwtp-Ed-ak6NoX_4Aeg_253825864")]
    [Description(
        @"Party that is going to carry the position on their books at another clearinghouse (exchanges)."
    )]
    CorrespondentClearingFirm = PartyTypeCode.CorrespondentClearingFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that is the counterparty in a trade.
    /// Encoded/decoded by serializers as &quot;COFI&quot;.
    /// </summary>
    [EnumMember(Value = "COFI")]
    [IsoId("_ZyLpw9p-Ed-ak6NoX_4Aeg_253826236")]
    [Description(@"Party that is the counterparty in a trade.")]
    ContraFirm = PartyTypeCode.ContraFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that is the clearing firm of the counterparty in a trade.
    /// Encoded/decoded by serializers as &quot;COCL&quot;.
    /// </summary>
    [EnumMember(Value = "COCL")]
    [IsoId("_ZyLpxNp-Ed-ak6NoX_4Aeg_253826279")]
    [Description(@"Party that is the clearing firm of the counterparty in a trade.")]
    ContraClearingFirm = PartyTypeCode.ContraClearingFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party (broker or other firm), which is the contra side of the trade for the underlying security.
    /// Encoded/decoded by serializers as &quot;UNDE&quot;.
    /// </summary>
    [EnumMember(Value = "UNDE")]
    [IsoId("_ZyLpxdp-Ed-ak6NoX_4Aeg_253826717")]
    [Description(
        @"Party (broker or other firm), which is the contra side of the trade for the underlying security."
    )]
    UnderlyingContraFirm = PartyTypeCode.UnderlyingContraFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party to which the trade is given up (carries the position that results from a trade).
    /// Encoded/decoded by serializers as &quot;GIVE&quot;.
    /// </summary>
    [EnumMember(Value = "GIVE")]
    [IsoId("_ZyLpxtp-Ed-ak6NoX_4Aeg_253826812")]
    [Description(
        @"Party to which the trade is given up (carries the position that results from a trade)."
    )]
    GiveUpClearingFirm = PartyTypeCode.GiveUpClearingFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that originates an order.
    /// Encoded/decoded by serializers as &quot;ORDE&quot;.
    /// </summary>
    [EnumMember(Value = "ORDE")]
    [IsoId("_ZyLpx9p-Ed-ak6NoX_4Aeg_253826837")]
    [Description(@"Party that originates an order.")]
    OrderOriginationFirm = PartyTypeCode.OrderOriginationFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party (member of an exchange)that is sponsoring an entering firm to send orders directly to the exchange.
    /// Encoded/decoded by serializers as &quot;SPON&quot;.
    /// </summary>
    [EnumMember(Value = "SPON")]
    [IsoId("_ZyLpyNp-Ed-ak6NoX_4Aeg_253827226")]
    [Description(
        @"Party (member of an exchange)that is sponsoring an entering firm to send orders directly to the exchange."
    )]
    SponsoringFirm = PartyTypeCode.SponsoringFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party (broker) that settles security transactions from another broker for a fee = take up broker.
    /// Encoded/decoded by serializers as &quot;CLEA&quot;.
    /// </summary>
    [EnumMember(Value = "CLEA")]
    [IsoId("_ZyLpydp-Ed-ak6NoX_4Aeg_254747310")]
    [Description(
        @"Party (broker) that settles security transactions from another broker for a fee = take up broker."
    )]
    Clearingfirm = PartyTypeCode.Clearingfirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that can relay an order directly to the trading floor, or give clients direct access to the floor. The introducing firm delegates the work of the floor operation, trade execution and accounting.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_ZyLpytp-Ed-ak6NoX_4Aeg_254747508")]
    [Description(
        @"Party that can relay an order directly to the trading floor, or give clients direct access to the floor. The introducing firm delegates the work of the floor operation, trade execution and accounting."
    )]
    IntroducingFirm = PartyTypeCode.IntroducingFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that has recorded or reported an execution of a trade. When an entering firm that is not a party to a trade enters the trade into a trade recording system, any inquiries can be directed to the appropriate source.
    /// Encoded/decoded by serializers as &quot;ENTE&quot;.
    /// </summary>
    [EnumMember(Value = "ENTE")]
    [IsoId("_ZyVawNp-Ed-ak6NoX_4Aeg_254747897")]
    [Description(
        @"Party that has recorded or reported an execution of a trade. When an entering firm that is not a party to a trade enters the trade into a trade recording system, any inquiries can be directed to the appropriate source."
    )]
    EnteringFirm = PartyTypeCode.EnteringFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A client is identified in third party-transactions or for investor in intermediary transactions.
    /// Encoded/decoded by serializers as &quot;CLIE&quot;.
    /// </summary>
    [EnumMember(Value = "CLIE")]
    [IsoId("_ZyVawdp-Ed-ak6NoX_4Aeg_254748439")]
    [Description(
        @"A client is identified in third party-transactions or for investor in intermediary transactions."
    )]
    Client = PartyTypeCode.Client, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Broker to which the investment manager directs the execution of a portion of the trade.
    /// Encoded/decoded by serializers as &quot;STEP&quot;.
    /// </summary>
    [EnumMember(Value = "STEP")]
    [IsoId("_ZyVawtp-Ed-ak6NoX_4Aeg_254748828")]
    [Description(
        @"Broker to which the investment manager directs the execution of a portion of the trade."
    )]
    StepInBroker = PartyTypeCode.StepInBroker, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party (buyer or seller) that positively affirms the details of a previously agreed security trade confirmation.
    /// Encoded/decoded by serializers as &quot;AFFI&quot;.
    /// </summary>
    [EnumMember(Value = "AFFI")]
    [IsoId("_ZyVaw9p-Ed-ak6NoX_4Aeg_254749231")]
    [Description(
        @"Party (buyer or seller) that positively affirms the details of a previously agreed security trade confirmation."
    )]
    AffirmingParty = PartyTypeCode.AffirmingParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party acting as the Electronic Trade Confirmation (ETC) service provider 1.
    /// Encoded/decoded by serializers as &quot;ETC1&quot;.
    /// </summary>
    [EnumMember(Value = "ETC1")]
    [IsoId("_ZyVaxNp-Ed-ak6NoX_4Aeg_254749386")]
    [Description(@"Party acting as the Electronic Trade Confirmation (ETC) service provider 1.")]
    ETCServiceProvider1 = PartyTypeCode.ETCServiceProvider1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party acting as the Electronic Trade Confirmation (ETC) service provider 2.
    /// Encoded/decoded by serializers as &quot;ETC2&quot;.
    /// </summary>
    [EnumMember(Value = "ETC2")]
    [IsoId("_ZyVaxdp-Ed-ak6NoX_4Aeg_254749776")]
    [Description(@"Party acting as the Electronic Trade Confirmation (ETC) service provider 2.")]
    ETCServiceProvider2 = PartyTypeCode.ETCServiceProvider2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_ZyVaxtp-Ed-ak6NoX_4Aeg_280607415")]
    [Description(@"Party, either an individual or organisation, whose assets are being invested.")]
    Investor = PartyTypeCode.Investor, // same ordinal as derivation source for type conversions
}
