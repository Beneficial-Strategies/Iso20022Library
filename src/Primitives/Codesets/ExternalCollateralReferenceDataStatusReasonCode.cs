// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status reason, as published in an external collateral reference data status reason code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NUvNQKkvEeynsLtPxJMJTQ")]
[Description(
    @"Specifies the status reason, as published in an external collateral reference data status reason code list.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalCollateralReferenceDataStatusReason1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalCollateralReferenceDataStatusReasonCode>))]
public enum ExternalCollateralReferenceDataStatusReasonCode
{
    /// <summary>
    /// Instructing party/counterparty combination is not configured for the instruction type.
    /// Encoded/decoded by serializers as &quot;COMB&quot;.
    /// </summary>
    [EnumMember(Value = "COMB")]
    [IsoId("_G4Ak8KkwEeynsLtPxJMJTQ")]
    [Description(@"Instructing party/counterparty combination is not configured for the instruction type.")]
    InstructingPartyCounterpartyCombination,

    /// <summary>
    /// Eligibility set profile not found.
    /// Encoded/decoded by serializers as &quot;ESPN&quot;.
    /// </summary>
    [EnumMember(Value = "ESPN")]
    [IsoId("_zgFG8KkvEeynsLtPxJMJTQ")]
    [Description(@"Eligibility set profile not found.")]
    EligibilitySetProfileNotFound,

    /// <summary>
    /// Extension not allowed as there is no end date for original instruction.
    /// Encoded/decoded by serializers as &quot;EXTN&quot;.
    /// </summary>
    [EnumMember(Value = "EXTN")]
    [IsoId("_4EJIAKkvEeynsLtPxJMJTQ")]
    [Description(@"Extension not allowed as there is no end date for original instruction.")]
    ExtensionNotAllowed,

    /// <summary>
    /// Index does not exist.
    /// Encoded/decoded by serializers as &quot;INDX&quot;.
    /// </summary>
    [EnumMember(Value = "INDX")]
    [IsoId("_8HRmQKkvEeynsLtPxJMJTQ")]
    [Description(@"Index does not exist.")]
    IndexDoesNotExist,

    /// <summary>
    /// Input parameters not supported (when the instruction comes at  thet transaction level).
    /// Encoded/decoded by serializers as &quot;IPNS&quot;.
    /// </summary>
    [EnumMember(Value = "IPNS")]
    [IsoId("_A7uzwKkwEeynsLtPxJMJTQ")]
    [Description(@"Input parameters not supported (when the instruction comes at  thet transaction level).")]
    InputParametersNotSupported,

    /// <summary>
    /// List identification does not exist for the instructing party.
    /// Encoded/decoded by serializers as &quot;LIST&quot;.
    /// </summary>
    [EnumMember(Value = "LIST")]
    [IsoId("_STqI4KkwEeynsLtPxJMJTQ")]
    [Description(@"List identification does not exist for the instructing party.")]
    ListIdentificationDoesNotExist,

    /// <summary>
    /// All fields in message format are not supported.
    /// Encoded/decoded by serializers as &quot;MFNS&quot;.
    /// </summary>
    [EnumMember(Value = "MFNS")]
    [IsoId("_hKnLgKkvEeynsLtPxJMJTQ")]
    [Description(@"All fields in message format are not supported.")]
    AllFieldsNotSupported,

    /// <summary>
    /// Instructing party not configured for the instruction type.
    /// Encoded/decoded by serializers as &quot;NCFG&quot;.
    /// </summary>
    [EnumMember(Value = "NCFG")]
    [IsoId("_LwyRwKkwEeynsLtPxJMJTQ")]
    [Description(@"Instructing party not configured for the instruction type.")]
    InstructingPartyNotConfigured,

    /// <summary>
    /// Original instruction not found.
    /// Encoded/decoded by serializers as &quot;NRGN&quot;.
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_WOJBcKkwEeynsLtPxJMJTQ")]
    [Description(@"Original instruction not found.")]
    OriginalInstructionNotFound,

    /// <summary>
    /// Original instruction already expired.
    /// Encoded/decoded by serializers as &quot;OIEX&quot;.
    /// </summary>
    [EnumMember(Value = "OIEX")]
    [IsoId("_o4LesKkwEeynsLtPxJMJTQ")]
    [Description(@"Original instruction already expired.")]
    OriginalIntructionExpired,

    /// <summary>
    /// Does not support this removal type.
    /// Encoded/decoded by serializers as &quot;RMVL&quot;.
    /// </summary>
    [EnumMember(Value = "RMVL")]
    [IsoId("_yqUuMKkwEeynsLtPxJMJTQ")]
    [Description(@"Does not support this removal type.")]
    RemovalType,

    /// <summary>
    /// Start date of original instruction does not match.
    /// Encoded/decoded by serializers as &quot;SDNM&quot;.
    /// </summary>
    [EnumMember(Value = "SDNM")]
    [IsoId("_8DbyoKkwEeynsLtPxJMJTQ")]
    [Description(@"Start date of original instruction does not match.")]
    StartDateOriginalInstruction,

    /// <summary>
    /// Security identification is not supported.
    /// Encoded/decoded by serializers as &quot;SIDN&quot;.
    /// </summary>
    [EnumMember(Value = "SIDN")]
    [IsoId("_0wIkIKkwEeynsLtPxJMJTQ")]
    [Description(@"Security identification is not supported.")]
    SecurityIdentificationNotSupported,

    /// <summary>
    /// Security identification type not supported.
    /// Encoded/decoded by serializers as &quot;SITN&quot;.
    /// </summary>
    [EnumMember(Value = "SITN")]
    [IsoId("_5PIfAKkwEeynsLtPxJMJTQ")]
    [Description(@"Security identification type not supported.")]
    SecurityIdentificationType,

    /// <summary>
    /// System error.
    /// Encoded/decoded by serializers as &quot;SYST&quot;.
    /// </summary>
    [EnumMember(Value = "SYST")]
    [IsoId("_BWJCYKkxEeynsLtPxJMJTQ")]
    [Description(@"System error.")]
    SystemError,
}
