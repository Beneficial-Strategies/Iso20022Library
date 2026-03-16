// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Underlying Transaction32.
/// </summary>
[IsoId("_9PyU4TEsEe6GxLzpkVnWYg")]
[DisplayName("Underlying Transaction32")]
public partial record UnderlyingTransaction32
{
    #nullable enable

    /// <summary>
    /// Original Group Information And Status.
    /// </summary>
    [DisplayName("Original Group Information And Status")]
    [IsoXmlTag("OrgnlGrpInfAndSts")]
    public OriginalGroupHeader23? OriginalGroupInformationAndStatus { get; init; } 

    /// <summary>
    /// Original Payment Information And Status.
    /// </summary>
    [DisplayName("Original Payment Information And Status")]
    [IsoXmlTag("OrgnlPmtInfAndSts")]
    public ValueList<OriginalPaymentInstruction48> OriginalPaymentInformationAndStatus { get; init; } = [];

    /// <summary>
    /// Transaction Information And Status.
    /// </summary>
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    public ValueList<PaymentTransaction152> TransactionInformationAndStatus { get; init; } = [];

    
    #nullable disable
    
}
