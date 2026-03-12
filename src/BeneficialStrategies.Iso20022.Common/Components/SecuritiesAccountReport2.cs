// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to report information about securities account reference data.
/// </summary>
[IsoId("_t8qdteGEEeWCAvUNsZ5u6g")]
[DisplayName("Securities Account Report")]
public partial record SecuritiesAccountReport2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_uIaaseGEEeWCAvUNsZ5u6g")]
    [DisplayName("Securities Account Identification")]
    [IsoXmlTag("SctiesAcctId")]
    public required SecuritiesAccount19 SecuritiesAccountIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the returned securities account reference data or error information.
    /// </summary>
    [IsoId("_uIaas-GEEeWCAvUNsZ5u6g")]
    [DisplayName("Securities Account Or Error")]
    [IsoXmlTag("SctiesAcctOrErr")]
    public required SecuritiesAccountOrBusinessError2Choice_ SecuritiesAccountOrError { get; init; } 
    
    
    #nullable disable
    
}
