// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference of a transfer instruction cancellation.
/// </summary>
[IsoId("_SwnEetp-Ed-ak6NoX_4Aeg_63934446")]
[DisplayName("Transfer Reference")]
public partial record TransferReference3
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_Sww1cNp-Ed-ak6NoX_4Aeg_716567294")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; } 
    
    /// <summary>
    /// Transfer and cancellation reference.
    /// </summary>
    [IsoId("_Sww1cdp-Ed-ak6NoX_4Aeg_-1130016572")]
    [DisplayName("Transfer References")]
    [IsoXmlTag("TrfRefs")]
    public ValueList<TransferReference4> TransferReferences { get; init; } = [];
    // ID for the above is _Sww1cdp-Ed-ak6NoX_4Aeg_-1130016572
    
    
    #nullable disable
    
}
