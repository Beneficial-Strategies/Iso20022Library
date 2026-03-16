// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the technical input channel, as published in an external technical input channel code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_d3jk8Lf9Eee9KIDjEHK7ZQ")]
[Description(
    @"Specifies the technical input channel, as published in an external technical input channel code list.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalTechnicalInputChannel1Code))]
public enum ExternalTechnicalInputChannelCode
{
    /// <summary>
    /// Technical Input Channel is fax or facsimile
    /// Encoded/decoded by serializers as &quot;FAXI&quot;.
    /// </summary>
    [EnumMember(Value = "FAXI")]
    [IsoId("_uG8YgPRYEeuLhpyIdtJzwg")]
    [Description(@"Technical Input Channel is fax or facsimile")]
    Fax,

    /// <summary>
    /// Technical Input Channel is paper
    /// Encoded/decoded by serializers as &quot;PAPR&quot;.
    /// </summary>
    [EnumMember(Value = "PAPR")]
    [IsoId("_uG8Yg_RYEeuLhpyIdtJzwg")]
    [Description(@"Technical Input Channel is paper")]
    Paper,

    /// <summary>
    /// Technical Input Channel is tape
    /// Encoded/decoded by serializers as &quot;TAPE&quot;.
    /// </summary>
    [EnumMember(Value = "TAPE")]
    [IsoId("_uG8YhvRYEeuLhpyIdtJzwg")]
    [Description(@"Technical Input Channel is tape")]
    Tape,

    /// <summary>
    /// Technical Input Channel is internet
    /// Encoded/decoded by serializers as &quot;WEBI&quot;.
    /// </summary>
    [EnumMember(Value = "WEBI")]
    [IsoId("_uG8YifRYEeuLhpyIdtJzwg")]
    [Description(@"Technical Input Channel is internet")]
    Internet,
}
