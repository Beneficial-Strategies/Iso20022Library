// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentIdentification13"/>
[IsoId("_uwh3MRUHEequmIwg9GMA4Q")]
[DisplayName("Payment Identification")]
public partial record PaymentIdentification13
{
    /// <inheritdoc cref="IPaymentIdentification13.InstructionIdentification"/>
    [IsoId("_vHb7VRUHEequmIwg9GMA4Q")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentIdentification13.EndToEndIdentification"/>
    [IsoId("_vHb7VxUHEequmIwg9GMA4Q")]
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text EndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentIdentification13.TransactionIdentification"/>
    [IsoId("_vHb7WRUHEequmIwg9GMA4Q")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentIdentification13.UETR"/>
    [IsoId("_vHb7WxUHEequmIwg9GMA4Q")]
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? UETR { get; init; }

    /// <inheritdoc cref="IPaymentIdentification13.ClearingSystemReference"/>
    [IsoId("_vHb7XRUHEequmIwg9GMA4Q")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }
}
