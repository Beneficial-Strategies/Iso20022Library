// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ayjhpdp-Ed-ak6NoX_4Aeg_-1957925382")]
[Description(@"Type of date.")]
[DerivedFrom(typeof(DateTypeCode))]
public enum DateType7Code
{
    /// <summary>
    /// Ongoing basis, which indicates that the date is determined by &quot;ongoing basis&quot; process, for example &quot;au fil de l&apos;eau&quot;.
    /// Encoded/decoded by serializers as &quot;ONGO&quot;.
    /// </summary>
    [EnumMember(Value = "ONGO")]
    [IsoId("_ayjhptp-Ed-ak6NoX_4Aeg_24028541")]
    [Description(
        @"Ongoing basis, which indicates that the date is determined by ""ongoing basis"" process, for example ""au fil de l'eau""."
    )]
    Ongoing = DateTypeCode.Ongoing, // same ordinal as derivation source for type conversions
}
