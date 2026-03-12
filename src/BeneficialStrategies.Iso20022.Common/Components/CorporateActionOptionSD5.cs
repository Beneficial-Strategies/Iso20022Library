// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option details.
/// </summary>
[IsoId("_1e_1RDL3EeKU9IrkkToqcw_-1892432228")]
[DisplayName("Corporate Action Option SD")]
public partial record CorporateActionOptionSD5
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1e_1RTL3EeKU9IrkkToqcw_-2017370071")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Workflow status of the specified option based on the consistency of the issuer declared data elements (excluding DTC data elements).
    /// </summary>
    [IsoId("_1fI_MDL3EeKU9IrkkToqcw_-713619834")]
    [DisplayName("Option Status")]
    [IsoXmlTag("OptnSts")]
    public WorkflowStatus1Code? OptionStatus { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the offeror will select random lots if the offer has been prorated. The offeror may accept or reject conditional tenders on a random basis. Holders must indicate their willingness to have their rejected conditional tender accepted by random lot (if necessary). The holder must surrender all shares held in order to be eligible for this preference.
    /// </summary>
    [IsoId("_1fI_MTL3EeKU9IrkkToqcw_-1595253566")]
    [DisplayName("Random Lot Preference Flag")]
    [IsoXmlTag("RandLotPrefFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RandomLotPreferenceFlag { get; init; } 
    
    /// <summary>
    /// Date on which the new shares to be issued will be distributed, as opposed to the &quot;declared payable date.&quot; This date is typically used in some Asian markets.
    /// </summary>
    [IsoId("_1fI_MjL3EeKU9IrkkToqcw_-1644636037")]
    [DisplayName("New Share Dispatched Date")]
    [IsoXmlTag("NewShrDsptchdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NewShareDispatchedDate { get; init; } 
    
    
    #nullable disable
    
}
