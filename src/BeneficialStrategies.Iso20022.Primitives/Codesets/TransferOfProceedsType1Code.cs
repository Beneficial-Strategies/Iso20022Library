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
[IsoId("_bVpwkIYaEe-haozGYc1X7Q")]
[Description(@"Specifies the type of transfer for the market claim proceeds.")]
[DerivedFrom(typeof(TransferOfProceedsTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<TransferOfProceedsType1Code>))]
public enum TransferOfProceedsType1Code
{
    /// <summary>
    /// Market Claim is to transfer proceeds received from the issuer to the entitled party.
    /// Encoded/decoded by serializers as &quot;CLFT&quot;.
    /// </summary>
    [EnumMember(Value = "CLFT")]
    [IsoId("_cM4TgYYaEe-haozGYc1X7Q")]
    [Description(@"Market Claim is to transfer proceeds received from the issuer to the entitled party.")]
    FullTransferOfReceivedProceeds = TransferOfProceedsTypeCode.FullTransferOfReceivedProceeds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Market Claim is to transfer proceeds partially received from the issuer to the entitled party. Part is compensated in cash by the party that failed to fulfil its obligation.
    /// Encoded/decoded by serializers as &quot;CLNT&quot;.
    /// </summary>
    [EnumMember(Value = "CLNT")]
    [IsoId("_cXlHoYYaEe-haozGYc1X7Q")]
    [Description(@"Market Claim is to transfer proceeds partially received from the issuer to the entitled party. Part is compensated in cash by the party that failed to fulfil its obligation.")]
    PartialTransferOfReceivedProceeds = TransferOfProceedsTypeCode.PartialTransferOfReceivedProceeds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Market Claim is to compensate the entitled party in cash by the party that failed to fulfil its obligation. No proceeds have been received from the issuer.
    /// Encoded/decoded by serializers as &quot;CLPT&quot;.
    /// </summary>
    [EnumMember(Value = "CLPT")]
    [IsoId("_cUFHsYYaEe-haozGYc1X7Q")]
    [Description(@"Market Claim is to compensate the entitled party in cash by the party that failed to fulfil its obligation. No proceeds have been received from the issuer.")]
    NoTransferOfReceivedProceeds = TransferOfProceedsTypeCode.NoTransferOfReceivedProceeds, // same ordinal as derivation source for type conversions
}
