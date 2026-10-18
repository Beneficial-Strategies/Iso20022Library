// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a code to identify the transactor type.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BJtG0JV2EfCtl5jItl2apg")]
[Description(
    @"Specifies a code to identify the transactor type.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalTransactorTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalTransactorType1Code>))]
public enum ExternalTransactorType1Code
{
    /// <summary>
    /// Entity that offers a digital wallet solution enabling users to store payment instruments and initiate transactions electronically.
    /// Encoded/decoded by serializers as &quot;DWTP&quot;.
    /// </summary>
    [EnumMember(Value = "DWTP")]
    [IsoId("_ELeOsZV2EfCtl5jItl2apg")]
    [Description(@"Entity that offers a digital wallet solution enabling users to store payment instruments and initiate transactions electronically.")]
    DigitalWalletProvider = ExternalTransactorTypeCode.DigitalWalletProvider, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service provider that acts as an intermediary between merchants and payment networks, securely transmitting transaction data.
    /// Encoded/decoded by serializers as &quot;GATW&quot;.
    /// </summary>
    [EnumMember(Value = "GATW")]
    [IsoId("_ETfiQZV2EfCtl5jItl2apg")]
    [Description(@"Service provider that acts as an intermediary between merchants and payment networks, securely transmitting transaction data.")]
    Gateway = ExternalTransactorTypeCode.Gateway, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Third-party entity that partners with acquiring banks to provide merchant services, recruit merchants, and manage relationships.
    /// Encoded/decoded by serializers as &quot;IDSO&quot;.
    /// </summary>
    [EnumMember(Value = "IDSO")]
    [IsoId("_EYqWIZV2EfCtl5jItl2apg")]
    [Description(@"Third-party entity that partners with acquiring banks to provide merchant services, recruit merchants, and manage relationships.")]
    IndepententSalesOrganisation = ExternalTransactorTypeCode.IndepententSalesOrganisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Platform that connects buyers and sellers, facilitating transactions and often handling payment processing and settlement.
    /// Encoded/decoded by serializers as &quot;MKTP&quot;.
    /// </summary>
    [EnumMember(Value = "MKTP")]
    [IsoId("_Ee0BcZV2EfCtl5jItl2apg")]
    [Description(@"Platform that connects buyers and sellers, facilitating transactions and often handling payment processing and settlement.")]
    Marketplace = ExternalTransactorTypeCode.Marketplace, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity that enables sub-merchants to accept electronic payments without requiring each sub-merchant to have a direct merchant account.
    /// Encoded/decoded by serializers as &quot;PMFT&quot;.
    /// </summary>
    [EnumMember(Value = "PMFT")]
    [IsoId("_EkP7EZV2EfCtl5jItl2apg")]
    [Description(@"Entity that enables sub-merchants to accept electronic payments without requiring each sub-merchant to have a direct merchant account.")]
    PaymentFacilitator = ExternalTransactorTypeCode.PaymentFacilitator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service that enables conversion between fiat currency and digital assets, facilitating on-ramps and off-ramps.
    /// Encoded/decoded by serializers as &quot;RMPP&quot;.
    /// </summary>
    [EnumMember(Value = "RMPP")]
    [IsoId("_Eq_cQZV2EfCtl5jItl2apg")]
    [Description(@"Service that enables conversion between fiat currency and digital assets, facilitating on-ramps and off-ramps.")]
    RampProvider = ExternalTransactorTypeCode.RampProvider, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Provider of a wallet solution where the funding source and transaction execution are separated into stages.
    /// Encoded/decoded by serializers as &quot;SDWP&quot;.
    /// </summary>
    [EnumMember(Value = "SDWP")]
    [IsoId("_EwYSkZV2EfCtl5jItl2apg")]
    [Description(@"Provider of a wallet solution where the funding source and transaction execution are separated into stages.")]
    StagedDigitalWalletProvider = ExternalTransactorTypeCode.StagedDigitalWalletProvider, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity that consolidates bill payments for utilities and provides a single interface for consumers or businesses to pay multiple service providers.
    /// Encoded/decoded by serializers as &quot;UPTA&quot;.
    /// </summary>
    [EnumMember(Value = "UPTA")]
    [IsoId("_E3V2MZV2EfCtl5jItl2apg")]
    [Description(@"Entity that consolidates bill payments for utilities and provides a single interface for consumers or businesses to pay multiple service providers.")]
    UtilityPaymentAggregator = ExternalTransactorTypeCode.UtilityPaymentAggregator, // same ordinal as derivation source for type conversions
}
