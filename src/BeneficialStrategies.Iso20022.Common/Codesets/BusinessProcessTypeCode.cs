// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of business process model used to carry out the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__0wOw9ojEeC60axPepSq7g_-159430534")]
[Description(@"Type of business process model used to carry out the transaction.")]
[Derivations(typeof(BusinessProcessType1Code))]
public enum BusinessProcessTypeCode
{
    /// <summary>
    /// Specifies the processing of a transaction in a central matching utility model.
    /// Encoded/decoded by serializers as &quot;ISUP&quot;.
    /// </summary>
    [EnumMember(Value = "ISUP")]
    [IsoId("__0wOxNojEeC60axPepSq7g_1792633552")]
    [Description(@"Specifies the processing of a transaction in a central matching utility model.")]
    TripartiteCentralMatching,

    /// <summary>
    /// Specifies the processing of a transaction in a local matching model.
    /// Encoded/decoded by serializers as &quot;NISP&quot;.
    /// </summary>
    [EnumMember(Value = "NISP")]
    [IsoId("__0wOxdojEeC60axPepSq7g_1734197860")]
    [Description(@"Specifies the processing of a transaction in a local matching model.")]
    NotCoveredByInvestmentInstructions,

    /// <summary>
    /// Transaction notice results from an agreement made out of a trading platform between two members (broker and intermediary) of an authorised entity.
    /// Encoded/decoded by serializers as &quot;PRAC&quot;.
    /// </summary>
    [EnumMember(Value = "PRAC")]
    [IsoId("__0wOxtojEeC60axPepSq7g_-803464023")]
    [Description(
        @"Transaction notice results from an agreement made out of a trading platform between two members (broker and intermediary) of an authorised entity."
    )]
    PreAccepted,

    /// <summary>
    /// Transaction notice reverses a previously sent and agreed transaction notice. If the reversal transaction notice is stated to serve as invoice:
    /// o Fees and taxes contained in the transaction notice are considered as being in debit of the broker’s account and in credit of the intermediary’s account: it is a ‘credit invoice’;
    /// o The broker will have to specify the original transaction notice reference;
    /// o The reversal transaction notice will have the same direction (buy, sell) as the original transaction notice.
    /// Encoded/decoded by serializers as &quot;RSAL&quot;.
    /// </summary>
    [EnumMember(Value = "RSAL")]
    [IsoId("__05YsNojEeC60axPepSq7g_-1597663913")]
    [Description(
        @"Transaction notice reverses a previously sent and agreed transaction notice. If the reversal transaction notice is stated to serve as invoice:|o Fees and taxes contained in the transaction notice are considered as being in debit of the broker’s account and in credit of the intermediary’s account: it is a ‘credit invoice’;|o The broker will have to specify the original transaction notice reference;|o The reversal transaction notice will have the same direction (buy, sell) as the original transaction notice."
    )]
    Reversal,

    /// <summary>
    /// Specifies the processing of a transaction in a own account trade type model.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("__05YsdojEeC60axPepSq7g_-128588028")]
    [Description(@"Specifies the processing of a transaction in a own account trade type model.")]
    OwnAccountTradeType,

    /// <summary>
    /// Specifies the processing of a transaction in a through type model.
    /// Encoded/decoded by serializers as &quot;THRU&quot;.
    /// </summary>
    [EnumMember(Value = "THRU")]
    [IsoId("__05YstojEeC60axPepSq7g_-33504831")]
    [Description(@"Specifies the processing of a transaction in a through type model.")]
    ThroughType,

    /// <summary>
    /// Specifies the processing of a transaction in a billateral central matching model.
    /// Encoded/decoded by serializers as &quot;IDEL&quot;.
    /// </summary>
    [EnumMember(Value = "IDEL")]
    [IsoId("__05Ys9ojEeC60axPepSq7g_-1939625461")]
    [Description(
        @"Specifies the processing of a transaction in a billateral central matching model."
    )]
    BillateralCentralMatching,

    /// <summary>
    /// Specifies the processing of a transaction in a duplex type model.
    /// Encoded/decoded by serializers as &quot;DPLX&quot;.
    /// </summary>
    [EnumMember(Value = "DPLX")]
    [IsoId("__05YtNojEeC60axPepSq7g_1029292248")]
    [Description(@"Specifies the processing of a transaction in a duplex type model.")]
    DuplexType,
}
