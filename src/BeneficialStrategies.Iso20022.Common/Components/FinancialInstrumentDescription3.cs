// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Description of the financial instrument.
/// </summary>
[IsoId("_T1Tbpdp-Ed-ak6NoX_4Aeg_-1678511644")]
[DisplayName("Financial Instrument Description")]
public partial record FinancialInstrumentDescription3
{
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_T1Tbptp-Ed-ak6NoX_4Aeg_-1431011492")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification7 SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Place where the referenced financial instrument is listed.
    /// </summary>
    [IsoId("_T1Tbp9p-Ed-ak6NoX_4Aeg_635271488")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? PlaceOfListing { get; init; } 
    
    /// <summary>
    /// Identification of the place of safekeeping.
    /// </summary>
    [IsoId("_T1dMoNp-Ed-ak6NoX_4Aeg_-952279477")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public PartyIdentification2Choice_? SafekeepingPlace { get; init; } 
    
    
    #nullable disable
    
}
