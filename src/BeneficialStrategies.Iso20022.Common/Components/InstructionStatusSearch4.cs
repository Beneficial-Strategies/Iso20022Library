// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria which are used to search for the status of the payment.
/// </summary>
[IsoId("_yttMb5lcEeeE1Ya-LgRsuQ")]
[DisplayName("Instruction Status Search")]
public partial record InstructionStatusSearch4
{
    #nullable enable
    
    /// <summary>
    /// Status of a transfer.
    /// </summary>
    [IsoId("_y1nyQ5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Payment Instruction Status")]
    [IsoXmlTag("PmtInstrSts")]
    public PaymentStatusCodeSearch2Choice_? PaymentInstructionStatus { get; init; } 
    
    /// <summary>
    /// Date and time at which the status was assigned to the transfer.
    /// </summary>
    [IsoId("_y1nyRZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Payment Instruction Status Date Time")]
    [IsoXmlTag("PmtInstrStsDtTm")]
    public DateTimePeriod1Choice_? PaymentInstructionStatusDateTime { get; init; } 
    
    /// <summary>
    /// Defines the reason that has been used by the Target2 SSP system to reject the transaction.
    /// </summary>
    [IsoId("_y1nyR5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Proprietary Status Reason")]
    [IsoXmlTag("PrtryStsRsn")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4AlphaNumericText? ProprietaryStatusReason { get; init; } 
    
    
    #nullable disable
    
}
