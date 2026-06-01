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
[IsoId("_K2qZcCq8EfCD0_iZ8tw-zA")]
[Description(
    @"Specifies a code to identify the transactor type.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalTransactorType1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalTransactorTypeCode>))]
public enum ExternalTransactorTypeCode
{
    /// <summary>
    /// Entity that offers a digital wallet solution enabling users to store payment instruments and initiate transactions electronically.
    /// Encoded/decoded by serializers as &quot;DWTP&quot;.
    /// </summary>
    [EnumMember(Value = "DWTP")]
    [IsoId("_XZNlsFwtEfCoP_h9uwd39Q")]
    [Description(@"Entity that offers a digital wallet solution enabling users to store payment instruments and initiate transactions electronically.")]
    DigitalWalletProvider,

    /// <summary>
    /// Service provider that acts as an intermediary between merchants and payment networks, securely transmitting transaction data.
    /// Encoded/decoded by serializers as &quot;GATW&quot;.
    /// </summary>
    [EnumMember(Value = "GATW")]
    [IsoId("_eW5wkFwtEfCoP_h9uwd39Q")]
    [Description(@"Service provider that acts as an intermediary between merchants and payment networks, securely transmitting transaction data.")]
    Gateway,

    /// <summary>
    /// Third-party entity that partners with acquiring banks to provide merchant services, recruit merchants, and manage relationships.
    /// Encoded/decoded by serializers as &quot;IDSO&quot;.
    /// </summary>
    [EnumMember(Value = "IDSO")]
    [IsoId("_kXdgcF6AEfCoP_h9uwd39Q")]
    [Description(@"Third-party entity that partners with acquiring banks to provide merchant services, recruit merchants, and manage relationships.")]
    IndepententSalesOrganisation,

    /// <summary>
    /// Platform that connects buyers and sellers, facilitating transactions and often handling payment processing and settlement.
    /// Encoded/decoded by serializers as &quot;MKTP&quot;.
    /// </summary>
    [EnumMember(Value = "MKTP")]
    [IsoId("_SLb5QFwtEfCoP_h9uwd39Q")]
    [Description(@"Platform that connects buyers and sellers, facilitating transactions and often handling payment processing and settlement.")]
    Marketplace,

    /// <summary>
    /// Entity that enables sub-merchants to accept electronic payments without requiring each sub-merchant to have a direct merchant account.
    /// Encoded/decoded by serializers as &quot;PMFT&quot;.
    /// </summary>
    [EnumMember(Value = "PMFT")]
    [IsoId("_EZP7wFwtEfCoP_h9uwd39Q")]
    [Description(@"Entity that enables sub-merchants to accept electronic payments without requiring each sub-merchant to have a direct merchant account.")]
    PaymentFacilitator,

    /// <summary>
    /// Service that enables conversion between fiat currency and digital assets, facilitating on-ramps and off-ramps.
    /// Encoded/decoded by serializers as &quot;RMPP&quot;.
    /// </summary>
    [EnumMember(Value = "RMPP")]
    [IsoId("_lhHUgFwtEfCoP_h9uwd39Q")]
    [Description(@"Service that enables conversion between fiat currency and digital assets, facilitating on-ramps and off-ramps.")]
    RampProvider,

    /// <summary>
    /// Provider of a wallet solution where the funding source and transaction execution are separated into stages.
    /// Encoded/decoded by serializers as &quot;SDWP&quot;.
    /// </summary>
    [EnumMember(Value = "SDWP")]
    [IsoId("_AuFXwV6BEfCoP_h9uwd39Q")]
    [Description(@"Provider of a wallet solution where the funding source and transaction execution are separated into stages.")]
    StagedDigitalWalletProvider,

    /// <summary>
    /// Entity that consolidates bill payments for utilities and provides a single interface for consumers or businesses to pay multiple service providers.
    /// Encoded/decoded by serializers as &quot;UPTA&quot;.
    /// </summary>
    [EnumMember(Value = "UPTA")]
    [IsoId("_FBubkFwuEfCoP_h9uwd39Q")]
    [Description(@"Entity that consolidates bill payments for utilities and provides a single interface for consumers or businesses to pay multiple service providers.")]
    UtilityPaymentAggregator,
}
