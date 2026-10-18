// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentIdentification3"/>
[IsoId("_P6E8ONp-Ed-ak6NoX_4Aeg_2126712429")]
[DisplayName("Payment Identification")]
public partial record PaymentIdentification3
{
    /// <inheritdoc cref="IPaymentIdentification3.InstructionIdentification"/>
    [IsoId("_P6OGINp-Ed-ak6NoX_4Aeg_2126712459")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentIdentification3.EndToEndIdentification"/>
    [IsoId("_P6OGIdp-Ed-ak6NoX_4Aeg_2126712490")]
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text EndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentIdentification3.TransactionIdentification"/>
    [IsoId("_P6OGItp-Ed-ak6NoX_4Aeg_2126712551")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentIdentification3.ClearingSystemReference"/>
    [IsoId("_P6OGI9p-Ed-ak6NoX_4Aeg_-2094373157")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }
}
