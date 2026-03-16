// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of eligibility.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jBmr4e5NEeCisYr99QEiWA_-1187231304")]
[Description(@"Defines the type of eligibility.")]
[Derivations(typeof(EligibilityType1Code))]
public enum EligibilityTypeCode
{
    /// <summary>
    /// Eligibility applies at securities level.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_jBmr4u5NEeCisYr99QEiWA_-356717849")]
    [Description(@"Eligibility applies at securities level.")]
    Securities,

    /// <summary>
    /// Eligibility applies at the level of issuer CSD.
    /// All of the securities issued by the issuer CSD are eligible.
    /// Encoded/decoded by serializers as &quot;ISCS&quot;.
    /// </summary>
    [EnumMember(Value = "ISCS")]
    [IsoId("_jBmr4-5NEeCisYr99QEiWA_597315770")]
    [Description(
        @"Eligibility applies at the level of issuer CSD.|All of the securities issued by the issuer CSD are eligible."
    )]
    IssuerCSD,

    /// <summary>
    /// Eligibility applies at country level.
    /// All of the securities issued in that country are eligible.
    /// Encoded/decoded by serializers as &quot;CTRY&quot;.
    /// </summary>
    [EnumMember(Value = "CTRY")]
    [IsoId("_jBmr5O5NEeCisYr99QEiWA_1479587050")]
    [Description(
        @"Eligibility applies at country level.|All of the securities issued in that country are eligible."
    )]
    Country,
}
