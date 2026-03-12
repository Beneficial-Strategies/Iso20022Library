// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the securities order transmission attributes.
/// </summary>
[IsoId("_gW374OqLEeSsk6KxwbYJ9w")]
[DisplayName("Securities Transaction Transmission")]
public partial record SecuritiesTransactionTransmission2
{
    #nullable enable
    
    /// <summary>
    /// Indication as to whether the transaction results from an order transmitted by the reporting of a client to a third party.
    /// Usage: Only applicable when the conditions for transmission are not satisfied.
    /// </summary>
    [IsoId("_N4TSUOqMEeSsk6KxwbYJ9w")]
    [DisplayName("Transmission Indicator")]
    [IsoXmlTag("TrnsmssnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator TransmissionIndicator { get; init; } 
    
    /// <summary>
    /// Identifies the buyer transmitting the order to the reporting firm. 
    /// Usage: Only required for reporting firms reporting transactions on behalf of order transmitting firm.
    /// </summary>
    [IsoId("_9VEUEeqMEeSsk6KxwbYJ9w")]
    [DisplayName("Transmitting Buyer")]
    [IsoXmlTag("TrnsmttgBuyr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? TransmittingBuyer { get; init; } 
    
    /// <summary>
    /// Identifies the seller transmitting the order to the reporting firm. 
    /// Usage: Only required for reporting firms reporting transactions on behalf of order transmitting firm.
    /// </summary>
    [IsoId("_1GQfkOqMEeSsk6KxwbYJ9w")]
    [DisplayName("Transmitting Seller")]
    [IsoXmlTag("TrnsmttgSellr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? TransmittingSeller { get; init; } 
    
    
    #nullable disable
    
}
