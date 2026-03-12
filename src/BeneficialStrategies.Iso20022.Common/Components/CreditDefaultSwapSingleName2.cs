// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Credit default swap derivative specific for reporting on a single name credit default swap.
/// </summary>
[IsoId("_NmrxeX5fEea2k7EBUopqxw")]
[DisplayName("Credit Default Swap Single Name")]
public partial record CreditDefaultSwapSingleName2
{
    #nullable enable
    
    /// <summary>
    /// Reference entity of a single name credit default swap (CDS) or a derivative on single name CDS.
    /// </summary>
    [IsoId("_NvBOEX5fEea2k7EBUopqxw")]
    [DisplayName("Sovereign Issuer")]
    [IsoXmlTag("SvrgnIssr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator SovereignIssuer { get; init; } 
    
    /// <summary>
    /// Reference entity of a single name credit default swap (CDS) or a derivative on single name credit default swap (CDS).
    /// </summary>
    [IsoId("_NvBOE35fEea2k7EBUopqxw")]
    [DisplayName("Reference Party")]
    [IsoXmlTag("RefPty")]
    public DerivativePartyIdentification1Choice_? ReferenceParty { get; init; } 
    
    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    [IsoId("_NvBOFX5fEea2k7EBUopqxw")]
    [DisplayName("Notional Currency")]
    [IsoXmlTag("NtnlCcy")]
    public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; } 
    
    
    #nullable disable
    
}
