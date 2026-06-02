// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of transfer for the market claim proceeds.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_v8ZnkIYZEe-haozGYc1X7Q")]
[Description(@"Specifies the type of transfer for the market claim proceeds.")]
[Derivations(typeof(TransferOfProceedsType1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<TransferOfProceedsTypeCode>))]
public enum TransferOfProceedsTypeCode
{
    /// <summary>
    /// Market Claim is to transfer proceeds received from the issuer to the entitled party.
    /// Encoded/decoded by serializers as &quot;CLFT&quot;.
    /// </summary>
    [EnumMember(Value = "CLFT")]
    [IsoId("_4MwUMIYZEe-haozGYc1X7Q")]
    [Description(@"Market Claim is to transfer proceeds received from the issuer to the entitled party.")]
    FullTransferOfReceivedProceeds,

    /// <summary>
    /// Market Claim is to transfer proceeds partially received from the issuer to the entitled party. Part is compensated in cash by the party that failed to fulfil its obligation.
    /// Encoded/decoded by serializers as &quot;CLNT&quot;.
    /// </summary>
    [EnumMember(Value = "CLNT")]
    [IsoId("_9OpgwIYZEe-haozGYc1X7Q")]
    [Description(@"Market Claim is to transfer proceeds partially received from the issuer to the entitled party. Part is compensated in cash by the party that failed to fulfil its obligation.")]
    PartialTransferOfReceivedProceeds,

    /// <summary>
    /// Market Claim is to compensate the entitled party in cash by the party that failed to fulfil its obligation. No proceeds have been received from the issuer.
    /// Encoded/decoded by serializers as &quot;CLPT&quot;.
    /// </summary>
    [EnumMember(Value = "CLPT")]
    [IsoId("_D58UEIYaEe-haozGYc1X7Q")]
    [Description(@"Market Claim is to compensate the entitled party in cash by the party that failed to fulfil its obligation. No proceeds have been received from the issuer.")]
    NoTransferOfReceivedProceeds,
}
