// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// File action result of processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yLTcUFECEee94_dUz-hvgw")]
[Description(@"File action result of processing.")]
[DerivedFrom(typeof(FileActionResultCode))]
public enum FileActionResult1Code
{
    /// <summary>
    /// Identified record is already present in the file.
    /// Encoded/decoded by serializers as &quot;DUPR&quot;.
    /// </summary>
    [EnumMember(Value = "DUPR")]
    [IsoId("_1m3kQVECEee94_dUz-hvgw")]
    [Description(@"Identified record is already present in the file.")]
    DuplicateRecord = FileActionResultCode.DuplicateRecord, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid record field syntax.
    /// Encoded/decoded by serializers as &quot;FERD&quot;.
    /// </summary>
    [EnumMember(Value = "FERD")]
    [IsoId("_2AgMQlECEee94_dUz-hvgw")]
    [Description(@"Invalid record field syntax.")]
    FieldEditError = FileActionResultCode.FieldEditError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid field value in record.
    /// Encoded/decoded by serializers as &quot;INFD&quot;.
    /// </summary>
    [EnumMember(Value = "INFD")]
    [IsoId("_2KX58lECEee94_dUz-hvgw")]
    [Description(@"Invalid field value in record.")]
    FieldValueInvalid = FileActionResultCode.FieldValueInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// File is locked and cannot be modified.
    /// Encoded/decoded by serializers as &quot;FLCK&quot;.
    /// </summary>
    [EnumMember(Value = "FLCK")]
    [IsoId("_2YQk8lECEee94_dUz-hvgw")]
    [Description(@"File is locked and cannot be modified.")]
    FileLocked = FileActionResultCode.FileLocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid record format.
    /// Encoded/decoded by serializers as &quot;FTER&quot;.
    /// </summary>
    [EnumMember(Value = "FTER")]
    [IsoId("_2jasElECEee94_dUz-hvgw")]
    [Description(@"Invalid record format.")]
    FormatError = FileActionResultCode.FormatError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Requested file action not supported.
    /// Encoded/decoded by serializers as &quot;NSUP&quot;.
    /// </summary>
    [EnumMember(Value = "NSUP")]
    [IsoId("_2tRyslECEee94_dUz-hvgw")]
    [Description(@"Requested file action not supported.")]
    NotSupported = FileActionResultCode.NotSupported, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of file action result
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_23jJAlECEee94_dUz-hvgw")]
    [Description(@"Other type of file action result")]
    Other = FileActionResultCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Action performed successfully
    /// Encoded/decoded by serializers as &quot;SUCC&quot;.
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_3D14klECEee94_dUz-hvgw")]
    [Description(@"Action performed successfully")]
    Successful = FileActionResultCode.Successful, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identified record was not found.
    /// Encoded/decoded by serializers as &quot;UTLR&quot;.
    /// </summary>
    [EnumMember(Value = "UTLR")]
    [IsoId("_3NXA8lECEee94_dUz-hvgw")]
    [Description(@"Identified record was not found.")]
    UnableToLocateRecord = FileActionResultCode.UnableToLocateRecord, // same ordinal as derivation source for type conversions

    /// <summary>
    /// File is unknown.
    /// Encoded/decoded by serializers as &quot;UNKF&quot;.
    /// </summary>
    [EnumMember(Value = "UNKF")]
    [IsoId("_3b2I4lECEee94_dUz-hvgw")]
    [Description(@"File is unknown.")]
    UnknownFile = FileActionResultCode.UnknownFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Action could not be performed.
    /// Encoded/decoded by serializers as &quot;USUC&quot;.
    /// </summary>
    [EnumMember(Value = "USUC")]
    [IsoId("_3nfYMlECEee94_dUz-hvgw")]
    [Description(@"Action could not be performed.")]
    Unsuccessful = FileActionResultCode.Unsuccessful, // same ordinal as derivation source for type conversions
}
