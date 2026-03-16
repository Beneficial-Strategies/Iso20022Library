// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether best execution rules as defined in the EU MiFID directive were followed for a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_beXewNp-Ed-ak6NoX_4Aeg_-83762235")]
[Description(
    @"Specifies whether best execution rules as defined in the EU MiFID directive were followed for a transaction."
)]
[DerivedFrom(typeof(BestExecutionCode))]
public enum BestExecution1Code
{
    /// <summary>
    /// Best execution rules were followed.
    /// Encoded/decoded by serializers as &quot;BTEX&quot;.
    /// </summary>
    [EnumMember(Value = "BTEX")]
    [IsoId("_beXewdp-Ed-ak6NoX_4Aeg_47375840")]
    [Description(@"Best execution rules were followed.")]
    Best = BestExecutionCode.Best, // same ordinal as derivation source for type conversions
}
