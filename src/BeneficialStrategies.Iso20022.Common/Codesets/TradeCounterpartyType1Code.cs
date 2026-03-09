// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the trade counterparty.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y0Kk0CR8Ee2VuKUpJ7HXPg")]
[Description(@"Specifies the type of the trade counterparty.")]
[DerivedFrom(typeof(TradeCounterpartyTypeCode))]
public enum TradeCounterpartyType1Code
{
    /// <summary>
    /// Specifies that party to the transaction is a Beneficiary.
    /// Encoded/decoded by serializers as &quot;BENE&quot;.
    /// </summary>
    [EnumMember(Value = "BENE")]
    [IsoId("_bZx8MCR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is a Beneficiary.")]
    Beneficiary = TradeCounterpartyTypeCode.Beneficiary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that party to the transaction is a Broker.
    /// Encoded/decoded by serializers as &quot;BROK&quot;.
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_bdHkESR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is a Broker.")]
    Broker = TradeCounterpartyTypeCode.Broker, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that party to the transaction is a Clearing Member.
    /// Encoded/decoded by serializers as &quot;CLEM&quot;.
    /// </summary>
    [EnumMember(Value = "CLEM")]
    [IsoId("_bhJIcSR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is a Clearing Member.")]
    ClearingMember = TradeCounterpartyTypeCode.ClearingMember, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that party to the transaction is an Executing Agent.
    /// Encoded/decoded by serializers as &quot;EXEA&quot;.
    /// </summary>
    [EnumMember(Value = "EXEA")]
    [IsoId("_bkTxMSR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is an Executing Agent.")]
    ExecutingAgent = TradeCounterpartyTypeCode.ExecutingAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that party to the transaction is an Other Counterparty.
    /// Encoded/decoded by serializers as &quot;OTHC&quot;.
    /// </summary>
    [EnumMember(Value = "OTHC")]
    [IsoId("_bngPISR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is an Other Counterparty.")]
    OtherCounterparty = TradeCounterpartyTypeCode.OtherCounterparty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that party to the transaction is a Reporting Counterparty.
    /// Encoded/decoded by serializers as &quot;REPC&quot;.
    /// </summary>
    [EnumMember(Value = "REPC")]
    [IsoId("_bqNk4SR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is a Reporting Counterparty.")]
    ReportingCounterparty = TradeCounterpartyTypeCode.ReportingCounterparty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that party to the transaction is a Submitting Agent.
    /// Encoded/decoded by serializers as &quot;SBMA&quot;.
    /// </summary>
    [EnumMember(Value = "SBMA")]
    [IsoId("_btzrcSR8Ee2VuKUpJ7HXPg")]
    [Description(@"Specifies that party to the transaction is a Submitting Agent.")]
    SubmittingAgent = TradeCounterpartyTypeCode.SubmittingAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that party to the transaction is an Entity Responsible For Report.
    /// Encoded/decoded by serializers as &quot;ERFR&quot;.
    /// </summary>
    [EnumMember(Value = "ERFR")]
    [IsoId("_5Qm-kCxqEe2xAdY9t5fB3g")]
    [Description(@"Specifies that party to the transaction is an Entity Responsible For Report.")]
    EntityResponsibleForReport = TradeCounterpartyTypeCode.EntityResponsibleForReport, // same ordinal as derivation source for type conversions
    
}
