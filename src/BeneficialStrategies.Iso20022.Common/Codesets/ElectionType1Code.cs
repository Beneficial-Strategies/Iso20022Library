// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of election.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ag-CZ9p-Ed-ak6NoX_4Aeg_-1602987297")]
[Description(@"Specifies the type of election.")]
[DerivedFrom(typeof(ElectionTypeCode))]
public enum ElectionType1Code
{
    /// <summary>
    /// New election advice.
    /// Encoded/decoded by serializers as &quot;NEWM&quot;.
    /// </summary>
    [EnumMember(Value = "NEWM")]
    [IsoId("_ag-CaNp-Ed-ak6NoX_4Aeg_-1543884834")]
    [Description(@"New election advice.")]
    NewElection = ElectionTypeCode.NewElection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Election advice which is the result of an option change.
    /// Encoded/decoded by serializers as &quot;CHAN&quot;.
    /// </summary>
    [EnumMember(Value = "CHAN")]
    [IsoId("_ahHzYNp-Ed-ak6NoX_4Aeg_-1543884803")]
    [Description(@"Election advice which is the result of an option change.")]
    OptionChange = ElectionTypeCode.OptionChange, // same ordinal as derivation source for type conversions
}
