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
[IsoId("_7EJK0Jb6Eeuc6pwKtqbEVQ")]
[Description(@"Determines the type of file action.")]
[DerivedFrom(typeof(FileActionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FileActionType2Code>))]
#endif
public enum FileActionType2Code
{
    /// <summary>
    /// Add a new record or file.
    /// Encoded/decoded by serializers as &quot;ADDD&quot;.
    /// </summary>
    [EnumMember(Value = "ADDD")]
    [IsoId("_A7LPoZb7Eeuc6pwKtqbEVQ")]
    [Description(@"Add a new record or file.")]
    Add = FileActionTypeCode.Add, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Replacing  previously added records.
    /// Encoded/decoded by serializers as &quot;BRPT&quot;.
    /// </summary>
    [EnumMember(Value = "BRPT")]
    [IsoId("_BDlkwZb7Eeuc6pwKtqbEVQ")]
    [Description(@"Replacing  previously added records.")]
    BulkReplacement = FileActionTypeCode.BulkReplacement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delete an existing record or file.
    /// Encoded/decoded by serializers as &quot;DELT&quot;.
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_BJ62QZb7Eeuc6pwKtqbEVQ")]
    [Description(@"Delete an existing record or file.")]
    Delete = FileActionTypeCode.Delete, // same ordinal as derivation source for type conversions

    /// <summary>
    /// System purge.
    /// Encoded/decoded by serializers as &quot;DLSP&quot;.
    /// </summary>
    [EnumMember(Value = "DLSP")]
    [IsoId("_BPhvAZb7Eeuc6pwKtqbEVQ")]
    [Description(@"System purge.")]
    DeleteRecordSystemPurge = FileActionTypeCode.DeleteRecordSystemPurge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request the content of an existing record or file.
    /// Encoded/decoded by serializers as &quot;ENQR&quot;.
    /// </summary>
    [EnumMember(Value = "ENQR")]
    [IsoId("_BV3AgZb7Eeuc6pwKtqbEVQ")]
    [Description(@"Request the content of an existing record or file.")]
    Enquire = FileActionTypeCode.Enquire, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of file action defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_BcMSAZb7Eeuc6pwKtqbEVQ")]
    [Description(@"Other type of file action defined at national level.")]
    OtherNational = FileActionTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of file action defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_BiAmIZb7Eeuc6pwKtqbEVQ")]
    [Description(@"Other type of file action defined at private level.")]
    OtherPrivate = FileActionTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Add a new record or file if none exists or replace an existing record or file if one exists.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_BnuMkZb7Eeuc6pwKtqbEVQ")]
    [Description(
        @"Add a new record or file if none exists or replace an existing record or file if one exists."
    )]
    Replace = FileActionTypeCode.Replace, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for a file or record.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_BuMA8Zb7Eeuc6pwKtqbEVQ")]
    [Description(@"Request for a file or record.")]
    Request = FileActionTypeCode.Request, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Update an existing record or file.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_B0JfAZb7Eeuc6pwKtqbEVQ")]
    [Description(@"Update an existing record or file.")]
    Update = FileActionTypeCode.Update, // same ordinal as derivation source for type conversions
}
