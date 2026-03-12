// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the reconciliation period between an acquirer and an issuer or their respective agents.
/// </summary>
[IsoId("_L6ZPMEYXEeegp_DADCe7HQ")]
[DisplayName("Reconciliation")]
public partial record Reconciliation3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the reconciliation.
    /// </summary>
    [IsoId("_qZEYIEYXEeegp_DADCe7HQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Date of the reconciliation.
    /// ISO 8583:93/2003 bit 28
    /// </summary>
    [IsoId("_xtdy0EYXEeegp_DADCe7HQ")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; } 
    
    /// <summary>
    /// A value used to allow a period within a reconciliation date.  Refer to ISO8583:2003 Field 29
    /// </summary>
    [IsoId("_ccHP8d0cEeil7LQldntseg")]
    [DisplayName("Checkpoint Reference")]
    [IsoXmlTag("ChckptRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CheckpointReference { get; init; } 
    
    
    #nullable disable
    
}
