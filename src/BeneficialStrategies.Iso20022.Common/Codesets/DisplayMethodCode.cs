// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Instructions for the use of display quantity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_awUtAtp-Ed-ak6NoX_4Aeg_711015828")]
[Description(@"Instructions for the use of display quantity.")]
[Derivations(typeof(DisplayMethod1Code))]
public enum DisplayMethodCode
{
    /// <summary>
    /// Indicates that original quantity must be used.
    /// Encoded/decoded by serializers as &quot;INIT&quot;.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_awUtA9p-Ed-ak6NoX_4Aeg_751651641")]
    [Description(@"Indicates that original quantity must be used.")]
    Initial,
    
    /// <summary>
    /// Indicates that Quantity must be refreshed.
    /// Encoded/decoded by serializers as &quot;NEW1&quot;.
    /// </summary>
    [EnumMember(Value = "NEW1")]
    [IsoId("_awUtBNp-Ed-ak6NoX_4Aeg_1093354350")]
    [Description(@"Indicates that Quantity must be refreshed.")]
    New,
    
    /// <summary>
    /// Randomize value.
    /// Encoded/decoded by serializers as &quot;RAND&quot;.
    /// </summary>
    [EnumMember(Value = "RAND")]
    [IsoId("_awUtBdp-Ed-ak6NoX_4Aeg_1226340443")]
    [Description(@"Randomize value.")]
    Random,
    
}
