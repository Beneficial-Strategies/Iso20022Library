// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Fraud reporting action codes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_PJSbgJgFEee-7IkMvqfAcA")]
[Description(@"Fraud reporting action codes.")]
[DerivedFrom(typeof(FraudReportingActionCode))]
public enum FraudReportingAction1Code
{
    /// <summary>
    /// Fraud information already reported.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_SrO4QZgFEee-7IkMvqfAcA")]
    [Description(@"Fraud information already reported.")]
    Duplicate = FraudReportingActionCode.Duplicate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Closing a previously reported fraud.
    /// Encoded/decoded by serializers as &quot;CLSE&quot;.
    /// </summary>
    [EnumMember(Value = "CLSE")]
    [IsoId("_SzSoEZgFEee-7IkMvqfAcA")]
    [Description(@"Closing a previously reported fraud.")]
    Close = FraudReportingActionCode.Close, // same ordinal as derivation source for type conversions

    /// <summary>
    /// New fraud information not reported yet.
    /// Encoded/decoded by serializers as &quot;NEWF&quot;.
    /// </summary>
    [EnumMember(Value = "NEWF")]
    [IsoId("_S7ilIZgFEee-7IkMvqfAcA")]
    [Description(@"New fraud information not reported yet.")]
    New = FraudReportingActionCode.New, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other process about a fraud already reported defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_TD-vcZgFEee-7IkMvqfAcA")]
    [Description(@"Other process about a fraud already reported defined at national level.")]
    OtherNational = FraudReportingActionCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other process about a fraud already reported defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_TPeNwZgFEee-7IkMvqfAcA")]
    [Description(@"Other process about a fraud already reported defined at private level.")]
    OtherPrivate = FraudReportingActionCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reopen a previously closed reported fraud case
    /// Encoded/decoded by serializers as &quot;REOP&quot;.
    /// </summary>
    [EnumMember(Value = "REOP")]
    [IsoId("_TXxOIZgFEee-7IkMvqfAcA")]
    [Description(@"Reopen a previously closed reported fraud case")]
    Reopen = FraudReportingActionCode.Reopen, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Update information about a fraud already reported.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_TgMKUZgFEee-7IkMvqfAcA")]
    [Description(@"Update information about a fraud already reported.")]
    Update = FraudReportingActionCode.Update, // same ordinal as derivation source for type conversions
}
