// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the method for the payment of the tax applied on the services.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6WDrtJqlEeGSON8vddiWzQ_387174603")]
[Description(@"Defines the method for the payment of the tax applied on the services.")]
[Derivations(typeof(ServicePaymentMethod1Code))]
public enum ServicePaymentMethodCode
{
    /// <summary>
    /// Allows the bank to offset a service charge with interest earned on the deposit account balance. The actual charges arising from balance compensable services are always calculated and charged at month end. Used in the USA.
    /// Encoded/decoded by serializers as &quot;BCMP&quot;.
    /// </summary>
    [EnumMember(Value = "BCMP")]
    [IsoId("_6WDrtZqlEeGSON8vddiWzQ_-473995216")]
    [Description(
        @"Allows the bank to offset a service charge with interest earned on the deposit account balance. The actual charges arising from balance compensable services are always calculated and charged at month end. Used in the USA."
    )]
    BalanceCompensable,

    /// <summary>
    /// Charge is not balance compensable and is due. In the absence of balance compensable charges in Europe, this would be the most commonly used code for services that are billed at month end.
    /// Encoded/decoded by serializers as &quot;FLAT&quot;.
    /// </summary>
    [EnumMember(Value = "FLAT")]
    [IsoId("_6WDrtpqlEeGSON8vddiWzQ_1684310842")]
    [Description(
        @"Charge is not balance compensable and is due. In the absence of balance compensable charges in Europe, this would be the most commonly used code for services that are billed at month end."
    )]
    HardCharge,

    /// <summary>
    /// Charge was previously assessed and is not part of the amount due as of this statement. This code is used for charges that were debited as the chargeable event took place.
    /// Encoded/decoded by serializers as &quot;PVCH&quot;.
    /// </summary>
    [EnumMember(Value = "PVCH")]
    [IsoId("_6WDrt5qlEeGSON8vddiWzQ_1354744715")]
    [Description(
        @"Charge was previously assessed and is not part of the amount due as of this statement. This code is used for charges that were debited as the chargeable event took place."
    )]
    PreviouslyCharged,

    /// <summary>
    /// Charge was previously invoiced and is not part of the amount due as of this statement. This code is used for charges that were invoiced as the chargeable event took place.
    /// Encoded/decoded by serializers as &quot;INVS&quot;.
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("_6WDruJqlEeGSON8vddiWzQ_-1745232232")]
    [Description(
        @"Charge was previously invoiced and is not part of the amount due as of this statement. This code is used for charges that were invoiced as the chargeable event took place."
    )]
    InvoicedSeparately,

    /// <summary>
    /// Charge is waived and not due. The waived amount must be placed in original charge amount.
    /// Encoded/decoded by serializers as &quot;WVED&quot;.
    /// </summary>
    [EnumMember(Value = "WVED")]
    [IsoId("_6WNcsJqlEeGSON8vddiWzQ_-1690890239")]
    [Description(
        @"Charge is waived and not due. The waived amount must be placed in original charge amount."
    )]
    Waived,

    /// <summary>
    /// Service is free, no charge, to the customer.
    /// Encoded/decoded by serializers as &quot;FREE&quot;.
    /// </summary>
    [EnumMember(Value = "FREE")]
    [IsoId("_6WNcsZqlEeGSON8vddiWzQ_949588255")]
    [Description(@"Service is free, no charge, to the customer.")]
    Free,
}
