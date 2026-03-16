// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code to identify the type of bid request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_begosNp-Ed-ak6NoX_4Aeg_451517447")]
[Description(@"Code to identify the type of bid request.")]
[Derivations(typeof(BidType1Code))]
public enum BidTypeCode
{
    /// <summary>
    /// Bid type is non disclosed.
    /// Encoded/decoded by serializers as &quot;NDIS&quot;.
    /// </summary>
    [EnumMember(Value = "NDIS")]
    [IsoId("_begosdp-Ed-ak6NoX_4Aeg_467216118")]
    [Description(@"Bid type is non disclosed.")]
    NonDisclosed,

    /// <summary>
    /// Bid type is disclosed.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_begostp-Ed-ak6NoX_4Aeg_481992122")]
    [Description(@"Bid type is disclosed.")]
    Disclosed,

    /// <summary>
    /// List order is not related to a bid.
    /// Encoded/decoded by serializers as &quot;NOBI&quot;.
    /// </summary>
    [EnumMember(Value = "NOBI")]
    [IsoId("_begos9p-Ed-ak6NoX_4Aeg_487533177")]
    [Description(@"List order is not related to a bid.")]
    NoBid,
}
