// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details related to a direct debit mandate signed between the creditor and the debtor.
/// </summary>
[IsoId("_rKvJEdppEeearpaEPXv9UA")]
[DisplayName("Mandate Related Information")]
public partial record MandateRelatedInformation13
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    [IsoId("_rTxJQ9ppEeearpaEPXv9UA")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MandateIdentification { get; init; } 
    
    /// <summary>
    /// Date on which the direct debit mandate has been signed by the debtor.
    /// </summary>
    [IsoId("_rTxJRdppEeearpaEPXv9UA")]
    [DisplayName("Date Of Signature")]
    [IsoXmlTag("DtOfSgntr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfSignature { get; init; } 
    
    /// <summary>
    /// Image of scanned signed mandate.
    /// </summary>
    [IsoId("_IYrp8NpqEeearpaEPXv9UA")]
    [DisplayName("Mandate Image")]
    [IsoXmlTag("MndtImg")]
    [IsoSimpleType(IsoSimpleType.Max2MBBinary)]
    public IsoMax2MBBinary? MandateImage { get; init; } 
    
    
    #nullable disable
    
}
