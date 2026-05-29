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
[IsoId("_KF-gUKkxEeynsLtPxJMJTQ")]
[Description(
    @"Specifies the status reason, as published in an external collateral reference data status reason code list.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalCollateralReferenceDataStatusReasonCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalCollateralReferenceDataStatusReason1Code>))]
public enum ExternalCollateralReferenceDataStatusReason1Code
{
    /// <summary>
    /// Instructing party/counterparty combination is not configured for the instruction type.
    /// Encoded/decoded by serializers as &quot;COMB&quot;.
    /// </summary>
    [EnumMember(Value = "COMB")]
    [IsoId("_MzIDEakxEeynsLtPxJMJTQ")]
    [Description(@"Instructing party/counterparty combination is not configured for the instruction type.")]
    InstructingPartyCounterpartyCombination = ExternalCollateralReferenceDataStatusReasonCode.InstructingPartyCounterpartyCombination, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Eligibility set profile not found.
    /// Encoded/decoded by serializers as &quot;ESPN&quot;.
    /// </summary>
    [EnumMember(Value = "ESPN")]
    [IsoId("_MdX1gakxEeynsLtPxJMJTQ")]
    [Description(@"Eligibility set profile not found.")]
    EligibilitySetProfileNotFound = ExternalCollateralReferenceDataStatusReasonCode.EligibilitySetProfileNotFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Extension not allowed as there is no end date for original instruction.
    /// Encoded/decoded by serializers as &quot;EXTN&quot;.
    /// </summary>
    [EnumMember(Value = "EXTN")]
    [IsoId("_MhjK4akxEeynsLtPxJMJTQ")]
    [Description(@"Extension not allowed as there is no end date for original instruction.")]
    ExtensionNotAllowed = ExternalCollateralReferenceDataStatusReasonCode.ExtensionNotAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Index does not exist.
    /// Encoded/decoded by serializers as &quot;INDX&quot;.
    /// </summary>
    [EnumMember(Value = "INDX")]
    [IsoId("_MmKlIakxEeynsLtPxJMJTQ")]
    [Description(@"Index does not exist.")]
    IndexDoesNotExist = ExternalCollateralReferenceDataStatusReasonCode.IndexDoesNotExist, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Input parameters not supported (when the instruction comes at  thet transaction level).
    /// Encoded/decoded by serializers as &quot;IPNS&quot;.
    /// </summary>
    [EnumMember(Value = "IPNS")]
    [IsoId("_Mu9UwakxEeynsLtPxJMJTQ")]
    [Description(@"Input parameters not supported (when the instruction comes at  thet transaction level).")]
    InputParametersNotSupported = ExternalCollateralReferenceDataStatusReasonCode.InputParametersNotSupported, // same ordinal as derivation source for type conversions

    /// <summary>
    /// List identification does not exist for the instructing party.
    /// Encoded/decoded by serializers as &quot;LIST&quot;.
    /// </summary>
    [EnumMember(Value = "LIST")]
    [IsoId("_M76ysakxEeynsLtPxJMJTQ")]
    [Description(@"List identification does not exist for the instructing party.")]
    ListIdentificationDoesNotExist = ExternalCollateralReferenceDataStatusReasonCode.ListIdentificationDoesNotExist, // same ordinal as derivation source for type conversions

    /// <summary>
    /// All fields in message format are not supported.
    /// Encoded/decoded by serializers as &quot;MFNS&quot;.
    /// </summary>
    [EnumMember(Value = "MFNS")]
    [IsoId("_MZWRIakxEeynsLtPxJMJTQ")]
    [Description(@"All fields in message format are not supported.")]
    AllFieldsNotSupported = ExternalCollateralReferenceDataStatusReasonCode.AllFieldsNotSupported, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructing party not configured for the instruction type.
    /// Encoded/decoded by serializers as &quot;NCFG&quot;.
    /// </summary>
    [EnumMember(Value = "NCFG")]
    [IsoId("_M3TYcakxEeynsLtPxJMJTQ")]
    [Description(@"Instructing party not configured for the instruction type.")]
    InstructingPartyNotConfigured = ExternalCollateralReferenceDataStatusReasonCode.InstructingPartyNotConfigured, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original instruction not found.
    /// Encoded/decoded by serializers as &quot;NRGN&quot;.
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_NEQ2YakxEeynsLtPxJMJTQ")]
    [Description(@"Original instruction not found.")]
    OriginalInstructionNotFound = ExternalCollateralReferenceDataStatusReasonCode.OriginalInstructionNotFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original instruction already expired.
    /// Encoded/decoded by serializers as &quot;OIEX&quot;.
    /// </summary>
    [EnumMember(Value = "OIEX")]
    [IsoId("_NISawakxEeynsLtPxJMJTQ")]
    [Description(@"Original instruction already expired.")]
    OriginalIntructionExpired = ExternalCollateralReferenceDataStatusReasonCode.OriginalIntructionExpired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Does not support this removal type.
    /// Encoded/decoded by serializers as &quot;RMVL&quot;.
    /// </summary>
    [EnumMember(Value = "RMVL")]
    [IsoId("_NM51AakxEeynsLtPxJMJTQ")]
    [Description(@"Does not support this removal type.")]
    RemovalType = ExternalCollateralReferenceDataStatusReasonCode.RemovalType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Start date of original instruction does not match.
    /// Encoded/decoded by serializers as &quot;SDNM&quot;.
    /// </summary>
    [EnumMember(Value = "SDNM")]
    [IsoId("_Nang4akxEeynsLtPxJMJTQ")]
    [Description(@"Start date of original instruction does not match.")]
    StartDateOriginalInstruction = ExternalCollateralReferenceDataStatusReasonCode.StartDateOriginalInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security identification is not supported.
    /// Encoded/decoded by serializers as &quot;SIDN&quot;.
    /// </summary>
    [EnumMember(Value = "SIDN")]
    [IsoId("_NRrAQakxEeynsLtPxJMJTQ")]
    [Description(@"Security identification is not supported.")]
    SecurityIdentificationNotSupported = ExternalCollateralReferenceDataStatusReasonCode.SecurityIdentificationNotSupported, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security identification type not supported.
    /// Encoded/decoded by serializers as &quot;SITN&quot;.
    /// </summary>
    [EnumMember(Value = "SITN")]
    [IsoId("_NWAGoakxEeynsLtPxJMJTQ")]
    [Description(@"Security identification type not supported.")]
    SecurityIdentificationType = ExternalCollateralReferenceDataStatusReasonCode.SecurityIdentificationType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// System error.
    /// Encoded/decoded by serializers as &quot;SYST&quot;.
    /// </summary>
    [EnumMember(Value = "SYST")]
    [IsoId("_Ne8AMakxEeynsLtPxJMJTQ")]
    [Description(@"System error.")]
    SystemError = ExternalCollateralReferenceDataStatusReasonCode.SystemError, // same ordinal as derivation source for type conversions
}
