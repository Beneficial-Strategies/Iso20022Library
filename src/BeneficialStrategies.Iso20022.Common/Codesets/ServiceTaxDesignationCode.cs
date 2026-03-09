// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the taxable status of the service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6WNctpqlEeGSON8vddiWzQ_739430745")]
[Description(@"Defines the taxable status of the service.")]
[Derivations(typeof(ServiceTaxDesignation1Code))]
public enum ServiceTaxDesignationCode
{
    /// <summary>
    /// No taxes are due.
    /// Encoded/decoded by serializers as &quot;XMPT&quot;.
    /// </summary>
    [EnumMember(Value = "XMPT")]
    [IsoId("_6WXNsJqlEeGSON8vddiWzQ_-1826168172")]
    [Description(@"No taxes are due.")]
    Exempt,
    
    /// <summary>
    /// Tax is due but at zero percent and a zero charge.
    /// Encoded/decoded by serializers as &quot;ZERO&quot;.
    /// </summary>
    [EnumMember(Value = "ZERO")]
    [IsoId("_6WXNsZqlEeGSON8vddiWzQ_-1583318414")]
    [Description(@"Tax is due but at zero percent and a zero charge.")]
    ZeroRate,
    
    /// <summary>
    /// One or more taxes are due on this service.
    /// Encoded/decoded by serializers as &quot;TAXE&quot;.
    /// </summary>
    [EnumMember(Value = "TAXE")]
    [IsoId("_6WXNspqlEeGSON8vddiWzQ_-1665032100")]
    [Description(@"One or more taxes are due on this service.")]
    Taxable,
    
}
