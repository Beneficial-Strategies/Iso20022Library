// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of election.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ahHzYdp-Ed-ak6NoX_4Aeg_-1893441845")]
[Description(@"Specifies the type of election.")]
[Derivations(typeof(ElectionType1Code))]
public enum ElectionTypeCode
{
    /// <summary>
    /// New election advice.
    /// Encoded/decoded by serializers as &quot;NEWM&quot;.
    /// </summary>
    [EnumMember(Value = "NEWM")]
    [IsoId("_ahHzYtp-Ed-ak6NoX_4Aeg_-1876817891")]
    [Description(@"New election advice.")]
    NewElection,

    /// <summary>
    /// Election advice which is the result of an option change.
    /// Encoded/decoded by serializers as &quot;CHAN&quot;.
    /// </summary>
    [EnumMember(Value = "CHAN")]
    [IsoId("_ahHzY9p-Ed-ak6NoX_4Aeg_-1876817860")]
    [Description(@"Election advice which is the result of an option change.")]
    OptionChange,
}
