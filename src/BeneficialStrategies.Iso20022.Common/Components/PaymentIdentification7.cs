// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentIdentification7"/>
[IsoId("_Tyw-UXrhEeidVZmeoasaWQ")]
[DisplayName("Payment Identification")]
public partial record PaymentIdentification7
{
    /// <inheritdoc cref="IPaymentIdentification7.InstructionIdentification"/>
    [IsoId("_UFMyIXrhEeidVZmeoasaWQ")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentIdentification7.EndToEndIdentification"/>
    [IsoId("_UFMyI3rhEeidVZmeoasaWQ")]
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text EndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentIdentification7.TransactionIdentification"/>
    [IsoId("_UFMyJXrhEeidVZmeoasaWQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentIdentification7.UETR"/>
    [IsoId("_ymm7cXrgEeidVZmeoasaWQ")]
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? UETR { get; init; }

    /// <inheritdoc cref="IPaymentIdentification7.ClearingSystemReference"/>
    [IsoId("_UFMyJ3rhEeidVZmeoasaWQ")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }
}
