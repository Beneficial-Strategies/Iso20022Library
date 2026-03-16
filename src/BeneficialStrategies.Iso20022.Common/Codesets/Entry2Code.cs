// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of an entry in a report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ahQ9VNp-Ed-ak6NoX_4Aeg_-245723672")]
[Description(@"Specifies the type of an entry in a report.")]
[DerivedFrom(typeof(EntryCode))]
public enum Entry2Code
{
    /// <summary>
    /// Trial pay-in schedule.
    /// Encoded/decoded by serializers as &quot;TRIA&quot;.
    /// </summary>
    [EnumMember(Value = "TRIA")]
    [IsoId("_ahQ9Vdp-Ed-ak6NoX_4Aeg_-218020347")]
    [Description(@"Trial pay-in schedule.")]
    Trial = EntryCode.Trial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Official pay-in schedule.
    /// Encoded/decoded by serializers as &quot;OFFI&quot;.
    /// </summary>
    [EnumMember(Value = "OFFI")]
    [IsoId("_ahQ9Vtp-Ed-ak6NoX_4Aeg_-214324853")]
    [Description(@"Official pay-in schedule.")]
    Official = EntryCode.Official, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pay-in schedule on request.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_ahQ9V9p-Ed-ak6NoX_4Aeg_-203241624")]
    [Description(@"Pay-in schedule on request.")]
    Requested = EntryCode.Requested, // same ordinal as derivation source for type conversions
}
