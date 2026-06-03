// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the underlying (group of) transaction(s) to which the resolution of investigation applies.
/// </summary>
[IsoId("803140af-b4a1-4f4e-ac35-6b007ca7480a")]
[DisplayName("Underlying Transaction35")]
public record UnderlyingTransaction35
{
    [IsoId("500e3690-8d77-4334-9525-52ea1470aa53")]
    [DisplayName("Original Group Information And Status")]
    [IsoXmlTag("OrgnlGrpInfAndSts")]
    public OriginalGroupHeader23? OriginalGroupInformationAndStatus { get; init; }

    [IsoId("6ec13301-4cb1-4e42-a786-6c9eb6a3edc1")]
    [DisplayName("Original Payment Information And Status")]
    [IsoXmlTag("OrgnlPmtInfAndSts")]
    public ValueList<OriginalPaymentInstruction54> OriginalPaymentInformationAndStatus { get; init; } = [];

    [IsoId("32324361-a3d7-4b44-b544-9c1a2d916133")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction170> TransactionInformationAndStatus { get; init; } = [];
}
