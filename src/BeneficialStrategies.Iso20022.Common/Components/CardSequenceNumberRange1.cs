// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Range of sequence numbers related to card transactions.
/// </summary>
[IsoId("_t5o4wVkyEeGeoaLUQk__nA_-981636366")]
[DisplayName("Card Sequence Number Range")]
public partial record CardSequenceNumberRange1
{
    #nullable enable
    
    /// <summary>
    /// CardSequenceNumberRange1: FirstTransactionSequenceNumberMessage element to be finalised once feedback from Card SEG has been received.
    /// </summary>
    [IsoId("_t5o4wlkyEeGeoaLUQk__nA_1543954032")]
    [DisplayName("First Transaction")]
    [IsoXmlTag("FrstTx")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? FirstTransaction { get; init; } 
    
    /// <summary>
    /// CardSequenceNumberRange1: LastTransactionSequenceNumberMessage element to be finalised once feedback from Card SEG has been received.
    /// </summary>
    [IsoId("_t5ypwFkyEeGeoaLUQk__nA_407420783")]
    [DisplayName("Last Transaction")]
    [IsoXmlTag("LastTx")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? LastTransaction { get; init; } 
    
    
    #nullable disable
    
}
