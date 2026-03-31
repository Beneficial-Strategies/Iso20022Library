// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the condition under which automatic borrowing is allowed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bjuf5dp-Ed-ak6NoX_4Aeg_1205177778")]
[Description(@"Specifies the condition under which automatic borrowing is allowed.")]
[Derivations(typeof(AutoBorrowing1Code), typeof(AutoBorrowing2Code))]
public enum AutoBorrowingCode
{
    /// <summary>
    /// Only last resort borrowing should be considered to make settlement occur.
    /// Encoded/decoded by serializers as &quot;LAMI&quot;.
    /// </summary>
    [EnumMember(Value = "LAMI")]
    [IsoId("_bjuf5tp-Ed-ak6NoX_4Aeg_1205177795")]
    [Description(@"Only last resort borrowing should be considered to make settlement occur.")]
    LastResort,

    /// <summary>
    /// No automatic borrowing should take place.
    /// Encoded/decoded by serializers as &quot;NBOR&quot;.
    /// </summary>
    [EnumMember(Value = "NBOR")]
    [IsoId("_bjuf59p-Ed-ak6NoX_4Aeg_1205177796")]
    [Description(@"No automatic borrowing should take place.")]
    NoAutomatic,

    /// <summary>
    /// Automatic borrowing should take place.
    /// Encoded/decoded by serializers as &quot;YBOR&quot;.
    /// </summary>
    [EnumMember(Value = "YBOR")]
    [IsoId("_bjuf6Np-Ed-ak6NoX_4Aeg_1205177813")]
    [Description(@"Automatic borrowing should take place.")]
    Automatic,

    /// <summary>
    /// Return of stocks should take place.
    /// Encoded/decoded by serializers as &quot;RTRN&quot;.
    /// </summary>
    [EnumMember(Value = "RTRN")]
    [IsoId("_bjuf6dp-Ed-ak6NoX_4Aeg_-926996655")]
    [Description(@"Return of stocks should take place.")]
    Return,
}
