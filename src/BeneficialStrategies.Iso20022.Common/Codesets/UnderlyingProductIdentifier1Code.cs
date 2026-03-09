// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the underlying product type for reporting to trade repositories. These product codes must be in line with the ISDA Product Taxonomy.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-ZqKICjmEeK1Sbo8NpBROA")]
[Description(@"Indicates the underlying product type for reporting to trade repositories. These product codes must be in line with the ISDA Product Taxonomy.")]
[DerivedFrom(typeof(UnderlyingProductIdentifierCode))]
public enum UnderlyingProductIdentifier1Code
{
    /// <summary>
    /// Underlying product type of the transaction is a Foreign Exchange Forward.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_iRz_kSjvEeK1Sbo8NpBROA")]
    [Description(@"Underlying product type of the transaction is a Foreign Exchange Forward.")]
    ForeignExchangeForward = UnderlyingProductIdentifierCode.ForeignExchangeForward, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying product type of the transaction is a Foreign Exchange Non Deliverable Forward.
    /// Encoded/decoded by serializers as &quot;NDFO&quot;.
    /// </summary>
    [EnumMember(Value = "NDFO")]
    [IsoId("_iWttsSjvEeK1Sbo8NpBROA")]
    [Description(@"Underlying product type of the transaction is a Foreign Exchange Non Deliverable Forward.")]
    ForeignExchangeNonDeliverableForward = UnderlyingProductIdentifierCode.ForeignExchangeNonDeliverableForward, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying product type of the transaction is Foreign Exchange Spot.
    /// Encoded/decoded by serializers as &quot;SPOT&quot;.
    /// </summary>
    [EnumMember(Value = "SPOT")]
    [IsoId("_ibYyUSjvEeK1Sbo8NpBROA")]
    [Description(@"Underlying product type of the transaction is Foreign Exchange Spot.")]
    ForeignExchangeSpot = UnderlyingProductIdentifierCode.ForeignExchangeSpot, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying product type of the transaction is a Foreign Exchange SWAP.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_ij84cSjvEeK1Sbo8NpBROA")]
    [Description(@"Underlying product type of the transaction is a Foreign Exchange SWAP.")]
    ForeignExchangeSWAP = UnderlyingProductIdentifierCode.ForeignExchangeSWAP, // same ordinal as derivation source for type conversions
    
}
