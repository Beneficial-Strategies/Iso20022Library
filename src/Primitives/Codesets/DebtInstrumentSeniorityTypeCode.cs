// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the seniority type of a specific debt instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Uq4csc4tEeSc85GUbgBycw")]
[Description(@"Specifies the seniority type of a specific debt instrument.")]
[Derivations(typeof(DebtInstrumentSeniorityType1Code), typeof(DebtInstrumentSeniorityType2Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<DebtInstrumentSeniorityTypeCode>))]
public enum DebtInstrumentSeniorityTypeCode
{
    /// <summary>
    /// Debt that takes priority over other unsecured or otherwise more junior debt owed by the issuer.
    /// Encoded/decoded by serializers as &quot;SNDB&quot;.
    /// </summary>
    [EnumMember(Value = "SNDB")]
    [IsoId("_c5p08M4tEeSc85GUbgBycw")]
    [Description(
        @"Debt that takes priority over other unsecured or otherwise more junior debt owed by the issuer."
    )]
    SeniorDebt,

    /// <summary>
    /// Subordinated debt or preferred equity instrument that represents a claim on a company&apos;s assets which is senior only to that of the common shares.
    /// Encoded/decoded by serializers as &quot;MZZD&quot;.
    /// </summary>
    [EnumMember(Value = "MZZD")]
    [IsoId("_c8oQcM4tEeSc85GUbgBycw")]
    [Description(
        @"Subordinated debt or preferred equity instrument that represents a claim on a company's assets which is senior only to that of the common shares."
    )]
    MezzanineDebt,

    /// <summary>
    /// Debt owed to an unsecured creditor that can only be paid, in the event of a liquidation, after the claims of secured creditors have been met.
    /// Encoded/decoded by serializers as &quot;SBOD&quot;.
    /// </summary>
    [EnumMember(Value = "SBOD")]
    [IsoId("_dAWS0M4tEeSc85GUbgBycw")]
    [Description(
        @"Debt owed to an unsecured creditor that can only be paid, in the event of a liquidation, after the claims of secured creditors have been met."
    )]
    SubordinatedDebt,

    /// <summary>
    /// Debt that is either unsecured or has a lower priority than of another debt claim on the same asset or property.
    /// Encoded/decoded by serializers as &quot;JUND&quot;.
    /// </summary>
    [EnumMember(Value = "JUND")]
    [IsoId("_dGAO4M4tEeSc85GUbgBycw")]
    [Description(
        @"Debt that is either unsecured or has a lower priority than of another debt claim on the same asset or property."
    )]
    JuniorDebt,

    /// <summary>
    /// Other type of debts.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VTTZsEEPEeWwF-kIleVYXQ")]
    [Description(@"Other type of debts.")]
    Other,

    /// <summary>
    /// Debt with a high payment priority above lower ranking junior and subordinated but below preferred.
    /// Encoded/decoded by serializers as &quot;SNPR&quot;.
    /// </summary>
    [EnumMember(Value = "SNPR")]
    [IsoId("_-3mhYFBVEfCpNoeDQdjnVw")]
    [Description(@"Debt with a high payment priority above lower ranking junior and subordinated but below preferred.")]
    SeniorNonPreferred,

    /// <summary>
    /// Debt with a high payment priority above non-preferred and other lower ranking junior and subordinated.
    /// Encoded/decoded by serializers as &quot;SPRF&quot;.
    /// </summary>
    [EnumMember(Value = "SPRF")]
    [IsoId("_8KxuwFBVEfCpNoeDQdjnVw")]
    [Description(@"Debt with a high payment priority above non-preferred and other lower ranking junior and subordinated.")]
    SeniorPreferred,

    /// <summary>
    /// Debt with a high payment priority above preferred and other lower ranking junior and subordinated.
    /// Encoded/decoded by serializers as &quot;SSEC&quot;.
    /// </summary>
    [EnumMember(Value = "SSEC")]
    [IsoId("_4lVSEFBVEfCpNoeDQdjnVw")]
    [Description(@"Debt with a high payment priority above preferred and other lower ranking junior and subordinated.")]
    SeniorSecured,

    /// <summary>
    /// Debt with a high payment priority above preferred and other lower ranking junior and subordinated but below secured debt.
    /// Encoded/decoded by serializers as &quot;SUNS&quot;.
    /// </summary>
    [EnumMember(Value = "SUNS")]
    [IsoId("_6a9-AFBVEfCpNoeDQdjnVw")]
    [Description(@"Debt with a high payment priority above preferred and other lower ranking junior and subordinated but below secured debt.")]
    SeniorUnsecured,
}
