// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the status of the billing statement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6VUE0pqlEeGSON8vddiWzQ_720168746")]
[Description(@"Defines the status of the billing statement.")]
[DerivedFrom(typeof(BillingStatementStatusCode))]
public enum BillingStatementStatus1Code
{
    /// <summary>
    /// Statement is the original statement.
    /// Encoded/decoded by serializers as &quot;ORGN&quot;.
    /// </summary>
    [EnumMember(Value = "ORGN")]
    [IsoId("_6VUE05qlEeGSON8vddiWzQ_1712373044")]
    [Description(@"Statement is the original statement.")]
    Original = BillingStatementStatusCode.Original, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Statement replaces the original statement.
    /// Encoded/decoded by serializers as &quot;RPLC&quot;.
    /// </summary>
    [EnumMember(Value = "RPLC")]
    [IsoId("_6VUE1JqlEeGSON8vddiWzQ_1116652808")]
    [Description(@"Statement replaces the original statement.")]
    Replace = BillingStatementStatusCode.Replace, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Statement is a test statement.
    /// Encoded/decoded by serializers as &quot;TEST&quot;.
    /// </summary>
    [EnumMember(Value = "TEST")]
    [IsoId("_6VUE1ZqlEeGSON8vddiWzQ_1105554031")]
    [Description(@"Statement is a test statement.")]
    Test = BillingStatementStatusCode.Test, // same ordinal as derivation source for type conversions
    
}
