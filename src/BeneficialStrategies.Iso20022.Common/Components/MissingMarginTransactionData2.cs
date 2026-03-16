// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed information about the outstanding derivatives for which no margin or outdated margin information has been reported.
/// </summary>
[IsoId("_rud9m1owEe23K4GXSpBSeg")]
[DisplayName("Missing Margin Transaction Data")]
public record MissingMarginTransactionData2
{
    /// <summary>
    /// Identification of a transaction.
    /// </summary>
    [IsoId("_rvjisVowEe23K4GXSpBSeg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TradeTransactionIdentification24 TransactionIdentification { get; init; }

    /// <summary>
    /// Indicates the date and time of the last collateral amount determination or calculation.
    /// </summary>
    [IsoId("_rvjis1owEe23K4GXSpBSeg")]
    [DisplayName("Collateral Time Stamp")]
    [IsoXmlTag("CollTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CollateralTimeStamp { get; init; }
}
