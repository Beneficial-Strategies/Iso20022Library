// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional cover details for the claim non receipt.
/// </summary>
[IsoId("_txvhAVkyEeGeoaLUQk__nA_85102909")]
[DisplayName("Missing Cover")]
public partial record MissingCover3
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether or not the claim is related to a missing cover.
    /// </summary>
    [IsoId("_txvhAlkyEeGeoaLUQk__nA_-1915822713")]
    [DisplayName("Missing Cover Indicator")]
    [IsoXmlTag("MssngCoverInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator MissingCoverIndicator { get; init; } 
    
    /// <summary>
    /// Set of elements provided to update incorrect settlement information for the cover related to the received payment instruction.
    /// </summary>
    [IsoId("_txvhA1kyEeGeoaLUQk__nA_1049610550")]
    [DisplayName("Cover Correction")]
    [IsoXmlTag("CoverCrrctn")]
    public SettlementInstruction3? CoverCorrection { get; init; } 
    
    
    #nullable disable
    
}
