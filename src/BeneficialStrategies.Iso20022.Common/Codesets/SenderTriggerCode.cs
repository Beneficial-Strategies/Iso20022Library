// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the trigger code used by the sender to generate the file.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hy2h4MmLEeWAGphE2LvqeA")]
[Description(@"Specifies the trigger code used by the sender to generate the file.")]
[Derivations(typeof(SenderTrigger1Code))]
public enum SenderTriggerCode
{
    /// <summary>
    /// File generated based on a date/time event.
    /// Encoded/decoded by serializers as &quot;DTTM&quot;.
    /// </summary>
    [EnumMember(Value = "DTTM")]
    [IsoId("_jSXz4MmLEeWAGphE2LvqeA")]
    [Description(@"File generated based on a date/time event.")]
    DateTime,
    
    /// <summary>
    /// File generated based on a forced event (file generation has been forced).
    /// Encoded/decoded by serializers as &quot;FRCD&quot;.
    /// </summary>
    [EnumMember(Value = "FRCD")]
    [IsoId("_oAGHQMmLEeWAGphE2LvqeA")]
    [Description(@"File generated based on a forced event (file generation has been forced).")]
    Forced,
    
    /// <summary>
    /// File generated based on a manual event (file has been
    /// generated manually).
    /// Encoded/decoded by serializers as &quot;MANL&quot;.
    /// </summary>
    [EnumMember(Value = "MANL")]
    [IsoId("_qjgfMMmLEeWAGphE2LvqeA")]
    [Description(@"File generated based on a manual event (file has been|generated manually).")]
    Manual,
    
    /// <summary>
    /// File generated based on a signature event (file has the minimum required signature from the sender).
    /// Encoded/decoded by serializers as &quot;SFSG&quot;.
    /// </summary>
    [EnumMember(Value = "SFSG")]
    [IsoId("_uTR8kMmLEeWAGphE2LvqeA")]
    [Description(@"File generated based on a signature event (file has the minimum required signature from the sender).")]
    SufficientlySigned,
    
}
