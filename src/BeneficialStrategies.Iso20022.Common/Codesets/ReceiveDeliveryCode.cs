// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the settlement transaction is a delivery or receipt.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zafih9p-Ed-ak6NoX_4Aeg_448211310")]
[Description(@"Specifies whether the settlement transaction is a delivery or receipt.")]
[Derivations(typeof(ReceiveDelivery1Code))]
public enum ReceiveDeliveryCode
{
    /// <summary>
    /// Financial instruments will be debited from the safekeeping account.
    /// Encoded/decoded by serializers as &quot;DELI&quot;.
    /// </summary>
    [EnumMember(Value = "DELI")]
    [IsoId("_ZafiiNp-Ed-ak6NoX_4Aeg_448211319")]
    [Description(@"Financial instruments will be debited from the safekeeping account.")]
    Delivery,

    /// <summary>
    /// Financial instruments will be credited to the safekeeping account.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_ZaoscNp-Ed-ak6NoX_4Aeg_448211335")]
    [Description(@"Financial instruments will be credited to the safekeeping account.")]
    Receive,
}
