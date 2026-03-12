// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the payment instruction.
/// </summary>
[IsoId("_YfG9NXX1Eei3jO6riKEVXg")]
[DisplayName("Payment Instruction")]
public partial record PaymentInstruction33
{
    #nullable enable
    
    /// <summary>
    /// Further information related to the processing of the payment instruction. The instruction can relate to a level of service between the bank and the customer, or give instructions to and for specific parties in the payment chain.|.
    /// </summary>
    [IsoId("_YpY6k3X1Eei3jO6riKEVXg")]
    [DisplayName("Instruction")]
    [IsoXmlTag("Instr")]
    public Instruction1Code? Instruction { get; init; } 
    
    /// <summary>
    /// Type, or nature, of the payment, for example an express payment.
    /// </summary>
    [IsoId("_YpY6lXX1Eei3jO6riKEVXg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PaymentType4Choice_? Type { get; init; } 
    
    /// <summary>
    /// Urgency or order of importance that the originator would like the recipient of the payment instruction to apply to the processing of the payment instruction.|.
    /// </summary>
    [IsoId("_YpY6l3X1Eei3jO6riKEVXg")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public Priority1Choice_? Priority { get; init; } 
    
    /// <summary>
    /// Date and time range within which the payment instruction must be processed.|.
    /// </summary>
    [IsoId("_YpY6mXX1Eei3jO6riKEVXg")]
    [DisplayName("Processing Validity Time")]
    [IsoXmlTag("PrcgVldtyTm")]
    public DateTimePeriod1Choice_? ProcessingValidityTime { get; init; } 
    
    
    #nullable disable
    
}
