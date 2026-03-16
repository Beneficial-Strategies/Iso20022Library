// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional indicators on the transaction.
/// </summary>
[IsoId("_ZVa-kGhoEeaqBY_HJicULw")]
[DisplayName("Securities Transaction Indicator")]
public record SecuritiesTransactionIndicator2
{
    /// <summary>
    /// Indicates whether the transaction was executed under a pre-trade waiver.
    /// </summary>
    [IsoId("_ZmkY8WhoEeaqBY_HJicULw")]
    [DisplayName("Waiver Indicator")]
    [IsoXmlTag("WvrInd")]
    public ReportingWaiverType1Code? WaiverIndicator { get; init; }

    /// <summary>
    /// Indicates a short sell concluded by the investment agent on its own accounts or on behalf of a client, as described in the local regulation.
    /// </summary>
    [IsoId("_ZmkY82hoEeaqBY_HJicULw")]
    [DisplayName("Short Selling Indicator")]
    [IsoXmlTag("ShrtSellgInd")]
    public Side5Code? ShortSellingIndicator { get; init; }

    /// <summary>
    /// Indicates the type of transaction in accordance with the local regulation.
    /// </summary>
    [IsoId("_ZmkY9WhoEeaqBY_HJicULw")]
    [DisplayName("OTC Post Trade Indicator")]
    [IsoXmlTag("OTCPstTradInd")]
    public ReportingWaiverType3Code? OTCPostTradeIndicator { get; init; }

    /// <summary>
    /// Indicates whether the transaction is objectively measurable as reducing risks directly relating to the commercial activity of the entity executing the transaction.
    /// </summary>
    [IsoId("_ZmkY92hoEeaqBY_HJicULw")]
    [DisplayName("Risk Reducing Transaction")]
    [IsoXmlTag("RskRdcgTx")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RiskReducingTransaction { get; init; }

    /// <summary>
    /// Indicates whether the transaction falls within the scope of activity to be reported under the Securities Financing Transactions Regulation.
    /// </summary>
    [IsoId("_ZmkY-WhoEeaqBY_HJicULw")]
    [DisplayName("Securities Financing Transaction Indicator")]
    [IsoXmlTag("SctiesFincgTxInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator SecuritiesFinancingTransactionIndicator { get; init; }
}
