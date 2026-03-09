// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Determines the type of file action service.
/// ISO 8583:87 bit 91; ISO 8583:93/2003 bit 24
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gSYcUFDpEee94_dUz-hvgw")]
[Description(@"Determines the type of file action service.|ISO 8583:87 bit 91; ISO 8583:93/2003 bit 24")]
[Derivations(typeof(FileActionType1Code),typeof(FileActionType2Code))]
public enum FileActionTypeCode
{
    /// <summary>
    /// Add a new record or file.
    /// Encoded/decoded by serializers as &quot;ADDD&quot;.
    /// </summary>
    [EnumMember(Value = "ADDD")]
    [IsoId("_r5DkgFDpEee94_dUz-hvgw")]
    [Description(@"Add a new record or file.")]
    Add,
    
    /// <summary>
    /// Update an existing record or file.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_v5sIYFDpEee94_dUz-hvgw")]
    [Description(@"Update an existing record or file.")]
    Update,
    
    /// <summary>
    /// Delete an existing record or file.
    /// Encoded/decoded by serializers as &quot;DELT&quot;.
    /// </summary>
    [EnumMember(Value = "DELT")]
    [IsoId("_5aB2MFDpEee94_dUz-hvgw")]
    [Description(@"Delete an existing record or file.")]
    Delete,
    
    /// <summary>
    /// Add a new record or file if none exists or replace an existing record or file if one exists.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_95wJ0FDpEee94_dUz-hvgw")]
    [Description(@"Add a new record or file if none exists or replace an existing record or file if one exists.")]
    Replace,
    
    /// <summary>
    /// Request the content of an existing record or file.
    /// Encoded/decoded by serializers as &quot;ENQR&quot;.
    /// </summary>
    [EnumMember(Value = "ENQR")]
    [IsoId("_H57OQFDqEee94_dUz-hvgw")]
    [Description(@"Request the content of an existing record or file.")]
    Enquire,
    
    /// <summary>
    /// Other type of file action defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_PGFS8FDqEee94_dUz-hvgw")]
    [Description(@"Other type of file action defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other type of file action defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_UTMRAFDqEee94_dUz-hvgw")]
    [Description(@"Other type of file action defined at private level.")]
    OtherPrivate,
    
    /// <summary>
    /// Replacing  previously added records.
    /// Encoded/decoded by serializers as &quot;BRPT&quot;.
    /// </summary>
    [EnumMember(Value = "BRPT")]
    [IsoId("_yWvlYOkUEemeDPHh-U9b6w")]
    [Description(@"Replacing  previously added records.")]
    BulkReplacement,
    
    /// <summary>
    /// System purge.
    /// Encoded/decoded by serializers as &quot;DLSP&quot;.
    /// </summary>
    [EnumMember(Value = "DLSP")]
    [IsoId("_EQBUEOkVEemeDPHh-U9b6w")]
    [Description(@"System purge.")]
    DeleteRecordSystemPurge,
    
    /// <summary>
    /// Request for a file or record.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_zF9MQJb6Eeuc6pwKtqbEVQ")]
    [Description(@"Request for a file or record.")]
    Request,
    
}
