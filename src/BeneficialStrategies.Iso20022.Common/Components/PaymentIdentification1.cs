// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentIdentification1"/>
[IsoId("_Prnpd9p-Ed-ak6NoX_4Aeg_1924360852")]
[DisplayName("Payment Identification")]
public partial record PaymentIdentification1
{
    /// <inheritdoc cref="IPaymentIdentification1.InstructionIdentification"/>
    [IsoId("_PrnpeNp-Ed-ak6NoX_4Aeg_1924360930")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentIdentification1.EndToEndIdentification"/>
    [IsoId("_Prnpedp-Ed-ak6NoX_4Aeg_1924360895")]
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text EndToEndIdentification { get; init; }
}
