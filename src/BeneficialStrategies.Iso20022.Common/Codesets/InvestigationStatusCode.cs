// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the status of the investigation response related to a previously sent request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__-fWcz_lEeGQnbmlZjr_fQ")]
[Description(
    @"Provides the status of the investigation response related to a previously sent request."
)]
[Derivations(typeof(InvestigationStatus1Code))]
public enum InvestigationStatusCode
{
    /// <summary>
    /// Search for requested data is complete, the data has been found and will be sent using a separate message flow.
    /// Encoded/decoded by serializers as &quot;FOUN&quot;.
    /// </summary>
    [EnumMember(Value = "FOUN")]
    [IsoId("_Ksjbpz_mEeGQnbmlZjr_fQ")]
    [Description(
        @"Search for requested data is complete, the data has been found and will be sent using a separate message flow."
    )]
    DataFound,

    /// <summary>
    /// Search for requested data is complete, data not found.
    /// Encoded/decoded by serializers as &quot;NFOU&quot;.
    /// </summary>
    [EnumMember(Value = "NFOU")]
    [IsoId("_YnWilz_mEeGQnbmlZjr_fQ")]
    [Description(@"Search for requested data is complete, data not found.")]
    DataNotFound,

    /// <summary>
    /// Search for requested data not complete yet.
    /// Encoded/decoded by serializers as &quot;NOAP&quot;.
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_szJtjT_mEeGQnbmlZjr_fQ")]
    [Description(@"Search for requested data not complete yet.")]
    NotApplicable,
}
