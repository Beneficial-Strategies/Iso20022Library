// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the remittance advice.
/// </summary>
[IsoId("_RcTcsW49EeiU9cctagi5ow")]
[DisplayName("Remittance Location")]
public partial record RemittanceLocation5
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the remittance information sent separately from the payment instruction, such as a remittance advice.
    /// </summary>
    [IsoId("_RmlaEW49EeiU9cctagi5ow")]
    [DisplayName("Remittance Identification")]
    [IsoXmlTag("RmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RemittanceIdentification { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide information on the location and/or delivery of the remittance information.
    /// </summary>
    [IsoId("_RmlaE249EeiU9cctagi5ow")]
    [DisplayName("Remittance Location Details")]
    [IsoXmlTag("RmtLctnDtls")]
    public ValueList<RemittanceLocationData1> RemittanceLocationDetails { get; init; } = [];
    // ID for the above is _RmlaE249EeiU9cctagi5ow
    
    /// <summary>
    /// Identifies the underlying transaction.
    /// </summary>
    [IsoId("_RmlaFW49EeiU9cctagi5ow")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required TransactionReferences5 References { get; init; } 
    
    
    #nullable disable
    
}
