// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates if a Cancel/Replace instruction has caused an order to loose its book priority.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bVIDMtp-Ed-ak6NoX_4Aeg_335335591")]
[Description(@"Indicates if a Cancel/Replace instruction has caused an order to loose its book priority.")]
public enum BookPriorityIndicatorCode
{
    /// <summary>
    /// Indicates that the book priority is unchanged.
    /// Encoded/decoded by serializers as &quot;UNCH&quot;.
    /// </summary>
    [EnumMember(Value = "UNCH")]
    [IsoId("_bVIDM9p-Ed-ak6NoX_4Aeg_335335592")]
    [Description(@"Indicates that the book priority is unchanged.")]
    Unchanged,
    
    /// <summary>
    /// Indicates that the book priority is lost as a result of an order change.
    /// Encoded/decoded by serializers as &quot;LOST&quot;.
    /// </summary>
    [EnumMember(Value = "LOST")]
    [IsoId("_bVIDNNp-Ed-ak6NoX_4Aeg_335335601")]
    [Description(@"Indicates that the book priority is lost as a result of an order change.")]
    Lost,
    
}
