// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Determines the type of file action.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_O2unUXFiEfC68Y4jZPNEug")]
[Description(@"Determines the type of file action.")]
[DerivedFrom(typeof(FileActionTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<FileActionType3Code>))]
public enum FileActionType3Code
{
    /// <summary>
    /// Add a new record or file.
    /// Encoded/decoded by serializers as &quot;ADDD&quot;.
    /// </summary>
    [EnumMember(Value = "ADDD")]
    [IsoId("_O5LeYXFiEfC68Y4jZPNEug")]
    [Description(@"Add a new record or file.")]
    Add = FileActionTypeCode.Add, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Replacing  previously added records.
    /// Encoded/decoded by serializers as &quot;BRPT&quot;.
    /// </summary>
    [EnumMember(Value = "BRPT")]
    [IsoId("_O5LeY3FiEfC68Y4jZPNEug")]
    [Description(@"Replacing  previously added records.")]
    BulkReplacement = FileActionTypeCode.BulkReplacement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delete an existing record or file.
    /// Encoded/decoded by serializers as &quot;DELT&quot;.
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_O5LeZXFiEfC68Y4jZPNEug")]
    [Description(@"Delete an existing record or file.")]
    Delete = FileActionTypeCode.Delete, // same ordinal as derivation source for type conversions

    /// <summary>
    /// System purge.
    /// Encoded/decoded by serializers as &quot;DLSP&quot;.
    /// </summary>
    [EnumMember(Value = "DLSP")]
    [IsoId("_O5LeZ3FiEfC68Y4jZPNEug")]
    [Description(@"System purge.")]
    DeleteRecordSystemPurge = FileActionTypeCode.DeleteRecordSystemPurge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request the content of an existing record or file.
    /// Encoded/decoded by serializers as &quot;ENQR&quot;.
    /// </summary>
    [EnumMember(Value = "ENQR")]
    [IsoId("_O5LeaXFiEfC68Y4jZPNEug")]
    [Description(@"Request the content of an existing record or file.")]
    Enquire = FileActionTypeCode.Enquire, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Add a new record or file if none exists or replace an existing record or file if one exists.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_O5Leb3FiEfC68Y4jZPNEug")]
    [Description(@"Add a new record or file if none exists or replace an existing record or file if one exists.")]
    Replace = FileActionTypeCode.Replace, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for a file or record.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_O5LecXFiEfC68Y4jZPNEug")]
    [Description(@"Request for a file or record.")]
    Request = FileActionTypeCode.Request, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Update an existing record or file.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_O5Lec3FiEfC68Y4jZPNEug")]
    [Description(@"Update an existing record or file.")]
    Update = FileActionTypeCode.Update, // same ordinal as derivation source for type conversions
}
