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
[IsoId("_AS0XgQKyEe2rHs6fbn9-0A")]
[DisplayName("Transaction Modification")]
public partial record TransactionModification6
{
    #nullable enable
    
    /// <summary>
    /// Reference to the instruction related to the payment for which a modification is requested.
    /// </summary>
    [IsoId("_A9ynIQKyEe2rHs6fbn9-0A")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification7Choice_ PaymentIdentification { get; init; } 
    
    /// <summary>
    /// New payment values.
    /// </summary>
    [IsoId("_A9ynIwKyEe2rHs6fbn9-0A")]
    [DisplayName("New Payment Value Set")]
    [IsoXmlTag("NewPmtValSet")]
    public required PaymentInstruction33 NewPaymentValueSet { get; init; } 
    
    
    #nullable disable
    
}
