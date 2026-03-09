// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the method for the payment of the services charge.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6V6hxZqlEeGSON8vddiWzQ_1243106424")]
[Description(@"Defines the method for the payment of the services charge.")]
[DerivedFrom(typeof(ServicePaymentMethodCode))]
public enum ServicePaymentMethod1Code
{
    /// <summary>
    /// Allows the bank to offset a service charge with interest earned on the deposit account balance. The actual charges arising from balance compensable services are always calculated and charged at month end. Used in the USA.
    /// Encoded/decoded by serializers as &quot;BCMP&quot;.
    /// </summary>
    [EnumMember(Value = "BCMP")]
    [IsoId("_6V6hxpqlEeGSON8vddiWzQ_1103448435")]
    [Description(@"Allows the bank to offset a service charge with interest earned on the deposit account balance. The actual charges arising from balance compensable services are always calculated and charged at month end. Used in the USA.")]
    BalanceCompensable = ServicePaymentMethodCode.BalanceCompensable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge is not balance compensable and is due. In the absence of balance compensable charges in Europe, this would be the most commonly used code for services that are billed at month end.
    /// Encoded/decoded by serializers as &quot;FLAT&quot;.
    /// </summary>
    [EnumMember(Value = "FLAT")]
    [IsoId("_6V6hx5qlEeGSON8vddiWzQ_-588731762")]
    [Description(@"Charge is not balance compensable and is due. In the absence of balance compensable charges in Europe, this would be the most commonly used code for services that are billed at month end.")]
    HardCharge = ServicePaymentMethodCode.HardCharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge was previously assessed and is not part of the amount due as of this statement. This code is used for charges that were debited as the chargeable event took place.
    /// Encoded/decoded by serializers as &quot;PVCH&quot;.
    /// </summary>
    [EnumMember(Value = "PVCH")]
    [IsoId("_6WDrsJqlEeGSON8vddiWzQ_878417001")]
    [Description(@"Charge was previously assessed and is not part of the amount due as of this statement. This code is used for charges that were debited as the chargeable event took place.")]
    PreviouslyCharged = ServicePaymentMethodCode.PreviouslyCharged, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge was previously invoiced and is not part of the amount due as of this statement. This code is used for charges that were invoiced as the chargeable event took place.
    /// Encoded/decoded by serializers as &quot;INVS&quot;.
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("_6WDrsZqlEeGSON8vddiWzQ_-599830539")]
    [Description(@"Charge was previously invoiced and is not part of the amount due as of this statement. This code is used for charges that were invoiced as the chargeable event took place.")]
    InvoicedSeparately = ServicePaymentMethodCode.InvoicedSeparately, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge is waived and not due. The waived amount must be placed in original charge amount.
    /// Encoded/decoded by serializers as &quot;WVED&quot;.
    /// </summary>
    [EnumMember(Value = "WVED")]
    [IsoId("_6WDrspqlEeGSON8vddiWzQ_21670166")]
    [Description(@"Charge is waived and not due. The waived amount must be placed in original charge amount.")]
    Waived = ServicePaymentMethodCode.Waived, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service is free, no charge, to the customer.
    /// Encoded/decoded by serializers as &quot;FREE&quot;.
    /// </summary>
    [EnumMember(Value = "FREE")]
    [IsoId("_6WDrs5qlEeGSON8vddiWzQ_1488818929")]
    [Description(@"Service is free, no charge, to the customer.")]
    Free = ServicePaymentMethodCode.Free, // same ordinal as derivation source for type conversions
    
}
