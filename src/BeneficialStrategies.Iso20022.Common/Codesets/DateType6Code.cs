// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of dates.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ayjhodp-Ed-ak6NoX_4Aeg_947717671")]
[Description(@"Specifies the type of dates.")]
[DerivedFrom(typeof(DateTypeCode))]
public enum DateType6Code
{
    /// <summary>
    /// Open-dated, which indicates that the date has not been established.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_ayjhotp-Ed-ak6NoX_4Aeg_988349228")]
    [Description(@"Open-dated, which indicates that the date has not been established.")]
    Open = DateTypeCode.Open, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Date is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ayjho9p-Ed-ak6NoX_4Aeg_988349289")]
    [Description(@"Date is unknown by the sender or has not been established.")]
    Unknown = DateTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ongoing basis, which indicates that the date is determined by &quot;ongoing basis&quot; process, for example &quot;au fil de l&apos;eau&quot;.
    /// Encoded/decoded by serializers as &quot;ONGO&quot;.
    /// </summary>
    [EnumMember(Value = "ONGO")]
    [IsoId("_ayjhpNp-Ed-ak6NoX_4Aeg_988349381")]
    [Description(@"Ongoing basis, which indicates that the date is determined by ""ongoing basis"" process, for example ""au fil de l'eau"".")]
    Ongoing = DateTypeCode.Ongoing, // same ordinal as derivation source for type conversions
    
}
