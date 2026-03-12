// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the extended parameters for an Isabel payment file.
/// </summary>
[IsoId("_AfkC0KA3EeWiJt5KdX5iuQ")]
[DisplayName("Isabel Extended Header")]
public partial record IsabelExtendedHeader1
{
    #nullable enable
    
    /// <summary>
    /// SEPA related information for a payment file.
    /// </summary>
    [IsoId("_BZu2wMmREeWAGphE2LvqeA")]
    [DisplayName("SEPA")]
    [IsoXmlTag("SEPA")]
    public IsabelSEPAFile1? SEPA { get; init; } 
    
    /// <summary>
    /// Belgian bank protocol number (BPN) of the receiving bank.
    /// </summary>
    [IsoId("_IBl7kMmREeWAGphE2LvqeA")]
    [DisplayName("BPN Financial Institution")]
    [IsoXmlTag("BPNFI")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3 ,MinimumLength = 1)]
    public IsoMax3Text? BPNFinancialInstitution { get; init; } 
    
    /// <summary>
    /// Business identification code of the receiving bank.
    /// </summary>
    [IsoId("_NbCsgMmREeWAGphE2LvqeA")]
    [DisplayName("BIC Financial Institution")]
    [IsoXmlTag("BICFI")]
    [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
    public IsoBICFIIdentifier? BICFinancialInstitution { get; init; } 
    
    
    #nullable disable
    
}
