// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the obligations of one of the participants to a derivative contract. The obligations may be conceptual or operational only, with settlement of any obligations arising from the derivative contract taking place on a net basis, after the netting of the obligations arising from each leg of the contract.
/// </summary>
[IsoId("_zoVNcMhqEeadgvwNGwK05w")]
[DisplayName("Derivative Underlying Leg")]
public partial record DerivativeUnderlyingLeg1
{
    #nullable enable
    
    /// <summary>
    /// Attributes that relate to the financial instrument (contract) being traded that are common across derivatives.
    /// </summary>
    [IsoId("_-u88kMhqEeadgvwNGwK05w")]
    [DisplayName("Contract Attributes")]
    [IsoXmlTag("CtrctAttrbts")]
    public required FinancialInstrumentAttributes88 ContractAttributes { get; init; } 
    
    /// <summary>
    /// Attributes of a derivative that are specific to whether the derivative is a value defined derivative or quantity defined derivative.
    /// </summary>
    [IsoId("_ttQKIOPJEea7_eMQH225xA")]
    [DisplayName("Defined Attributes")]
    [IsoXmlTag("DfndAttrbts")]
    public DefinedAttributes1Choice_? DefinedAttributes { get; init; } 
    
    
    #nullable disable
    
}
