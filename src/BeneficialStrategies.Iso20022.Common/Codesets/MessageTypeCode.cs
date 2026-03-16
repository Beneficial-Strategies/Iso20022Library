// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the message type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aL9bs9p-Ed-ak6NoX_4Aeg_-127004772")]
[Description(@"Specifies the message type.")]
[Derivations(typeof(CashForecastMessage1Code), typeof(StatementType1Code))]
public enum MessageTypeCode
{
    /// <summary>
    /// Accounting Statement of Holdings (semt 003).
    /// Encoded/decoded by serializers as &quot;ST03&quot;.
    /// </summary>
    [EnumMember(Value = "ST03")]
    [IsoId("_aL9btNp-Ed-ak6NoX_4Aeg_-97453198")]
    [Description(@"Accounting Statement of Holdings (semt 003).")]
    AccountingHoldings,

    /// <summary>
    /// Custody Statement of Holdings (semt 002).
    /// Encoded/decoded by serializers as &quot;ST02&quot;.
    /// </summary>
    [EnumMember(Value = "ST02")]
    [IsoId("_aL9btdp-Ed-ak6NoX_4Aeg_-72518511")]
    [Description(@"Custody Statement of Holdings (semt 002).")]
    CustodyHoldings,

    /// <summary>
    /// Statement of Investment Fund Transactions (semt 006).
    /// Encoded/decoded by serializers as &quot;ST06&quot;.
    /// </summary>
    [EnumMember(Value = "ST06")]
    [IsoId("_aL9bttp-Ed-ak6NoX_4Aeg_-59589519")]
    [Description(@"Statement of Investment Fund Transactions (semt 006).")]
    InvestmentFundTransactions,

    /// <summary>
    /// Fund estimated cash forecast report (camt.040).
    /// Encoded/decoded by serializers as &quot;CF40&quot;.
    /// </summary>
    [EnumMember(Value = "CF40")]
    [IsoId("_aL9bt9p-Ed-ak6NoX_4Aeg_1942126911")]
    [Description(@"Fund estimated cash forecast report (camt.040).")]
    Estimated,

    /// <summary>
    /// Fund detailed estimated cash forecast Report (042).
    /// Encoded/decoded by serializers as &quot;CF42&quot;.
    /// </summary>
    [EnumMember(Value = "CF42")]
    [IsoId("_aMHMsNp-Ed-ak6NoX_4Aeg_1943046943")]
    [Description(@"Fund detailed estimated cash forecast Report (042).")]
    EstimatedDetailed,

    /// <summary>
    /// Fund confirmed cash forecast report (camt.041).
    /// Encoded/decoded by serializers as &quot;CF41&quot;.
    /// </summary>
    [EnumMember(Value = "CF41")]
    [IsoId("_aMHMsdp-Ed-ak6NoX_4Aeg_1943046978")]
    [Description(@"Fund confirmed cash forecast report (camt.041).")]
    Confirmed,

    /// <summary>
    /// Fund detailed confirmed cash forecast report (camt.043).
    /// Encoded/decoded by serializers as &quot;CF43&quot;.
    /// </summary>
    [EnumMember(Value = "CF43")]
    [IsoId("_aMHMstp-Ed-ak6NoX_4Aeg_1943047021")]
    [Description(@"Fund detailed confirmed cash forecast report (camt.043).")]
    CornfirmedDetailed,

    /// <summary>
    /// Securities Balance Transparency (semt.041).
    /// Encoded/decoded by serializers as &quot;ST41&quot;.
    /// </summary>
    [EnumMember(Value = "ST41")]
    [IsoId("_Xo0oMNnYEeSy3ba5KBm7wA")]
    [Description(@"Securities Balance Transparency (semt.041).")]
    Transparency,
}
