// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique global identification structure used to match transactions throughout their lifecycle (for example, authorisation to financial, financial to chargebacks, etc.). 
/// It shall contain the same value in all messages throughout a transaction&apos;s lifecycle.
/// ISO 8583:2003 bit 21
/// </summary>
[IsoId("_LoxEIMWaEeiCfKAZkk6ZAQ")]
[DisplayName("Transaction Life Cycle Identification")]
public partial record TransactionLifeCycleIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Unique transaction identifier.
    /// ISO 8583:2003 bit 21-2
    /// </summary>
    [IsoId("_Lztv4cWaEeiCfKAZkk6ZAQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Exact15Text)]
    public required IsoExact15Text Identification { get; init; } 
    
    
    #nullable disable
    
}
