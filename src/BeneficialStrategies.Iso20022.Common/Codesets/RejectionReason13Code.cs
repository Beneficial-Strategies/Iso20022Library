// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of a rejection of a movement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zgv7idp-Ed-ak6NoX_4Aeg_1920640283")]
[Description(@"Specifies the reason of a rejection of a movement.")]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason13Code
{
    /// <summary>
    /// The validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_Zg5FcNp-Ed-ak6NoX_4Aeg_-1186004164")]
    [Description(@"The validation of the advice/instruction/request failed.")]
    FailedValidation = RejectionReasonCode.FailedValidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Several message with the same identification.
    /// Encoded/decoded by serializers as &quot;SAID&quot;.
    /// </summary>
    [EnumMember(Value = "SAID")]
    [IsoId("_Zg5Fcdp-Ed-ak6NoX_4Aeg_-1186004134")]
    [Description(@"Several message with the same identification.")]
    SameIdentification = RejectionReasonCode.SameIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction contains an invalid message identification, identification is unknown.
    /// Encoded/decoded by serializers as &quot;INID&quot;.
    /// </summary>
    [EnumMember(Value = "INID")]
    [IsoId("_Zg5Fctp-Ed-ak6NoX_4Aeg_-1186004103")]
    [Description(
        @"Instruction contains an invalid message identification, identification is unknown."
    )]
    InvalidIdentification = RejectionReasonCode.InvalidIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid corporate action identification supplied.
    /// Encoded/decoded by serializers as &quot;REFI&quot;.
    /// </summary>
    [EnumMember(Value = "REFI")]
    [IsoId("_Zg5Fc9p-Ed-ak6NoX_4Aeg_-1186004102")]
    [Description(@"Invalid corporate action identification supplied.")]
    InvalidCAIdentification = RejectionReasonCode.InvalidCAIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer CA Identification does not correspond with the Corporate Action Identification supplied.
    /// Encoded/decoded by serializers as &quot;MICA&quot;.
    /// </summary>
    [EnumMember(Value = "MICA")]
    [IsoId("_Zg5FdNp-Ed-ak6NoX_4Aeg_-1186004072")]
    [Description(
        @"Issuer CA Identification does not correspond with the Corporate Action Identification supplied."
    )]
    MismatchedCAIdentification = RejectionReasonCode.MismatchedCAIdentification, // same ordinal as derivation source for type conversions
}
