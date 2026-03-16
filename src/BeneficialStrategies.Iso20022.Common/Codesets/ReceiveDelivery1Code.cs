// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the settlement transaction is a delivery or receipt.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZafihNp-Ed-ak6NoX_4Aeg_-212858839")]
[Description(@"Specifies whether the settlement transaction is a delivery or receipt.")]
[DerivedFrom(typeof(ReceiveDeliveryCode))]
public enum ReceiveDelivery1Code
{
    /// <summary>
    /// Financial instruments will be debited from the safekeeping account.
    /// Encoded/decoded by serializers as &quot;DELI&quot;.
    /// </summary>
    [EnumMember(Value = "DELI")]
    [IsoId("_Zafihdp-Ed-ak6NoX_4Aeg_-99264763")]
    [Description(@"Financial instruments will be debited from the safekeeping account.")]
    Delivery = ReceiveDeliveryCode.Delivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments will be credited to the safekeeping account.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_Zafihtp-Ed-ak6NoX_4Aeg_-69712465")]
    [Description(@"Financial instruments will be credited to the safekeeping account.")]
    Receive = ReceiveDeliveryCode.Receive, // same ordinal as derivation source for type conversions
}
