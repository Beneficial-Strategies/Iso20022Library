// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the status of the cancellation request.
/// </summary>
[IsoId("_t3QTIFkyEeGeoaLUQk__nA_923487656")]
[DisplayName("Cancellation Status Reason")]
public partial record CancellationStatusReason2
{
    #nullable enable
    
    /// <summary>
    /// Party that issues the cancellation status.
    /// </summary>
    [IsoId("_t3QTIVkyEeGeoaLUQk__nA_1263735859")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification43? Originator { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the status report.
    /// </summary>
    [IsoId("_t3QTIlkyEeGeoaLUQk__nA_77446057")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public CancellationStatusReason2Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Further details on the cancellation status reason.
    /// </summary>
    [IsoId("_t3aEIFkyEeGeoaLUQk__nA_617998777")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
