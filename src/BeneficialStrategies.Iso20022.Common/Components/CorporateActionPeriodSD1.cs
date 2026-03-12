// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action details periods details.
/// </summary>
[IsoId("_1TE5JjL3EeKU9IrkkToqcw_-513074553")]
[DisplayName("Corporate Action Period SD")]
public partial record CorporateActionPeriodSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1TODEDL3EeKU9IrkkToqcw_1666762332")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Period during which the securities can be submitted to Reorganisation deposit service at DTC (The Depository Trust Corporation). DTC First Day for Reorg Deposit (start date) is the day on which security is eligible for reorganisation deposit service at DTC. DTC Last Day for Reorg Deposit is the last day on which securities are eligible to be submitted for reorganisation deposit service at DTC.
    /// </summary>
    [IsoId("_1TODETL3EeKU9IrkkToqcw_-626663858")]
    [DisplayName("DTC Reorganisation Deposit Period")]
    [IsoXmlTag("DTCReorgDpstPrd")]
    public Period3? DTCReorganisationDepositPeriod { get; init; } 
    
    /// <summary>
    /// Period during which the co-depositories deliveries are suspended at DTC (The Depository Trust Corporation). DTC Last Day for Depository Delivery (start date) - the last day on which depository deliveries will be accepted. DTC Chill Release Day for Depository Delivery (end date) - day when chill is released and depositories can resume delivery activities.
    /// </summary>
    [IsoId("_1TODEjL3EeKU9IrkkToqcw_-285404633")]
    [DisplayName("DTC Chill Period For Depository Delivery")]
    [IsoXmlTag("DTCChillPrdForDpstryDlvry")]
    public Period3? DTCChillPeriodForDepositoryDelivery { get; init; } 
    
    
    #nullable disable
    
}
