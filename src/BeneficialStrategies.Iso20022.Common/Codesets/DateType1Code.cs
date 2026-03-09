// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies when date is unknown.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ayQmt9p-Ed-ak6NoX_4Aeg_-400780880")]
[Description(@"Specifies when date is unknown.")]
[DerivedFrom(typeof(DateTypeCode))]
public enum DateType1Code
{
    /// <summary>
    /// Date is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ayQmuNp-Ed-ak6NoX_4Aeg_-6438361")]
    [Description(@"Date is unknown by the sender or has not been established.")]
    Unknown = DateTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
}
