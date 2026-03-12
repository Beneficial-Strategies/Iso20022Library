// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a master agreement.
/// </summary>
[IsoId("_Dv7RIbRDEemPBPgZjF7-nQ")]
[DisplayName("Master Agreement")]
public partial record MasterAgreement6
{
    #nullable enable
    
    /// <summary>
    /// Classification of a master agreement.
    /// </summary>
    [IsoId("_D0jScbRDEemPBPgZjF7-nQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required AgreementType1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Reference to the year of the master agreement version used for the reported trade.
    /// </summary>
    [IsoId("_D0jSc7RDEemPBPgZjF7-nQ")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    public IsoMax50Text? Version { get; init; } 
    
    /// <summary>
    /// Additional information specifying the other type of the master agreement.
    /// </summary>
    [IsoId("_D0jSdbRDEemPBPgZjF7-nQ")]
    [DisplayName("Other Master Agreement Details")]
    [IsoXmlTag("OthrMstrAgrmtDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? OtherMasterAgreementDetails { get; init; } 
    
    
    #nullable disable
    
}
