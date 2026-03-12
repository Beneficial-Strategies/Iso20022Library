// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters of the TMS protocol between a POI and a terminal manager.
/// </summary>
[IsoId("_dnyOAGpbEeS4r8z7dKyh1g")]
[DisplayName("TMS Protocol Parameters")]
public partial record TMSProtocolParameters1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the master terminal manager or the terminal manager.
    /// </summary>
    [IsoId("_4uhx0GpbEeS4r8z7dKyh1g")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification71 TerminalManagerIdentification { get; init; } 
    
    /// <summary>
    /// Maintenance services provided by the terminal manager.
    /// </summary>
    [IsoId("_CoSFMGpcEeS4r8z7dKyh1g")]
    [DisplayName("Maintenance Service")]
    [IsoXmlTag("MntncSvc")]
    public SimpleValueList<DataSetCategory5Code> MaintenanceService { get; init; } = new SimpleValueList<DataSetCategory5Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _CoSFMGpcEeS4r8z7dKyh1g
    
    /// <summary>
    /// Version of the TMS protocol parameters.
    /// </summary>
    [IsoId("_uWz6oGpcEeS4r8z7dKyh1g")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public required IsoMax256Text Version { get; init; } 
    
    /// <summary>
    /// Identification of applications which may be managed by the TM, partially or globally.
    /// </summary>
    [IsoId("_zmYW0GpcEeS4r8z7dKyh1g")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ApplicationIdentification { get; init; } 
    
    /// <summary>
    /// Addresses of the terminal manager host.
    /// </summary>
    [IsoId("_wteusGpqEeSMqvBfBY1c9A")]
    [DisplayName("Host Address")]
    [IsoXmlTag("HstAdr")]
    public NetworkParameters3? HostAddress { get; init; } 
    
    /// <summary>
    /// Cryptographic key used to communicate with the terminal manager host.
    /// </summary>
    [IsoId("_Iby-IGprEeSMqvBfBY1c9A")]
    [DisplayName("Host Key")]
    [IsoXmlTag("HstKey")]
    public KEKIdentifier2? HostKey { get; init; } 
    
    /// <summary>
    /// New identification of the POI for the terminal manager.
    /// </summary>
    [IsoId("_OnH38GprEeSMqvBfBY1c9A")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? POIIdentification { get; init; } 
    
    /// <summary>
    /// New identification of the initiating party to set in TMS messages with this terminal manager.
    /// </summary>
    [IsoId("_UK63sGprEeSMqvBfBY1c9A")]
    [DisplayName("Initiating Party Identification")]
    [IsoXmlTag("InitgPtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? InitiatingPartyIdentification { get; init; } 
    
    /// <summary>
    /// New identification of the recipient party to set in TMS messages with this terminal manager.
    /// </summary>
    [IsoId("_nSjP4GprEeSMqvBfBY1c9A")]
    [DisplayName("Recipient Party Identification")]
    [IsoXmlTag("RcptPtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RecipientPartyIdentification { get; init; } 
    
    
    #nullable disable
    
}
