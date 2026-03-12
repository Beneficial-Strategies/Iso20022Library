// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the cassette of an ATM.
/// </summary>
[IsoId("_-ZZzEIqeEeS4a4abTJTSSw")]
[DisplayName("ATM Cassette")]
public partial record ATMCassette1
{
    #nullable enable
    
    /// <summary>
    /// Physical identification of the cassette for the ATM.
    /// </summary>
    [IsoId("_LdNnoIqfEeS4a4abTJTSSw")]
    [DisplayName("Physical Identification")]
    [IsoXmlTag("PhysId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PhysicalIdentification { get; init; } 
    
    /// <summary>
    /// Logical identification of the cassette for the ATM.
    /// </summary>
    [IsoId("_OFwXMIqfEeS4a4abTJTSSw")]
    [DisplayName("Logical Identification")]
    [IsoXmlTag("LogclId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text LogicalIdentification { get; init; } 
    
    /// <summary>
    /// Type of cassette.
    /// </summary>
    [IsoId("_6yEDgIqfEeS4a4abTJTSSw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCassetteType1Code Type { get; init; } 
    
    /// <summary>
    /// Type of items the cash-in takes.
    /// </summary>
    [IsoId("_gIIiEIqgEeS4a4abTJTSSw")]
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    public ATMNoteType1Code? SubType { get; init; } 
    
    /// <summary>
    /// Type of media inside the cassette.
    /// </summary>
    [IsoId("_oPE0AIqgEeS4a4abTJTSSw")]
    [DisplayName("Media Type")]
    [IsoXmlTag("MdiaTp")]
    public ATMMediaType1Code? MediaType { get; init; } 
    
    /// <summary>
    /// Counter per unit value or globally.
    /// </summary>
    [IsoId("_2CdEUIqgEeS4a4abTJTSSw")]
    [DisplayName("Media Counters")]
    [IsoXmlTag("MdiaCntrs")]
    public ATMCassetteCounters1? MediaCounters { get; init; } 
    
    
    #nullable disable
    
}
