// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the source of Common Reporting Standard (CRS) status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kOZ0kENsEeaS-NnwLNvMPg")]
[Description(@"Specifies the source of Common Reporting Standard (CRS) status.")]
[Derivations(typeof(CRSSourceStatus1Code))]
public enum CRSSourceStatusCode
{
    /// <summary>
    /// Source of the Common Reporting Standard (CRS) status is calculated.
    /// Encoded/decoded by serializers as &quot;CALC&quot;.
    /// </summary>
    [EnumMember(Value = "CALC")]
    [IsoId("_rSF5wUNsEeaS-NnwLNvMPg")]
    [Description(@"Source of the Common Reporting Standard (CRS) status is calculated.")]
    Calculated,

    /// <summary>
    /// Source of the Common Reporting Standard (CRS) status is as declared by the investor.
    /// Encoded/decoded by serializers as &quot;DECL&quot;.
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("_rSF5wkNsEeaS-NnwLNvMPg")]
    [Description(
        @"Source of the Common Reporting Standard (CRS) status is as declared by the investor."
    )]
    Declared,
}
