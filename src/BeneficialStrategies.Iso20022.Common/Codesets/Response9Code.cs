// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the performed service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7CBR4Q1PEeqjM-rxn3HuXQ")]
[Description(@"Result of the performed service.")]
[DerivedFrom(typeof(ResponseCode))]
public enum Response9Code
{
    /// <summary>
    /// Service has been successfuly provided.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_7ORlMQ1PEeqjM-rxn3HuXQ")]
    [Description(@"Service has been successfuly provided.")]
    Approved = ResponseCode.Approved, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service is declined.
    /// Encoded/decoded by serializers as &quot;DECL&quot;.
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("_7ORlMw1PEeqjM-rxn3HuXQ")]
    [Description(@"Service is declined.")]
    Declined = ResponseCode.Declined, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service has been partialy provided.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_7ORlNQ1PEeqjM-rxn3HuXQ")]
    [Description(@"Service has been partialy provided.")]
    PartialApproved = ResponseCode.PartialApproved, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been received but hasn&apos;t been processed.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_9uQ1sQ1PEeqjM-rxn3HuXQ")]
    [Description(@"Transaction has been received but hasn't been processed.")]
    Suspended = ResponseCode.Suspended, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service cannot be provided for technical reason (eg timeout contacting the Issuer, security problem).
    /// Encoded/decoded by serializers as &quot;TECH&quot;.
    /// </summary>
    [EnumMember(Value = "TECH")]
    [IsoId("_92_68Q1PEeqjM-rxn3HuXQ")]
    [Description(
        @"Service cannot be provided for technical reason (eg timeout contacting the Issuer, security problem)."
    )]
    TechnicalError = ResponseCode.TechnicalError, // same ordinal as derivation source for type conversions
}
