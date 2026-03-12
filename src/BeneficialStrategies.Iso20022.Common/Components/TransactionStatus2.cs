// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the future status of the transaction by means of a code and a period.
/// </summary>
[IsoId("_Ut7swNp-Ed-ak6NoX_4Aeg_97707535")]
[DisplayName("Transaction Status")]
public partial record TransactionStatus2
{
    #nullable enable
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_Ut7swdp-Ed-ak6NoX_4Aeg_157735099")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required BaselineStatus1Code Status { get; init; } 
    
    /// <summary>
    /// Date and time at which the current status will change.
    /// </summary>
    [IsoId("_Ut7swtp-Ed-ak6NoX_4Aeg_185440156")]
    [DisplayName("Change Date Time")]
    [IsoXmlTag("ChngDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ChangeDateTime { get; init; } 
    
    
    #nullable disable
    
}
