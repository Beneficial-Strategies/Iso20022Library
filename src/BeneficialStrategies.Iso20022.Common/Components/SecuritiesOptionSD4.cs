// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option securities movement details.
/// </summary>
[IsoId("_1gMIEjL3EeKU9IrkkToqcw_385488940")]
[DisplayName("Securities Option SD")]
public partial record SecuritiesOptionSD4
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1gMIEzL3EeKU9IrkkToqcw_-611583413")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Unique number associated with a payout within an option.
    /// </summary>
    [IsoId("_1gMIFDL3EeKU9IrkkToqcw_260551097")]
    [DisplayName("Payout Number")]
    [IsoXmlTag("PyoutNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public required IsoExact3NumericText PayoutNumber { get; init; } 
    
    /// <summary>
    /// Describes the type of payout associated with the event.
    /// </summary>
    [IsoId("_1gMIFTL3EeKU9IrkkToqcw_-1542715842")]
    [DisplayName("Payout Type")]
    [IsoXmlTag("PyoutTp")]
    public required DTCCPayoutType2Code PayoutType { get; init; } 
    
    /// <summary>
    /// Workflow status of the payout.
    /// </summary>
    [IsoId("_1gVSADL3EeKU9IrkkToqcw_29434994")]
    [DisplayName("Payout Status")]
    [IsoXmlTag("PyoutSts")]
    public required WorkflowStatus1Code PayoutStatus { get; init; } 
    
    
    #nullable disable
    
}
