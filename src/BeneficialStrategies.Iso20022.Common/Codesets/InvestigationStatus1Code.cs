// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the status of the investigation response related to a previously sent request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_whTckFlIEeGYqvgbBHXAZw")]
[Description(
    @"Provides the status of the investigation response related to a previously sent request."
)]
[DerivedFrom(typeof(InvestigationStatusCode))]
public enum InvestigationStatus1Code
{
    /// <summary>
    /// Search for requested data is complete, the data has been found and will be sent using a separate message flow.
    /// Encoded/decoded by serializers as &quot;FOUN&quot;.
    /// </summary>
    [EnumMember(Value = "FOUN")]
    [IsoId("_xZMG1llIEeGYqvgbBHXAZw")]
    [Description(
        @"Search for requested data is complete, the data has been found and will be sent using a separate message flow."
    )]
    DataFound = InvestigationStatusCode.DataFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Search for requested data is complete, data not found.
    /// Encoded/decoded by serializers as &quot;NFOU&quot;.
    /// </summary>
    [EnumMember(Value = "NFOU")]
    [IsoId("_xeGcBllIEeGYqvgbBHXAZw")]
    [Description(@"Search for requested data is complete, data not found.")]
    DataNotFound = InvestigationStatusCode.DataNotFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Search for requested data not complete yet.
    /// Encoded/decoded by serializers as &quot;NOAP&quot;.
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_xj6wJllIEeGYqvgbBHXAZw")]
    [Description(@"Search for requested data not complete yet.")]
    NotApplicable = InvestigationStatusCode.NotApplicable, // same ordinal as derivation source for type conversions
}
