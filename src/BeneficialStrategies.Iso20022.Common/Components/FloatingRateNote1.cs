// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of a debt instrument in which the periodic interest payments are calculated on the basis of the value (that is, fixing of an underlying reference rate such as the Euribor) on predefined dates (that is, fixing dates) and which has a maturity of no more than one year.
/// </summary>
[IsoId("_4_T1k7v5EeSOSvzq0yuABw")]
[DisplayName("Floating Rate Note")]
public partial record FloatingRateNote1
{
    #nullable enable
    
    /// <summary>
    /// Underlying reference rate on the basis on which the periodic interest payments are calculated.
    /// </summary>
    [IsoId("_4_T1lLv5EeSOSvzq0yuABw")]
    [DisplayName("Reference Rate Index")]
    [IsoXmlTag("RefRateIndx")]
    [IsoSimpleType(IsoSimpleType.ISINIdentifier)]
    public required IsoISINIdentifier ReferenceRateIndex { get; init; } 
    
    /// <summary>
    /// Number of basis points added to (if positive) or deducted from (if negative) the underlying reference rate to calculate the actual interest rate applicable for a given period at issuance of the floating rate instrument.
    /// Used to express differences in interest rates, for example, a difference of 0.10% is equivalent to a change of 10 basis points.
    /// </summary>
    [IsoId("_4_T1lbv5EeSOSvzq0yuABw")]
    [DisplayName("Basis Point Spread")]
    [IsoXmlTag("BsisPtSprd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber BasisPointSpread { get; init; } 
    
    
    #nullable disable
    
}
