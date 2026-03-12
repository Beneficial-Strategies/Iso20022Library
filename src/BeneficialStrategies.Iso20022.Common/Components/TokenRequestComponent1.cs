// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a token request or response.
/// </summary>
[IsoId("_iE6YcC_0EeugIJ3Gvoevmg")]
[DisplayName("Token Request Component")]
public partial record TokenRequestComponent1
{
    #nullable enable
    
    /// <summary>
    /// Identification of an element in a sequence.
    /// </summary>
    [IsoId("_8UVdQC_1EeugIJ3Gvoevmg")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_-Is94S_1EeugIJ3Gvoevmg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment77 Environment { get; init; } 
    
    
    #nullable disable
    
}
