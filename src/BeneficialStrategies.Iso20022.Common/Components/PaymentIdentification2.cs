// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentIdentification2"/>
[IsoId("_Ps9tQdp-Ed-ak6NoX_4Aeg_1593827907")]
[DisplayName("Payment Identification")]
public partial record PaymentIdentification2
{
    /// <inheritdoc cref="IPaymentIdentification2.InstructionIdentification"/>
    [IsoId("_Ps9tQtp-Ed-ak6NoX_4Aeg_1593828020")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentIdentification2.EndToEndIdentification"/>
    [IsoId("_Ps9tQ9p-Ed-ak6NoX_4Aeg_1593827967")]
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text EndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentIdentification2.TransactionIdentification"/>
    [IsoId("_Ps9tRNp-Ed-ak6NoX_4Aeg_1735127457")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; }
}
