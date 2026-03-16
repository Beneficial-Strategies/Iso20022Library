// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the factors that are/were applied in the event of pre-allocation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YrGs9Np-Ed-ak6NoX_4Aeg_-1913582483")]
[Description(@"Indicates the factors that are/were applied in the event of pre-allocation.")]
[Derivations(typeof(TradingSession1Code))]
public enum TradingSessionCode
{
    /// <summary>
    /// Orders that are traded in regularly occuring auctions: orders are accumulated and executed on basis of defined algorithms.
    /// Encoded/decoded by serializers as &quot;AUCT&quot;.
    /// </summary>
    [EnumMember(Value = "AUCT")]
    [IsoId("_YrGs9dp-Ed-ak6NoX_4Aeg_-1134133596")]
    [Description(
        @"Orders that are traded in regularly occuring auctions: orders are accumulated and executed on basis of defined algorithms."
    )]
    Auction,

    /// <summary>
    /// Trading process where orders are executed directly against each others as they hit the marketplace.
    /// Encoded/decoded by serializers as &quot;CONT&quot;.
    /// </summary>
    [EnumMember(Value = "CONT")]
    [IsoId("_YrGs9tp-Ed-ak6NoX_4Aeg_-610494837")]
    [Description(
        @"Trading process where orders are executed directly against each others as they hit the marketplace."
    )]
    Continuous,
}
