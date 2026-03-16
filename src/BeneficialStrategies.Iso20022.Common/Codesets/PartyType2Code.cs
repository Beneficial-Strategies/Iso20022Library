// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of party involved in the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZyVax9p-Ed-ak6NoX_4Aeg_-1463923724")]
[Description(@"Specifies the type of party involved in the transaction.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType2Code
{
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_ZyVayNp-Ed-ak6NoX_4Aeg_1425772570")]
    [Description(@"Party, either an individual or organisation, whose assets are being invested.")]
    Investor = PartyTypeCode.Investor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that identifies an executing / give-up broker.
    /// Encoded/decoded by serializers as &quot;EXEC&quot;.
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_ZyeksNp-Ed-ak6NoX_4Aeg_1488571424")]
    [Description(@"Party that identifies an executing / give-up broker.")]
    ExecutingFirm = PartyTypeCode.ExecutingFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that receives the trade credit.
    /// Encoded/decoded by serializers as &quot;BROK&quot;.
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_Zyeksdp-Ed-ak6NoX_4Aeg_1488571597")]
    [Description(@"Party that receives the trade credit.")]
    BrokerOfCredit = PartyTypeCode.BrokerOfCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that is going to carry the position on their books at another clearinghouse (exchanges).
    /// Encoded/decoded by serializers as &quot;CORR&quot;.
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_Zyekstp-Ed-ak6NoX_4Aeg_1488571614")]
    [Description(
        @"Party that is going to carry the position on their books at another clearinghouse (exchanges)."
    )]
    CorrespondentClearingFirm = PartyTypeCode.CorrespondentClearingFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that is the counterparty in a trade.
    /// Encoded/decoded by serializers as &quot;COFI&quot;.
    /// </summary>
    [EnumMember(Value = "COFI")]
    [IsoId("_Zyeks9p-Ed-ak6NoX_4Aeg_1488572277")]
    [Description(@"Party that is the counterparty in a trade.")]
    ContraFirm = PartyTypeCode.ContraFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that is the clearing firm of the counterparty in a trade.
    /// Encoded/decoded by serializers as &quot;COCL&quot;.
    /// </summary>
    [EnumMember(Value = "COCL")]
    [IsoId("_ZyektNp-Ed-ak6NoX_4Aeg_1488572337")]
    [Description(@"Party that is the clearing firm of the counterparty in a trade.")]
    ContraClearingFirm = PartyTypeCode.ContraClearingFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party (broker or other firm), which is the contra side of the trade for the underlying security.
    /// Encoded/decoded by serializers as &quot;UNDE&quot;.
    /// </summary>
    [EnumMember(Value = "UNDE")]
    [IsoId("_Zyektdp-Ed-ak6NoX_4Aeg_1488572527")]
    [Description(
        @"Party (broker or other firm), which is the contra side of the trade for the underlying security."
    )]
    UnderlyingContraFirm = PartyTypeCode.UnderlyingContraFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party to which the trade is given up (carries the position that results from a trade).
    /// Encoded/decoded by serializers as &quot;GIVE&quot;.
    /// </summary>
    [EnumMember(Value = "GIVE")]
    [IsoId("_Zyekttp-Ed-ak6NoX_4Aeg_1488572864")]
    [Description(
        @"Party to which the trade is given up (carries the position that results from a trade)."
    )]
    GiveUpClearingFirm = PartyTypeCode.GiveUpClearingFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that originates an order.
    /// Encoded/decoded by serializers as &quot;ORDE&quot;.
    /// </summary>
    [EnumMember(Value = "ORDE")]
    [IsoId("_Zyekt9p-Ed-ak6NoX_4Aeg_1488573423")]
    [Description(@"Party that originates an order.")]
    OrderOriginationFirm = PartyTypeCode.OrderOriginationFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party (member of an exchange)that is sponsoring an entering firm to send orders directly to the exchange.
    /// Encoded/decoded by serializers as &quot;SPON&quot;.
    /// </summary>
    [EnumMember(Value = "SPON")]
    [IsoId("_ZyekuNp-Ed-ak6NoX_4Aeg_1488574258")]
    [Description(
        @"Party (member of an exchange)that is sponsoring an entering firm to send orders directly to the exchange."
    )]
    SponsoringFirm = PartyTypeCode.SponsoringFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party (broker) that settles security transactions from another broker for a fee = take up broker.
    /// Encoded/decoded by serializers as &quot;CLEA&quot;.
    /// </summary>
    [EnumMember(Value = "CLEA")]
    [IsoId("_Zyekudp-Ed-ak6NoX_4Aeg_1488574430")]
    [Description(
        @"Party (broker) that settles security transactions from another broker for a fee = take up broker."
    )]
    Clearingfirm = PartyTypeCode.Clearingfirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that can relay an order directly to the trading floor, or give clients direct access to the floor. The introducing firm delegates the work of the floor operation, trade execution and accounting.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_Zyekutp-Ed-ak6NoX_4Aeg_1489494904")]
    [Description(
        @"Party that can relay an order directly to the trading floor, or give clients direct access to the floor. The introducing firm delegates the work of the floor operation, trade execution and accounting."
    )]
    IntroducingFirm = PartyTypeCode.IntroducingFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that has recorded or reported an execution of a trade. When an entering firm that is not a party to a trade enters the trade into a trade recording system, any inquiries can be directed to the appropriate source.
    /// Encoded/decoded by serializers as &quot;ENTE&quot;.
    /// </summary>
    [EnumMember(Value = "ENTE")]
    [IsoId("_ZyoVsNp-Ed-ak6NoX_4Aeg_1489495041")]
    [Description(
        @"Party that has recorded or reported an execution of a trade. When an entering firm that is not a party to a trade enters the trade into a trade recording system, any inquiries can be directed to the appropriate source."
    )]
    EnteringFirm = PartyTypeCode.EnteringFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A client is identified in third party-transactions or for investor in intermediary transactions.
    /// Encoded/decoded by serializers as &quot;CLIE&quot;.
    /// </summary>
    [EnumMember(Value = "CLIE")]
    [IsoId("_ZyoVsdp-Ed-ak6NoX_4Aeg_1489495378")]
    [Description(
        @"A client is identified in third party-transactions or for investor in intermediary transactions."
    )]
    Client = PartyTypeCode.Client, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Broker to which the investment manager directs the execution of a portion of the trade.
    /// Encoded/decoded by serializers as &quot;STEP&quot;.
    /// </summary>
    [EnumMember(Value = "STEP")]
    [IsoId("_ZyoVstp-Ed-ak6NoX_4Aeg_1489495860")]
    [Description(
        @"Broker to which the investment manager directs the execution of a portion of the trade."
    )]
    StepInBroker = PartyTypeCode.StepInBroker, // same ordinal as derivation source for type conversions
}
