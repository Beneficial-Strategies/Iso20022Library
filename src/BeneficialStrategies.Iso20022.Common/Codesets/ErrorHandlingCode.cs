// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Error codes generated when the response to a query exceeds the maximum size or the data is not available.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ah3aSNp-Ed-ak6NoX_4Aeg_2042159796")]
[Description(
    @"Error codes generated when the response to a query exceeds the maximum size or the data is not available."
)]
[Derivations(typeof(ErrorHandling1Code))]
public enum ErrorHandlingCode
{
    /// <summary>
    /// Specifies the error code when the data requested are not yet available.
    /// Encoded/decoded by serializers as &quot;X020&quot;.
    /// </summary>
    [EnumMember(Value = "X020")]
    [IsoId("_aiBLQNp-Ed-ak6NoX_4Aeg_-1881551578")]
    [Description(@"Specifies the error code when the data requested are not yet available.")]
    DataNotYetAvailable,

    /// <summary>
    /// Specifies the error code when the data requested generates a message size that exceed the processing capacity.
    /// Encoded/decoded by serializers as &quot;X030&quot;.
    /// </summary>
    [EnumMember(Value = "X030")]
    [IsoId("_aiBLQdp-Ed-ak6NoX_4Aeg_-1825215686")]
    [Description(
        @"Specifies the error code when the data requested generates a message size that exceed the processing capacity."
    )]
    MessageSizeLimitExceeded,

    /// <summary>
    /// Specifies the error code when the data requested have not been found.
    /// Encoded/decoded by serializers as &quot;X050&quot;.
    /// </summary>
    [EnumMember(Value = "X050")]
    [IsoId("_aiBLQtp-Ed-ak6NoX_4Aeg_-1823370699")]
    [Description(@"Specifies the error code when the data requested have not been found.")]
    DataNotAvailable,
}
