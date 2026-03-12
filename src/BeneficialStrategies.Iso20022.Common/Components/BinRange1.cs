// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a set of cards which shares the same functionalities.
/// </summary>
[IsoId("_qe2mAHC8Ee2bmOA3bkVsMg")]
[DisplayName("Bin Range")]
public partial record BinRange1
{
    #nullable enable
    
    /// <summary>
    /// Lower value of BIN in the range.
    /// </summary>
    [IsoId("_6yFj8HC8Ee2bmOA3bkVsMg")]
    [DisplayName("Lower Bin")]
    [IsoXmlTag("LwrBin")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText LowerBin { get; init; } 
    
    /// <summary>
    /// Higher value of BIN in the range.
    /// </summary>
    [IsoId("_-Bh7cHC8Ee2bmOA3bkVsMg")]
    [DisplayName("Higher Bin")]
    [IsoXmlTag("HghrBin")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText HigherBin { get; init; } 
    
    
    #nullable disable
    
}
