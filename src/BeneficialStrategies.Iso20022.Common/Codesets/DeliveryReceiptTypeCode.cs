// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how the transaction is to be settled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_azTIgNp-Ed-ak6NoX_4Aeg_-314094989")]
[Description(@"Specifies how the transaction is to be settled.")]
[Derivations(typeof(DeliveryReceiptType2Code))]
public enum DeliveryReceiptTypeCode
{
    /// <summary>
    /// Settlement of the financial instrument and cash is separate.
    /// Encoded/decoded by serializers as &quot;FREE&quot;.
    /// </summary>
    [EnumMember(Value = "FREE")]
    [IsoId("_azTIgdp-Ed-ak6NoX_4Aeg_84863839")]
    [Description(@"Settlement of the financial instrument and cash is separate.")]
    SeparateSettlement,

    /// <summary>
    /// Settlement of the financial instrument and cash takes place in a delivery versus payment (DVP) environment, that is, through an International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as &quot;APMT&quot;.
    /// </summary>
    [EnumMember(Value = "APMT")]
    [IsoId("_azTIgtp-Ed-ak6NoX_4Aeg_84863864")]
    [Description(
        @"Settlement of the financial instrument and cash takes place in a delivery versus payment (DVP) environment, that is, through an International Central Securities Depository (ICSD) or Central Securities Depository (CSD)."
    )]
    AgainstPaymentSettlement,
}
