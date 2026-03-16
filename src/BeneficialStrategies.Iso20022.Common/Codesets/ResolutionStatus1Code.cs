// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a resolution in an agenda is still active or has been deleted.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZU0_Zdp-Ed-ak6NoX_4Aeg_188066871")]
[Description(@"Specifies whether a resolution in an agenda is still active or has been deleted.")]
[DerivedFrom(typeof(ResolutionStatusCode))]
public enum ResolutionStatus1Code
{
    /// <summary>
    /// Meeting resolution has to be voted for by the participants to a general meeting.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_ZU0_Ztp-Ed-ak6NoX_4Aeg_268414544")]
    [Description(
        @"Meeting resolution has to be voted for by the participants to a general meeting."
    )]
    Active = ResolutionStatusCode.Active, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Meeting resolution has been withdrawn.
    /// Encoded/decoded by serializers as &quot;WDRA&quot;.
    /// </summary>
    [EnumMember(Value = "WDRA")]
    [IsoId("_ZU0_Z9p-Ed-ak6NoX_4Aeg_268414545")]
    [Description(@"Meeting resolution has been withdrawn.")]
    Withdrawn = ResolutionStatusCode.Withdrawn, // same ordinal as derivation source for type conversions
}
