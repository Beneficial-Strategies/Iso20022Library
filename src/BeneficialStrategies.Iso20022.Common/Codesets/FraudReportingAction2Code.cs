// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Fraud reporting action codes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3Y6dQRODEfC1ZfCQz0xB3g")]
[Description(@"Fraud reporting action codes.")]
[DerivedFrom(typeof(FraudReportingActionCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<FraudReportingAction2Code>))]
public enum FraudReportingAction2Code
{
    /// <summary>
    /// Closing a previously reported fraud.
    /// Encoded/decoded by serializers as &quot;CLSE&quot;.
    /// </summary>
    [EnumMember(Value = "CLSE")]
    [IsoId("_3gUFwxODEfC1ZfCQz0xB3g")]
    [Description(@"Closing a previously reported fraud.")]
    Close = FraudReportingActionCode.Close, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fraud information already reported.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_3gUFwRODEfC1ZfCQz0xB3g")]
    [Description(@"Fraud information already reported.")]
    Duplicate = FraudReportingActionCode.Duplicate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// New fraud information not reported yet.
    /// Encoded/decoded by serializers as &quot;NEWF&quot;.
    /// </summary>
    [EnumMember(Value = "NEWF")]
    [IsoId("_3gUFxRODEfC1ZfCQz0xB3g")]
    [Description(@"New fraud information not reported yet.")]
    New = FraudReportingActionCode.New, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reopen a previously closed reported fraud case.
    /// Encoded/decoded by serializers as &quot;REOP&quot;.
    /// </summary>
    [EnumMember(Value = "REOP")]
    [IsoId("_3gUFyxODEfC1ZfCQz0xB3g")]
    [Description(@"Reopen a previously closed reported fraud case.")]
    Reopen = FraudReportingActionCode.Reopen, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Update information about a fraud already reported.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_3gUFzRODEfC1ZfCQz0xB3g")]
    [Description(@"Update information about a fraud already reported.")]
    Update = FraudReportingActionCode.Update, // same ordinal as derivation source for type conversions
}
