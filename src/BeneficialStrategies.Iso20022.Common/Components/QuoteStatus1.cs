// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the status of a quote and the rejection reason if required.
/// </summary>
[IsoId("_Q9IUqNp-Ed-ak6NoX_4Aeg_1434126655")]
[DisplayName("Quote Status")]
public partial record QuoteStatus1
{
    #nullable enable
    
    /// <summary>
    /// Provides information related to the status of a quote.
    /// </summary>
    [IsoId("_Q9IUqdp-Ed-ak6NoX_4Aeg_-1311303659")]
    [DisplayName("Quote Status")]
    [IsoXmlTag("QtSts")]
    public required QuoteStatus1Code QuoteStatus { get; init; } 
    
    /// <summary>
    /// Provides information related to the rejection of the quote.
    /// </summary>
    [IsoId("_Q9SFodp-Ed-ak6NoX_4Aeg_111978599")]
    [DisplayName("Rejection Reason")]
    [IsoXmlTag("RjctnRsn")]
    public RejectionReason3Code? RejectionReason { get; init; } 
    
    
    #nullable disable
    
}
