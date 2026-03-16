// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether best execution rules as defined in the EU MiFID directive were followed for a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_beXewtp-Ed-ak6NoX_4Aeg_-112393777")]
[Description(
    @"Specifies whether best execution rules as defined in the EU MiFID directive were followed for a transaction."
)]
[Derivations(typeof(BestExecution1Code))]
public enum BestExecutionCode
{
    /// <summary>
    /// Best execution rules were followed.
    /// Encoded/decoded by serializers as &quot;BTEX&quot;.
    /// </summary>
    [EnumMember(Value = "BTEX")]
    [IsoId("_beXew9p-Ed-ak6NoX_4Aeg_146193560")]
    [Description(@"Best execution rules were followed.")]
    Best,
}
