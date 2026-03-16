// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the condition under which automatic borrowing is allowed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bjuf4Np-Ed-ak6NoX_4Aeg_-875280899")]
[Description(@"Specifies the condition under which automatic borrowing is allowed.")]
[DerivedFrom(typeof(AutoBorrowingCode))]
public enum AutoBorrowing2Code
{
    /// <summary>
    /// Only last resort borrowing should be considered to make settlement occur.
    /// Encoded/decoded by serializers as &quot;LAMI&quot;.
    /// </summary>
    [EnumMember(Value = "LAMI")]
    [IsoId("_bjuf4dp-Ed-ak6NoX_4Aeg_-875280874")]
    [Description(@"Only last resort borrowing should be considered to make settlement occur.")]
    LastResort = AutoBorrowingCode.LastResort, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No automatic borrowing should take place.
    /// Encoded/decoded by serializers as &quot;NBOR&quot;.
    /// </summary>
    [EnumMember(Value = "NBOR")]
    [IsoId("_bjuf4tp-Ed-ak6NoX_4Aeg_-875280873")]
    [Description(@"No automatic borrowing should take place.")]
    NoAutomatic = AutoBorrowingCode.NoAutomatic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Automatic borrowing should take place.
    /// Encoded/decoded by serializers as &quot;YBOR&quot;.
    /// </summary>
    [EnumMember(Value = "YBOR")]
    [IsoId("_bjuf49p-Ed-ak6NoX_4Aeg_-875280857")]
    [Description(@"Automatic borrowing should take place.")]
    Automatic = AutoBorrowingCode.Automatic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Return of stocks should take place.
    /// Encoded/decoded by serializers as &quot;RTRN&quot;.
    /// </summary>
    [EnumMember(Value = "RTRN")]
    [IsoId("_bjuf5Np-Ed-ak6NoX_4Aeg_-871586494")]
    [Description(@"Return of stocks should take place.")]
    Return = AutoBorrowingCode.Return, // same ordinal as derivation source for type conversions
}
