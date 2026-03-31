// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the trade counterparty.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5cohQCR7Ee2VuKUpJ7HXPg")]
[Description(@"Specifies the type of the trade counterparty.")]
[Derivations(typeof(TradeCounterpartyType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TradeCounterpartyTypeCode>))]
#endif
public enum TradeCounterpartyTypeCode
{
    /// <summary>
    /// Specifies that party to the transaction is a Reporting Counterparty.
    /// Encoded/decoded by serializers as &quot;REPC&quot;.
    /// </summary>
    [EnumMember(Value = "REPC")]
    [IsoId("_AgatECR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is a Reporting Counterparty.")]
    ReportingCounterparty,

    /// <summary>
    /// Specifies that party to the transaction is an Other Counterparty.
    /// Encoded/decoded by serializers as &quot;OTHC&quot;.
    /// </summary>
    [EnumMember(Value = "OTHC")]
    [IsoId("_DLsnkCR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is an Other Counterparty.")]
    OtherCounterparty,

    /// <summary>
    /// Specifies that party to the transaction is a Broker.
    /// Encoded/decoded by serializers as &quot;BROK&quot;.
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_OnUWUCR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is a Broker.")]
    Broker,

    /// <summary>
    /// Specifies that party to the transaction is a Submitting Agent.
    /// Encoded/decoded by serializers as &quot;SBMA&quot;.
    /// </summary>
    [EnumMember(Value = "SBMA")]
    [IsoId("_QITn8CR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is a Submitting Agent.")]
    SubmittingAgent,

    /// <summary>
    /// Specifies that party to the transaction is a Clearing Member.
    /// Encoded/decoded by serializers as &quot;CLEM&quot;.
    /// </summary>
    [EnumMember(Value = "CLEM")]
    [IsoId("_R-ftgCR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is a Clearing Member.")]
    ClearingMember,

    /// <summary>
    /// Specifies that party to the transaction is a Beneficiary.
    /// Encoded/decoded by serializers as &quot;BENE&quot;.
    /// </summary>
    [EnumMember(Value = "BENE")]
    [IsoId("_T-wVECR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is a Beneficiary.")]
    Beneficiary,

    /// <summary>
    /// Specifies that party to the transaction is an Executing Agent.
    /// Encoded/decoded by serializers as &quot;EXEA&quot;.
    /// </summary>
    [EnumMember(Value = "EXEA")]
    [IsoId("_WtZFkCR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is an Executing Agent.")]
    ExecutingAgent,

    /// <summary>
    /// Specifies that party to the transaction is an Entity Responsible For Report.
    /// Encoded/decoded by serializers as &quot;ERFR&quot;.
    /// </summary>
    [EnumMember(Value = "ERFR")]
    [IsoId("_xA_40CxqEe2xAdY9t5fB3g")]
    [Description(@"Specifies that party to the transaction is an Entity Responsible For Report.")]
    EntityResponsibleForReport,
}
