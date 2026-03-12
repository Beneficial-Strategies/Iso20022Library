// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the requested modifications.
/// </summary>
[IsoId("_VShXY5lQEee-Zps0fZQaFQ")]
[DisplayName("Transaction Modification")]
public partial record TransactionModification4
{
    #nullable enable
    
    /// <summary>
    /// Reference to the instruction related to the payment for which a modification is requested.
    /// </summary>
    [IsoId("_Vblzo5lQEee-Zps0fZQaFQ")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification5Choice_ PaymentIdentification { get; init; } 
    
    /// <summary>
    /// New payment values.
    /// </summary>
    [IsoId("_VblzpZlQEee-Zps0fZQaFQ")]
    [DisplayName("New Payment Value Set")]
    [IsoXmlTag("NewPmtValSet")]
    public required PaymentInstruction27 NewPaymentValueSet { get; init; } 
    
    
    #nullable disable
    
}
