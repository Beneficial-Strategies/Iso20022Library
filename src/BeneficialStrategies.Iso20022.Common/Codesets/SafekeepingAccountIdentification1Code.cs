// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the account identification via a code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y-eU49p-Ed-ak6NoX_4Aeg_1272441146")]
[Description(@"Specifies the account identification via a code.")]
[DerivedFrom(typeof(SafekeepingAccountIdentificationCode))]
public enum SafekeepingAccountIdentification1Code
{
    /// <summary>
    /// Announcement applies to all safekeeping accounts that own underlying financial instrument. (Used for general or preliminary announcements.).
    /// Encoded/decoded by serializers as &quot;GENR&quot;.
    /// </summary>
    [EnumMember(Value = "GENR")]
    [IsoId("_Y-eU5Np-Ed-ak6NoX_4Aeg_-2050057453")]
    [Description(@"Announcement applies to all safekeeping accounts that own underlying financial instrument. (Used for general or preliminary announcements.).")]
    General = SafekeepingAccountIdentificationCode.General, // same ordinal as derivation source for type conversions
    
}
