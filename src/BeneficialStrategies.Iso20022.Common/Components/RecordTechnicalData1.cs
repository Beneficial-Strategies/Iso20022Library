// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instrument specific technical data to support identification.
/// </summary>
[IsoId("_NUoVYB5REeWc9bJOIIhUUw")]
[DisplayName("Record Technical Data")]
public partial record RecordTechnicalData1
{
    #nullable enable
    
    /// <summary>
    /// Defines the date and time when the report was originally received by the national competent authority.
    /// </summary>
    [IsoId("_RydWIB5SEeWc9bJOIIhUUw")]
    [DisplayName("Receipt Date Time")]
    [IsoXmlTag("RctDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ReceiptDateTime { get; init; } 
    
    /// <summary>
    /// Describes the reason for the exchange of the transaction report between the competent authorities.
    /// </summary>
    [IsoId("_TaRd8B5REeWc9bJOIIhUUw")]
    [DisplayName("Exchange Reason")]
    [IsoXmlTag("XchgRsn")]
    public SimpleValueList<AuthorityExchangeReason1Code> ExchangeReason { get; init; } = new SimpleValueList<AuthorityExchangeReason1Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _TaRd8B5REeWc9bJOIIhUUw
    
    
    #nullable disable
    
}
