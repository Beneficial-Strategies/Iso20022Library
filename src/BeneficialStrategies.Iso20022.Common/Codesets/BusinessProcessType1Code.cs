// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of business process model used to carry out the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__0mdwNojEeC60axPepSq7g_-2020190846")]
[Description(@"Type of business process model used to carry out the transaction.")]
[DerivedFrom(typeof(BusinessProcessTypeCode))]
public enum BusinessProcessType1Code
{
    /// <summary>
    /// Specifies the processing of a transaction in a central matching utility model.
    /// Encoded/decoded by serializers as &quot;ISUP&quot;.
    /// </summary>
    [EnumMember(Value = "ISUP")]
    [IsoId("__0mdwdojEeC60axPepSq7g_1532057379")]
    [Description(@"Specifies the processing of a transaction in a central matching utility model.")]
    TripartiteCentralMatching = BusinessProcessTypeCode.TripartiteCentralMatching, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies the processing of a transaction in a local matching model.
    /// Encoded/decoded by serializers as &quot;NISP&quot;.
    /// </summary>
    [EnumMember(Value = "NISP")]
    [IsoId("__0mdwtojEeC60axPepSq7g_1520958602")]
    [Description(@"Specifies the processing of a transaction in a local matching model.")]
    NotCoveredByInvestmentInstructions = BusinessProcessTypeCode.NotCoveredByInvestmentInstructions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction notice results from an agreement made out of a trading platform between two members (broker and intermediary) of an authorised entity.
    /// Encoded/decoded by serializers as &quot;PRAC&quot;.
    /// </summary>
    [EnumMember(Value = "PRAC")]
    [IsoId("__0mdw9ojEeC60axPepSq7g_394185007")]
    [Description(
        @"Transaction notice results from an agreement made out of a trading platform between two members (broker and intermediary) of an authorised entity."
    )]
    PreAccepted = BusinessProcessTypeCode.PreAccepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction notice reverses a previously sent and agreed transaction notice. If the reversal transaction notice is stated to serve as invoice:
    /// o Fees and taxes contained in the transaction notice are considered as being in debit of the broker’s account and in credit of the intermediary’s account: it is a ‘credit invoice’;
    /// o The broker will have to specify the original transaction notice reference;
    /// o The reversal transaction notice will have the same direction (buy, sell) as the original transaction notice.
    /// Encoded/decoded by serializers as &quot;RSAL&quot;.
    /// </summary>
    [EnumMember(Value = "RSAL")]
    [IsoId("__0mdxNojEeC60axPepSq7g_-1697522113")]
    [Description(
        @"Transaction notice reverses a previously sent and agreed transaction notice. If the reversal transaction notice is stated to serve as invoice:|o Fees and taxes contained in the transaction notice are considered as being in debit of the broker’s account and in credit of the intermediary’s account: it is a ‘credit invoice’;|o The broker will have to specify the original transaction notice reference;|o The reversal transaction notice will have the same direction (buy, sell) as the original transaction notice."
    )]
    Reversal = BusinessProcessTypeCode.Reversal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies the processing of a transaction in a own account trade type model.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("__0mdxdojEeC60axPepSq7g_-73630408")]
    [Description(@"Specifies the processing of a transaction in a own account trade type model.")]
    OwnAccountTradeType = BusinessProcessTypeCode.OwnAccountTradeType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies the processing of a transaction in a through type model.
    /// Encoded/decoded by serializers as &quot;THRU&quot;.
    /// </summary>
    [EnumMember(Value = "THRU")]
    [IsoId("__0wOwNojEeC60axPepSq7g_1409712494")]
    [Description(@"Specifies the processing of a transaction in a through type model.")]
    ThroughType = BusinessProcessTypeCode.ThroughType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies the processing of a transaction in a billateral central matching model.
    /// Encoded/decoded by serializers as &quot;IDEL&quot;.
    /// </summary>
    [EnumMember(Value = "IDEL")]
    [IsoId("__0wOwdojEeC60axPepSq7g_-1661996260")]
    [Description(
        @"Specifies the processing of a transaction in a billateral central matching model."
    )]
    BillateralCentralMatching = BusinessProcessTypeCode.BillateralCentralMatching, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies the processing of a transaction in a duplex type model.
    /// Encoded/decoded by serializers as &quot;DPLX&quot;.
    /// </summary>
    [EnumMember(Value = "DPLX")]
    [IsoId("__0wOwtojEeC60axPepSq7g_1051589305")]
    [Description(@"Specifies the processing of a transaction in a duplex type model.")]
    DuplexType = BusinessProcessTypeCode.DuplexType, // same ordinal as derivation source for type conversions
}
