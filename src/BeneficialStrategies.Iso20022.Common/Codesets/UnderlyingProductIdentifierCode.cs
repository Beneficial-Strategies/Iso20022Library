// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the underlying product type for reporting to trade repositories. These product codes must be in line with the ISDA Product Taxonomy.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QQZXoCjmEeK1Sbo8NpBROA")]
[Description(
    @"Indicates the underlying product type for reporting to trade repositories. These product codes must be in line with the ISDA Product Taxonomy."
)]
[Derivations(typeof(UnderlyingProductIdentifier1Code))]
public enum UnderlyingProductIdentifierCode
{
    /// <summary>
    /// Underlying product type of the transaction is a Foreign Exchange Forward.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_hVYioCjmEeK1Sbo8NpBROA")]
    [Description(@"Underlying product type of the transaction is a Foreign Exchange Forward.")]
    ForeignExchangeForward,

    /// <summary>
    /// Underlying product type of the transaction is a Foreign Exchange Non Deliverable Forward.
    /// Encoded/decoded by serializers as &quot;NDFO&quot;.
    /// </summary>
    [EnumMember(Value = "NDFO")]
    [IsoId("_l4StICjmEeK1Sbo8NpBROA")]
    [Description(
        @"Underlying product type of the transaction is a Foreign Exchange Non Deliverable Forward."
    )]
    ForeignExchangeNonDeliverableForward,

    /// <summary>
    /// Underlying product type of the transaction is Foreign Exchange Spot.
    /// Encoded/decoded by serializers as &quot;SPOT&quot;.
    /// </summary>
    [EnumMember(Value = "SPOT")]
    [IsoId("_n1NFwCjmEeK1Sbo8NpBROA")]
    [Description(@"Underlying product type of the transaction is Foreign Exchange Spot.")]
    ForeignExchangeSpot,

    /// <summary>
    /// Underlying product type of the transaction is a Foreign Exchange SWAP.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_qTSRwCjmEeK1Sbo8NpBROA")]
    [Description(@"Underlying product type of the transaction is a Foreign Exchange SWAP.")]
    ForeignExchangeSWAP,
}
