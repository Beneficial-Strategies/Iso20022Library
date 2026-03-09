// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ayZwpNp-Ed-ak6NoX_4Aeg_-1040840411")]
[Description(@"Specifies a type of date.")]
[DerivedFrom(typeof(DateTypeCode))]
public enum DateType4Code
{
    /// <summary>
    /// Open-dated, which indicates that the date has not been established.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_ayZwpdp-Ed-ak6NoX_4Aeg_-753628532")]
    [Description(@"Open-dated, which indicates that the date has not been established.")]
    Open = DateTypeCode.Open, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Date is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ayZwptp-Ed-ak6NoX_4Aeg_-739775519")]
    [Description(@"Date is unknown by the sender or has not been established.")]
    Unknown = DateTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
}
