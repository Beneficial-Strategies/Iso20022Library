// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of an entry in a report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ahQ9WNp-Ed-ak6NoX_4Aeg_-1271465048")]
[Description(@"Specifies the type of an entry in a report.")]
[Derivations(typeof(Entry2Code))]
public enum EntryCode
{
    /// <summary>
    /// Trial pay-in schedule.
    /// Encoded/decoded by serializers as &quot;TRIA&quot;.
    /// </summary>
    [EnumMember(Value = "TRIA")]
    [IsoId("_ahauUNp-Ed-ak6NoX_4Aeg_-1237295637")]
    [Description(@"Trial pay-in schedule.")]
    Trial,
    
    /// <summary>
    /// Official pay-in schedule.
    /// Encoded/decoded by serializers as &quot;OFFI&quot;.
    /// </summary>
    [EnumMember(Value = "OFFI")]
    [IsoId("_ahauUdp-Ed-ak6NoX_4Aeg_-1227134519")]
    [Description(@"Official pay-in schedule.")]
    Official,
    
    /// <summary>
    /// Pay-in schedule on request.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_ahauUtp-Ed-ak6NoX_4Aeg_-276202344")]
    [Description(@"Pay-in schedule on request.")]
    Requested,
    
}
