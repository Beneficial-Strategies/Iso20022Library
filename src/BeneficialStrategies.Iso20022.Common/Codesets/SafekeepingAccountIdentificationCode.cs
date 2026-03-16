// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the account identification via a code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y-eU5dp-Ed-ak6NoX_4Aeg_1234577798")]
[Description(@"Specifies the account identification via a code.")]
[Derivations(typeof(SafekeepingAccountIdentification1Code))]
public enum SafekeepingAccountIdentificationCode
{
    /// <summary>
    /// Announcement applies to all safekeeping accounts that own underlying financial instrument. (Used for general or preliminary announcements.).
    /// Encoded/decoded by serializers as &quot;GENR&quot;.
    /// </summary>
    [EnumMember(Value = "GENR")]
    [IsoId("_Y-eU5tp-Ed-ak6NoX_4Aeg_1301070404")]
    [Description(
        @"Announcement applies to all safekeeping accounts that own underlying financial instrument. (Used for general or preliminary announcements.)."
    )]
    General,
}
