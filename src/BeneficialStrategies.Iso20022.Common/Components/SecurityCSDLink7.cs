// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines how the CSD is linked to the security.
/// </summary>
[IsoId("_x-0e8Wc-EemvNLufWGIVOQ")]
[DisplayName("Security CSD Link")]
public partial record SecurityCSDLink7
{
    #nullable enable
    
    /// <summary>
    /// Defines the date since when the CSD is linked to the security.
    /// </summary>
    [IsoId("_yJ6UoWc-EemvNLufWGIVOQ")]
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    public required DateAndDateTime2Choice_ ValidFrom { get; init; } 
    
    /// <summary>
    /// Defines the date until when the CSD is linked to the security.
    /// </summary>
    [IsoId("_yJ6Uo2c-EemvNLufWGIVOQ")]
    [DisplayName("Valid To")]
    [IsoXmlTag("VldTo")]
    public DateAndDateTime2Choice_? ValidTo { get; init; } 
    
    /// <summary>
    /// Specify if the involved CSD (issuer/technical issuer/investor) is also the maintainer of related reference data.
    /// </summary>
    [IsoId("_yJ6UpWc-EemvNLufWGIVOQ")]
    [DisplayName("Security Maintenance")]
    [IsoXmlTag("SctyMntnc")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SecurityMaintenance { get; init; } 
    
    /// <summary>
    /// CSD Issuer of a security.
    /// </summary>
    [IsoId("_yJ6Up2c-EemvNLufWGIVOQ")]
    [DisplayName("Issuer CSD")]
    [IsoXmlTag("IssrCSD")]
    public SystemPartyIdentification2Choice_? IssuerCSD { get; init; } 
    
    /// <summary>
    /// CSD Investor of a security.
    /// </summary>
    [IsoId("_yJ6UqWc-EemvNLufWGIVOQ")]
    [DisplayName("Investor CSD")]
    [IsoXmlTag("InvstrCSD")]
    public SystemPartyIdentification2Choice_? InvestorCSD { get; init; } 
    
    /// <summary>
    /// Technical issuer of a security.
    /// </summary>
    [IsoId("_yJ6Uq2c-EemvNLufWGIVOQ")]
    [DisplayName("Technical Issuer CSD")]
    [IsoXmlTag("TechIssrCSD")]
    public SystemPartyIdentification2Choice_? TechnicalIssuerCSD { get; init; } 
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_yJ6UrWc-EemvNLufWGIVOQ")]
    [DisplayName("Issuance Account")]
    [IsoXmlTag("IssncAcct")]
    public IssuanceAccount2? IssuanceAccount { get; init; } 
    
    
    #nullable disable
    
}
