// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies late announcements: wither the announcement was made before or after position capture.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1puekzL3EeKU9IrkkToqcw_1613949680")]
[Description(
    @"Specifies late announcements: wither the announcement was made before or after position capture."
)]
[Derivations(typeof(DTCLate1Code))]
public enum DTCLateCode
{
    /// <summary>
    /// Informs both internal and external users that the announcement was added after the position capture date.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_1puelDL3EeKU9IrkkToqcw_-879956095")]
    [Description(
        @"Informs both internal and external users that the announcement was added after the position capture date."
    )]
    LateAnnouncement,

    /// <summary>
    /// Informs both internal and external users that the announcement is late, however, it has not gone through the position capture stage.
    /// Encoded/decoded by serializers as &quot;LAAS&quot;.
    /// </summary>
    [EnumMember(Value = "LAAS")]
    [IsoId("_1puelTL3EeKU9IrkkToqcw_-742748975")]
    [Description(
        @"Informs both internal and external users that the announcement is late, however, it has not gone through the position capture stage."
    )]
    LateAnnouncementPending,
}
