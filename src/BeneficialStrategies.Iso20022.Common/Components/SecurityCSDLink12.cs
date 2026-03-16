// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security CSD Link12.
/// </summary>
[IsoId("_FpaikeFTEe6zNorB_Q2tDg")]
[DisplayName("Security CSD Link12")]
public partial record SecurityCSDLink12
{
    #nullable enable

    /// <summary>
    /// Default Link.
    /// </summary>
    [DisplayName("Default Link")]
    [IsoXmlTag("DfltLk")]
    public IsoTrueFalseIndicator? DefaultLink { get; init; } 

    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 

    /// <summary>
    /// Issuance Account.
    /// </summary>
    [DisplayName("Issuance Account")]
    [IsoXmlTag("IssncAcct")]
    public ValueList<IssuanceAccount3> IssuanceAccount { get; init; } = [];

    /// <summary>
    /// Issuer Investor CSD.
    /// </summary>
    [DisplayName("Issuer Investor CSD")]
    [IsoXmlTag("IssrInvstrCSD")]
    public required IssuerOrInvestor2Choice_ IssuerInvestorCSD { get; init; } 

    /// <summary>
    /// Security Maintenance.
    /// </summary>
    [DisplayName("Security Maintenance")]
    [IsoXmlTag("SctyMntnc")]
    public required IsoTrueFalseIndicator SecurityMaintenance { get; init; } 

    /// <summary>
    /// Technical Issuer CSD.
    /// </summary>
    [DisplayName("Technical Issuer CSD")]
    [IsoXmlTag("TechIssrCSD")]
    public SystemPartyIdentification2Choice_? TechnicalIssuerCSD { get; init; } 

    /// <summary>
    /// Valid From.
    /// </summary>
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    public required DateAndDateTime2Choice_ ValidFrom { get; init; } 

    /// <summary>
    /// Valid To.
    /// </summary>
    [DisplayName("Valid To")]
    [IsoXmlTag("VldTo")]
    public DateAndDateTime2Choice_? ValidTo { get; init; } 

    
    #nullable disable
    
}
