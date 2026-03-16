// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// File action processing result.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_K1GHcFEBEee94_dUz-hvgw")]
[Description(@"File action processing result.")]
[Derivations(typeof(FileActionResult1Code))]
public enum FileActionResultCode
{
    /// <summary>
    /// Identified record is already present in the file.
    /// Encoded/decoded by serializers as &quot;DUPR&quot;.
    /// </summary>
    [EnumMember(Value = "DUPR")]
    [IsoId("_Pt5CYFEBEee94_dUz-hvgw")]
    [Description(@"Identified record is already present in the file.")]
    DuplicateRecord,

    /// <summary>
    /// Invalid record field syntax.
    /// Encoded/decoded by serializers as &quot;FERD&quot;.
    /// </summary>
    [EnumMember(Value = "FERD")]
    [IsoId("_VZwZAFEBEee94_dUz-hvgw")]
    [Description(@"Invalid record field syntax.")]
    FieldEditError,

    /// <summary>
    /// Invalid field value in record.
    /// Encoded/decoded by serializers as &quot;INFD&quot;.
    /// </summary>
    [EnumMember(Value = "INFD")]
    [IsoId("_gJrfYFEBEee94_dUz-hvgw")]
    [Description(@"Invalid field value in record.")]
    FieldValueInvalid,

    /// <summary>
    /// File is locked and cannot be modified.
    /// Encoded/decoded by serializers as &quot;FLCK&quot;.
    /// </summary>
    [EnumMember(Value = "FLCK")]
    [IsoId("_gNZhwFEBEee94_dUz-hvgw")]
    [Description(@"File is locked and cannot be modified.")]
    FileLocked,

    /// <summary>
    /// Invalid record format.
    /// Encoded/decoded by serializers as &quot;FTER&quot;.
    /// </summary>
    [EnumMember(Value = "FTER")]
    [IsoId("_xcLh8FEBEee94_dUz-hvgw")]
    [Description(@"Invalid record format.")]
    FormatError,

    /// <summary>
    /// Requested file action not supported.
    /// Encoded/decoded by serializers as &quot;NSUP&quot;.
    /// </summary>
    [EnumMember(Value = "NSUP")]
    [IsoId("_22ywgFEBEee94_dUz-hvgw")]
    [Description(@"Requested file action not supported.")]
    NotSupported,

    /// <summary>
    /// Action performed successfully
    /// Encoded/decoded by serializers as &quot;SUCC&quot;.
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("__5-oQFEBEee94_dUz-hvgw")]
    [Description(@"Action performed successfully")]
    Successful,

    /// <summary>
    /// Identified record was not found.
    /// Encoded/decoded by serializers as &quot;UTLR&quot;.
    /// </summary>
    [EnumMember(Value = "UTLR")]
    [IsoId("_IsQWMFECEee94_dUz-hvgw")]
    [Description(@"Identified record was not found.")]
    UnableToLocateRecord,

    /// <summary>
    /// File is unknown.
    /// Encoded/decoded by serializers as &quot;UNKF&quot;.
    /// </summary>
    [EnumMember(Value = "UNKF")]
    [IsoId("_R6qmgFECEee94_dUz-hvgw")]
    [Description(@"File is unknown.")]
    UnknownFile,

    /// <summary>
    /// Other type of file action result
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Zg-3oFECEee94_dUz-hvgw")]
    [Description(@"Other type of file action result")]
    Other,

    /// <summary>
    /// Action could not be performed.
    /// Encoded/decoded by serializers as &quot;USUC&quot;.
    /// </summary>
    [EnumMember(Value = "USUC")]
    [IsoId("_bg12kFECEee94_dUz-hvgw")]
    [Description(@"Action could not be performed.")]
    Unsuccessful,
}
